using System;
using System.Collections.Generic;
using System.Text;

namespace agricola
{
    public class TakeTwoBuildingResourcesOrFamilyGrowth : Action
    {
        public TakeTwoBuildingResourcesOrFamilyGrowth()
        {
            this.Stage = ActionStages.StartingCard;
            this.NumPlayersForAction = NumPlayersForAction.FivePlayer;
            this.Complexity = GameComplexityLevel.Family;
        }

        public override void TakeAction( Player player, out object data )
        {
            throw new NotImplementedException();
        }
    }
}
