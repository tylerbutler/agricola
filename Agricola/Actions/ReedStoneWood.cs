using System;
using System.Collections.Generic;
using System.Text;

namespace agricola
{
    public class ReedStoneWood : Action, IRefillable
    {
        public ReedStoneWood( GameComplexityLevel complexity )
            : base()
        {
            this.Stage = ActionStages.StartingCard;
            this.NumPlayersForAction = NumPlayersForAction.FivePlayer;
            this.Complexity = complexity;

            this.Resources.Add( AllResources.Reed, 1 );
            this.Resources.Add( AllResources.Stone, 1 );
            this.Resources.Add( AllResources.Wood, 1 );
        }

        public override void TakeAction( Player player, out object data )
        {
            player.Resources[AllResources.Reed] += this.Resources[AllResources.Reed];
            player.Resources[AllResources.Stone] += this.Resources[AllResources.Stone];
            player.Resources[AllResources.Wood] += this.Resources[AllResources.Wood];
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
