using System.ComponentModel;

namespace SIMS.View
{
    partial class DriverMainWindow
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
            this.btnCalculatePrice = new System.Windows.Forms.Button();
            this.btnEnterTheRoad = new System.Windows.Forms.Button();
            this.btnChangePassword = new System.Windows.Forms.Button();
            this.btnLogOut = new System.Windows.Forms.Button();
            this.btnBuyTag = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.panel1.Controls.Add(this.btnCalculatePrice);
            this.panel1.Controls.Add(this.btnEnterTheRoad);
            this.panel1.Controls.Add(this.btnChangePassword);
            this.panel1.Controls.Add(this.btnLogOut);
            this.panel1.Controls.Add(this.btnBuyTag);
            this.panel1.Controls.Add(this.btnExit);
            this.panel1.Location = new System.Drawing.Point(26, 30);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(420, 445);
            this.panel1.TabIndex = 3;
            // 
            // btnCalculatePrice
            // 
            this.btnCalculatePrice.Font = new System.Drawing.Font("Orbitron", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.btnCalculatePrice.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.btnCalculatePrice.Location = new System.Drawing.Point(30, 225);
            this.btnCalculatePrice.Name = "btnCalculatePrice";
            this.btnCalculatePrice.Size = new System.Drawing.Size(372, 57);
            this.btnCalculatePrice.TabIndex = 9;
            this.btnCalculatePrice.Text = "Calculate price";
            this.btnCalculatePrice.UseVisualStyleBackColor = true;
            this.btnCalculatePrice.Click += new System.EventHandler(this.btnCalculatePrice_Click);
            // 
            // btnEnterTheRoad
            // 
            this.btnEnterTheRoad.Font = new System.Drawing.Font("Orbitron", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.btnEnterTheRoad.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.btnEnterTheRoad.Location = new System.Drawing.Point(30, 162);
            this.btnEnterTheRoad.Name = "btnEnterTheRoad";
            this.btnEnterTheRoad.Size = new System.Drawing.Size(372, 57);
            this.btnEnterTheRoad.TabIndex = 8;
            this.btnEnterTheRoad.Text = "Enter the road";
            this.btnEnterTheRoad.UseVisualStyleBackColor = true;
            this.btnEnterTheRoad.Click += new System.EventHandler(this.btnEnterTheRoad_Click);
            // 
            // btnChangePassword
            // 
            this.btnChangePassword.Font = new System.Drawing.Font("Orbitron", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.btnChangePassword.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.btnChangePassword.Location = new System.Drawing.Point(30, 351);
            this.btnChangePassword.Name = "btnChangePassword";
            this.btnChangePassword.Size = new System.Drawing.Size(372, 57);
            this.btnChangePassword.TabIndex = 7;
            this.btnChangePassword.Text = "Change password";
            this.btnChangePassword.UseVisualStyleBackColor = true;
            this.btnChangePassword.Click += new System.EventHandler(this.btnChangePassword_Click);
            // 
            // btnLogOut
            // 
            this.btnLogOut.Font = new System.Drawing.Font("Orbitron", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.btnLogOut.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.btnLogOut.Location = new System.Drawing.Point(30, 288);
            this.btnLogOut.Name = "btnLogOut";
            this.btnLogOut.Size = new System.Drawing.Size(372, 57);
            this.btnLogOut.TabIndex = 6;
            this.btnLogOut.Text = "LogOut";
            this.btnLogOut.UseVisualStyleBackColor = true;
            this.btnLogOut.Click += new System.EventHandler(this.btnLogOut_Click);
            // 
            // btnBuyTag
            // 
            this.btnBuyTag.Font = new System.Drawing.Font("Orbitron", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.btnBuyTag.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.btnBuyTag.Location = new System.Drawing.Point(30, 36);
            this.btnBuyTag.Name = "btnBuyTag";
            this.btnBuyTag.Size = new System.Drawing.Size(372, 57);
            this.btnBuyTag.TabIndex = 5;
            this.btnBuyTag.Text = "Buy tag";
            this.btnBuyTag.UseVisualStyleBackColor = true;
            this.btnBuyTag.Click += new System.EventHandler(this.btnBuyTag_Click);
            // 
            // btnExit
            // 
            this.btnExit.Font = new System.Drawing.Font("Orbitron", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.btnExit.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.btnExit.Location = new System.Drawing.Point(30, 99);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(372, 57);
            this.btnExit.TabIndex = 4;
            this.btnExit.Text = "Exit the road";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // DriverMainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(479, 487);
            this.Controls.Add(this.panel1);
            this.Name = "DriverMainWindow";
            this.Text = "DriverMainWindow";
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
        }

        private System.Windows.Forms.Button btnCalculatePrice;

        private System.Windows.Forms.Button btnEnterTheRoad;

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnChangePassword;
        private System.Windows.Forms.Button btnLogOut;
        private System.Windows.Forms.Button btnBuyTag;
        private System.Windows.Forms.Button btnExit;

        #endregion
    }
}