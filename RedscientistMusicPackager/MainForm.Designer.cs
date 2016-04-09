namespace RedscientistMusicPackager
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.tbOutputFolder = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.btnBrowseOutputFolder = new System.Windows.Forms.Button();
            this.btnExecute = new System.Windows.Forms.Button();
            this.tabMusic = new System.Windows.Forms.TabPage();
            this.btnSaveTrack = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.nmTrackNumber = new System.Windows.Forms.NumericUpDown();
            this.label10 = new System.Windows.Forms.Label();
            this.btnBrowseTrackFile = new System.Windows.Forms.Button();
            this.tbTrackFile = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.tbTrackName = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.btnNewTrack = new System.Windows.Forms.Button();
            this.btnRemoveSelected = new System.Windows.Forms.Button();
            this.lbAlbumTracks = new System.Windows.Forms.ListBox();
            this.tabGeneral = new System.Windows.Forms.TabPage();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.btnBrowseArtwork = new System.Windows.Forms.Button();
            this.pbArtwork = new System.Windows.Forms.PictureBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.tbAlbumName = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tbAlbumGenre = new System.Windows.Forms.TextBox();
            this.tbAlbumId = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.tbArtistName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tbArtistId = new System.Windows.Forms.TextBox();
            this.tabControl = new System.Windows.Forms.TabControl();
            this.progressBar = new System.Windows.Forms.ProgressBar();
            this.backgroundWorker = new System.ComponentModel.BackgroundWorker();
            this.nmAlbumYear = new System.Windows.Forms.NumericUpDown();
            this.tabMusic.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nmTrackNumber)).BeginInit();
            this.tabGeneral.SuspendLayout();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbArtwork)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.tabControl.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nmAlbumYear)).BeginInit();
            this.SuspendLayout();
            // 
            // tbOutputFolder
            // 
            this.tbOutputFolder.Location = new System.Drawing.Point(72, 281);
            this.tbOutputFolder.Name = "tbOutputFolder";
            this.tbOutputFolder.Size = new System.Drawing.Size(467, 20);
            this.tbOutputFolder.TabIndex = 3;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 284);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(54, 13);
            this.label5.TabIndex = 3;
            this.label5.Text = "Output to:";
            // 
            // btnBrowseOutputFolder
            // 
            this.btnBrowseOutputFolder.Location = new System.Drawing.Point(545, 281);
            this.btnBrowseOutputFolder.Name = "btnBrowseOutputFolder";
            this.btnBrowseOutputFolder.Size = new System.Drawing.Size(54, 23);
            this.btnBrowseOutputFolder.TabIndex = 4;
            this.btnBrowseOutputFolder.Text = "Browse";
            this.btnBrowseOutputFolder.UseVisualStyleBackColor = true;
            this.btnBrowseOutputFolder.Click += new System.EventHandler(this.btnBrowseOutputFolder_Click);
            // 
            // btnExecute
            // 
            this.btnExecute.Location = new System.Drawing.Point(605, 281);
            this.btnExecute.Name = "btnExecute";
            this.btnExecute.Size = new System.Drawing.Size(57, 23);
            this.btnExecute.TabIndex = 5;
            this.btnExecute.Text = "Execute";
            this.btnExecute.UseVisualStyleBackColor = true;
            this.btnExecute.Click += new System.EventHandler(this.btnExecute_Click);
            // 
            // tabMusic
            // 
            this.tabMusic.BackColor = System.Drawing.SystemColors.Control;
            this.tabMusic.Controls.Add(this.btnSaveTrack);
            this.tabMusic.Controls.Add(this.groupBox3);
            this.tabMusic.Controls.Add(this.btnNewTrack);
            this.tabMusic.Controls.Add(this.btnRemoveSelected);
            this.tabMusic.Controls.Add(this.lbAlbumTracks);
            this.tabMusic.Location = new System.Drawing.Point(4, 22);
            this.tabMusic.Name = "tabMusic";
            this.tabMusic.Padding = new System.Windows.Forms.Padding(3);
            this.tabMusic.Size = new System.Drawing.Size(644, 233);
            this.tabMusic.TabIndex = 1;
            this.tabMusic.Text = "Music tracks";
            // 
            // btnSaveTrack
            // 
            this.btnSaveTrack.Location = new System.Drawing.Point(290, 146);
            this.btnSaveTrack.Name = "btnSaveTrack";
            this.btnSaveTrack.Size = new System.Drawing.Size(83, 23);
            this.btnSaveTrack.TabIndex = 10;
            this.btnSaveTrack.Text = "Save track";
            this.btnSaveTrack.UseVisualStyleBackColor = true;
            this.btnSaveTrack.Click += new System.EventHandler(this.btnSaveTrack_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.nmTrackNumber);
            this.groupBox3.Controls.Add(this.label10);
            this.groupBox3.Controls.Add(this.btnBrowseTrackFile);
            this.groupBox3.Controls.Add(this.tbTrackFile);
            this.groupBox3.Controls.Add(this.label9);
            this.groupBox3.Controls.Add(this.tbTrackName);
            this.groupBox3.Controls.Add(this.label8);
            this.groupBox3.Location = new System.Drawing.Point(290, 35);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(344, 105);
            this.groupBox3.TabIndex = 9;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Track information";
            // 
            // nmTrackNumber
            // 
            this.nmTrackNumber.Location = new System.Drawing.Point(60, 19);
            this.nmTrackNumber.Maximum = new decimal(new int[] {
            65536,
            0,
            0,
            0});
            this.nmTrackNumber.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nmTrackNumber.Name = "nmTrackNumber";
            this.nmTrackNumber.Size = new System.Drawing.Size(120, 20);
            this.nmTrackNumber.TabIndex = 14;
            this.nmTrackNumber.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(6, 74);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(26, 13);
            this.label10.TabIndex = 12;
            this.label10.Text = "File:";
            // 
            // btnBrowseTrackFile
            // 
            this.btnBrowseTrackFile.Location = new System.Drawing.Point(281, 69);
            this.btnBrowseTrackFile.Name = "btnBrowseTrackFile";
            this.btnBrowseTrackFile.Size = new System.Drawing.Size(57, 23);
            this.btnBrowseTrackFile.TabIndex = 13;
            this.btnBrowseTrackFile.Text = "Browse";
            this.btnBrowseTrackFile.UseVisualStyleBackColor = true;
            this.btnBrowseTrackFile.Click += new System.EventHandler(this.btnBrowseTrackFile_Click);
            // 
            // tbTrackFile
            // 
            this.tbTrackFile.Location = new System.Drawing.Point(60, 71);
            this.tbTrackFile.Name = "tbTrackFile";
            this.tbTrackFile.Size = new System.Drawing.Size(215, 20);
            this.tbTrackFile.TabIndex = 12;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(6, 48);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(38, 13);
            this.label9.TabIndex = 11;
            this.label9.Text = "Name:";
            // 
            // tbTrackName
            // 
            this.tbTrackName.Location = new System.Drawing.Point(60, 45);
            this.tbTrackName.Name = "tbTrackName";
            this.tbTrackName.Size = new System.Drawing.Size(278, 20);
            this.tbTrackName.TabIndex = 10;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(6, 22);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(48, 13);
            this.label8.TabIndex = 9;
            this.label8.Text = "Track #:";
            // 
            // btnNewTrack
            // 
            this.btnNewTrack.Location = new System.Drawing.Point(290, 6);
            this.btnNewTrack.Name = "btnNewTrack";
            this.btnNewTrack.Size = new System.Drawing.Size(83, 23);
            this.btnNewTrack.TabIndex = 7;
            this.btnNewTrack.Text = "New track";
            this.btnNewTrack.UseVisualStyleBackColor = true;
            this.btnNewTrack.Click += new System.EventHandler(this.btnNewTrack_Click);
            // 
            // btnRemoveSelected
            // 
            this.btnRemoveSelected.Location = new System.Drawing.Point(6, 198);
            this.btnRemoveSelected.Name = "btnRemoveSelected";
            this.btnRemoveSelected.Size = new System.Drawing.Size(111, 23);
            this.btnRemoveSelected.TabIndex = 6;
            this.btnRemoveSelected.Text = "Remove selected";
            this.btnRemoveSelected.UseVisualStyleBackColor = true;
            this.btnRemoveSelected.Click += new System.EventHandler(this.btnRemoveSelected_Click);
            // 
            // lbAlbumTracks
            // 
            this.lbAlbumTracks.FormattingEnabled = true;
            this.lbAlbumTracks.Location = new System.Drawing.Point(6, 6);
            this.lbAlbumTracks.Name = "lbAlbumTracks";
            this.lbAlbumTracks.Size = new System.Drawing.Size(278, 186);
            this.lbAlbumTracks.TabIndex = 0;
            this.lbAlbumTracks.SelectedIndexChanged += new System.EventHandler(this.lbAlbumTracks_SelectedIndexChanged);
            // 
            // tabGeneral
            // 
            this.tabGeneral.BackColor = System.Drawing.SystemColors.Control;
            this.tabGeneral.Controls.Add(this.groupBox4);
            this.tabGeneral.Controls.Add(this.groupBox2);
            this.tabGeneral.Controls.Add(this.groupBox1);
            this.tabGeneral.Location = new System.Drawing.Point(4, 22);
            this.tabGeneral.Name = "tabGeneral";
            this.tabGeneral.Padding = new System.Windows.Forms.Padding(3);
            this.tabGeneral.Size = new System.Drawing.Size(644, 233);
            this.tabGeneral.TabIndex = 0;
            this.tabGeneral.Text = "General information";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.btnBrowseArtwork);
            this.groupBox4.Controls.Add(this.pbArtwork);
            this.groupBox4.Location = new System.Drawing.Point(447, 14);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(191, 210);
            this.groupBox4.TabIndex = 10;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Album artwork";
            // 
            // btnBrowseArtwork
            // 
            this.btnBrowseArtwork.Location = new System.Drawing.Point(64, 171);
            this.btnBrowseArtwork.Name = "btnBrowseArtwork";
            this.btnBrowseArtwork.Size = new System.Drawing.Size(54, 23);
            this.btnBrowseArtwork.TabIndex = 6;
            this.btnBrowseArtwork.Text = "Browse";
            this.btnBrowseArtwork.UseVisualStyleBackColor = true;
            this.btnBrowseArtwork.Click += new System.EventHandler(this.btnBrowseArtwork_Click);
            // 
            // pbArtwork
            // 
            this.pbArtwork.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pbArtwork.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pbArtwork.Location = new System.Drawing.Point(28, 28);
            this.pbArtwork.Name = "pbArtwork";
            this.pbArtwork.Size = new System.Drawing.Size(130, 130);
            this.pbArtwork.TabIndex = 9;
            this.pbArtwork.TabStop = false;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.nmAlbumYear);
            this.groupBox2.Controls.Add(this.tbAlbumName);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.tbAlbumGenre);
            this.groupBox2.Controls.Add(this.tbAlbumId);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Location = new System.Drawing.Point(6, 91);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(434, 133);
            this.groupBox2.TabIndex = 8;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Album information";
            // 
            // tbAlbumName
            // 
            this.tbAlbumName.BackColor = System.Drawing.SystemColors.Window;
            this.tbAlbumName.Location = new System.Drawing.Point(81, 19);
            this.tbAlbumName.Name = "tbAlbumName";
            this.tbAlbumName.Size = new System.Drawing.Size(340, 20);
            this.tbAlbumName.TabIndex = 0;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 22);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(38, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Name:";
            // 
            // tbAlbumGenre
            // 
            this.tbAlbumGenre.Location = new System.Drawing.Point(81, 71);
            this.tbAlbumGenre.Name = "tbAlbumGenre";
            this.tbAlbumGenre.Size = new System.Drawing.Size(340, 20);
            this.tbAlbumGenre.TabIndex = 6;
            // 
            // tbAlbumId
            // 
            this.tbAlbumId.Location = new System.Drawing.Point(81, 45);
            this.tbAlbumId.Name = "tbAlbumId";
            this.tbAlbumId.Size = new System.Drawing.Size(340, 20);
            this.tbAlbumId.TabIndex = 0;
            this.tbAlbumId.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbAlbumId_KeyPress);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(13, 48);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(21, 13);
            this.label4.TabIndex = 2;
            this.label4.Text = "ID:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(13, 74);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(39, 13);
            this.label7.TabIndex = 4;
            this.label7.Text = "Genre:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(11, 100);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(32, 13);
            this.label6.TabIndex = 3;
            this.label6.Text = "Year:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.tbArtistName);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.tbArtistId);
            this.groupBox1.Location = new System.Drawing.Point(6, 10);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(434, 78);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Artist information";
            // 
            // tbArtistName
            // 
            this.tbArtistName.Location = new System.Drawing.Point(81, 19);
            this.tbArtistName.Name = "tbArtistName";
            this.tbArtistName.Size = new System.Drawing.Size(340, 20);
            this.tbArtistName.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Name:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 48);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(21, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "ID:";
            // 
            // tbArtistId
            // 
            this.tbArtistId.Location = new System.Drawing.Point(81, 45);
            this.tbArtistId.Name = "tbArtistId";
            this.tbArtistId.Size = new System.Drawing.Size(340, 20);
            this.tbArtistId.TabIndex = 0;
            this.tbArtistId.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbArtistId_KeyPress);
            // 
            // tabControl
            // 
            this.tabControl.Controls.Add(this.tabGeneral);
            this.tabControl.Controls.Add(this.tabMusic);
            this.tabControl.Location = new System.Drawing.Point(12, 12);
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(652, 259);
            this.tabControl.TabIndex = 3;
            // 
            // progressBar
            // 
            this.progressBar.Location = new System.Drawing.Point(12, 315);
            this.progressBar.Name = "progressBar";
            this.progressBar.Size = new System.Drawing.Size(648, 23);
            this.progressBar.TabIndex = 6;
            // 
            // backgroundWorker
            // 
            this.backgroundWorker.WorkerReportsProgress = true;
            this.backgroundWorker.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorker_DoWork);
            this.backgroundWorker.ProgressChanged += new System.ComponentModel.ProgressChangedEventHandler(this.backgroundWorker_ProgressChanged);
            this.backgroundWorker.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.backgroundWorker_RunWorkerCompleted);
            // 
            // nmAlbumYear
            // 
            this.nmAlbumYear.Location = new System.Drawing.Point(81, 97);
            this.nmAlbumYear.Maximum = new decimal(new int[] {
            65536,
            0,
            0,
            0});
            this.nmAlbumYear.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nmAlbumYear.Name = "nmAlbumYear";
            this.nmAlbumYear.Size = new System.Drawing.Size(120, 20);
            this.nmAlbumYear.TabIndex = 7;
            this.nmAlbumYear.Value = new decimal(new int[] {
            2000,
            0,
            0,
            0});
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(676, 350);
            this.Controls.Add(this.progressBar);
            this.Controls.Add(this.btnExecute);
            this.Controls.Add(this.btnBrowseOutputFolder);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.tbOutputFolder);
            this.Controls.Add(this.tabControl);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MainForm";
            this.Text = "Redscientist Music Packager";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.tabMusic.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nmTrackNumber)).EndInit();
            this.tabGeneral.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pbArtwork)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.tabControl.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.nmAlbumYear)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnBrowseOutputFolder;
        private System.Windows.Forms.Button btnExecute;
        private System.Windows.Forms.TabPage tabMusic;
        private System.Windows.Forms.Button btnSaveTrack;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button btnBrowseTrackFile;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button btnRemoveSelected;
        private System.Windows.Forms.TabPage tabGeneral;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Button btnBrowseArtwork;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TabControl tabControl;
        public System.Windows.Forms.TextBox tbOutputFolder;
        public System.Windows.Forms.TextBox tbTrackFile;
        public System.Windows.Forms.TextBox tbTrackName;
        public System.Windows.Forms.Button btnNewTrack;
        public System.Windows.Forms.ListBox lbAlbumTracks;
        public System.Windows.Forms.PictureBox pbArtwork;
        public System.Windows.Forms.TextBox tbAlbumName;
        public System.Windows.Forms.TextBox tbAlbumGenre;
        public System.Windows.Forms.TextBox tbAlbumId;
        public System.Windows.Forms.TextBox tbArtistName;
        public System.Windows.Forms.TextBox tbArtistId;
        public System.Windows.Forms.NumericUpDown nmTrackNumber;
        private System.Windows.Forms.ProgressBar progressBar;
        public System.ComponentModel.BackgroundWorker backgroundWorker;
        public System.Windows.Forms.NumericUpDown nmAlbumYear;
    }
}

