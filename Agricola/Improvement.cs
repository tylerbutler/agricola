using System;
using System.Collections.Generic;
using System.Text;

namespace agricola
{
    [Serializable]
    public abstract class Improvement
    {
        public int ClayCost
        {
            get
            {
                throw new System.NotImplementedException();
            }
            set
            {
            }
        }

        public int StoneCost
        {
            get
            {
                throw new System.NotImplementedException();
            }
            set
            {
            }
        }

        public int WoodCost
        {
            get
            {
                throw new System.NotImplementedException();
            }
            set
            {
            }
        }

        public int ReedCost
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
