using System;
using System.Collections.Generic;
using System.Text;

namespace agricola
{
    public class Fishing : Action, IRefillable
    {
        public Fishing()
            : base()
        {
            this.Stage = ActionStages.OnBoard;
            this.Number = 10;

            this.Resources.Add( AllResources.Food, 0 );
        }

        public override void TakeAction( Player player, out object data )
        {
            player.Resources[AllResources.Food] += this.Resources[AllResources.Food];
            this.Resources[AllResources.Food] = 0;
            data = null;
        }

        #region IRefillable Members

        public void Refill()
        {
            this.Resources[AllResources.Food]++;
        }

        #endregion
    }
}
