using System;
using System.Collections.Generic;
using System.Text;

namespace agricola
{
    public class TakeOccupation : Action
    {
        public TakeOccupation()
            : base()
        {
            this.Stage = ActionStages.OnBoard;
            this.GameVersion = GameVersion.AllButFamily();
            this.Number = 11;
            this.Cost.Add( AllResources.Food, 1 );
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
