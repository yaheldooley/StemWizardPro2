using NAudio.Wave;
using System;
using System.Windows.Forms;

namespace StemWizardPro2
{
	public class AudioData
	{
		public string originalfullPath;
		public string newfullPath;
		public PCMType pcmType;

		public string originalFileName;
		public string newFileName;

		public int UMID;

		public string channelExt;
		public int channelsCount;
		public string channelFormat;

		public int roundedDuration;
		public int duration;

		

		public long sampleRate;

		public string InputType;

	}

	public static partial class ChannelFormat
	{
		
	}
}
