﻿using System;
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
        }

        public override void TakeAction( Player player, out object data )
        {
            throw new NotImplementedException();
        }
    }
}
