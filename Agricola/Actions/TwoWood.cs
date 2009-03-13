using System;
using System.Collections.Generic;
using System.Text;

namespace agricola
{
    public class TwoWood : Action, IRefillable
    {
        public TwoWood()
        {
            this.Stage = ActionStages.OnBoard;
            this.GameVersion = GameVersion.ThreePlayer;

            if( Properties.Settings.Default.GameVersion == Properties.Resources.FamilyGameVersionString )
            {
                this.GameVersion = this.GameVersion | GameVersion.Family;
            }
            else if( Properties.Settings.Default.GameVersion == Properties.Resources.RegularGameVersionString )
            {
                this.GameVersion = this.GameVersion | GameVersion.Regular;
            }

            this.Resources.Add( AllResources.Wood, 0 );
        }
    
        public override void TakeAction( Player player, out object data )
        {
            player.Resources[AllResources.Wood] += this.Resources[AllResources.Wood];
            this.Resources[AllResources.Wood] = 0;
            data = null;
        }

        #region IRefillable Members

        public void Refill()
        {
            this.Resources[AllResources.Wood] += 2;
        }

        #endregion
    }
}
