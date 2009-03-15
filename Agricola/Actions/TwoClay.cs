using System;
using System.Collections.Generic;
using System.Text;

namespace agricola
{
    public class TwoClay : Action, IRefillable
    {
        public TwoClay( GameComplexityLevel complexity )
        {
            this.Stage = ActionStages.StartingCard;
            this.NumPlayersForAction = NumPlayersForAction.FourPlayer;
            this.Complexity = complexity;

            this.Resources.Add( AllResources.Clay, 0 );
        }
    
        public override void TakeAction( Player player, out object data )
        {
            player.Resources[AllResources.Clay] += this.Resources[AllResources.Clay];
            this.Resources[AllResources.Clay] = 0;
            data = null;
        }

        #region IRefillable Members

        public void Refill()
        {
            this.Resources[AllResources.Clay] += 2;
        }

        #endregion
    }
}
