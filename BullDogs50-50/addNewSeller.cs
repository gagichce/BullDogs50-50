using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BullDogs50_50
{
    public partial class addNewSeller : Form
    {
        mainEntryForm parent;
        public addNewSeller(mainEntryForm parent)
        {
            InitializeComponent();
            this.parent = parent;
            FiftyFiftyHelper.getAvailablePouchNumbers(parent.getSellers()).ToList().ForEach(x => listBoxAvailablePouchNumbers.Items.Add(x));
            listBoxAvailablePouchNumbers.SelectedItem = listBoxAvailablePouchNumbers.Items[0];
            this.ActiveControl = textBoxSellerName;
        }

        private void buttonCancelAddSeller_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Inputted Data will be lost!", "Cancel?", MessageBoxButtons.YesNo) == System.Windows.Forms.DialogResult.Yes)
                this.Close();
        }

        private void buttonAddSeller_Click(object sender, EventArgs e)
        {
            addSeller();
        }

        private void addSeller()
        {
            parent.addSeller(new Seller(int.Parse(listBoxAvailablePouchNumbers.SelectedItem.ToString()), textBoxSellerName.Text));
            this.Close();
        }

        private void addNewSeller_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                addSeller();
                e.Handled = true;
            }
        }
    }
}
