using System;
using System.Collections.Generic;
using System.Text;

namespace agricola
{
    public class FamilyGrowthMinorImprovement : Action
    {
        public FamilyGrowthMinorImprovement()
            : base()
        {
            this.Stage = ActionStages.Stage2;
        }

        public override void TakeAction( Player player, out object data )
        {
            throw new NotImplementedException();
        }
    }
}
