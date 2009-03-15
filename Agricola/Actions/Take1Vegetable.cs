using System;
using System.Collections.Generic;
using System.Text;

namespace agricola
{
    public class Take1Vegetable : Action
    {
        public Take1Vegetable()
            : base()
        {
            this.Stage = ActionStages.Stage3;
        }
    
        public override void TakeAction( Player player, out object data )
        {
            player.Resources[AllResources.Vegetable]++;
            data = null;
        }
    }
}
