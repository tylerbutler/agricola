using System;
using System.Collections.Generic;
using System.Text;

namespace agricola
{
    public class Take1Grain : Action
    {
        public Take1Grain()
        {
            this.ActionStage = ActionStages.OnBoard;
            this.GameVersion = GameVersion.All;
        }
    
        public override void TakeAction( Player player, out object data )
        {
            player.Resources[AllResources.Grain]++;
            data = null;
        }
    }
}
