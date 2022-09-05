using System.ComponentModel;

namespace SIMS.View
{
    partial class SingleStationReport
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
            this.dtpTo = new System.Windows.Forms.DateTimePicker();
            this.dtpFrom = new System.Windows.Forms.DateTimePicker();
            this.btnSubmit = new System.Windows.Forms.Button();
            this.lblTo = new System.Windows.Forms.Label();
            this.lblFrom = new System.Windows.Forms.Label();
            this.tbName = new System.Windows.Forms.TextBox();
            this.lblName = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.panel1.Controls.Add(this.dtpTo);
            this.panel1.Controls.Add(this.dtpFrom);
            this.panel1.Controls.Add(this.btnSubmit);
            this.panel1.Controls.Add(this.lblTo);
            this.panel1.Controls.Add(this.lblFrom);
            this.panel1.Controls.Add(this.tbName);
            this.panel1.Controls.Add(this.lblName);
            this.panel1.Location = new System.Drawing.Point(36, 50);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(729, 350);
            this.panel1.TabIndex = 4;
            // 
            // dtpTo
            // 
            this.dtpTo.Location = new System.Drawing.Point(329, 188);
            this.dtpTo.Name = "dtpTo";
            this.dtpTo.Size = new System.Drawing.Size(225, 22);
            this.dtpTo.TabIndex = 10;
            // 
            // dtpFrom
            // 
            this.dtpFrom.Location = new System.Drawing.Point(329, 124);
            this.dtpFrom.Name = "dtpFrom";
            this.dtpFrom.Size = new System.Drawing.Size(225, 22);
            this.dtpFrom.TabIndex = 9;
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
            // lblTo
            // 
            this.lblTo.Font = new System.Drawing.Font("Orbitron", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.lblTo.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.lblTo.Location = new System.Drawing.Point(49, 188);
            this.lblTo.Name = "lblTo";
            this.lblTo.Size = new System.Drawing.Size(170, 37);
            this.lblTo.TabIndex = 6;
            this.lblTo.Text = "To:";
            // 
            // lblFrom
            // 
            this.lblFrom.Font = new System.Drawing.Font("Orbitron", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.lblFrom.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.lblFrom.Location = new System.Drawing.Point(49, 124);
            this.lblFrom.Name = "lblFrom";
            this.lblFrom.Size = new System.Drawing.Size(148, 37);
            this.lblFrom.TabIndex = 2;
            this.lblFrom.Text = "From:";
            // 
            // tbName
            // 
            this.tbName.Font = new System.Drawing.Font("Orbitron", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.tbName.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.tbName.Location = new System.Drawing.Point(329, 65);
            this.tbName.Name = "tbName";
            this.tbName.Size = new System.Drawing.Size(225, 28);
            this.tbName.TabIndex = 1;
            // 
            // lblName
            // 
            this.lblName.Font = new System.Drawing.Font("Orbitron", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.lblName.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.lblName.Location = new System.Drawing.Point(49, 65);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(177, 37);
            this.lblName.TabIndex = 0;
            this.lblName.Text = "Stations name:";
            // 
            // SingleStationReport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel1);
            this.Name = "SingleStationReport";
            this.Text = "SingleStationReport";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
        }

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnSubmit;
        private System.Windows.Forms.Label lblTo;
        private System.Windows.Forms.Label lblFrom;
        private System.Windows.Forms.TextBox tbName;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.DateTimePicker dtpFrom;
        private System.Windows.Forms.DateTimePicker dtpTo;

        #endregion
    }
}