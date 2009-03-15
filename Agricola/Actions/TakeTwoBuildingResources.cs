﻿using System;
using System.Collections.Generic;
using System.Text;

namespace agricola
{
    public class TakeTwoBuildingResources : Action
    {
        public TakeTwoBuildingResources( NumPlayersForAction numPlayers )
        {
            this.Stage = ActionStages.StartingCard;
            this.NumPlayersForAction = numPlayers;
            this.Complexity = GameComplexityLevel.Family;
        }
    
        public override void TakeAction( Player player, out object data )
        {
            throw new NotImplementedException();
        }
    }
}
