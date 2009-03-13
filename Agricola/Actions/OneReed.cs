using System;
using System.Collections.Generic;
using System.Text;

namespace agricola
{
    public class OneReed : Action, IRefillable
    {
        public OneReed()
            : base()
        {
            this.Stage = ActionStages.OnBoard;
            this.Number = 9;

            this.Resources.Add( AllResources.Reed, 0 );
        }

        public override void TakeAction( Player player, out object data )
        {
            player.Resources[AllResources.Reed] += this.Resources[AllResources.Reed];
            this.Resources[AllResources.Reed] = 0;
            data = null;
        }

        #region IRefillable Members

        public void Refill()
        {
            this.Resources[AllResources.Reed]++;
        }

        #endregion
    }
}
