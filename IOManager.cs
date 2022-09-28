using System;
using System.Collections.Generic;
using System.Linq;

namespace StemWizardPro2
{
	public class IOManager
	{
		private List<StemEntry> OrderedStems = new List<StemEntry>();

		private Dictionary<string, string> DefaultIO = new Dictionary<string, string> {
			{ "mix", "Mix"},
			{ "mixminus", "MixminusVO"},
			{ "mne", "MnE"},
			{ "undipped", "Undipped Music"},
			{ "music", "Music"},
			{ "dial", "Dial"},
			{ "sfx", "Sfx"},
			{ "vo", "VO"},
			};
		public IOSettings LoadDefaultIO()
		{
			IOSettings defaultSettings = new IOSettings();
			foreach(KeyValuePair<string, string> pair in DefaultIO)
			{
				defaultSettings.Inputs.Add(pair.Key);
				defaultSettings.Outputs.Add(pair.Value);
				defaultSettings.Mp3Settings.Add("NO");
			}
			CreateStemEntriesFromIOSettings(defaultSettings);
			return defaultSettings;
		}


		public void CreateStemEntriesFromIOSettings(IOSettings settings)
		{
			OrderedStems.Clear();

			for (int i = 0; i < settings.Inputs.Count; i++)
			{
				StemEntry stem = new StemEntry();
				if (settings.Inputs[i] == string.Empty)
				{
					continue;
				}
				else stem.Input = settings.Inputs[i];

				if (i >= settings.Outputs.Count || settings.Outputs[i] == string.Empty)
				{
					continue;
				}
				else stem.Output = settings.Outputs[i];

				int kbps;
				if (i >= settings.Mp3Settings.Count || !int.TryParse(settings.Mp3Settings[i], out kbps)) kbps = 0;
				stem.MP3KBPS = kbps;
				OrderedStems.Add(stem);
			}
			SortInputListByCharacterLength();
		}

		public void SortInputListByCharacterLength()
		{
			OrderedStems = OrderedStems.OrderBy(split => split.Input.Length).ToList();
		}

		public string ParseFilenameForInputs(string fileName)
		{
			string stringToSearch = fileName.ToLower();

			for (int i = 0; i < OrderedStems.Count; i++)
			{
				if (stringToSearch.Contains(OrderedStems[i].Input))
				{
					return OrderedStems[i].Output;
				}
			}
			return string.Empty;
		}

		public class IOSettings
		{
			public List<string> Inputs = new List<string>();
			public List<string> Outputs = new List<string>();
			public List<string> Mp3Settings = new List<string>();
		}


		public string UpperFirstChar(string input)
		{
			if (string.IsNullOrEmpty(input))
			{
				return null;
			}

			char[] chars = input.ToCharArray();
			chars[0] = char.ToUpper(chars[0]);
			return new string(chars);
		}
	}
}
