using System.ComponentModel;

namespace SIMS.View
{
    partial class ChangePasswordWindow
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
            this.tbOldPass = new System.Windows.Forms.TextBox();
            this.btnSubmit = new System.Windows.Forms.Button();
            this.tbNewPass = new System.Windows.Forms.TextBox();
            this.lblPassword = new System.Windows.Forms.Label();
            this.lblEmail = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.panel1.Controls.Add(this.tbOldPass);
            this.panel1.Controls.Add(this.btnSubmit);
            this.panel1.Controls.Add(this.tbNewPass);
            this.panel1.Controls.Add(this.lblPassword);
            this.panel1.Controls.Add(this.lblEmail);
            this.panel1.Location = new System.Drawing.Point(35, 41);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(730, 369);
            this.panel1.TabIndex = 2;
            // 
            // tbOldPass
            // 
            this.tbOldPass.Font = new System.Drawing.Font("Orbitron", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.tbOldPass.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.tbOldPass.Location = new System.Drawing.Point(363, 86);
            this.tbOldPass.Name = "tbOldPass";
            this.tbOldPass.Size = new System.Drawing.Size(225, 28);
            this.tbOldPass.TabIndex = 5;
            this.tbOldPass.UseSystemPasswordChar = true;
            // 
            // btnSubmit
            // 
            this.btnSubmit.Font = new System.Drawing.Font("Orbitron", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.btnSubmit.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.btnSubmit.Location = new System.Drawing.Point(363, 229);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(225, 57);
            this.btnSubmit.TabIndex = 4;
            this.btnSubmit.Text = "Submit";
            this.btnSubmit.UseVisualStyleBackColor = true;
            this.btnSubmit.Click += new System.EventHandler(this.btnSubmit_Click);
            // 
            // tbNewPass
            // 
            this.tbNewPass.Font = new System.Drawing.Font("Orbitron", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.tbNewPass.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.tbNewPass.Location = new System.Drawing.Point(363, 150);
            this.tbNewPass.Name = "tbNewPass";
            this.tbNewPass.Size = new System.Drawing.Size(225, 28);
            this.tbNewPass.TabIndex = 3;
            this.tbNewPass.UseSystemPasswordChar = true;
            // 
            // lblPassword
            // 
            this.lblPassword.Font = new System.Drawing.Font("Orbitron", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.lblPassword.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.lblPassword.Location = new System.Drawing.Point(137, 150);
            this.lblPassword.Name = "lblPassword";
            this.lblPassword.Size = new System.Drawing.Size(201, 53);
            this.lblPassword.TabIndex = 2;
            this.lblPassword.Text = "New password:";
            // 
            // lblEmail
            // 
            this.lblEmail.Font = new System.Drawing.Font("Orbitron", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.lblEmail.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.lblEmail.Location = new System.Drawing.Point(137, 86);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(178, 55);
            this.lblEmail.TabIndex = 0;
            this.lblEmail.Text = "Old password:";
            // 
            // ChangePasswordWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel1);
            this.Name = "ChangePasswordWindow";
            this.Text = "ChangePasswordWindow";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
        }

        private System.Windows.Forms.TextBox tbOldPass;

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnSubmit;
        private System.Windows.Forms.TextBox tbNewPass;
        private System.Windows.Forms.Label lblPassword;
        private System.Windows.Forms.Label lblEmail;

        #endregion
    }
}