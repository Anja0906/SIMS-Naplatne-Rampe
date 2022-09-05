using System.ComponentModel;

namespace SIMS.View
{
    partial class PricelistChanging
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.dtpStartOfValidity = new System.Windows.Forms.DateTimePicker();
            this.btnSubmit = new System.Windows.Forms.Button();
            this.lblCoefficent = new System.Windows.Forms.Label();
            this.lblDateOfValidity = new System.Windows.Forms.Label();
            this.tbCoefficent = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.panel1.Controls.Add(this.tbCoefficent);
            this.panel1.Controls.Add(this.dtpStartOfValidity);
            this.panel1.Controls.Add(this.btnSubmit);
            this.panel1.Controls.Add(this.lblCoefficent);
            this.panel1.Controls.Add(this.lblDateOfValidity);
            this.panel1.Location = new System.Drawing.Point(35, 41);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(730, 330);
            this.panel1.TabIndex = 2;
            // 
            // dtpStartOfValidity
            // 
            this.dtpStartOfValidity.Location = new System.Drawing.Point(363, 86);
            this.dtpStartOfValidity.Name = "dtpStartOfValidity";
            this.dtpStartOfValidity.Size = new System.Drawing.Size(225, 22);
            this.dtpStartOfValidity.TabIndex = 5;
            // 
            // btnSubmit
            // 
            this.btnSubmit.Font = new System.Drawing.Font("Orbitron", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.btnSubmit.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.btnSubmit.Location = new System.Drawing.Point(363, 226);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(225, 57);
            this.btnSubmit.TabIndex = 4;
            this.btnSubmit.Text = "Submit";
            this.btnSubmit.UseVisualStyleBackColor = true;
            this.btnSubmit.Click += new System.EventHandler(this.btnSubmit_Click);
            // 
            // lblCoefficent
            // 
            this.lblCoefficent.Font = new System.Drawing.Font("Orbitron", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.lblCoefficent.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.lblCoefficent.Location = new System.Drawing.Point(42, 150);
            this.lblCoefficent.Name = "lblCoefficent";
            this.lblCoefficent.Size = new System.Drawing.Size(148, 37);
            this.lblCoefficent.TabIndex = 2;
            this.lblCoefficent.Text = "Coefficent:";
            // 
            // lblDateOfValidity
            // 
            this.lblDateOfValidity.Font = new System.Drawing.Font("Orbitron", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.lblDateOfValidity.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.lblDateOfValidity.Location = new System.Drawing.Point(42, 86);
            this.lblDateOfValidity.Name = "lblDateOfValidity";
            this.lblDateOfValidity.Size = new System.Drawing.Size(205, 37);
            this.lblDateOfValidity.TabIndex = 0;
            this.lblDateOfValidity.Text = "Start of validity:";
            // 
            // tbCoefficent
            // 
            this.tbCoefficent.Location = new System.Drawing.Point(363, 150);
            this.tbCoefficent.Name = "tbCoefficent";
            this.tbCoefficent.Size = new System.Drawing.Size(225, 22);
            this.tbCoefficent.TabIndex = 6;
            // 
            // PricelistChanging
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 416);
            this.Controls.Add(this.panel1);
            this.Name = "PricelistChanging";
            this.Text = "PricelistChanging";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
        }

        private System.Windows.Forms.TextBox tbCoefficent;

        private System.Windows.Forms.DateTimePicker dtpStartOfValidity;

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnSubmit;
        private System.Windows.Forms.Label lblCoefficent;
        private System.Windows.Forms.Label lblDateOfValidity;

        #endregion
    }
}