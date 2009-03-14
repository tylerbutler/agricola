using System;
using System.Collections.Generic;
using System.Text;

namespace agricola
{
    [FlagsAttribute]
    public enum GameComplexityLevel
    {
        Family = 1 << 0,
        Regular = 1 << 1,
        All = ( 1 << 2 ) - 1,
    }
}
