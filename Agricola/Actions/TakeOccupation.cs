using System;
using System.Collections.Generic;
using System.Text;

namespace agricola
{
    public class TakeOccupation : Action
    {
        public Dictionary<AllResources,int> Cost = new Dictionary<AllResources, int>();

        public TakeOccupation()
            : base()
        {
            this.Stage = ActionStages.OnBoard;
            this.NumPlayersForAction = NumPlayersForAction.All;
            this.Complexity = GameComplexityLevel.Regular;
            this.Cost.Add( AllResources.Food, 1 );
        }

        public override void TakeAction( Player player, out object data )
        {
            throw new NotImplementedException();
        }
    }
}
