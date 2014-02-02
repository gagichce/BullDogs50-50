using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BullDogs50_50
{
    class Bundle : BundleInterface
    {
        private int bundleValue;
        private int setValue;
        private int ticketsPerSet;
        private int setsPerBundle;

        public int getSetsPerBundle()
        {
            return setsPerBundle;
        }

        public int getSetValue()
        {
            return setValue;
        }

        public int getBundleValue()
        {
            return bundleValue;
        }

        public int getTicketsPerSet()
        {
            return ticketsPerSet;
        }
    }
}
