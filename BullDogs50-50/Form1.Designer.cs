﻿namespace BullDogs50_50
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
            // mainEntryForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(612, 492);
            this.Controls.Add(this.totalCashMoney);
            this.Name = "mainEntryForm";
            this.Text = "Hamilton Bulldogs 50/50 Draw";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.mainEntryForm_KeyDown);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label totalCashMoney;
    }
}

