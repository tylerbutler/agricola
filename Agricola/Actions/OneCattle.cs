using System;
using System.Collections.Generic;
using System.Text;

namespace agricola
{
    public class OneCattle : Action, IRefillable
    {
        public OneCattle()
            : base()
        {
            this.Stage = ActionStages.Stage4;
            this.Resources.Add( AllResources.Cattle, 0 );
        }

        public override void TakeAction( Player player, out object data )
        {
            player.Resources[AllResources.Cattle] += this.Resources[AllResources.Cattle];
            this.Resources[AllResources.Cattle] = 0;
            data = null;
        }

        #region IRefillable Members

        public void Refill()
        {
            this.Resources[AllResources.Cattle]++;
        }

        #endregion
    }
}
