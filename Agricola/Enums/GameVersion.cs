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
        All = (1 << 6) - 1,
    }

    /// <summary>
    /// This extension method checks if a given GameVersion Enum flag is set in an enum value.
    /// </summary>
    public static class GameVersionEnumHelperFoo
    {
        public static bool HasFlag( this GameVersion item, GameVersion query )
        {
            return ( ( item & query ) == query );
        }
    }
}
