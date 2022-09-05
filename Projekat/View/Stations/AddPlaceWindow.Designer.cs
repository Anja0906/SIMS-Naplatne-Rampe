using System.ComponentModel;

namespace SIMS.View
{
    partial class AddPlaceWindow
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
            this.cbVehicleType = new System.Windows.Forms.ComboBox();
            this.cbBillingType = new System.Windows.Forms.ComboBox();
            this.btnSubmit = new System.Windows.Forms.Button();
            this.lblVehicleType = new System.Windows.Forms.Label();
            this.lblBillingType = new System.Windows.Forms.Label();
            this.tbId = new System.Windows.Forms.TextBox();
            this.lblId = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.panel1.Controls.Add(this.cbVehicleType);
            this.panel1.Controls.Add(this.cbBillingType);
            this.panel1.Controls.Add(this.btnSubmit);
            this.panel1.Controls.Add(this.lblVehicleType);
            this.panel1.Controls.Add(this.lblBillingType);
            this.panel1.Controls.Add(this.tbId);
            this.panel1.Controls.Add(this.lblId);
            this.panel1.Location = new System.Drawing.Point(35, 11);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(605, 350);
            this.panel1.TabIndex = 3;
            // 
            // cbVehicleType
            // 
            this.cbVehicleType.FormattingEnabled = true;
            this.cbVehicleType.Location = new System.Drawing.Point(329, 188);
            this.cbVehicleType.Name = "cbVehicleType";
            this.cbVehicleType.Size = new System.Drawing.Size(225, 24);
            this.cbVehicleType.TabIndex = 10;
            // 
            // cbBillingType
            // 
            this.cbBillingType.FormattingEnabled = true;
            this.cbBillingType.Location = new System.Drawing.Point(329, 130);
            this.cbBillingType.Name = "cbBillingType";
            this.cbBillingType.Size = new System.Drawing.Size(225, 24);
            this.cbBillingType.TabIndex = 9;
            // 
            // btnSubmit
            // 
            this.btnSubmit.Font = new System.Drawing.Font("Orbitron", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.btnSubmit.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.btnSubmit.Location = new System.Drawing.Point(329, 252);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(225, 57);
            this.btnSubmit.TabIndex = 8;
            this.btnSubmit.Text = "Submit";
            this.btnSubmit.UseVisualStyleBackColor = true;
            this.btnSubmit.Click += new System.EventHandler(this.btnSubmit_Click);
            // 
            // lblVehicleType
            // 
            this.lblVehicleType.Font = new System.Drawing.Font("Orbitron", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.lblVehicleType.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.lblVehicleType.Location = new System.Drawing.Point(49, 188);
            this.lblVehicleType.Name = "lblVehicleType";
            this.lblVehicleType.Size = new System.Drawing.Size(170, 37);
            this.lblVehicleType.TabIndex = 6;
            this.lblVehicleType.Text = "Vehicle type:";
            // 
            // lblBillingType
            // 
            this.lblBillingType.Font = new System.Drawing.Font("Orbitron", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.lblBillingType.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.lblBillingType.Location = new System.Drawing.Point(49, 124);
            this.lblBillingType.Name = "lblBillingType";
            this.lblBillingType.Size = new System.Drawing.Size(148, 37);
            this.lblBillingType.TabIndex = 2;
            this.lblBillingType.Text = "Billing type:";
            // 
            // tbId
            // 
            this.tbId.Font = new System.Drawing.Font("Orbitron", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.tbId.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.tbId.Location = new System.Drawing.Point(329, 65);
            this.tbId.Name = "tbId";
            this.tbId.Size = new System.Drawing.Size(225, 28);
            this.tbId.TabIndex = 1;
            // 
            // lblId
            // 
            this.lblId.Font = new System.Drawing.Font("Orbitron", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.lblId.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.lblId.Location = new System.Drawing.Point(49, 65);
            this.lblId.Name = "lblId";
            this.lblId.Size = new System.Drawing.Size(129, 37);
            this.lblId.TabIndex = 0;
            this.lblId.Text = "Id:";
            // 
            // AddPlaceWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(674, 390);
            this.Controls.Add(this.panel1);
            this.Name = "AddPlaceWindow";
            this.Text = "AddPlaceWindow";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
        }

        private System.Windows.Forms.ComboBox cbBillingType;
        private System.Windows.Forms.ComboBox cbVehicleType;

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnSubmit;
        private System.Windows.Forms.Label lblVehicleType;
        private System.Windows.Forms.Label lblBillingType;
        private System.Windows.Forms.TextBox tbId;
        private System.Windows.Forms.Label lblId;

        #endregion
    }
}