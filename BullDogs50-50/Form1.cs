using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;

namespace BullDogs50_50
{
    public partial class mainEntryForm : Form
    {
        public mainEntryForm()
        {
            InitializeComponent();
            addSeller(new Seller(1, "Colin Gagich"));
            targetSeller = currentSellers[0];
            targetSeller.addThreeForFiveBundle();
            targetSeller.addThreeForFiveBundle();
            updateList();
            updateTotal();
        }
        private List<Seller> currentSellers = new List<Seller>();
        private Seller targetSeller;

        public void addSeller(Seller toAdd)
        {
            this.currentSellers.Add(toAdd);
            updateList();
        }

        public List<Seller> getSellers()
        {
            return this.currentSellers;
        }

        private void mainEntryForm_KeyDown(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.B:
                    targetSeller.addThreeForFiveBundle();
                    e.SuppressKeyPress = true;
                    Debug.WriteLine("B was pressed");
                    break;
                case Keys.S:
                    e.SuppressKeyPress = true;
                    Debug.WriteLine("S was pressed");
                    break;
            }

            updateTotal();
        }

        private void updateTotal()
        {
            totalCashMoney.Text = String.Format("{0:C2}", (FiftyFiftyHelper.currentPotTotal(currentSellers) / 2.0));
        }

        private void updateList()
        {
            listViewSeller.Items.Clear();
            currentSellers = currentSellers.OrderByDescending(x => x.valueSold()).ToList();
            currentSellers.ForEach(x => listViewSeller.Items.Add(new ListViewItem(x.ToListViewItem())));
        }

        private void buttonAddSeller_Click(object sender, EventArgs e)
        {
            addNewSeller newForm = new addNewSeller(this);
            newForm.Show();
        }
    }
}
