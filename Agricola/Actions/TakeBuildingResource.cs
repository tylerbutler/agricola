using System;
using System.Collections.Generic;
using System.Text;

namespace agricola
{
    public class TakeBuildingResource : Action
    {
        public TakeBuildingResource( GameComplexityLevel complexity )
        {
            this.Stage = ActionStages.StartingCard;
            this.NumPlayersForAction = NumPlayersForAction.ThreePlayer;
            this.Complexity = complexity;
        }

        public override void TakeAction( Player player, out object data )
        {
            throw new NotImplementedException();
        }
    }
}
