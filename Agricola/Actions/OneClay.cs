using System;
using System.Collections.Generic;
using System.Text;

namespace agricola
{
    public class OneClay : Action, IRefillable
    {
        public OneClay( GameComplexityLevel complexity, NumPlayersForAction numPlayers )
            : base()
        {
            this.Stage = ActionStages.OnBoard;
            this.Complexity = complexity;
            this.NumPlayersForAction = numPlayers;

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
            this.Resources[AllResources.Clay]++;
        }

        #endregion
    }
}
