namespace BullDogs50_50
{
    partial class mainEntryForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.totalCashMoney = new System.Windows.Forms.Label();
            this.listViewSeller = new System.Windows.Forms.ListView();
            this.sellerName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.pouchNumber = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.soldValue = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.buttonAddSeller = new System.Windows.Forms.Button();
            this.buttonRemoveSeller = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // totalCashMoney
            // 
            this.totalCashMoney.AutoSize = true;
            this.totalCashMoney.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.totalCashMoney.Location = new System.Drawing.Point(124, 9);
            this.totalCashMoney.Name = "totalCashMoney";
            this.totalCashMoney.Size = new System.Drawing.Size(98, 37);
            this.totalCashMoney.TabIndex = 0;
            this.totalCashMoney.Text = "$0.00";
            // 
            // listViewSeller
            // 
            this.listViewSeller.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.sellerName,
            this.pouchNumber,
            this.soldValue});
            this.listViewSeller.Location = new System.Drawing.Point(261, 223);
            this.listViewSeller.Name = "listViewSeller";
            this.listViewSeller.Size = new System.Drawing.Size(427, 257);
            this.listViewSeller.TabIndex = 1;
            this.listViewSeller.UseCompatibleStateImageBehavior = false;
            this.listViewSeller.View = System.Windows.Forms.View.Details;
            this.listViewSeller.MouseClick += new System.Windows.Forms.MouseEventHandler(this.listViewSeller_MouseClick);
            // 
            // sellerName
            // 
            this.sellerName.Text = "Seller Name";
            this.sellerName.Width = 121;
            // 
            // pouchNumber
            // 
            this.pouchNumber.Text = "Pouch";
            // 
            // soldValue
            // 
            this.soldValue.Text = "Sold Value";
            this.soldValue.Width = 83;
            // 
            // buttonAddSeller
            // 
            this.buttonAddSeller.Location = new System.Drawing.Point(261, 194);
            this.buttonAddSeller.Name = "buttonAddSeller";
            this.buttonAddSeller.Size = new System.Drawing.Size(75, 23);
            this.buttonAddSeller.TabIndex = 2;
            this.buttonAddSeller.Text = "Add Seller";
            this.buttonAddSeller.UseVisualStyleBackColor = true;
            this.buttonAddSeller.Click += new System.EventHandler(this.buttonAddSeller_Click);
            // 
            // buttonRemoveSeller
            // 
            this.buttonRemoveSeller.Location = new System.Drawing.Point(342, 194);
            this.buttonRemoveSeller.Name = "buttonRemoveSeller";
            this.buttonRemoveSeller.Size = new System.Drawing.Size(95, 23);
            this.buttonRemoveSeller.TabIndex = 3;
            this.buttonRemoveSeller.Text = "Delete Seller(s)";
            this.buttonRemoveSeller.UseVisualStyleBackColor = true;
            this.buttonRemoveSeller.Click += new System.EventHandler(this.buttonRemoveSeller_Click);
            // 
            // mainEntryForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(700, 492);
            this.Controls.Add(this.buttonRemoveSeller);
            this.Controls.Add(this.buttonAddSeller);
            this.Controls.Add(this.listViewSeller);
            this.Controls.Add(this.totalCashMoney);
            this.KeyPreview = true;
            this.Name = "mainEntryForm";
            this.Text = "Hamilton Bulldogs 50/50 Draw";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.mainEntryForm_KeyDown);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label totalCashMoney;
        private System.Windows.Forms.ListView listViewSeller;
        private System.Windows.Forms.ColumnHeader sellerName;
        private System.Windows.Forms.ColumnHeader soldValue;
        private System.Windows.Forms.ColumnHeader pouchNumber;
        private System.Windows.Forms.Button buttonAddSeller;
        private System.Windows.Forms.Button buttonRemoveSeller;
    }
}

