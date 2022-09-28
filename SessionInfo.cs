using NAudio.Wave;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace StemWizardPro2
{
	public static partial class SessionInfo
	{
		//public static SessionInfo Instance;

		public static string DirectoryPath;

		public static string SessionName = "";

		public static string Prefix = "";
		public static string Length = "";
		public static string Suffix = "";
		public static string SEP = "_";

		public static ExtensionMode extensionMode = ExtensionMode.MatchFormat;

		public static bool DetectLength = true;

		public static List<AudioData> AllAudioData = new List<AudioData>();

		private static Dictionary<string, List<AudioData>> FileNameDict = new Dictionary<string, List<AudioData>>();
		public static List<AudioData> UniqueFileNameList = new List<AudioData>();

		private static List<EntryStatus> EntryStatusList = new List<EntryStatus>();

		public static void GetFilesInDirectory(ListView listview)
		{
			listview.Items.Clear();
			DirectoryPath = Directory.GetCurrentDirectory();
			AllAudioData.Clear();
			FileNameDict.Clear();
			UniqueFileNameList.Clear();
			EntryStatusList.Clear();
			if (ChannelList.Count < 1)
			{
				foreach (string name in Enum.GetNames(typeof(Channel))) ChannelList.Add("." + name);
			}

			var files = Directory.GetFiles(DirectoryPath, "*.*", SearchOption.TopDirectoryOnly)
			.Where(s => s.EndsWith(".wav") || s.EndsWith(".aif"));
			string[] filePaths = files.ToArray();

			// Get General Wave Data
			for (int i = 0; i < filePaths.Length; i++) StoreAudioData(filePaths[i]);
			

			DetectAllChannelFormats();
			CreateNewFilenamesForAll();

			foreach(EntryStatus entry in EntryStatusList)
			{
				string[] row1 = { entry.secondMessage };
				listview.Items.Add(entry.firstMessage).SubItems.AddRange(row1);

				//listview.Items[entry.firstMessage].UseItemStyleForSubItems = false;

				Color statusColor = Color.Green;
				if (!entry.status) statusColor = Color.Red;
				//listview.Items[entry.firstMessage].SubItems[0].ForeColor = statusColor;	
			}


			Console.WriteLine("Done");
		}

		private static void StoreAudioData(string s)
		{
			string ext = Path.GetExtension(s);

			PCMType pcmFormat = PCMType.wav;

			if (ext == ".wav")
			{
				pcmFormat = PCMType.wav;
			}
			else if (ext == ".aif")
			{
				pcmFormat = PCMType.aif;
			}
			AudioData data = new AudioData();
			IngestPCMData(Path.GetFullPath(s), pcmFormat);
		}

		private static void IngestPCMData(string path, PCMType audioFormat)
		{
			AudioData audio = new AudioData();
			audio.fullPath = path;
			audio.fileName = Path.GetFileNameWithoutExtension(path);
			audio.InputType = Form1.IO.ParseFilenameForInputs(audio.fileName);
			
			if (audio.InputType == string.Empty)
			{
				AddEntryToListview(audio.fileName, "No matching input", false);
				return;
			}
			

			audio.pcmType = audioFormat;
			
			switch (audioFormat)
			{
				case PCMType.wav:
					try
					{
						int byFive;

						WaveFileReader wave = new WaveFileReader(path);
						audio.channelsCount = wave.WaveFormat.Channels;
						audio.sampleRate = wave.WaveFormat.SampleRate;
						foreach (RiffChunk chunk in wave.ExtraChunks)
						{
							if (chunk.IdentifierAsString.ToLower() == "umid")
							{
								audio.UMID = chunk.Identifier;
								Console.WriteLine(audio.UMID);
								break;
							}
						}
						
						TimeSpan tp = wave.TotalTime;
						audio.duration = Convert.ToInt32(tp.TotalSeconds);
						byFive = audio.duration / 5;
						int audiolength = byFive * 5;

						wave.Dispose();
					}
					catch
					{
						Console.Write("File {0} could not be read correctly: " + audio.fullPath);
						Console.ReadKey();
					}
					break;

				case PCMType.aif:
					try
					{
						int byFive;
						AiffFileReader aif = new AiffFileReader(path);
						audio.channelsCount = aif.WaveFormat.Channels;
						audio.sampleRate = aif.SampleCount;
						
						TimeSpan tp = aif.TotalTime;
						audio.duration = Convert.ToInt32(tp.TotalSeconds);
						byFive = audio.duration / 5;
						int audiolength = byFive * 5;

						aif.Dispose();
					}
					catch
					{
						Console.Write("File {0} could not be read correctly: " + path);
						Console.ReadKey();
					}
					break;
			}

			if (audio.channelsCount == 1)
			{
				audio = GetChannelPosition(audio);
			}
		
			bool hasFileName = FileNameDict.ContainsKey(audio.fileName);
			if (!hasFileName)
			{
				List<AudioData> newData = new List<AudioData>();
				newData.Add(audio);
				FileNameDict.Add(audio.fileName, newData);
			}

			else if (hasFileName)
			{
				FileNameDict[audio.fileName].Add(audio);
			}

			AllAudioData.Add(audio); // must happen later, make sure it can be added
		}

		private static AudioData GetChannelPosition(AudioData audio)
		{
			string ext = Path.GetExtension(audio.fileName);
			if (ChannelList.Contains(ext))
			{
				audio.channelExt = ext;
				audio.fileName = audio.fileName.Replace(ext, "");
				return audio;
			}
			

			audio.channelExt = string.Empty;
			return audio; // its simply just a mono file

		}


		public static Dictionary<string, string> AllAudioChannelFormats = new Dictionary<string, string> {
		{"Mono", "Mono" },
		{ "Stereo", "St"},
		{ "LCR", "LCR"},
		{ "Quad", "Quad"},
		{ "5.0", "5_0"},
		{ "5.1", "5_1"},
		{ "7.0", "7_0"},
		{ "7.1", "7_1"},
		{ "7.0.2", "7_0_2"},
		{ "7.1.2", "7_1_2"},
		};


		private static string GetChannelFormat(int value)
		{
			if (value > 0 && value < 11)
			{
				return AllAudioChannelFormats.ElementAt(value - 1).Value;
			}
			return string.Empty;
		}

		private static void DetectAllChannelFormats()
		{
			foreach (KeyValuePair<string, List<AudioData>> uniqueName in FileNameDict)
			{
				// Group together files with same name
				if (uniqueName.Value.Count == 1)
				{
					AudioData singleInstance = uniqueName.Value[0];

					if (singleInstance.channelsCount == 1 && singleInstance.channelExt.ToString() == null)
					{
						singleInstance.channelFormat = "Mono";
					}
					else if (singleInstance.channelsCount > 1)
					{
						singleInstance.channelFormat = GetChannelFormat(singleInstance.channelsCount);
					}
				}
				else
				{
					string format = GetChannelFormat(uniqueName.Value.Count);

					foreach (AudioData data in uniqueName.Value)
					{
						data.channelFormat = format;
					}
				}
			}
		}

		private static void CreateNewFilenamesForAll()
		{
			foreach (KeyValuePair<string, List<AudioData>> uniqueName in FileNameDict)
			{
				foreach (AudioData data in uniqueName.Value)
				{
					if (DetectLength)
					{
						data.newFileName = $"{SessionName}{SEP}{Prefix}{data.roundedDuration}{Suffix}{SEP}";
					}
					else
					{
						data.newFileName = $"{SessionName}{SEP}{Prefix}{Length}{Suffix}{SEP}";
					}
			
					data.newFileName += $"{ data.channelFormat }{ SEP }{ data.InputType }{ data.channelExt }";
					
					if (!UniqueFileNameList.Contains(data))
					{
						UniqueFileNameList.Add(data);
						AddEntryToListview(data.fileName + data.channelExt, data.newFileName, true);
					}
					else AddEntryToListview(data.fileName + data.channelExt, $"{data.newFileName} conflicts, will be ignored", false);
				}
			}
		}

		public static void AddEntryToListview(string oldName, string newName, bool status)
		{
			EntryStatus entry = new EntryStatus();
			entry.firstMessage = oldName;
			entry.secondMessage = newName;
			entry.status = status;
			EntryStatusList.Add(entry);
		}

		public static void ProcessUniqueFileNameList()
		{
			if (UniqueFileNameList.Count > 0)
			{
				Directory.CreateDirectory(SessionName);
				string sessionFolderPath = DirectoryPath + '\\' + SessionName;
				

				foreach(AudioData audio in UniqueFileNameList)
				{
					string currentFile = Path.GetFileName(audio.fullPath);
					string ext = $".{audio.pcmType}";
					
					if (DetectLength)
					{
						string lengthFolder = sessionFolderPath + '\\' + audio.roundedDuration.ToString();
						//If project folder doesnt exist, create it in Root
						if (!Directory.Exists(lengthFolder))
						{
							Directory.CreateDirectory(lengthFolder);
						}
						//File does not exist so rename and move to folder
						if (!File.Exists(lengthFolder + "\\" + audio.newFileName + ext))
						{
							//Rename file and move to new folder
							File.Move(currentFile, lengthFolder + "\\" + audio.newFileName + ext);
						}
					}
					else
					{
						if (Length != string.Empty)
						{
							string lengthFolder = sessionFolderPath + '\\' + Length;
							//If project folder doesnt exist, create it in Root
							if (!Directory.Exists(lengthFolder))
							{
								Directory.CreateDirectory(lengthFolder);
							}
							//File does not exist so rename and move to folder
							if (!File.Exists(lengthFolder + "\\" + audio.newFileName + ext))
							{
								//Rename file and move to new folder
								File.Move(currentFile, lengthFolder + "\\" + audio.newFileName + ext);
							}
						}

					}
				}
			}
		}

		public static List<string> ChannelList = new List<string>();		

	}

}
