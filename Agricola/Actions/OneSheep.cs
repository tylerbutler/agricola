using System;
using System.Collections.Generic;
using System.Text;

namespace agricola
{
    public class OneSheep : Action, IRefillable
    {
        public OneSheep()
            : base()
        {
            this.Stage = ActionStages.Stage1;
            this.Resources.Add( AllResources.Sheep, 0 );
        }

        public override void TakeAction( Player player, out object data )
        {
            player.Resources[AllResources.Sheep] += this.Resources[AllResources.Sheep];
            this.Resources[AllResources.Sheep] = 0;
            data = null;
        }

        #region IRefillable Members

        public void Refill()
        {
            this.Resources[AllResources.Sheep]++;
        }

        #endregion
    }
}
