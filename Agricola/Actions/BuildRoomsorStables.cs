using System;
using System.Collections.Generic;
using System.Text;

namespace agricola
{
    public class BuildRoomsorStables : Action
    {
        public BuildRoomsorStables()
            : base()
        {
            this.Stage = ActionStages.OnBoard;
            this.Number = 1;
        }

        public override void TakeAction( Player player, out object data )
        {
            throw new NotImplementedException();
        }
    }
}
