using System;
using System.Collections.Generic;
using System.Text;

namespace agricola
{
    public class ReedStoneFood : Action
    {
        public ReedStoneFood( GameComplexityLevel complexity )
            : base()
        {
            this.Stage = ActionStages.StartingCard;
            this.NumPlayersForAction = NumPlayersForAction.FourPlayer;
            this.Complexity = complexity;

            this.Resources.Add( AllResources.Reed, 1 );
            this.Resources.Add( AllResources.Stone, 1 );
            this.Resources.Add( AllResources.Food, 1 );
        }

        public override void TakeAction( Player player, out object data )
        {
            player.Resources[AllResources.Reed] += this.Resources[AllResources.Reed];
            player.Resources[AllResources.Stone] += this.Resources[AllResources.Stone];
            player.Resources[AllResources.Food] += this.Resources[AllResources.Food];
            data = null;
        }
    }
}
