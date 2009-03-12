using System;
using System.Collections.Generic;
using System.Text;

namespace agricola
{
    public class BuildRoomsorStables : Action
    {
        public BuildRoomsorStables()
        {
            this.ActionStage = ActionStages.OnBoard;
            this.GameVersion = GameVersion.All;
        }

        public override void TakeAction( Player player, out object data )
        {
            throw new NotImplementedException();
        }
    }
}
