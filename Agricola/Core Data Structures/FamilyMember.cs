using System;
using System.Collections.Generic;
using System.Text;

namespace agricola
{
    public class FamilyMember
    {
        public bool IsUsed = false;
        public Player Owner;

        public FamilyMember( Player owner )
        {
            this.Owner = owner;
        }
    }
}
