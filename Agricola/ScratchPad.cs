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

            bool test = b.GameVersion.IsAvailableInGameVersion( GameVersion.Regular );
            test = b.GameVersion.IsAvailableInGameVersion( GameVersion.All );
            test = b.GameVersion.IsAvailableInGameVersion( GameVersion.Family );
            test = b.GameVersion.IsAvailableInGameVersion( GameVersion.FivePlayer );
        }
    }
}
