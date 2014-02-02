using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BullDogs50_50
{
    class BundleBuilder
    {
        static Bundle buildMeABlueBundle()
        {
            return new Bundle(3, 5, 8);
        }

        static Bundle buildMeAWhiteBundle()
        {
            return new Bundle(2, 24);
        }
    }
}
