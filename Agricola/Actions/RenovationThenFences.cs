using System;
using System.Collections.Generic;
using System.Text;

namespace agricola
{
    public class RenovationThenFences : Action
    {
        public RenovationThenFences()
            : base()
        {
            this.Stage = ActionStages.Stage6;
        }

        public override void TakeAction( Player player, out object data )
        {
            throw new NotImplementedException();
        }

        #region ICostsResources Members

        public Dictionary<AllResources, int> Cost
        {
            get
            {
                throw new NotImplementedException();
            }
            set
            {
                throw new NotImplementedException();
            }
        }

        #endregion
    }
}
