using System;
using System.Collections.Generic;
using System.Text;

namespace agricola
{
    public class TakeBuildingResource : Action
    {
        public TakeBuildingResource()
        {
            this.Stage = ActionStages.OnBoard;
            this.GameVersion = NumPlayersForAction.ThreePlayer;

            if( Properties.Settings.Default.GameVersion == Properties.Resources.FamilyGameVersionString )
            {
                this.GameComplexityLevel = GameComplexityLevel.Family;
            }
            else if( Properties.Settings.Default.GameVersion == Properties.Resources.RegularGameVersionString )
            {
                this.GameComplexityLevel = GameComplexityLevel.Regular;
            }
        }

        public override void TakeAction( Player player, out object data )
        {
            throw new NotImplementedException();
        }
    }
}
