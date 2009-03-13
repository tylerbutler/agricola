using System;
using System.Collections.Generic;
using System.Text;

namespace agricola
{
    public class StartingPlayer : Action
    {
        private ActionDelegate ActionDelegate;

        public StartingPlayer()
            : base()
        {
            this.Stage = ActionStages.OnBoard;
            this.Number = 2;

            if( Properties.Settings.Default.GameVersion == Properties.Resources.FamilyGameVersionString )
            {
                this.ActionDelegate = new ActionDelegate( this.TakeActionFamily );
            }
            else if( Properties.Settings.Default.GameVersion == Properties.Resources.RegularGameVersionString )
            {
                this.ActionDelegate = new ActionDelegate( this.TakeActionRegular );
            }
        }
    
        public override void TakeAction( Player player, out object data )
        {
            this.ActionDelegate( player, out data );
        }

        private void TakeActionFamily( Player player, out object data )
        {
            throw new NotImplementedException();
        }

        private void TakeActionRegular( Player player, out object data )
        {
            throw new NotImplementedException();
        }
    }
}
