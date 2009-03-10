using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace agricola
{
    public interface IActivity
    {
        void TakeAction( Player player, out object Data );
    }
}
