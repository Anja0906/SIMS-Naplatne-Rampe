using System.ComponentModel;

namespace SIMS.View
{
    partial class AdministratorMainWondow
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
            this.btnAddPlace = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.btnLogOut = new System.Windows.Forms.Button();
            this.btnPricelist = new System.Windows.Forms.Button();
            this.btnReports = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.panel1.Controls.Add(this.btnAddPlace);
            this.panel1.Controls.Add(this.button3);
            this.panel1.Controls.Add(this.btnLogOut);
            this.panel1.Controls.Add(this.btnPricelist);
            this.panel1.Controls.Add(this.btnReports);
            this.panel1.Location = new System.Drawing.Point(35, 41);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(420, 384);
            this.panel1.TabIndex = 2;
            // 
            // btnAddPlace
            // 
            this.btnAddPlace.Font = new System.Drawing.Font("Orbitron", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.btnAddPlace.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.btnAddPlace.Location = new System.Drawing.Point(30, 162);
            this.btnAddPlace.Name = "btnAddPlace";
            this.btnAddPlace.Size = new System.Drawing.Size(372, 57);
            this.btnAddPlace.TabIndex = 8;
            this.btnAddPlace.Text = "Add new billing place";
            this.btnAddPlace.UseVisualStyleBackColor = true;
            this.btnAddPlace.Click += new System.EventHandler(this.btnAddPlace_Click);
            // 
            // button3
            // 
            this.button3.Font = new System.Drawing.Font("Orbitron", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.button3.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.button3.Location = new System.Drawing.Point(30, 288);
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
            this.btnLogOut.Location = new System.Drawing.Point(30, 225);
            this.btnLogOut.Name = "btnLogOut";
            this.btnLogOut.Size = new System.Drawing.Size(372, 57);
            this.btnLogOut.TabIndex = 6;
            this.btnLogOut.Text = "LogOut";
            this.btnLogOut.UseVisualStyleBackColor = true;
            this.btnLogOut.Click += new System.EventHandler(this.btnLogOut_Click);
            // 
            // btnPricelist
            // 
            this.btnPricelist.Font = new System.Drawing.Font("Orbitron", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.btnPricelist.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.btnPricelist.Location = new System.Drawing.Point(30, 36);
            this.btnPricelist.Name = "btnPricelist";
            this.btnPricelist.Size = new System.Drawing.Size(372, 57);
            this.btnPricelist.TabIndex = 5;
            this.btnPricelist.Text = "Pricelist";
            this.btnPricelist.UseVisualStyleBackColor = true;
            this.btnPricelist.Click += new System.EventHandler(this.btnPricelist_Click);
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
            // AdministratorMainWondow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(496, 482);
            this.Controls.Add(this.panel1);
            this.Name = "AdministratorMainWondow";
            this.Text = "AdministratorMainWondow";
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
        }

        private System.Windows.Forms.Button btnAddPlace;

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnReports;
        private System.Windows.Forms.Button btnPricelist;
        private System.Windows.Forms.Button btnLogOut;
        private System.Windows.Forms.Button button3;

        #endregion
    }
}