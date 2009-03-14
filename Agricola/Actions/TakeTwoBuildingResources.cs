using System;
using System.Collections.Generic;
using System.Text;

namespace agricola
{
    public class TakeTwoBuildingResources : Action
    {
        public TakeTwoBuildingResources()
        {
            this.Stage = ActionStages.OnBoard;
            this.GameVersion = GameVersion.ThreePlayer;
        }
    
        public override void TakeAction( Player player, out object data )
        {
            throw new NotImplementedException();
        }
    }
}
