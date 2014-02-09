using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BullDogs50_50
{
    class Bundle : BundleInterface
    {
        protected DateTime CreationTime;
        protected int bundleValue;

        public DateTime getCreateTime()
        {
            return this.CreationTime;
        }

        public int getBundleValue()
        {
            return bundleValue;
        }
    }
}
