using System;
using System.Collections.Generic;
using System.Text;

namespace agricola
{
    public class SheepBoarCattle : Action
    {
        public SheepBoarCattle( GameComplexityLevel complexity )
            : base()
        {
            this.Stage = ActionStages.StartingCard;
            this.NumPlayersForAction = NumPlayersForAction.FivePlayer;
            this.Complexity = complexity;

            this.Resources.Add( AllResources.Sheep, 1 );
            this.Resources.Add( AllResources.WildBoar, 1 );
            this.Resources.Add( AllResources.Cattle, 1 );
            this.Resources.Add( AllResources.Food, 1 );
        }

        public override void TakeAction( Player player, out object data )
        {
            throw new NotImplementedException();
        }
    }
}
