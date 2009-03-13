using System;
using System.Collections.Generic;
using System.Text;

namespace agricola
{
    public class PlowField : Action
    {
        public PlowField()
            : base()
        {
            this.Stage = ActionStages.OnBoard;
            this.Number = 4;
        }
    
        public override void TakeAction( Player player, out object data )
        {
            throw new NotImplementedException();
        }
    }
}
