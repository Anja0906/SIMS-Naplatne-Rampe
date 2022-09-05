using System.ComponentModel;

namespace SIMS.View
{
    partial class PricelistWindow
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
            this.btnChangePricelist = new System.Windows.Forms.Button();
            this.lblDateOfValidity = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // listBox1
            // 
            this.listBox1.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.listBox1.Font = new System.Drawing.Font("Orbitron", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.listBox1.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.listBox1.FormattingEnabled = true;
            this.listBox1.HorizontalScrollbar = true;
            this.listBox1.ItemHeight = 16;
            this.listBox1.Location = new System.Drawing.Point(32, 39);
            this.listBox1.Name = "listBox1";
            this.listBox1.ScrollAlwaysVisible = true;
            this.listBox1.SelectionMode = System.Windows.Forms.SelectionMode.None;
            this.listBox1.Size = new System.Drawing.Size(737, 372);
            this.listBox1.TabIndex = 2;
            // 
            // btnChangePricelist
            // 
            this.btnChangePricelist.Font = new System.Drawing.Font("Orbitron", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.btnChangePricelist.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.btnChangePricelist.Location = new System.Drawing.Point(545, 437);
            this.btnChangePricelist.Name = "btnChangePricelist";
            this.btnChangePricelist.Size = new System.Drawing.Size(224, 57);
            this.btnChangePricelist.TabIndex = 5;
            this.btnChangePricelist.Text = "Change pricelist";
            this.btnChangePricelist.UseVisualStyleBackColor = true;
            this.btnChangePricelist.Click += new System.EventHandler(this.btnChangePricelist_Click);
            // 
            // lblDateOfValidity
            // 
            this.lblDateOfValidity.Font = new System.Drawing.Font("Orbitron", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.lblDateOfValidity.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.lblDateOfValidity.Location = new System.Drawing.Point(32, 437);
            this.lblDateOfValidity.Name = "lblDateOfValidity";
            this.lblDateOfValidity.Size = new System.Drawing.Size(249, 57);
            this.lblDateOfValidity.TabIndex = 6;
            this.lblDateOfValidity.Text = "Start of validity:";
            // 
            // PricelistWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.ClientSize = new System.Drawing.Size(800, 519);
            this.Controls.Add(this.lblDateOfValidity);
            this.Controls.Add(this.btnChangePricelist);
            this.Controls.Add(this.listBox1);
            this.Name = "PricelistWindow";
            this.Text = "PricelistWindow";
            this.ResumeLayout(false);
        }

        private System.Windows.Forms.Label lblDateOfValidity;

        private System.Windows.Forms.Button btnChangePricelist;

        private System.Windows.Forms.ListBox listBox1;

        #endregion
    }
}