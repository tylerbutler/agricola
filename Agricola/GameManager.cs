using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace agricola
{
    public class GameManager
    {
        public Dictionary<ActionStages, List<Action>> ActionDeck = new Dictionary<ActionStages, List<Action>>();
        private List<Action> StartingCards = new List<Action>();

        private List<Player> players;
        public List<Player> Players
        {
            get
            {
                return this.players;
            }
            set
            {
                this.players = value;
            }
        }

        public List<Action> GetStartingCards( NumPlayersForAction numPlayers, GameComplexityLevel complexity )
        {
            IEnumerable<Action> r = from c in StartingCards
                                    where ( c.NumPlayersForAction == numPlayers && c.Complexity == complexity )
                                    select c;
            return (List<Action>)r;
        }

        public GameManager()
        {
            // Stage 1 Action Cards
            List<Action> Stage1 = new List<Action>();
            Stage1.Add( new MajorMinorImprovement() );
            Stage1.Add( new SowAndOrBakeBread() );
            Stage1.Add( new OneSheep() );
            Stage1.Add( new Fences() );
            ActionDeck.Add( ActionStages.Stage1, Stage1 );

            // Stage 2 Action Cards
            List<Action> Stage2 = new List<Action>();
            Stage2.Add( new OneStone( ActionStages.Stage2 ) );
            Stage2.Add( new FamilyGrowthMinorImprovement() );
            Stage2.Add( new RenovationMajorMinorImprovement() );
            ActionDeck.Add( ActionStages.Stage2, Stage2 );

            // Stage 3 Action Cards
            List<Action> Stage3 = new List<Action>();
            Stage3.Add( new OneWildBoar() );
            Stage3.Add( new Take1Vegetable() );
            ActionDeck.Add( ActionStages.Stage3, Stage3 );

            // Stage 4 Action Cards
            List<Action> Stage4 = new List<Action>();
            Stage4.Add( new OneStone( ActionStages.Stage4 ) );
            Stage4.Add( new OneCattle() );
            ActionDeck.Add( ActionStages.Stage4, Stage4 );

            // Stage 5 Action Cards
            List<Action> Stage5 = new List<Action>();
            Stage5.Add( new FamilyGrowthWithoutSpace() );
            Stage5.Add( new PlowFieldAndSow() );
            ActionDeck.Add( ActionStages.Stage5, Stage5 );

            // Stage 6 Action Card
            List<Action> Stage6 = new List<Action>();
            Stage6.Add( new RenovationThenFences() );
            ActionDeck.Add( ActionStages.Stage6, Stage6 );

            // Three Player Action Cards
            StartingCards.Add( new TwoWood( GameComplexityLevel.Family, NumPlayersForAction.ThreePlayer ) );
            StartingCards.Add( new TwoWood( GameComplexityLevel.Regular, NumPlayersForAction.ThreePlayer ) );
            StartingCards.Add( new TakeBuildingResource( GameComplexityLevel.Family ) );
            StartingCards.Add( new TakeBuildingResource( GameComplexityLevel.Regular ) );
            StartingCards.Add( new TakeTwoBuildingResources( NumPlayersForAction.ThreePlayer ) );
            StartingCards.Add( new TakeOccupation3Player() );
            StartingCards.Add( new OneClay( ActionStages.StartingCard, GameComplexityLevel.Family, NumPlayersForAction.ThreePlayer ) );
            StartingCards.Add( new OneClay( ActionStages.StartingCard, GameComplexityLevel.Regular, NumPlayersForAction.ThreePlayer ) );

            // Four Player Action Cards
            StartingCards.Add( new TwoClay( GameComplexityLevel.Family ) );
            StartingCards.Add( new TwoClay( GameComplexityLevel.Regular ) );
            StartingCards.Add( new OneWood( GameComplexityLevel.Family ) );
            StartingCards.Add( new OneWood( GameComplexityLevel.Regular ) );
            StartingCards.Add( new TakeOccupation4Player() );
            StartingCards.Add( new TakeTwoBuildingResources( NumPlayersForAction.FourPlayer ) );
            StartingCards.Add( new ReedStoneFood( GameComplexityLevel.Family ) );
            StartingCards.Add( new ReedStoneFood( GameComplexityLevel.Regular ) );
            StartingCards.Add( new TwoWood( GameComplexityLevel.Family, NumPlayersForAction.FourPlayer ) );
            StartingCards.Add( new TwoWood( GameComplexityLevel.Regular, NumPlayersForAction.FourPlayer ) );
            StartingCards.Add( new TravelingPlayers( GameComplexityLevel.Family ) );
            StartingCards.Add( new TravelingPlayers( GameComplexityLevel.Regular ) );

            // Five Player Action Cards
            StartingCards.Add( new BuildOneRoomOrTravelingPlayers( GameComplexityLevel.Family ) );
            StartingCards.Add( new BuildOneRoomOrTravelingPlayers( GameComplexityLevel.Regular ) );
            StartingCards.Add( new ReedStoneWood( GameComplexityLevel.Family ) );
            StartingCards.Add( new ReedStoneWood( GameComplexityLevel.Regular ) );
            StartingCards.Add( new TakeOccupationOrFamilyGrowth() );
            StartingCards.Add( new TakeTwoBuildingResourcesOrFamilyGrowth() );
            StartingCards.Add( new ThreeClay( GameComplexityLevel.Family ) );
            StartingCards.Add( new ThreeClay( GameComplexityLevel.Regular ) );
            StartingCards.Add( new FourWood( GameComplexityLevel.Family ) );
            StartingCards.Add( new FourWood( GameComplexityLevel.Regular ) );
            StartingCards.Add( new SheepBoarCattle( GameComplexityLevel.Family ) );
            StartingCards.Add( new SheepBoarCattle( GameComplexityLevel.Regular ) );


        }
    }
}
