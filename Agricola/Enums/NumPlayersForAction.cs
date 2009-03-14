using System;
using System.Collections.Generic;
using System.Text;

namespace agricola
{
    [FlagsAttribute]
    public enum GameVersion
    {
        None = 0, // Do not use
        TwoPlayer = 1 << 1,
        ThreePlayer = 1 << 2,
        FourPlayer = 1 << 3,
        FivePlayer = 1 << 4,
        All = ( 1 << 5 ) - 1,
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

        //public static GameVersion AllButRegular( this GameVersion item )
        //{
        //    return (GameVersion)( (int)GameVersion.All - (int)GameVersion.Regular );
        //}

        //public static GameVersion AllButFamily( this GameVersion item )
        //{
        //    return (GameVersion)( (int)GameVersion.All - (int)GameVersion.Family );
        //}
    }
}
