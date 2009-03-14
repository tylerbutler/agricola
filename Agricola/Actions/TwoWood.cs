using System;
using System.Collections.Generic;
using System.Text;

namespace agricola
{
    public class TwoWood : Action, IRefillable
    {
        public TwoWood( GameComplexityLevel complexity )
        {
            this.Stage = ActionStages.StartingCard;
            this.NumPlayersForAction = NumPlayersForAction.ThreePlayer;
            this.Complexity = complexity;

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
            this.Resources[AllResources.Wood] += 2;
        }

        #endregion
    }
}
