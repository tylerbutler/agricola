using System;
using System.Collections.Generic;
using System.Text;

namespace agricola
{
    public class BuildStablesBakeBread : Action
    {
        public BuildStablesBakeBread()
            : base()
        {
            this.Stage = ActionStages.OnBoard;
            
            // Action is available in all game versions, but NOT the regular game (only family version)
            this.NumPlayersForAction = NumPlayersForAction.All;
            this.Complexity = GameComplexityLevel.Family;
            this.Number = 5;
        }

        public override void TakeAction( Player player, out object data )
        {
            throw new NotImplementedException();
        }
    }
}
