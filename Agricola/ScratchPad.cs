using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace agricola
{
    class ScratchPad
    {
        public static void Main( string[] args )
        {
            List<Action> ActionDeck = new List<Action>();

            // Three Player Action Cards
            ActionDeck.Add( new TwoWood( GameComplexityLevel.Family ) );
            ActionDeck.Add( new TwoWood( GameComplexityLevel.Regular ) );
            ActionDeck.Add( new TakeBuildingResource( GameComplexityLevel.Family ) );
            ActionDeck.Add( new TakeBuildingResource( GameComplexityLevel.Regular ) );
            ActionDeck.Add( new TakeTwoBuildingResources() );
            ActionDeck.Add( new TakeOccupation3Player() );
            ActionDeck.Add( new OneClay( GameComplexityLevel.Family, NumPlayersForAction.ThreePlayer ) );
            ActionDeck.Add( new OneClay( GameComplexityLevel.Regular, NumPlayersForAction.ThreePlayer ) );

            foreach( Action card in ActionDeck )
            {
                Console.WriteLine( card.Name );
            }
        }
    }
}
