using System;
using System.Collections.Generic;
using System.Text;

namespace agricola
{
    public class OneClay : Action, IRefillable
    {
        public OneClay()
            : base()
        {
            this.Stage = ActionStages.OnBoard;
            switch( Properties.Settings.Default.NumPlayers )
            {
                case 1:
                case 2:
                    this.GameVersion = GameVersion.All;
                    this.Number = 8;
                    break;
                case 3:
                    this.GameVersion = GameVersion.ThreePlayer;
                    this.Number = 12;
                    break;
                default:
                    break;
            }

            if( Properties.Settings.Default.GameVersion == Properties.Resources.FamilyGameVersionString )
            {
                this.GameComplexityLevel = GameComplexityLevel.Family;
            }
            else if( Properties.Settings.Default.GameVersion == Properties.Resources.RegularGameVersionString )
            {
                this.GameComplexityLevel = GameComplexityLevel.Regular;
            }

            this.Resources.Add( AllResources.Clay, 0 );
        }

        public override void TakeAction( Player player, out object data )
        {
            player.Resources[AllResources.Clay] += this.Resources[AllResources.Clay];
            this.Resources[AllResources.Clay] = 0;
            data = null;
        }

        #region IRefillable Members

        public void Refill()
        {
            this.Resources[AllResources.Clay]++;
        }

        #endregion
    }
}
