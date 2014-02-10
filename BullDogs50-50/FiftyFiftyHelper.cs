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

        public static string[] getAvailablePouchNumbers(List<Seller> theSellers)
        {
            List<int> possiblePouches = Enumerable.Range(1, 50).ToList();
            theSellers.ForEach(x => possiblePouches.Remove(x.getPouchNumber()));
            return possiblePouches.ConvertAll<string>(delegate(int i) {return i.ToString();}).ToArray();
        }
    }
}
