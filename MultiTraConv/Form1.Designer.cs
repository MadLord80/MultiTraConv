namespace MultiTraConv
{
    partial class MultiTraConv
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MultiTraConv));
			this.mp3dir_dialog = new System.Windows.Forms.FolderBrowserDialog();
			this.mp3dir_button = new System.Windows.Forms.Button();
			this.mp3_path = new System.Windows.Forms.TextBox();
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.oma_path = new System.Windows.Forms.TextBox();
			this.omadir_button = new System.Windows.Forms.Button();
			this.omadir_dialog = new System.Windows.Forms.FolderBrowserDialog();
			this.FilesTable = new System.Windows.Forms.ListView();
			this.filename = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.filestatus = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.label3 = new System.Windows.Forms.Label();
			this.progressBar = new System.Windows.Forms.ProgressBar();
			this.all_count = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.conv_count = new System.Windows.Forms.Label();
			this.start_convert = new System.Windows.Forms.Button();
			this.stop_convert = new System.Windows.Forms.Button();
			this.button_Settings = new System.Windows.Forms.Button();
			this.Help_button = new System.Windows.Forms.Button();
			this.button1 = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// mp3dir_dialog
			// 
			this.mp3dir_dialog.RootFolder = System.Environment.SpecialFolder.MyComputer;
			this.mp3dir_dialog.ShowNewFolderButton = false;
			// 
			// mp3dir_button
			// 
			this.mp3dir_button.Location = new System.Drawing.Point(926, 14);
			this.mp3dir_button.Name = "mp3dir_button";
			this.mp3dir_button.Size = new System.Drawing.Size(24, 23);
			this.mp3dir_button.TabIndex = 0;
			this.mp3dir_button.Text = "...";
			this.mp3dir_button.UseVisualStyleBackColor = true;
			this.mp3dir_button.Click += new System.EventHandler(this.mp3dir_button_Click);
			// 
			// mp3_path
			// 
			this.mp3_path.Location = new System.Drawing.Point(141, 17);
			this.mp3_path.Name = "mp3_path";
			this.mp3_path.ReadOnly = true;
			this.mp3_path.Size = new System.Drawing.Size(779, 20);
			this.mp3_path.TabIndex = 1;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(12, 20);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(129, 13);
			this.label1.TabIndex = 2;
			this.label1.Text = "Input directory (mp3, wav)";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(12, 53);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(128, 13);
			this.label2.TabIndex = 3;
			this.label2.Text = "Output directory (oma, sc)";
			// 
			// oma_path
			// 
			this.oma_path.Location = new System.Drawing.Point(141, 50);
			this.oma_path.Name = "oma_path";
			this.oma_path.ReadOnly = true;
			this.oma_path.Size = new System.Drawing.Size(779, 20);
			this.oma_path.TabIndex = 4;
			// 
			// omadir_button
			// 
			this.omadir_button.Location = new System.Drawing.Point(926, 48);
			this.omadir_button.Name = "omadir_button";
			this.omadir_button.Size = new System.Drawing.Size(24, 23);
			this.omadir_button.TabIndex = 5;
			this.omadir_button.Text = "...";
			this.omadir_button.UseVisualStyleBackColor = true;
			this.omadir_button.Click += new System.EventHandler(this.omadir_button_Click);
			// 
			// omadir_dialog
			// 
			this.omadir_dialog.RootFolder = System.Environment.SpecialFolder.MyComputer;
			// 
			// FilesTable
			// 
			this.FilesTable.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.filename,
            this.filestatus});
			this.FilesTable.GridLines = true;
			this.FilesTable.Location = new System.Drawing.Point(15, 134);
			this.FilesTable.Name = "FilesTable";
			this.FilesTable.Size = new System.Drawing.Size(935, 363);
			this.FilesTable.TabIndex = 6;
			this.FilesTable.UseCompatibleStateImageBehavior = false;
			this.FilesTable.View = System.Windows.Forms.View.Details;
			// 
			// filename
			// 
			this.filename.Text = "File";
			this.filename.Width = 746;
			// 
			// filestatus
			// 
			this.filestatus.Text = "Status";
			this.filestatus.Width = 185;
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(12, 115);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(95, 13);
			this.label3.TabIndex = 7;
			this.label3.Text = "Process summary: ";
			// 
			// progressBar
			// 
			this.progressBar.Location = new System.Drawing.Point(113, 115);
			this.progressBar.Name = "progressBar";
			this.progressBar.Size = new System.Drawing.Size(837, 13);
			this.progressBar.TabIndex = 8;
			this.progressBar.Tag = "";
			// 
			// all_count
			// 
			this.all_count.AutoSize = true;
			this.all_count.Location = new System.Drawing.Point(451, 96);
			this.all_count.Name = "all_count";
			this.all_count.Size = new System.Drawing.Size(13, 13);
			this.all_count.TabIndex = 9;
			this.all_count.Text = "0";
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Location = new System.Drawing.Point(483, 96);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(12, 13);
			this.label4.TabIndex = 10;
			this.label4.Text = "/";
			// 
			// conv_count
			// 
			this.conv_count.AutoSize = true;
			this.conv_count.Location = new System.Drawing.Point(492, 96);
			this.conv_count.Name = "conv_count";
			this.conv_count.Size = new System.Drawing.Size(13, 13);
			this.conv_count.TabIndex = 11;
			this.conv_count.Text = "0";
			// 
			// start_convert
			// 
			this.start_convert.Location = new System.Drawing.Point(781, 75);
			this.start_convert.Name = "start_convert";
			this.start_convert.Size = new System.Drawing.Size(117, 32);
			this.start_convert.TabIndex = 12;
			this.start_convert.Text = "Convert";
			this.start_convert.UseVisualStyleBackColor = true;
			this.start_convert.Click += new System.EventHandler(this.button1_Click);
			// 
			// stop_convert
			// 
			this.stop_convert.BackColor = System.Drawing.SystemColors.AppWorkspace;
			this.stop_convert.Enabled = false;
			this.stop_convert.FlatAppearance.BorderColor = System.Drawing.Color.Red;
			this.stop_convert.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.stop_convert.Location = new System.Drawing.Point(904, 75);
			this.stop_convert.Name = "stop_convert";
			this.stop_convert.Size = new System.Drawing.Size(46, 32);
			this.stop_convert.TabIndex = 15;
			this.stop_convert.Text = "Stop";
			this.stop_convert.UseVisualStyleBackColor = false;
			this.stop_convert.Click += new System.EventHandler(this.stop_convert_Click);
			// 
			// button_Settings
			// 
			this.button_Settings.Location = new System.Drawing.Point(15, 75);
			this.button_Settings.Name = "button_Settings";
			this.button_Settings.Size = new System.Drawing.Size(54, 32);
			this.button_Settings.TabIndex = 16;
			this.button_Settings.Text = "Settings";
			this.button_Settings.UseVisualStyleBackColor = true;
			this.button_Settings.Click += new System.EventHandler(this.button_Settings_Click);
			// 
			// Help_button
			// 
			this.Help_button.Location = new System.Drawing.Point(75, 75);
			this.Help_button.Name = "Help_button";
			this.Help_button.Size = new System.Drawing.Size(23, 32);
			this.Help_button.TabIndex = 17;
			this.Help_button.Text = "?";
			this.Help_button.UseVisualStyleBackColor = true;
			this.Help_button.Click += new System.EventHandler(this.Help_button_Click);
			// 
			// button1
			// 
			this.button1.Location = new System.Drawing.Point(597, 77);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(75, 23);
			this.button1.TabIndex = 18;
			this.button1.Text = "button1";
			this.button1.UseVisualStyleBackColor = true;
			this.button1.Click += new System.EventHandler(this.test);
			// 
			// MultiTraConv
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.AutoScroll = true;
			this.ClientSize = new System.Drawing.Size(970, 509);
			this.Controls.Add(this.button1);
			this.Controls.Add(this.Help_button);
			this.Controls.Add(this.button_Settings);
			this.Controls.Add(this.stop_convert);
			this.Controls.Add(this.start_convert);
			this.Controls.Add(this.conv_count);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.all_count);
			this.Controls.Add(this.progressBar);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.FilesTable);
			this.Controls.Add(this.omadir_button);
			this.Controls.Add(this.oma_path);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.mp3_path);
			this.Controls.Add(this.mp3dir_button);
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.MinimumSize = new System.Drawing.Size(986, 547);
			this.Name = "MultiTraConv";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "MMCS MultiTraConv";
			this.ResumeLayout(false);
			this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.FolderBrowserDialog mp3dir_dialog;
        private System.Windows.Forms.Button mp3dir_button;
        private System.Windows.Forms.TextBox mp3_path;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox oma_path;
        private System.Windows.Forms.Button omadir_button;
        private System.Windows.Forms.FolderBrowserDialog omadir_dialog;
        private System.Windows.Forms.ListView FilesTable;
        private System.Windows.Forms.ColumnHeader filename;
        private System.Windows.Forms.ColumnHeader filestatus;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ProgressBar progressBar;
        private System.Windows.Forms.Label all_count;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label conv_count;
        private System.Windows.Forms.Button start_convert;
        private System.Windows.Forms.Button stop_convert;
        private System.Windows.Forms.Button button_Settings;
        private System.Windows.Forms.Button Help_button;
		private System.Windows.Forms.Button button1;
	}
}

