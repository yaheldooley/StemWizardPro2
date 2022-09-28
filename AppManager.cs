using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;
using NAudio;

namespace StemWizardPro2
{
	public static class AppManager
	{	
		public static void ScanDirectoryForValidFiles(ListView listview)
		{
			SessionInfo.GetFilesInDirectory(listview);
		}

		// EXECUTE PROCESS

	}
}
