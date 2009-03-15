using System;
using System.Collections.Generic;
using System.Text;

namespace agricola
{
    public class PlowFieldAndSow : Action
    {
        public PlowFieldAndSow()
            : base()
        {
            this.Stage = ActionStages.Stage5;
        }
    
        public override void TakeAction( Player player, out object data )
        {
            throw new NotImplementedException();
        }
    }
}
