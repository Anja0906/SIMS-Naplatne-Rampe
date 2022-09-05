using System.ComponentModel;

namespace SIMS.View
{
    partial class ManagerMainWindow
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
            this.btnDevices = new System.Windows.Forms.Button();
            this.btnChangePassword = new System.Windows.Forms.Button();
            this.btnLogOut = new System.Windows.Forms.Button();
            this.btnStations = new System.Windows.Forms.Button();
            this.btnReports = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.panel1.Controls.Add(this.btnDevices);
            this.panel1.Controls.Add(this.btnChangePassword);
            this.panel1.Controls.Add(this.btnLogOut);
            this.panel1.Controls.Add(this.btnStations);
            this.panel1.Controls.Add(this.btnReports);
            this.panel1.Location = new System.Drawing.Point(22, 23);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(420, 382);
            this.panel1.TabIndex = 4;
            // 
            // btnDevices
            // 
            this.btnDevices.Font = new System.Drawing.Font("Orbitron", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.btnDevices.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.btnDevices.Location = new System.Drawing.Point(30, 162);
            this.btnDevices.Name = "btnDevices";
            this.btnDevices.Size = new System.Drawing.Size(372, 57);
            this.btnDevices.TabIndex = 8;
            this.btnDevices.Text = "Devices";
            this.btnDevices.UseVisualStyleBackColor = true;
            this.btnDevices.Click += new System.EventHandler(this.btnDevices_Click);
            // 
            // btnChangePassword
            // 
            this.btnChangePassword.Font = new System.Drawing.Font("Orbitron", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.btnChangePassword.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.btnChangePassword.Location = new System.Drawing.Point(30, 288);
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
            this.btnLogOut.Location = new System.Drawing.Point(30, 225);
            this.btnLogOut.Name = "btnLogOut";
            this.btnLogOut.Size = new System.Drawing.Size(372, 57);
            this.btnLogOut.TabIndex = 6;
            this.btnLogOut.Text = "LogOut";
            this.btnLogOut.UseVisualStyleBackColor = true;
            this.btnLogOut.Click += new System.EventHandler(this.btnLogOut_Click);
            // 
            // btnStations
            // 
            this.btnStations.Font = new System.Drawing.Font("Orbitron", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.btnStations.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.btnStations.Location = new System.Drawing.Point(30, 36);
            this.btnStations.Name = "btnStations";
            this.btnStations.Size = new System.Drawing.Size(372, 57);
            this.btnStations.TabIndex = 5;
            this.btnStations.Text = "Stations";
            this.btnStations.UseVisualStyleBackColor = true;
            this.btnStations.Click += new System.EventHandler(this.btnStations_Click);
            // 
            // btnReports
            // 
            this.btnReports.Font = new System.Drawing.Font("Orbitron", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.btnReports.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.btnReports.Location = new System.Drawing.Point(30, 99);
            this.btnReports.Name = "btnReports";
            this.btnReports.Size = new System.Drawing.Size(372, 57);
            this.btnReports.TabIndex = 4;
            this.btnReports.Text = "Reports";
            this.btnReports.UseVisualStyleBackColor = true;
            this.btnReports.Click += new System.EventHandler(this.btnReports_Click);
            // 
            // ManagerMainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(468, 450);
            this.Controls.Add(this.panel1);
            this.Name = "ManagerMainWindow";
            this.Text = "ManagerMainWindow";
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
        }

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnDevices;
        private System.Windows.Forms.Button btnChangePassword;
        private System.Windows.Forms.Button btnLogOut;
        private System.Windows.Forms.Button btnStations;
        private System.Windows.Forms.Button btnReports;

        #endregion
    }
}