using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Ionic.Zip;

namespace RedscientistMusicPackager
{
    static class Lib
    {
        public static MainForm mf = null;

        public static string paddingFromQuantityAndNumber(int quantity, int number)
        {
            int length;

            // MINIMUM 2 CHAR
            if (quantity < 10)
                length = 2;
            else if (quantity < 100)
                length = 2;
            else if (quantity < 1000)
                length = 3;
            else if (quantity < 10000)
                length = 4;
            else if (quantity < 100000)
                length = 5;
            else if (quantity < 1000000)
                length = 7;
            else if (quantity < 10000000)
                length = 8;
            else if (quantity < 100000000)
                length = 9;
            else
                length = 10;

            return (number).ToString().PadLeft(length, '0');

        }

        public static void DeleteDirectory(string target_dir)
        {
            string[] files = Directory.GetFiles(target_dir);
            string[] dirs = Directory.GetDirectories(target_dir);

            foreach (string file in files)
            {
                File.SetAttributes(file, FileAttributes.Normal);
                File.Delete(file);
            }

            foreach (string dir in dirs)
            {
                DeleteDirectory(dir);
            }

            Directory.Delete(target_dir, false);
        }

        public static void Execute()
        {
            string targetDir = mf.tbOutputFolder.Text + @"\" + mf.tbAlbumId.Text;

            if (Directory.Exists(targetDir))
                DeleteDirectory(targetDir);

            Directory.CreateDirectory(targetDir);
            Lib.mf.operationDone();

            mf.albumCover.Output(targetDir);

            foreach (Track trk in mf.trackList)
            {
                string fileDest = targetDir + @"\" + trk.ToString() + ".mp3";
                File.Copy(trk.File, fileDest);
                Lib.mf.operationDone();

                TagLib.File tagFile = TagLib.File.Create(fileDest); // track is the name of the mp3

                tagFile.Tag.AlbumArtists = new string[] { mf.tbArtistName.Text };
                tagFile.Tag.Album = mf.tbAlbumName.Text;
                tagFile.Tag.Track = Convert.ToUInt32(trk.TrackNumber);
                tagFile.Tag.Title = trk.Name;
                tagFile.Tag.Year = Convert.ToUInt32(mf.nmAlbumYear.Value);
                tagFile.Tag.Publisher = "RS Media { http://www.redscientist.com }";

                tagFile.Save();
                Lib.mf.operationDone();
            }

            using (ZipFile zip = new ZipFile())
            {
                foreach (Track trk in mf.trackList)
                {
                    string fileSrc = targetDir + @"\" + trk.ToString() + ".mp3";
                    zip.AddFile(fileSrc, "");
                }


                zip.AddFile(targetDir + @"\" + "cover.png", "");
                zip.AddFile(targetDir + @"\" + "folder.jpg", "");


                zip.Save(targetDir + @"\" + mf.tbAlbumId.Text + ".zip");
                Lib.mf.operationDone();
            }


            foreach (Track trk in mf.trackList)
            {
                string fileSrc = targetDir + @"\" + trk.ToString() + ".mp3";
                string fileDest = targetDir + @"\" + trk.TrackNumberNormalized + ".mp3";
                File.Move(fileSrc, fileDest);
                Lib.mf.operationDone();
            }

            string trackListXml = "";
            trackListXml += "<?xml version = \"1.0\" encoding = \"UTF-8\" ?>" + "\n";
            trackListXml += "<playlist version = \"1\" xmlns = \"http://xspf.org/ns/0/\">" + "\n";
            trackListXml += "    <trackList>" + "\n";

            foreach (Track trk in mf.trackList)
            {
                trackListXml += "        <track>" + "\n";
                trackListXml += "            <location>music/" + mf.tbAlbumId.Text + "/" + trk.TrackNumberNormalized + ".mp3</location>" + "\n";
                trackListXml += "" + "\n";
                trackListXml += "            <!-- artist or band name -->" + "\n";
                trackListXml += "            <creator>" + mf.tbArtistName.Text + "</creator>" + "\n";
                trackListXml += "" + "\n";
                trackListXml += "            <!-- album title -->" + "\n";
                trackListXml += "            <album>" + mf.tbAlbumName.Text + "</album>" + "\n";
                trackListXml += "" + "\n";
                trackListXml += "            <!-- name of the song -->" + "\n";
                trackListXml += "            <title>" + trk.Name + "</title>" + "\n";
                trackListXml += "" + "\n";
                trackListXml += "            <!-- comment on the song -->" + "\n";
                trackListXml += "            <annotation> </annotation>" + "\n";
                trackListXml += "" + "\n";
                trackListXml += "            <!-- song length, in milliseconds -->" + "\n";
                trackListXml += "            <duration>0</duration>" + "\n";
                trackListXml += "" + "\n";
                trackListXml += "            <!-- album art -->" + "\n";
                trackListXml += "            <image>music/" + mf.tbAlbumId.Text + "/folder.jpg</image>" + "\n";
                trackListXml += "" + "\n";
                trackListXml += "            <!-- if this is a deep link, URL of the original web page -->" + "\n";
                trackListXml += "            <info>http://www.redscientist.com/</info>" + "\n";
                trackListXml += "" + "\n";
                trackListXml += "        </track>" + "\n";
            }

            trackListXml += "    </trackList>" + "\n";
            trackListXml += "</playlist>";

            File.WriteAllText(targetDir + @"\" + "playlist.xml", trackListXml);
            Lib.mf.operationDone();
        }

    }
}
