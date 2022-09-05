using System.ComponentModel;

namespace SIMS.View
{
    partial class WorkerMainWindow
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
            this.button3 = new System.Windows.Forms.Button();
            this.btnLogOut = new System.Windows.Forms.Button();
            this.btnCollect = new System.Windows.Forms.Button();
            this.btnInform = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.panel1.Controls.Add(this.button3);
            this.panel1.Controls.Add(this.btnLogOut);
            this.panel1.Controls.Add(this.btnCollect);
            this.panel1.Controls.Add(this.btnInform);
            this.panel1.Location = new System.Drawing.Point(26, 26);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(420, 320);
            this.panel1.TabIndex = 3;
            // 
            // button3
            // 
            this.button3.Font = new System.Drawing.Font("Orbitron", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.button3.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.button3.Location = new System.Drawing.Point(30, 225);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(372, 57);
            this.button3.TabIndex = 7;
            this.button3.Text = "Change password";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // btnLogOut
            // 
            this.btnLogOut.Font = new System.Drawing.Font("Orbitron", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.btnLogOut.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.btnLogOut.Location = new System.Drawing.Point(30, 162);
            this.btnLogOut.Name = "btnLogOut";
            this.btnLogOut.Size = new System.Drawing.Size(372, 57);
            this.btnLogOut.TabIndex = 6;
            this.btnLogOut.Text = "LogOut";
            this.btnLogOut.UseVisualStyleBackColor = true;
            this.btnLogOut.Click += new System.EventHandler(this.btnLogOut_Click);
            // 
            // btnCollect
            // 
            this.btnCollect.Font = new System.Drawing.Font("Orbitron", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.btnCollect.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.btnCollect.Location = new System.Drawing.Point(30, 36);
            this.btnCollect.Name = "btnCollect";
            this.btnCollect.Size = new System.Drawing.Size(372, 57);
            this.btnCollect.TabIndex = 5;
            this.btnCollect.Text = "Collect the toll";
            this.btnCollect.UseVisualStyleBackColor = true;
            this.btnCollect.Click += new System.EventHandler(this.btnCollect_Click);
            // 
            // btnInform
            // 
            this.btnInform.Font = new System.Drawing.Font("Orbitron", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.btnInform.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.btnInform.Location = new System.Drawing.Point(30, 99);
            this.btnInform.Name = "btnInform";
            this.btnInform.Size = new System.Drawing.Size(372, 57);
            this.btnInform.TabIndex = 4;
            this.btnInform.Text = "Inform the police";
            this.btnInform.UseVisualStyleBackColor = true;
            this.btnInform.Click += new System.EventHandler(this.btnInform_Click);
            // 
            // WorkerMainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(481, 372);
            this.Controls.Add(this.panel1);
            this.Name = "WorkerMainWindow";
            this.Text = "WorkerMainWindow";
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
        }

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button btnLogOut;
        private System.Windows.Forms.Button btnCollect;
        private System.Windows.Forms.Button btnInform;

        #endregion
    }
}