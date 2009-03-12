using System;
using System.Collections.Generic;
using System.Text;

namespace agricola
{
    public class BuildStablesBakeBread : Action
    {
        public BuildStablesBakeBread()
        {
            this.ActionStage = ActionStages.OnBoard;
            this.GameVersion = ( GameVersion.Family | GameVersion.TwoPlayer | GameVersion.FivePlayer | GameVersion.FourPlayer | GameVersion.Regular | GameVersion.ThreePlayer );
            this.GameVersion = GameVersion.All;
        }

        public override void TakeAction( Player player, out object data )
        {
            throw new NotImplementedException();
        }
    }
}
