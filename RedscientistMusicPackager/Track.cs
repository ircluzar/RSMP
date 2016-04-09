using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RedscientistMusicPackager
{
    public class Track
    {
        public int TrackNumber = 0;
        public string Name = "";
        public string File = "";

        public string TrackNumberNormalized
        {
            get
            {
                return Lib.paddingFromQuantityAndNumber(Lib.mf.lbAlbumTracks.Items.Count, TrackNumber);
            }
        }

        public override string ToString()
        {
            return TrackNumberNormalized + ". " + Name;
        }
    }
}
