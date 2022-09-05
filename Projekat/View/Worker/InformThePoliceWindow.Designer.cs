using System.ComponentModel;

namespace SIMS.View
{
    partial class InformThePoliceWindow
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
            this.btnSubmit = new System.Windows.Forms.Button();
            this.txtBoxEmail = new System.Windows.Forms.TextBox();
            this.lblNumOfPlates = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.panel1.Controls.Add(this.btnSubmit);
            this.panel1.Controls.Add(this.txtBoxEmail);
            this.panel1.Controls.Add(this.lblNumOfPlates);
            this.panel1.Location = new System.Drawing.Point(35, 41);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(730, 241);
            this.panel1.TabIndex = 3;
            // 
            // btnSubmit
            // 
            this.btnSubmit.Font = new System.Drawing.Font("Orbitron", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.btnSubmit.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.btnSubmit.Location = new System.Drawing.Point(363, 123);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(225, 57);
            this.btnSubmit.TabIndex = 4;
            this.btnSubmit.Text = "Submit";
            this.btnSubmit.UseVisualStyleBackColor = true;
            this.btnSubmit.Click += new System.EventHandler(this.btnSubmit_Click);
            // 
            // txtBoxEmail
            // 
            this.txtBoxEmail.Font = new System.Drawing.Font("Orbitron", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.txtBoxEmail.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.txtBoxEmail.Location = new System.Drawing.Point(363, 60);
            this.txtBoxEmail.Name = "txtBoxEmail";
            this.txtBoxEmail.Size = new System.Drawing.Size(225, 28);
            this.txtBoxEmail.TabIndex = 1;
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
            // InformThePoliceWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 321);
            this.Controls.Add(this.panel1);
            this.Name = "InformThePoliceWindow";
            this.Text = "InformThePoliceWindow";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
        }

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnSubmit;
        private System.Windows.Forms.TextBox txtBoxEmail;
        private System.Windows.Forms.Label lblNumOfPlates;

        #endregion
    }
}