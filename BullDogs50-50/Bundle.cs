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

        public DateTime getCreateTime()
        {
            return this.CreationTime;
        }
    }
}
