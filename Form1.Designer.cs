
namespace StemWizardPro2
{
	partial class Form1
	{
		/// <summary>
		///  Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		///  Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}





		#region Windows Form Designer generated code

		/// <summary>
		///  Required method for Designer support - do not modify
		///  the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
			this.listView1 = new System.Windows.Forms.ListView();
			this.CurrentName = new System.Windows.Forms.ColumnHeader();
			this.AfterProcess = new System.Windows.Forms.ColumnHeader();
			this.ScanButton = new System.Windows.Forms.Button();
			this.SessionNameInput = new System.Windows.Forms.TextBox();
			this.label1 = new System.Windows.Forms.Label();
			this.PrefixText = new System.Windows.Forms.Label();
			this.PrefixInput = new System.Windows.Forms.TextBox();
			this.LengthInput = new System.Windows.Forms.TextBox();
			this.Lengthtext = new System.Windows.Forms.Label();
			this.SuffixText = new System.Windows.Forms.Label();
			this.SuffixInput = new System.Windows.Forms.TextBox();
			this.ExecuteButton = new System.Windows.Forms.Button();
			this.tabControl1 = new System.Windows.Forms.TabControl();
			this.mainPage = new System.Windows.Forms.TabPage();
			this.detectLengthCheckBox = new System.Windows.Forms.CheckBox();
			this.ioPage = new System.Windows.Forms.TabPage();
			this.dataGridView1 = new System.Windows.Forms.DataGridView();
			this.Inputs = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Ouputs = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.MP3 = new System.Windows.Forms.DataGridViewComboBoxColumn();
			this.Formats = new System.Windows.Forms.TabPage();
			this.dataGridViewFormats = new System.Windows.Forms.DataGridView();
			this.Format = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.FormatLabel = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.tabControl1.SuspendLayout();
			this.mainPage.SuspendLayout();
			this.ioPage.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
			this.Formats.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.dataGridViewFormats)).BeginInit();
			this.SuspendLayout();
			// 
			// listView1
			// 
			this.listView1.AutoArrange = false;
			this.listView1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(42)))), ((int)(((byte)(87)))));
			this.listView1.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.CurrentName,
            this.AfterProcess});
			this.listView1.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
			this.listView1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(219)))), ((int)(((byte)(153)))), ((int)(((byte)(29)))));
			this.listView1.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
			this.listView1.HideSelection = false;
			this.listView1.Location = new System.Drawing.Point(0, 1);
			this.listView1.MultiSelect = false;
			this.listView1.Name = "listView1";
			this.listView1.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.listView1.Size = new System.Drawing.Size(484, 427);
			this.listView1.TabIndex = 0;
			this.listView1.UseCompatibleStateImageBehavior = false;
			this.listView1.View = System.Windows.Forms.View.Details;
			// 
			// CurrentName
			// 
			this.CurrentName.Text = "Present Name";
			this.CurrentName.Width = 180;
			// 
			// AfterProcess
			// 
			this.AfterProcess.Text = "Future Name";
			this.AfterProcess.Width = 320;
			// 
			// ScanButton
			// 
			this.ScanButton.BackColor = System.Drawing.Color.White;
			this.ScanButton.FlatAppearance.BorderColor = System.Drawing.Color.DeepSkyBlue;
			this.ScanButton.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
			this.ScanButton.ForeColor = System.Drawing.Color.Black;
			this.ScanButton.Location = new System.Drawing.Point(366, 434);
			this.ScanButton.Name = "ScanButton";
			this.ScanButton.Size = new System.Drawing.Size(112, 50);
			this.ScanButton.TabIndex = 1;
			this.ScanButton.Text = "SCAN DIRECTORY";
			this.ScanButton.UseVisualStyleBackColor = false;
			this.ScanButton.Click += new System.EventHandler(this.ScanButton_Click);
			// 
			// SessionNameInput
			// 
			this.SessionNameInput.Location = new System.Drawing.Point(66, 436);
			this.SessionNameInput.Name = "SessionNameInput";
			this.SessionNameInput.Size = new System.Drawing.Size(161, 23);
			this.SessionNameInput.TabIndex = 2;
			this.SessionNameInput.Leave += new System.EventHandler(this.SessionNameInput_Leave);
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.BackColor = System.Drawing.Color.Transparent;
			this.label1.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
			this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
			this.label1.Location = new System.Drawing.Point(8, 436);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(40, 20);
			this.label1.TabIndex = 3;
			this.label1.Text = "Title";
			// 
			// PrefixText
			// 
			this.PrefixText.AutoSize = true;
			this.PrefixText.BackColor = System.Drawing.Color.Transparent;
			this.PrefixText.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
			this.PrefixText.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
			this.PrefixText.Location = new System.Drawing.Point(8, 467);
			this.PrefixText.Name = "PrefixText";
			this.PrefixText.Size = new System.Drawing.Size(45, 20);
			this.PrefixText.TabIndex = 4;
			this.PrefixText.Text = "Prefix";
			// 
			// PrefixInput
			// 
			this.PrefixInput.Location = new System.Drawing.Point(66, 466);
			this.PrefixInput.Name = "PrefixInput";
			this.PrefixInput.Size = new System.Drawing.Size(71, 23);
			this.PrefixInput.TabIndex = 5;
			this.PrefixInput.Leave += new System.EventHandler(this.PrefixInput_Leave);
			// 
			// LengthInput
			// 
			this.LengthInput.Location = new System.Drawing.Point(66, 496);
			this.LengthInput.Name = "LengthInput";
			this.LengthInput.Size = new System.Drawing.Size(71, 23);
			this.LengthInput.TabIndex = 7;
			this.LengthInput.Leave += new System.EventHandler(this.LengthInput_Leave);
			// 
			// Lengthtext
			// 
			this.Lengthtext.AutoSize = true;
			this.Lengthtext.BackColor = System.Drawing.Color.Transparent;
			this.Lengthtext.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
			this.Lengthtext.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
			this.Lengthtext.Location = new System.Drawing.Point(8, 497);
			this.Lengthtext.Name = "Lengthtext";
			this.Lengthtext.Size = new System.Drawing.Size(52, 20);
			this.Lengthtext.TabIndex = 6;
			this.Lengthtext.Text = "Length";
			// 
			// SuffixText
			// 
			this.SuffixText.AutoSize = true;
			this.SuffixText.BackColor = System.Drawing.Color.Transparent;
			this.SuffixText.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
			this.SuffixText.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
			this.SuffixText.Location = new System.Drawing.Point(8, 526);
			this.SuffixText.Name = "SuffixText";
			this.SuffixText.Size = new System.Drawing.Size(43, 20);
			this.SuffixText.TabIndex = 8;
			this.SuffixText.Text = "Suffix";
			// 
			// SuffixInput
			// 
			this.SuffixInput.Location = new System.Drawing.Point(66, 526);
			this.SuffixInput.Name = "SuffixInput";
			this.SuffixInput.Size = new System.Drawing.Size(71, 23);
			this.SuffixInput.TabIndex = 9;
			this.SuffixInput.Leave += new System.EventHandler(this.SuffixInput_Leave);
			// 
			// ExecuteButton
			// 
			this.ExecuteButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
			this.ExecuteButton.FlatAppearance.BorderColor = System.Drawing.Color.DeepSkyBlue;
			this.ExecuteButton.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
			this.ExecuteButton.ForeColor = System.Drawing.Color.Black;
			this.ExecuteButton.Location = new System.Drawing.Point(366, 503);
			this.ExecuteButton.Name = "ExecuteButton";
			this.ExecuteButton.Size = new System.Drawing.Size(112, 48);
			this.ExecuteButton.TabIndex = 10;
			this.ExecuteButton.Text = "EXECUTE";
			this.ExecuteButton.UseVisualStyleBackColor = false;
			this.ExecuteButton.Click += new System.EventHandler(this.ExecuteButton_Click);
			// 
			// tabControl1
			// 
			this.tabControl1.Controls.Add(this.mainPage);
			this.tabControl1.Controls.Add(this.ioPage);
			this.tabControl1.Controls.Add(this.Formats);
			this.tabControl1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
			this.tabControl1.Location = new System.Drawing.Point(12, 12);
			this.tabControl1.Name = "tabControl1";
			this.tabControl1.SelectedIndex = 0;
			this.tabControl1.Size = new System.Drawing.Size(492, 587);
			this.tabControl1.SizeMode = System.Windows.Forms.TabSizeMode.Fixed;
			this.tabControl1.TabIndex = 11;
			this.tabControl1.SelectedIndexChanged += new System.EventHandler(this.tabControl1_SelectedIndexChanged);
			// 
			// mainPage
			// 
			this.mainPage.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(24)))));
			this.mainPage.Controls.Add(this.detectLengthCheckBox);
			this.mainPage.Controls.Add(this.listView1);
			this.mainPage.Controls.Add(this.ExecuteButton);
			this.mainPage.Controls.Add(this.ScanButton);
			this.mainPage.Controls.Add(this.SuffixInput);
			this.mainPage.Controls.Add(this.SessionNameInput);
			this.mainPage.Controls.Add(this.SuffixText);
			this.mainPage.Controls.Add(this.label1);
			this.mainPage.Controls.Add(this.LengthInput);
			this.mainPage.Controls.Add(this.PrefixText);
			this.mainPage.Controls.Add(this.Lengthtext);
			this.mainPage.Controls.Add(this.PrefixInput);
			this.mainPage.ForeColor = System.Drawing.SystemColors.GradientInactiveCaption;
			this.mainPage.Location = new System.Drawing.Point(4, 24);
			this.mainPage.Name = "mainPage";
			this.mainPage.Padding = new System.Windows.Forms.Padding(3);
			this.mainPage.Size = new System.Drawing.Size(484, 559);
			this.mainPage.TabIndex = 0;
			this.mainPage.Text = "Main";
			// 
			// detectLengthCheckBox
			// 
			this.detectLengthCheckBox.AutoSize = true;
			this.detectLengthCheckBox.Checked = true;
			this.detectLengthCheckBox.CheckState = System.Windows.Forms.CheckState.Checked;
			this.detectLengthCheckBox.FlatAppearance.BorderColor = System.Drawing.Color.White;
			this.detectLengthCheckBox.FlatAppearance.CheckedBackColor = System.Drawing.Color.Lime;
			this.detectLengthCheckBox.ForeColor = System.Drawing.Color.Orange;
			this.detectLengthCheckBox.Location = new System.Drawing.Point(152, 498);
			this.detectLengthCheckBox.Name = "detectLengthCheckBox";
			this.detectLengthCheckBox.Size = new System.Drawing.Size(170, 19);
			this.detectLengthCheckBox.TabIndex = 11;
			this.detectLengthCheckBox.Text = "Detect Broadcast Lengths";
			this.detectLengthCheckBox.UseVisualStyleBackColor = true;
			this.detectLengthCheckBox.CheckedChanged += new System.EventHandler(this.DetectLengthCheckBox_CheckedChanged);
			// 
			// ioPage
			// 
			this.ioPage.BackColor = System.Drawing.Color.Transparent;
			this.ioPage.Controls.Add(this.dataGridView1);
			this.ioPage.Location = new System.Drawing.Point(4, 24);
			this.ioPage.Name = "ioPage";
			this.ioPage.Size = new System.Drawing.Size(484, 559);
			this.ioPage.TabIndex = 2;
			this.ioPage.Text = "I/O";
			// 
			// dataGridView1
			// 
			this.dataGridView1.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
			this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Inputs,
            this.Ouputs,
            this.MP3});
			this.dataGridView1.GridColor = System.Drawing.Color.DarkKhaki;
			this.dataGridView1.Location = new System.Drawing.Point(0, 3);
			this.dataGridView1.Name = "dataGridView1";
			this.dataGridView1.RowHeadersVisible = false;
			dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
			dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
			this.dataGridView1.RowsDefaultCellStyle = dataGridViewCellStyle2;
			this.dataGridView1.RowTemplate.DefaultCellStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
			this.dataGridView1.RowTemplate.DefaultCellStyle.ForeColor = System.Drawing.Color.White;
			this.dataGridView1.RowTemplate.DividerHeight = 2;
			this.dataGridView1.RowTemplate.Height = 28;
			this.dataGridView1.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.False;
			this.dataGridView1.Size = new System.Drawing.Size(489, 556);
			this.dataGridView1.TabIndex = 0;
			// 
			// Inputs
			// 
			this.Inputs.HeaderText = "Detection Key";
			this.Inputs.MinimumWidth = 100;
			this.Inputs.Name = "Inputs";
			this.Inputs.Resizable = System.Windows.Forms.DataGridViewTriState.False;
			this.Inputs.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
			this.Inputs.ToolTipText = "Key word used to detect the type of split stem in filename";
			this.Inputs.Width = 164;
			// 
			// Ouputs
			// 
			this.Ouputs.HeaderText = "Final Label";
			this.Ouputs.MinimumWidth = 100;
			this.Ouputs.Name = "Ouputs";
			this.Ouputs.Resizable = System.Windows.Forms.DataGridViewTriState.False;
			this.Ouputs.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
			this.Ouputs.ToolTipText = "What the split stem should be labeled as.";
			this.Ouputs.Width = 264;
			// 
			// MP3
			// 
			dataGridViewCellStyle1.NullValue = "NO";
			this.MP3.DefaultCellStyle = dataGridViewCellStyle1;
			this.MP3.HeaderText = "MP3";
			this.MP3.Items.AddRange(new object[] {
            "NO",
            "320",
            "256",
            "192",
            "160",
            "128",
            "96",
            "64"});
			this.MP3.MinimumWidth = 25;
			this.MP3.Name = "MP3";
			this.MP3.ToolTipText = "Choosing anything other than \"NO\" will create an MP3 at the chosen KBPS.";
			this.MP3.Width = 53;
			// 
			// Formats
			// 
			this.Formats.BackColor = System.Drawing.Color.Black;
			this.Formats.Controls.Add(this.dataGridViewFormats);
			this.Formats.Location = new System.Drawing.Point(4, 24);
			this.Formats.Name = "Formats";
			this.Formats.Padding = new System.Windows.Forms.Padding(3);
			this.Formats.Size = new System.Drawing.Size(484, 559);
			this.Formats.TabIndex = 3;
			this.Formats.Text = "Formats";
			// 
			// dataGridViewFormats
			// 
			this.dataGridViewFormats.AllowUserToAddRows = false;
			this.dataGridViewFormats.AllowUserToDeleteRows = false;
			this.dataGridViewFormats.AllowUserToResizeColumns = false;
			this.dataGridViewFormats.AllowUserToResizeRows = false;
			this.dataGridViewFormats.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
			this.dataGridViewFormats.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
			this.dataGridViewFormats.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
			this.dataGridViewFormats.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataGridViewFormats.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Format,
            this.FormatLabel});
			this.dataGridViewFormats.GridColor = System.Drawing.Color.DarkKhaki;
			this.dataGridViewFormats.Location = new System.Drawing.Point(136, 99);
			this.dataGridViewFormats.Name = "dataGridViewFormats";
			this.dataGridViewFormats.RowHeadersVisible = false;
			dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
			dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			dataGridViewCellStyle3.ForeColor = System.Drawing.Color.White;
			this.dataGridViewFormats.RowsDefaultCellStyle = dataGridViewCellStyle3;
			this.dataGridViewFormats.RowTemplate.DefaultCellStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
			this.dataGridViewFormats.RowTemplate.DefaultCellStyle.ForeColor = System.Drawing.Color.White;
			this.dataGridViewFormats.RowTemplate.DefaultCellStyle.Padding = new System.Windows.Forms.Padding(0, 0, 0, 2);
			this.dataGridViewFormats.RowTemplate.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.Black;
			this.dataGridViewFormats.RowTemplate.DividerHeight = 2;
			this.dataGridViewFormats.RowTemplate.Height = 28;
			this.dataGridViewFormats.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.False;
			this.dataGridViewFormats.Size = new System.Drawing.Size(227, 325);
			this.dataGridViewFormats.TabIndex = 1;
			// 
			// Format
			// 
			this.Format.HeaderText = "Format";
			this.Format.MinimumWidth = 75;
			this.Format.Name = "Format";
			this.Format.ReadOnly = true;
			this.Format.Resizable = System.Windows.Forms.DataGridViewTriState.False;
			this.Format.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
			this.Format.ToolTipText = "Audio Format";
			this.Format.Width = 75;
			// 
			// FormatLabel
			// 
			this.FormatLabel.HeaderText = "Label";
			this.FormatLabel.MinimumWidth = 100;
			this.FormatLabel.Name = "FormatLabel";
			this.FormatLabel.Resizable = System.Windows.Forms.DataGridViewTriState.False;
			this.FormatLabel.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
			this.FormatLabel.ToolTipText = "What the split stem should be labeled as.";
			this.FormatLabel.Width = 150;
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(69)))), ((int)(((byte)(143)))));
			this.ClientSize = new System.Drawing.Size(517, 610);
			this.Controls.Add(this.tabControl1);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.Name = "Form1";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "StemWizard Pro 2";
			this.tabControl1.ResumeLayout(false);
			this.mainPage.ResumeLayout(false);
			this.mainPage.PerformLayout();
			this.ioPage.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
			this.Formats.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.dataGridViewFormats)).EndInit();
			this.ResumeLayout(false);

		}



		#endregion

		private System.Windows.Forms.ListView listView1;
		private System.Windows.Forms.Button ScanButton;
		private System.Windows.Forms.ColumnHeader CurrentName;
		private System.Windows.Forms.TextBox SessionNameInput;
		private System.Windows.Forms.ColumnHeader AfterProcess;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label PrefixText;
		private System.Windows.Forms.TextBox PrefixInput;
		private System.Windows.Forms.TextBox LengthInput;
		private System.Windows.Forms.Label Lengthtext;
		private System.Windows.Forms.Label SuffixText;
		private System.Windows.Forms.TextBox SuffixInput;
		private System.Windows.Forms.Button ExecuteButton;
		private System.Windows.Forms.TabControl tabControl1;
		private System.Windows.Forms.TabPage mainPage;
		private System.Windows.Forms.TabPage ioPage;
		private System.Windows.Forms.DataGridView dataGridView1;
		private System.Windows.Forms.CheckBox detectLengthCheckBox;
		private System.Windows.Forms.TabPage Formats;
		private System.Windows.Forms.DataGridViewTextBoxColumn Inputs;
		private System.Windows.Forms.DataGridViewTextBoxColumn Ouputs;
		private System.Windows.Forms.DataGridViewComboBoxColumn MP3;
		private System.Windows.Forms.DataGridView dataGridViewFormats;
		private System.Windows.Forms.DataGridViewTextBoxColumn Format;
		private System.Windows.Forms.DataGridViewTextBoxColumn FormatLabel;
	}
}

