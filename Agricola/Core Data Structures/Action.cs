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
                return (NumPlayersForAction)this.gameVersion;
            }
            set
            {
                this.gameVersion = (int)value;
            }
        }

        private int gameVersion;
        private int number;

        public int Number
        {
            get
            {
                return this.number;
            }
            set
            {
                this.number = value;
            }
        }

        public Action()
        {
            // No defaults; subclasses should set the properties appropriately
            Name = GetType().ToString();
        }

        public GameComplexityLevel Complexity
        {
            get
            {
                throw new System.NotImplementedException();
            }
            set
            {
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
    }

    /// <summary>
    /// This delegate is used for Actions that change based on the version of the game that is being played.
    /// </summary>
    public delegate void ActionDelegate( Player player, out object data );

}
