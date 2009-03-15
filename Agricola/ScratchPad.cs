using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace agricola
{
    class ScratchPad
    {
        public static void Main( string[] args )
        {
            List<Action> ActionDeck = new List<Action>();


            foreach( Action card in ActionDeck )
            {
                Console.WriteLine( card.Name );
            }
        }
    }
}
