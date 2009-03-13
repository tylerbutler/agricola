using System;
using System.Collections.Generic;
using System.Text;

namespace agricola
{
    public class SowAndOrBakeBread : Action
    {
        public SowAndOrBakeBread()
            : base()
        {
            this.Stage = ActionStages.Stage1;
        }

        public override void TakeAction( Player player, out object data )
        {
            throw new NotImplementedException();
        }
    }
}
