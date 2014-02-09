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
            currentSellers.Add(new Seller(1, "Colin Gagich"));
            targetSeller = currentSellers[0];
        }
        private List<Seller> currentSellers = new List<Seller>();
        private Seller targetSeller;

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
    }
}
