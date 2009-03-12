using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace agricola
{
    class ScratchPad
    {
        public static void Main( string[] args )
        {
            BuildStablesBakeBread b = new BuildStablesBakeBread();
            GameVersion v = b.GameVersion;
            bool test = ( b.GameVersion & GameVersion.TwoPlayer ) == GameVersion.TwoPlayer;
            test = ( b.GameVersion & GameVersion.All ) == GameVersion.All;
            test = ( b.GameVersion == (GameVersion)1 );
            int i = (int)b.GameVersion;

            test = b.GameVersion.HasFlag( GameVersion.Regular );
        }
    }
}
