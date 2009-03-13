using System;
using System.Collections.Generic;
using System.Text;

namespace agricola
{
    public class ThreeWood : Action, IRefillable
    {
        public ThreeWood()
            : base()
        {
            this.Stage = ActionStages.OnBoard;
            this.Number = 7;

            this.Resources.Add( AllResources.Wood, 0 );
        }

        public override void TakeAction( Player player, out object data )
        {
            player.Resources[AllResources.Wood] += this.Resources[AllResources.Wood];
            this.Resources[AllResources.Wood] = 0;
            data = null;
        }

        #region IRefillable Members

        public void Refill()
        {
            this.Resources[AllResources.Wood] += 3;
        }

        #endregion
    }
}
