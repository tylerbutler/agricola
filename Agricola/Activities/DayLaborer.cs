using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace agricola
{
    class DayLaborer : IRefillable, IActivity
    {
        private int food;

        public int Food
        {
            get
            {
                return food;
            }
            set
            {
                food = value;
            }
        }

        #region Refillable Members

        public void Refill()
        {
            this.Food++;
        }

        #endregion

        #region IActivity Members

        public void TakeAction( Player player, out object Data )
        {
            Data = null;
            player.Food += this.Food;
            this.Food = 0;
        }

        #endregion
    }
}
