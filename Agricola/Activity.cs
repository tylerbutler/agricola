using System;
using System.Collections.Generic;
using System.Text;

namespace agricola
{
    public interface Activity
    {
        string Name
        {
            get;
            set;
        }

        string Description
        {
            get;
            set;
        }
        /// <summary>
        /// The action that should be taken when the Activity is selected by a player.
        /// </summary>
        void ActivityAction();
    }
}
