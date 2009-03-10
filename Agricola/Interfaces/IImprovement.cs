using System;
using System.Collections.Generic;
using System.Text;

namespace agricola
{
    public interface IImprovement
    {
        int ClayCost
        {
            get;
            set;
        }

        int StoneCost
        {
            get;
            set;
        }

        int WoodCost
        {
            get;
            set;
        }

        int ReedCost
        {
            get;
            set;
        }
    }
}
