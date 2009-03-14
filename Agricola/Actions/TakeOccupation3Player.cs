using System;
using System.Collections.Generic;
using System.Text;

namespace agricola
{
    public class TakeOccupation3Player : Action
    {
        public TakeOccupation3Player()
            : base()
        {
            this.Stage = ActionStages.OnBoard;
            this.GameVersion = NumPlayersForAction.ThreePlayer;
            this.Cost.Add( AllResources.Food, 2 );
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
