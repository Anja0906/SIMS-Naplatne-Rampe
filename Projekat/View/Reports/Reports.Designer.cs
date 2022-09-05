using System.ComponentModel;

namespace SIMS.View
{
    partial class Reports
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private IContainer components = null;

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
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.lblIncome = new System.Windows.Forms.Label();
            this.tbIncome = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // listBox1
            // 
            this.listBox1.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 16;
            this.listBox1.Location = new System.Drawing.Point(33, 29);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(737, 324);
            this.listBox1.TabIndex = 1;
            // 
            // lblIncome
            // 
            this.lblIncome.Font = new System.Drawing.Font("Orbitron", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.lblIncome.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.lblIncome.Location = new System.Drawing.Point(33, 388);
            this.lblIncome.Name = "lblIncome";
            this.lblIncome.Size = new System.Drawing.Size(154, 40);
            this.lblIncome.TabIndex = 2;
            this.lblIncome.Text = "Income:";
            // 
            // tbIncome
            // 
            this.tbIncome.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.tbIncome.Font = new System.Drawing.Font("Orbitron", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.tbIncome.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.tbIncome.Location = new System.Drawing.Point(178, 388);
            this.tbIncome.Multiline = true;
            this.tbIncome.Name = "tbIncome";
            this.tbIncome.Size = new System.Drawing.Size(216, 40);
            this.tbIncome.TabIndex = 3;
            // 
            // Reports
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.ClientSize = new System.Drawing.Size(800, 452);
            this.Controls.Add(this.tbIncome);
            this.Controls.Add(this.lblIncome);
            this.Controls.Add(this.listBox1);
            this.Name = "Reports";
            this.Text = "Reports";
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private System.Windows.Forms.TextBox tbIncome;

        private System.Windows.Forms.Label lblIncome;

        private System.Windows.Forms.ListBox listBox1;

        #endregion
    }
}