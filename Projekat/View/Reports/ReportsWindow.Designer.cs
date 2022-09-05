using System.ComponentModel;

namespace SIMS.View
{
    partial class ReportsWindow
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
            this.btnSingleStations = new System.Windows.Forms.Button();
            this.btnAllStations = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.panel1.Controls.Add(this.btnSingleStations);
            this.panel1.Controls.Add(this.btnAllStations);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(420, 204);
            this.panel1.TabIndex = 5;
            // 
            // btnSingleStations
            // 
            this.btnSingleStations.Font = new System.Drawing.Font("Orbitron", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.btnSingleStations.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.btnSingleStations.Location = new System.Drawing.Point(20, 36);
            this.btnSingleStations.Name = "btnSingleStations";
            this.btnSingleStations.Size = new System.Drawing.Size(372, 57);
            this.btnSingleStations.TabIndex = 5;
            this.btnSingleStations.Text = "Single station";
            this.btnSingleStations.UseVisualStyleBackColor = true;
            this.btnSingleStations.Click += new System.EventHandler(this.btnSingleStations_Click);
            // 
            // btnAllStations
            // 
            this.btnAllStations.Font = new System.Drawing.Font("Orbitron", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.btnAllStations.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.btnAllStations.Location = new System.Drawing.Point(20, 113);
            this.btnAllStations.Name = "btnAllStations";
            this.btnAllStations.Size = new System.Drawing.Size(372, 57);
            this.btnAllStations.TabIndex = 4;
            this.btnAllStations.Text = "All stations";
            this.btnAllStations.UseVisualStyleBackColor = true;
            this.btnAllStations.Click += new System.EventHandler(this.btnAllStations_Click);
            // 
            // ReportsWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(445, 236);
            this.Controls.Add(this.panel1);
            this.Name = "ReportsWindow";
            this.Text = "ReportsWindow";
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
        }

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnSingleStations;
        private System.Windows.Forms.Button btnAllStations;

        #endregion
    }
}