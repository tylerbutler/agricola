using System;
using System.Collections.Generic;
using System.Text;

namespace agricola
{
    public class TakeTwoBuildingResources : Action
    {
        public TakeTwoBuildingResources()
        {
            this.Stage = ActionStages.StartingCard;
            this.NumPlayersForAction = NumPlayersForAction.ThreePlayer;
            this.Complexity = GameComplexityLevel.Family;
        }
    
        public override void TakeAction( Player player, out object data )
        {
            throw new NotImplementedException();
        }
    }
}
