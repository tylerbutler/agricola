using System;
using System.Collections.Generic;
using System.Text;

namespace agricola
{
    public abstract class Activity
    {
        /// <summary>
        /// The action that should be taken when the Activity is selected by a player.
        /// </summary>
        public ActivityAction ActivityAction
        {
            get
            {
                throw new System.NotImplementedException();
            }
            set
            {
            }
        }

        public int Name
        {
            get
            {
                throw new System.NotImplementedException();
            }
            set
            {
            }
        }

        public int Description
        {
            get
            {
                throw new System.NotImplementedException();
            }
            set
            {
            }
        }
    }
}
