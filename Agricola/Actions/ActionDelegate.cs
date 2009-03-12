using System;
using System.Collections.Generic;
using System.Text;

namespace agricola
{
    /// <summary>
    /// This delegate is used for Actions that change based on the version of the game that is being played.
    /// </summary>
    public delegate void ActionDelegate( Player player, out object data );
}
