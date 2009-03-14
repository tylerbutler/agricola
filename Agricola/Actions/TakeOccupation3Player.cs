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
            this.Stage = ActionStages.StartingCard;
            this.NumPlayersForAction = NumPlayersForAction.ThreePlayer;
            this.Cost.Add( AllResources.Food, 2 );
        }

        public override void TakeAction( Player player, out object data )
        {
            throw new NotImplementedException();
        }

        public Dictionary<AllResources, int> Cost = new Dictionary<AllResources,int>();
    }
}
