using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BullDogs50_50
{
    class OneForTwoBundle : Bundle
    {
        public const int setValue = 2;
        public const int ticketsPerSet = 1;
        public const int setsPerBundle = 24;

        public OneForTwoBundle()
        {
            this.bundleValue = 48;
            this.CreationTime = DateTime.Now;
        }

    }
}
