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

        public Bundle(int setValue, int ticketsPerBundle)
        {
            this.ticketsPerSet = 1;
            this.setValue = setValue;
            this.setsPerBundle = ticketsPerSet;
            this.bundleValue = ticketsPerBundle * this.setValue;
        }

        public Bundle(int ticketsPerSet, int setValue, int setsPerBundle)
        {
            this.ticketsPerSet = ticketsPerSet;
            this.setValue = setValue;
            this.setsPerBundle = setsPerBundle;
            this.bundleValue = this.setsPerBundle * this.setValue;
        }

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
