using System;
using System.Collections.Generic;
using System.Text;

namespace agricola
{
    public class TakeOccupation4Player : Action
    {
        public TakeOccupation4Player()
            : base()
        {
            this.Stage = ActionStages.StartingCard;
            this.NumPlayersForAction = NumPlayersForAction.FourPlayer;
            this.Complexity = GameComplexityLevel.Regular;

            this.Cost.Add( AllResources.Food, 1 );
        }

        public override void TakeAction( Player player, out object data )
        {
            throw new NotImplementedException();
        }

        public Dictionary<AllResources, int> Cost = new Dictionary<AllResources,int>();
    }
}
