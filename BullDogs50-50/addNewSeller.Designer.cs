namespace BullDogs50_50
{
    partial class addNewSeller
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
            this.buttonAddSeller = new System.Windows.Forms.Button();
            this.buttonCancelAddSeller = new System.Windows.Forms.Button();
            this.textBoxSellerName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.listBoxAvailablePouchNumbers = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // buttonAddSeller
            // 
            this.buttonAddSeller.Location = new System.Drawing.Point(85, 98);
            this.buttonAddSeller.Name = "buttonAddSeller";
            this.buttonAddSeller.Size = new System.Drawing.Size(75, 23);
            this.buttonAddSeller.TabIndex = 0;
            this.buttonAddSeller.Text = "Add";
            this.buttonAddSeller.UseVisualStyleBackColor = true;
            this.buttonAddSeller.Click += new System.EventHandler(this.buttonAddSeller_Click);
            // 
            // buttonCancelAddSeller
            // 
            this.buttonCancelAddSeller.Location = new System.Drawing.Point(166, 98);
            this.buttonCancelAddSeller.Name = "buttonCancelAddSeller";
            this.buttonCancelAddSeller.Size = new System.Drawing.Size(75, 23);
            this.buttonCancelAddSeller.TabIndex = 1;
            this.buttonCancelAddSeller.Text = "Cancel";
            this.buttonCancelAddSeller.UseVisualStyleBackColor = true;
            this.buttonCancelAddSeller.Click += new System.EventHandler(this.buttonCancelAddSeller_Click);
            // 
            // textBoxSellerName
            // 
            this.textBoxSellerName.Location = new System.Drawing.Point(85, 12);
            this.textBoxSellerName.Name = "textBoxSellerName";
            this.textBoxSellerName.Size = new System.Drawing.Size(156, 20);
            this.textBoxSellerName.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Seller Name:";
            // 
            // listBoxAvailablePouchNumbers
            // 
            this.listBoxAvailablePouchNumbers.FormattingEnabled = true;
            this.listBoxAvailablePouchNumbers.Location = new System.Drawing.Point(166, 38);
            this.listBoxAvailablePouchNumbers.Name = "listBoxAvailablePouchNumbers";
            this.listBoxAvailablePouchNumbers.Size = new System.Drawing.Size(75, 56);
            this.listBoxAvailablePouchNumbers.TabIndex = 4;
            // 
            // addNewSeller
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(253, 133);
            this.Controls.Add(this.listBoxAvailablePouchNumbers);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBoxSellerName);
            this.Controls.Add(this.buttonCancelAddSeller);
            this.Controls.Add(this.buttonAddSeller);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "addNewSeller";
            this.Text = "Add New Seller";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonAddSeller;
        private System.Windows.Forms.Button buttonCancelAddSeller;
        private System.Windows.Forms.TextBox textBoxSellerName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox listBoxAvailablePouchNumbers;
    }
}