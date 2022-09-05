using System.ComponentModel;

namespace SIMS.View
{
    partial class AllStationsReport
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

        private void InitializeComponent()
{
    this.panel1 = new System.Windows.Forms.Panel();
    this.dtpTo = new System.Windows.Forms.DateTimePicker();
    this.dtpFrom = new System.Windows.Forms.DateTimePicker();
    this.btnSubmit = new System.Windows.Forms.Button();
    this.lblTo = new System.Windows.Forms.Label();
    this.lblFrom = new System.Windows.Forms.Label();
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
    this.panel1.Location = new System.Drawing.Point(35, 26);
    this.panel1.Name = "panel1";
    this.panel1.Size = new System.Drawing.Size(729, 327);
    this.panel1.TabIndex = 5;
    // 
    // dtpTo
    // 
    this.dtpTo.Location = new System.Drawing.Point(329, 136);
    this.dtpTo.Name = "dtpTo";
    this.dtpTo.Size = new System.Drawing.Size(225, 22);
    this.dtpTo.TabIndex = 10;
    // 
    // dtpFrom
    // 
    this.dtpFrom.Location = new System.Drawing.Point(329, 65);
    this.dtpFrom.Name = "dtpFrom";
    this.dtpFrom.Size = new System.Drawing.Size(225, 22);
    this.dtpFrom.TabIndex = 9;
    // 
    // btnSubmit
    // 
    this.btnSubmit.Font = new System.Drawing.Font("Orbitron", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
    this.btnSubmit.ForeColor = System.Drawing.SystemColors.WindowFrame;
    this.btnSubmit.Location = new System.Drawing.Point(329, 207);
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
    this.lblTo.Location = new System.Drawing.Point(49, 136);
    this.lblTo.Name = "lblTo";
    this.lblTo.Size = new System.Drawing.Size(170, 37);
    this.lblTo.TabIndex = 6;
    this.lblTo.Text = "To:";
    // 
    // lblFrom
    // 
    this.lblFrom.Font = new System.Drawing.Font("Orbitron", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
    this.lblFrom.ForeColor = System.Drawing.SystemColors.WindowFrame;
    this.lblFrom.Location = new System.Drawing.Point(49, 65);
    this.lblFrom.Name = "lblFrom";
    this.lblFrom.Size = new System.Drawing.Size(148, 37);
    this.lblFrom.TabIndex = 2;
    this.lblFrom.Text = "From:";
    // 
    // AllStationsReport
    // 
    this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
    this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
    this.ClientSize = new System.Drawing.Size(800, 386);
    this.Controls.Add(this.panel1);
    this.Name = "AllStationsReport";
    this.Text = "AllStationsReport";
    this.panel1.ResumeLayout(false);
    this.ResumeLayout(false);
}

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DateTimePicker dtpTo;
        private System.Windows.Forms.DateTimePicker dtpFrom;
        private System.Windows.Forms.Button btnSubmit;
        private System.Windows.Forms.Label lblTo;
        private System.Windows.Forms.Label lblFrom;

        #endregion
    }
}