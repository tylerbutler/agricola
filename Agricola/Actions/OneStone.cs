using System;
using System.Collections.Generic;
using System.Text;

namespace agricola
{
    public class OneStone : Action, IRefillable
    {
        public OneStone( ActionStages stage )
            : base()
        {
            this.Stage = stage;
            this.Resources.Add( AllResources.Stone, 0 );
        }

        public override void TakeAction( Player player, out object data )
        {
            player.Resources[AllResources.Stone] += this.Resources[AllResources.Stone];
            this.Resources[AllResources.Stone] = 0;
            data = null;
        }

        #region IRefillable Members

        public void Refill()
        {
            this.Resources[AllResources.Stone]++;
        }

        #endregion
    }
}
