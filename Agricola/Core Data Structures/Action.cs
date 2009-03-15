using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Bitworthy.Utilities;

namespace agricola
{
    public abstract class Action
    {
        private SerializableDictionary<AllResources, int> resources = new SerializableDictionary<AllResources,int>();

        public SerializableDictionary<AllResources, int> Resources
        {
            get
            {
                return resources;
            }
            set
            {
                this.resources = value;
            }
        }

        private ActionStages actionStage;
        public ActionStages Stage
        {
            get
            {
                return this.actionStage;
            }
            set
            {
                this.actionStage = value;
            }
        }

        /// <summary>
        /// What happens when a player chooses this Action.
        /// </summary>
        /// <param name="player">The player who took the Action.</param>
        /// <param name="data">An optional parameter that Actions can use to pass back data to the caller. Not all Actions will use this data.</param>
        public abstract void TakeAction( Player player, out object data );

        public NumPlayersForAction NumPlayersForAction
        {
            get
            {
                return (NumPlayersForAction)this.numPlayersForAction;
            }
            set
            {
                this.numPlayersForAction = (int)value;
            }
        }

        private int numPlayersForAction;

        public Action()
        {
            this.Complexity = GameComplexityLevel.All;
            this.NumPlayersForAction = NumPlayersForAction.All;
            Name = GetType().ToString();
        }

        private GameComplexityLevel complexity;
        public GameComplexityLevel Complexity
        {
            get
            {
                return this.complexity;
            }
            set
            {
                this.complexity = value;
            }
        }

        private string name;
        public string Name
        {
            get
            {
                return name;
            }
            private set
            {
                name = value;
            }
        }

        private Player isUsedBy;
        public Player IsUsedBy
        {
            get
            {
                return isUsedBy;
            }
            set
            {
                isUsedBy = value;
            }
        }
    }

    /// <summary>
    /// This delegate is used for Actions that change based on the version of the game that is being played.
    /// </summary>
    public delegate void ActionDelegate( Player player, out object data );

}
