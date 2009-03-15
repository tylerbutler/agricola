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
            this.NumPlayersForAction = NumPlayersForAction.All;
            this.Complexity = GameComplexityLevel.Family;
        }

        public override void TakeAction( Player player, out object data )
        {
            throw new NotImplementedException();
        }
    }
}
