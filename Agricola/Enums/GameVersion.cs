using System;
using System.Collections.Generic;
using System.Text;

namespace agricola
{
    [FlagsAttribute]
    public enum GameVersion
    {
        None = 0, // Do not use
        Regular = 1 << 0,
        Family = 1 << 1,
        TwoPlayer = 1 << 2,
        ThreePlayer = 1 << 3,
        FourPlayer = 1 << 4,
        FivePlayer = 1 << 5,
        All = ( 1 << 6 ) - 1,
    }

    /// <summary>
    /// This extension method checks if a given GameVersion Enum flag is set in an enum value.
    /// </summary>
    public static class GameVersionEnumHelper
    {
        public static bool IsAvailableInGameVersion( this GameVersion item, GameVersion query )
        {
            return ( ( item & query ) == query );
        }

        public static GameVersion AllButRegular( this GameVersion item )
        {
            return (GameVersion)( (int)GameVersion.All - (int)GameVersion.Regular );
        }

        public static GameVersion AllButFamily( this GameVersion item )
        {
            return (GameVersion)( (int)GameVersion.All - (int)GameVersion.Family );
        }
    }
}
