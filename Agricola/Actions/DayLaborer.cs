using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace agricola
{
    class DayLaborer : Action
    {
        private ActionDelegate ActionDelegate;

        public DayLaborer()
            : base()
        {
            this.Stage = ActionStages.OnBoard;

            if( Properties.Settings.Default.GameVersion == Properties.Resources.FamilyGameVersionString )
            {
                this.ActionDelegate = new ActionDelegate( this.TakeActionFamily );
            }
            else if( Properties.Settings.Default.GameVersion == Properties.Resources.RegularGameVersionString )
            {
                this.ActionDelegate = new ActionDelegate( this.TakeActionRegular );
            }
        }

        override public void TakeAction( Player p, out object data )
        {
            this.ActionDelegate( p, out data );
        }

        private void TakeActionFamily( Player player, out object data )
        {
            player.Resources[AllResources.Food]++;
            //todo Add logic to allow player to choose a resource
            throw new NotImplementedException();
        }

        private void TakeActionRegular( Player player, out object data )
        {
            player.Resources[AllResources.Food] += 2;
            data = null;
        }
    }
}
