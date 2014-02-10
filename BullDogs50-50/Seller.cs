using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BullDogs50_50
{
    public class Seller
    {
        private int sellerNumber;
        private string sellerName;
        public List<Bundle> soldBundles = new List<Bundle>();

        public Seller(int sellerNumber, string sellerName)
        {
            this.sellerName = sellerName;
            this.sellerNumber = sellerNumber;
        }

        public int getPouchNumber()
        {
            return this.sellerNumber;
        }

        public void addThreeForFiveBundle()
        {
            soldBundles.Add(new ThreeForFiveBundle());
        }

        public void addOneForTwoBundle()
        {
            soldBundles.Add(new OneForTwoBundle());
        }

        public int valueSold()
        {
            return soldBundles.Sum(x => x.getBundleValue());
        }

        public string[] ToListViewItem()
        {
            return new string[]{
                sellerName,
                sellerNumber.ToString("00"),
                valueSold().ToString("C")
            };
        }
    }
}
