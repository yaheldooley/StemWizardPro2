using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static StemWizardPro2.IOManager;

namespace StemWizardPro2
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
			AddAudioFormatsToDataGridTable();
			
			IO = new IOManager();
			SetIOPanelDataToIOSettings( IO.LoadDefaultIO() );
			UndoButton.Visible = false;
			ExecuteButton.Visible = false;
			executeStatusLabel.Visible = false;
		}

		public static IOManager IO;
		private void SetIOPanelDataToIOSettings(IOSettings _settings)
		{
			dataGridView1.Rows.Clear();
			for (int i = 0; i < _settings.Inputs.Count; i++)
			{
				dataGridView1.Rows.Add(_settings.Inputs[i]);
				dataGridView1.Rows[i].Cells[1].Value = _settings.Outputs[i];
				dataGridView1.Rows[i].Cells[2].Value = _settings.Mp3Settings[i].ToString();
			}

			//IO.CreateIO(inputList.ToArray(), outputList.ToArray(), mp3List.ToArray());
		}

		private void AddAudioFormatsToDataGridTable()
		{
			dataGridViewFormats.AllowUserToAddRows = false;

			for (int i = 0; i < SessionInfo.AllAudioChannelFormats.Count; i++)
			{
				string key = SessionInfo.AllAudioChannelFormats.ElementAt(i).Key;
				string value = SessionInfo.AllAudioChannelFormats.ElementAt(i).Value;
				dataGridViewFormats.Rows.Add();
				dataGridViewFormats.Rows[i].Cells[0].Value = key;
				dataGridViewFormats.Rows[i].Cells[1].Value = value;

			}
		}


		#region Button Events

		private void ScanButton_Click(object sender, EventArgs e)
		{
			Scan();
		}

		private void SessionNameInput_Leave(object sender, EventArgs e)
		{
			SessionInfo.SessionName = SessionNameInput.Text;
			Scan();
		}

		private void PrefixInput_Leave(object sender, System.EventArgs e)
		{
			SessionInfo.Prefix = PrefixInput.Text;
			Scan();
		}

		private void LengthInput_Leave(object sender, EventArgs e)
		{
			SessionInfo.Length = LengthInput.Text;
			Scan();
		}

		private void SuffixInput_Leave(object sender, EventArgs e)
		{
			SessionInfo.Suffix = SuffixInput.Text;
			Scan();
		}

		private void DetectLengthCheckBox_CheckedChanged(object sender, EventArgs e)
		{
			LengthInput.Enabled = !detectLengthCheckBox.Checked;
			SessionInfo.DetectLength = detectLengthCheckBox.Checked;
			Scan();
		}

		private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
		{
			switch ((sender as TabControl).SelectedIndex)
			{
				case 0:
					IO.CreateStemEntriesFromIOSettings( IOFromDataGridView() );
					for (int i = 0; i < dataGridViewFormats.Rows.Count; i++)
					{
						string key = dataGridViewFormats.Rows[i].Cells[0].Value.ToString();
						string value = dataGridViewFormats.Rows[i].Cells[1].Value.ToString();
						SessionInfo.AllAudioChannelFormats[key] = value; 
					}
					Scan();
					break;
			}
		}

		private void ExecuteButton_Click(object sender, EventArgs e)
		{
			SessionInfo.ProcessUniqueFileNameList();
			if (SessionInfo.HasFileHistory) UndoButton.Enabled = true;
		}

		private void UndoButton_Click(object sender, EventArgs e)
		{
			var status = SessionInfo.UndoExecute();
			executeStatusLabel.Visible = true;
			executeStatusLabel.ForeColor = status.success ? Color.Green : Color.Red;
			executeStatusLabel.Text = status.message;
			UndoButton.Visible = SessionInfo.HasFileHistory;
			// return status
		}

		private void executeStatusLabel_Click(object sender, EventArgs e)
		{
			executeStatusLabel.Text = "";
		}

		#endregion

		private void Scan()
		{
			listView1.Items.Clear();
			SessionInfo.GetFilesInDirectory(listView1);
			ExecuteButton.Visible = listView1.Items.Count > 0;
		}

		private IOSettings IOFromDataGridView()
		{
			IOSettings currentSettings = new IOSettings();

			for (int i = 0; i < dataGridView1.Rows.Count - 1; i++)
			{
				currentSettings.Inputs.Add(dataGridView1.Rows[i].Cells[0].Value.ToString());
				currentSettings.Outputs.Add(dataGridView1.Rows[i].Cells[1].Value.ToString());
				if (dataGridView1.Rows[i].Cells.Count < i)
				{
					dataGridView1.Rows[i].Cells[2].Value = "NO";
				}
				currentSettings.Mp3Settings.Add(dataGridView1.Rows[i].Cells[2].Value.ToString());
			}

			return currentSettings;
		}

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        
    }
}
