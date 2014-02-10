using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BullDogs50_50
{
    class ThreeForFiveBundle : Bundle
    {
        public const int setValue = 5;
        public const int ticketsPerSet = 3;
        public const int setsPerBundle = 8;

        public ThreeForFiveBundle()
        {
            this.CreationTime = DateTime.Now;
            this.bundleValue = 40;
        }
    }
}
