using System.ComponentModel;

namespace SIMS.View
{
    partial class PriceCalculator
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
            this.tbPrice = new System.Windows.Forms.TextBox();
            this.lblVehicleType = new System.Windows.Forms.Label();
            this.cbVehicleType = new System.Windows.Forms.ComboBox();
            this.cbExit = new System.Windows.Forms.ComboBox();
            this.cbEntry = new System.Windows.Forms.ComboBox();
            this.btnSubmit = new System.Windows.Forms.Button();
            this.lblExit = new System.Windows.Forms.Label();
            this.lblEntry = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.panel1.Controls.Add(this.tbPrice);
            this.panel1.Controls.Add(this.lblVehicleType);
            this.panel1.Controls.Add(this.cbVehicleType);
            this.panel1.Controls.Add(this.cbExit);
            this.panel1.Controls.Add(this.cbEntry);
            this.panel1.Controls.Add(this.btnSubmit);
            this.panel1.Controls.Add(this.lblExit);
            this.panel1.Controls.Add(this.lblEntry);
            this.panel1.Font = new System.Drawing.Font("Orbitron", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.panel1.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.panel1.Location = new System.Drawing.Point(35, 41);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(730, 437);
            this.panel1.TabIndex = 2;
            // 
            // tbPrice
            // 
            this.tbPrice.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.tbPrice.Location = new System.Drawing.Point(160, 289);
            this.tbPrice.Multiline = true;
            this.tbPrice.Name = "tbPrice";
            this.tbPrice.Size = new System.Drawing.Size(164, 57);
            this.tbPrice.TabIndex = 9;
            // 
            // lblVehicleType
            // 
            this.lblVehicleType.Font = new System.Drawing.Font("Orbitron", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.lblVehicleType.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.lblVehicleType.Location = new System.Drawing.Point(160, 227);
            this.lblVehicleType.Name = "lblVehicleType";
            this.lblVehicleType.Size = new System.Drawing.Size(148, 37);
            this.lblVehicleType.TabIndex = 8;
            this.lblVehicleType.Text = "Vehicle type:";
            // 
            // cbVehicleType
            // 
            this.cbVehicleType.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.cbVehicleType.FormattingEnabled = true;
            this.cbVehicleType.Location = new System.Drawing.Point(363, 227);
            this.cbVehicleType.Name = "cbVehicleType";
            this.cbVehicleType.Size = new System.Drawing.Size(224, 35);
            this.cbVehicleType.TabIndex = 7;
            // 
            // cbExit
            // 
            this.cbExit.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.cbExit.FormattingEnabled = true;
            this.cbExit.Location = new System.Drawing.Point(363, 156);
            this.cbExit.Name = "cbExit";
            this.cbExit.Size = new System.Drawing.Size(224, 35);
            this.cbExit.TabIndex = 6;
            // 
            // cbEntry
            // 
            this.cbEntry.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.cbEntry.FormattingEnabled = true;
            this.cbEntry.Location = new System.Drawing.Point(363, 89);
            this.cbEntry.Name = "cbEntry";
            this.cbEntry.Size = new System.Drawing.Size(224, 35);
            this.cbEntry.TabIndex = 5;
            // 
            // btnSubmit
            // 
            this.btnSubmit.Font = new System.Drawing.Font("Orbitron", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.btnSubmit.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.btnSubmit.Location = new System.Drawing.Point(363, 289);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(224, 57);
            this.btnSubmit.TabIndex = 4;
            this.btnSubmit.Text = "Calculate";
            this.btnSubmit.UseVisualStyleBackColor = true;
            this.btnSubmit.Click += new System.EventHandler(this.btnSubmit_Click);
            // 
            // lblExit
            // 
            this.lblExit.Font = new System.Drawing.Font("Orbitron", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.lblExit.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.lblExit.Location = new System.Drawing.Point(160, 153);
            this.lblExit.Name = "lblExit";
            this.lblExit.Size = new System.Drawing.Size(148, 37);
            this.lblExit.TabIndex = 2;
            this.lblExit.Text = "Exit:";
            // 
            // lblEntry
            // 
            this.lblEntry.Font = new System.Drawing.Font("Orbitron", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.lblEntry.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.lblEntry.Location = new System.Drawing.Point(160, 89);
            this.lblEntry.Name = "lblEntry";
            this.lblEntry.Size = new System.Drawing.Size(129, 37);
            this.lblEntry.TabIndex = 0;
            this.lblEntry.Text = "Entry:";
            // 
            // PriceCalculator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 502);
            this.Controls.Add(this.panel1);
            this.Name = "PriceCalculator";
            this.Text = "PriceCalculator";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
        }

        private System.Windows.Forms.ComboBox cbEntry;
        private System.Windows.Forms.ComboBox cbExit;
        private System.Windows.Forms.ComboBox cbVehicleType;
        private System.Windows.Forms.Label lblVehicleType;
        private System.Windows.Forms.TextBox tbPrice;

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnSubmit;
        private System.Windows.Forms.Label lblExit;
        private System.Windows.Forms.Label lblEntry;

        #endregion
    }
}