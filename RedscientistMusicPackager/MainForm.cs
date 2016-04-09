using RedscientistMusicPackager.Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RedscientistMusicPackager
{
    public partial class MainForm : Form
    {
        public Track currentTrack = new Track();
        public List<Track> trackList = new List<Track>();
        public Cover albumCover = null;
        BackgroundWorker bgGenCover;
        string coverLocation;

        public int nbOperationsTotal = 0;
        public int nbOperationsDone = 0;
        public int percentage = 0;

        List<Control> lockableControls = new List<Control>();

        string lastDirectory = null;

        public MainForm()
        {
            InitializeComponent();
            Lib.mf = this;
        }

        private void btnNewTrack_Click(object sender, EventArgs e)
        {
            lbAlbumTracks.ClearSelected();
            currentTrack = new Track();

            nmTrackNumber.Value++;
            tbTrackName.Text = "";
            tbTrackFile.Text = "";
        }

        private void btnSaveTrack_Click(object sender, EventArgs e)
        {
            if (!File.Exists(tbTrackFile.Text) || !tbTrackFile.Text.ToLower().EndsWith(".mp3"))
            {
                MessageBox.Show("Track file couldn't be found or isn't an mp3 file.");
                return;
            }

            foreach(char chr in Path.GetInvalidFileNameChars())
                if (tbTrackName.Text.Contains(chr))
                {
                    MessageBox.Show("Track name contains illegal characters");
                    return;
                }

            int lastTrackNumber = Convert.ToInt32(nmTrackNumber.Value);

            currentTrack.TrackNumber = Convert.ToInt32(nmTrackNumber.Value);
            currentTrack.Name = tbTrackName.Text;
            currentTrack.File = tbTrackFile.Text;

            if (lbAlbumTracks.SelectedIndex == -1)
            {
                if(isTrackPresent(currentTrack.TrackNumber))
                {
                    MessageBox.Show("Track # " + currentTrack.TrackNumber.ToString() + " is already in the Track list");
                    return;
                }

                trackList.Add(currentTrack);
                refreshTracklist();
                btnNewTrack_Click(null, null);

                nmTrackNumber.Value = lastTrackNumber + 1;
            }
            else
            {
                refreshTracklist();
            }

            

        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            lbAlbumTracks.DataSource = trackList;

            lockableControls.Add(btnExecute);
            lockableControls.Add(btnBrowseOutputFolder);
            lockableControls.Add(btnBrowseArtwork);
            lockableControls.Add(btnNewTrack);
            lockableControls.Add(btnBrowseTrackFile);
            lockableControls.Add(btnSaveTrack);
            lockableControls.Add(btnRemoveSelected);
            lockableControls.Add(lbAlbumTracks);
            lockableControls.Add(nmTrackNumber);
            lockableControls.Add(tbTrackName);
            lockableControls.Add(tbTrackFile);
            lockableControls.Add(tbArtistName);
            lockableControls.Add(tbArtistId);
            lockableControls.Add(tbAlbumName);
            lockableControls.Add(tbAlbumId);
            lockableControls.Add(nmAlbumYear);
            lockableControls.Add(tbAlbumGenre);
            lockableControls.Add(tbOutputFolder);

        }

        private void lbAlbumTracks_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lbAlbumTracks.SelectedIndex == -1)
                return;

            currentTrack = (Track)lbAlbumTracks.SelectedItem;

            nmTrackNumber.Value = Convert.ToDecimal(currentTrack.TrackNumber);
            tbTrackName.Text = currentTrack.Name;
            tbTrackFile.Text = currentTrack.File;
        }

        private void btnRemoveSelected_Click(object sender, EventArgs e)
        {
            if (lbAlbumTracks.SelectedIndex == -1)
                return;

            trackList.Remove(currentTrack);

            refreshTracklist();
            btnNewTrack_Click(null, null);
        }

        private void refreshTracklist()
        {
            trackList = trackList.OrderBy(track => track.TrackNumber).ToList<Track>();

            lbAlbumTracks.DataSource = null;
            lbAlbumTracks.DataSource = trackList;
        }

        private void btnBrowseTrackFile_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "MP3 files (*.mp3)|*.mp3|All files (*.*)|*.*";
            ofd.InitialDirectory = (lastDirectory != null ? lastDirectory : Directory.GetCurrentDirectory());
            ofd.Title = "Please select an MP3 file.";
            DialogResult result = ofd.ShowDialog();
            if (result == DialogResult.OK) // Test result.
            {
                tbTrackFile.Text = ofd.FileName;
                lastDirectory = ofd.FileName.Substring(ofd.FileName.LastIndexOf(@"\"));
            }
        }

        private bool isTrackPresent(int number)
        {
            foreach(Track item in trackList)
            {
                if (item.TrackNumber == number)
                    return true;
            }

            return false;
        }

        private void btnBrowseOutputFolder_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog folderBrowserDialog1 = new FolderBrowserDialog();
            if (folderBrowserDialog1.ShowDialog() == DialogResult.OK)
            {
                tbOutputFolder.Text = folderBrowserDialog1.SelectedPath;
            }
        }

        private void btnExecute_Click(object sender, EventArgs e)
        {

            #region Check if data is present

            if (tbOutputFolder.Text.Trim() == "")
            {
                MessageBox.Show("Output folder cannot be empty");
                return;
            }

            if (!Directory.Exists(tbOutputFolder.Text))
            {
                MessageBox.Show("Output folder could not be found or accessed");
                return;
            }

            if (tbArtistName.Text.Trim() == "")
            {
                MessageBox.Show("Artist name cannot be empty");
                return;
            }

            if (tbArtistId.Text.Trim() == "")
            {
                MessageBox.Show("Artist ID cannot be empty");
                return;
            }

            if (tbAlbumName.Text.Trim() == "")
            {
                MessageBox.Show("Album name cannot be empty");
                return;
            }

            if (tbAlbumId.Text.Trim() == "")
            {
                MessageBox.Show("Album ID cannot be empty");
                return;
            }

            if (tbAlbumGenre.Text.Trim() == "")
            {
                MessageBox.Show("Album genre cannot be empty");
                return;
            }

            if (albumCover == null)
            {
                MessageBox.Show("You must select an album cover");
                return;
            }

            if (trackList.Count == 0)
            {
                MessageBox.Show("You must have at least one track");
                return;
            }

            foreach (char chr in Path.GetInvalidFileNameChars())
                if (tbAlbumId.Text.Contains(chr))
                {
                    MessageBox.Show("Album ID contains illegal characters");
                    return;
                }

            #endregion

            lockControls();

            nbOperationsTotal = 0;
            nbOperationsDone = 0;

            nbOperationsTotal ++;                   // cleanup folder
            nbOperationsTotal += 3;                 // gen remaining pictures
            nbOperationsTotal += 4;                 // save pictures
            nbOperationsTotal += trackList.Count;   // copying files in folder
            nbOperationsTotal += trackList.Count;   // retagging files
            nbOperationsTotal++;                    // zipping files
            nbOperationsTotal += trackList.Count;   // renaming files
            nbOperationsTotal++;                    // generating playlist.xml

            backgroundWorker.RunWorkerAsync();
        }

        private void tbArtistId_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = e.KeyChar == ' ';
        }

        private void tbAlbumId_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = e.KeyChar == ' ';
        }

        private void btnBrowseArtwork_Click(object sender, EventArgs e)
        {


            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "Images (*.bmp;*.jpg;*.gif;*.png)|*.bmp;*.jpg;*.gif;*.png|" +
                        "All files (*.*)|*.*";
            ofd.InitialDirectory = (lastDirectory != null ? lastDirectory : Directory.GetCurrentDirectory());
            ofd.Title = "Please select an cover file.";
            DialogResult result = ofd.ShowDialog();
            if (result == DialogResult.OK) // Test result.
            {
                pbArtwork.Image = Resources.loading;

                bgGenCover = new BackgroundWorker();
                bgGenCover.RunWorkerCompleted += BgGenCover_RunWorkerCompleted;
                bgGenCover.DoWork += BgGenCover_DoWork;

                coverLocation = ofd.FileName;
                bgGenCover.RunWorkerAsync();
            }
        }

        private void BgGenCover_DoWork(object sender, DoWorkEventArgs e)
        {
            albumCover = new Cover(coverLocation);
        }

        private void BgGenCover_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            pbArtwork.Image = albumCover.folder.Image;
            
        }

        private void backgroundWorker_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            progressBar.Value = e.ProgressPercentage;
        }

        private void backgroundWorker_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            unlockControls();
            Process.Start(tbOutputFolder.Text + @"\" + tbAlbumId.Text);
        }

        private void backgroundWorker_DoWork(object sender, DoWorkEventArgs e)
        {
            Lib.Execute();
        }

        public void lockControls()
        {
            foreach (Control ctrl in lockableControls)
                ctrl.Enabled = false;
        }

        public void unlockControls()
        {
            foreach (Control ctrl in lockableControls)
                ctrl.Enabled = true;
        }

        public void operationDone()
        {
            nbOperationsDone++;
            percentage = (nbOperationsDone + 1) * 100 / (nbOperationsTotal + 1);
            backgroundWorker.ReportProgress(percentage);
        }
    }
}
