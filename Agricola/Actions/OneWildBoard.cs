using System;
using System.Collections.Generic;
using System.Text;

namespace agricola
{
    public class OneWildBoar : Action, IRefillable
    {
        public OneWildBoar()
            : base()
        {
            this.Stage = ActionStages.Stage3;
            this.Resources.Add( AllResources.WildBoar, 0 );
        }

        public override void TakeAction( Player player, out object data )
        {
            player.Resources[AllResources.WildBoar] += this.Resources[AllResources.WildBoar];
            this.Resources[AllResources.WildBoar] = 0;
            data = null;
        }

        #region IRefillable Members

        public void Refill()
        {
            this.Resources[AllResources.WildBoar]++;
        }

        #endregion
    }
}
