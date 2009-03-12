using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Bitworthy.Utilities;

namespace agricola
{
    public abstract class Action
    {
        private SerializableDictionary<AllResources, int> resources;

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
        public ActionStages ActionStage
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
        
        public abstract void TakeAction( Player player, out object data );

        public GameVersion GameVersion
        {
            get
            {
                return (GameVersion)this.gameVersion;
            }
            set
            {
                this.gameVersion = (int)value;
            }
        }

        private int gameVersion;
    }
}
