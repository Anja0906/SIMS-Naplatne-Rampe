using System.ComponentModel;

namespace SIMS.View
{
    partial class BuyTagWindow
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
            this.lblVehicleType = new System.Windows.Forms.Label();
            this.lblBalanceOfMoney = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.btnSubmit = new System.Windows.Forms.Button();
            this.tbNumberOfPlates = new System.Windows.Forms.TextBox();
            this.lblNumOfPlates = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.panel1.Controls.Add(this.cbVehicleType);
            this.panel1.Controls.Add(this.lblVehicleType);
            this.panel1.Controls.Add(this.lblBalanceOfMoney);
            this.panel1.Controls.Add(this.textBox1);
            this.panel1.Controls.Add(this.btnSubmit);
            this.panel1.Controls.Add(this.tbNumberOfPlates);
            this.panel1.Controls.Add(this.lblNumOfPlates);
            this.panel1.Location = new System.Drawing.Point(35, 41);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(730, 369);
            this.panel1.TabIndex = 2;
            // 
            // cbVehicleType
            // 
            this.cbVehicleType.FormattingEnabled = true;
            this.cbVehicleType.Location = new System.Drawing.Point(363, 201);
            this.cbVehicleType.Name = "cbVehicleType";
            this.cbVehicleType.Size = new System.Drawing.Size(225, 24);
            this.cbVehicleType.TabIndex = 8;
            // 
            // lblVehicleType
            // 
            this.lblVehicleType.Font = new System.Drawing.Font("Orbitron", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.lblVehicleType.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.lblVehicleType.Location = new System.Drawing.Point(82, 201);
            this.lblVehicleType.Name = "lblVehicleType";
            this.lblVehicleType.Size = new System.Drawing.Size(241, 37);
            this.lblVehicleType.TabIndex = 7;
            this.lblVehicleType.Text = "Vehicle type:";
            // 
            // lblBalanceOfMoney
            // 
            this.lblBalanceOfMoney.Font = new System.Drawing.Font("Orbitron", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.lblBalanceOfMoney.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.lblBalanceOfMoney.Location = new System.Drawing.Point(82, 126);
            this.lblBalanceOfMoney.Name = "lblBalanceOfMoney";
            this.lblBalanceOfMoney.Size = new System.Drawing.Size(241, 37);
            this.lblBalanceOfMoney.TabIndex = 6;
            this.lblBalanceOfMoney.Text = "Balance of money:";
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Orbitron", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.textBox1.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.textBox1.Location = new System.Drawing.Point(363, 126);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(225, 28);
            this.textBox1.TabIndex = 5;
            // 
            // btnSubmit
            // 
            this.btnSubmit.Font = new System.Drawing.Font("Orbitron", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.btnSubmit.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.btnSubmit.Location = new System.Drawing.Point(363, 285);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(225, 57);
            this.btnSubmit.TabIndex = 4;
            this.btnSubmit.Text = "Submit";
            this.btnSubmit.UseVisualStyleBackColor = true;
            this.btnSubmit.Click += new System.EventHandler(this.btnSubmit_Click);
            // 
            // tbNumberOfPlates
            // 
            this.tbNumberOfPlates.Font = new System.Drawing.Font("Orbitron", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.tbNumberOfPlates.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.tbNumberOfPlates.Location = new System.Drawing.Point(363, 60);
            this.tbNumberOfPlates.Name = "tbNumberOfPlates";
            this.tbNumberOfPlates.Size = new System.Drawing.Size(225, 28);
            this.tbNumberOfPlates.TabIndex = 1;
            // 
            // lblNumOfPlates
            // 
            this.lblNumOfPlates.Font = new System.Drawing.Font("Orbitron", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.lblNumOfPlates.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.lblNumOfPlates.Location = new System.Drawing.Point(82, 60);
            this.lblNumOfPlates.Name = "lblNumOfPlates";
            this.lblNumOfPlates.Size = new System.Drawing.Size(210, 37);
            this.lblNumOfPlates.TabIndex = 0;
            this.lblNumOfPlates.Text = "Number of plates:";
            // 
            // BuyTagWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel1);
            this.Name = "BuyTagWindow";
            this.Text = "BuyTagWindow";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
        }

        private System.Windows.Forms.ComboBox cbVehicleType;

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnSubmit;
        private System.Windows.Forms.TextBox tbNumberOfPlates;
        private System.Windows.Forms.Label lblNumOfPlates;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label lblBalanceOfMoney;
        private System.Windows.Forms.Label lblVehicleType;

        #endregion
    }
}