using System;
using System.Collections.Generic;
using System.Text;

namespace agricola
{
    public class BuildOneRoomOrTravelingPlayers : Action, IRefillable
    {
        public BuildOneRoomOrTravelingPlayers( GameComplexityLevel complexity )
            : base()
        {
            this.Stage = ActionStages.StartingCard;
            this.NumPlayersForAction = NumPlayersForAction.FivePlayer;
            this.Complexity = complexity;

            this.Resources.Add( AllResources.Food, 0 );
        }

        public override void TakeAction( Player player, out object data )
        {
            throw new NotImplementedException();
        }

        #region IRefillable Members

        public void Refill()
        {
            this.Resources[AllResources.Food]++;
        }

        #endregion

    }
}
