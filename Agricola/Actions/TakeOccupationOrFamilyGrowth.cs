using System;
using System.Collections.Generic;
using System.Text;

namespace agricola
{
    public class TakeOccupationOrFamilyGrowth : Action
    {
        public TakeOccupationOrFamilyGrowth()
            : base()
        {
            this.Stage = ActionStages.StartingCard;
            this.NumPlayersForAction = NumPlayersForAction.FivePlayer;
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
