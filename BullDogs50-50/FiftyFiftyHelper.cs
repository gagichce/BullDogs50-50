using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BullDogs50_50
{
    static class FiftyFiftyHelper
    {
        public static int currentPotTotal(List<Seller> theSellers)
        {
            return theSellers.Sum(x => x.valueSold());
        }
    }
}
