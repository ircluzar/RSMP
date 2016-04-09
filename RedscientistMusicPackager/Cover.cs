using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ImageProcessor;
using System.IO;
using ImageProcessor.Imaging.Formats;

namespace RedscientistMusicPackager
{
    public class Cover
    {
        string location;
        int quality = 70;
        public ImageFactory cover = new ImageFactory(false);
        public ImageFactory front = new ImageFactory(false);
        public ImageFactory frontweb = new ImageFactory(false);
        public ImageFactory folder = new ImageFactory(false);

        public Cover(string _location)
        {
            location = _location;

            genFolder();
        }

        public void genRemaining()
        {
            genCover();
            Lib.mf.operationDone();
            genFront();
            Lib.mf.operationDone();
            genFrontweb();
            Lib.mf.operationDone();
        }

        private void genCover()
        {
            byte[] coverBytes = File.ReadAllBytes(location);
            ISupportedImageFormat format = new PngFormat();

            using (MemoryStream inStream = new MemoryStream(coverBytes))
            {
                cover.Load(inStream);
                cover.Format(format);
            }
        }

        private void genFront()
        {
            byte[] coverBytes = File.ReadAllBytes(location);
            ISupportedImageFormat format = new JpegFormat();

            using (MemoryStream inStream = new MemoryStream(coverBytes))
            {
                front.Load(inStream);

                if(front.Image.Size.Height != front.Image.Size.Width)
                    if (front.Image.Size.Height > front.Image.Size.Width)
                        front.Crop(new Rectangle(0 , (front.Image.Size.Height - front.Image.Size.Width)/2 , front.Image.Size.Width , front.Image.Size.Width));
                    else
                        front.Crop(new Rectangle((front.Image.Size.Width - front.Image.Size.Height)/2 , 0 , front.Image.Size.Height , front.Image.Size.Height));

                front.Resize(new Size(1000, 1000));
                front.Format(format);
                front.Quality(quality);
            }
        }

        internal void Output(string targetDir)
        {
            genRemaining();

            cover.Save(targetDir + @"\" + "cover.png");
            Lib.mf.operationDone();
            front.Save(targetDir + @"\" + "front.jpg");
            Lib.mf.operationDone();
            frontweb.Save(targetDir + @"\" + "frontweb.jpg");
            Lib.mf.operationDone();
            folder.Save(targetDir + @"\" + "folder.jpg");
            Lib.mf.operationDone();
        }

        private void genFrontweb()
        {
            byte[] coverBytes = File.ReadAllBytes(location);
            ISupportedImageFormat format = new JpegFormat();

            using (MemoryStream inStream = new MemoryStream(coverBytes))
            {
                frontweb.Load(inStream);

                if (frontweb.Image.Size.Height != frontweb.Image.Size.Width)
                    if (frontweb.Image.Size.Height > frontweb.Image.Size.Width)
                        frontweb.Crop(new Rectangle(0, (frontweb.Image.Size.Height - frontweb.Image.Size.Width) / 2, frontweb.Image.Size.Width, frontweb.Image.Size.Width));
                    else
                        frontweb.Crop(new Rectangle((frontweb.Image.Size.Width - frontweb.Image.Size.Height) / 2, 0, frontweb.Image.Size.Height, frontweb.Image.Size.Height));

                frontweb.Resize(new Size(250, 250));
                frontweb.Format(format);
                frontweb.Quality(quality);
            }
        }

        private void genFolder()
        {
            byte[] coverBytes = File.ReadAllBytes(location);
            ISupportedImageFormat format = new JpegFormat();

            using (MemoryStream inStream = new MemoryStream(coverBytes))
            {
                folder.Load(inStream);

                if (folder.Image.Size.Height != folder.Image.Size.Width)
                    if (folder.Image.Size.Height > folder.Image.Size.Width)
                        folder.Crop(new Rectangle(0, (folder.Image.Size.Height - folder.Image.Size.Width) / 2, folder.Image.Size.Width, folder.Image.Size.Width));
                    else
                        folder.Crop(new Rectangle((folder.Image.Size.Width - folder.Image.Size.Height) / 2, 0, folder.Image.Size.Height, folder.Image.Size.Height));

                folder.Resize(new Size(130, 130));
                folder.Format(format);
                folder.Quality(quality);
            }
        }







    }
}
