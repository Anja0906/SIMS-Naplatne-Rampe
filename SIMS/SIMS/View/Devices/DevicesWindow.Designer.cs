using System.ComponentModel;

namespace SIMS.View
{
    partial class DevicesWindow
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
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.lblInUse = new System.Windows.Forms.Label();
            this.lblBroken = new System.Windows.Forms.Label();
            this.lbBroken = new System.Windows.Forms.ListBox();
            this.lbInUse = new System.Windows.Forms.ListBox();
            this.btnRepair = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.panel1.Controls.Add(this.textBox2);
            this.panel1.Controls.Add(this.textBox1);
            this.panel1.Controls.Add(this.lblInUse);
            this.panel1.Controls.Add(this.lblBroken);
            this.panel1.Controls.Add(this.lbBroken);
            this.panel1.Controls.Add(this.lbInUse);
            this.panel1.Controls.Add(this.btnRepair);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(776, 484);
            this.panel1.TabIndex = 4;
            // 
            // textBox2
            // 
            this.textBox2.BackColor = System.Drawing.Color.OrangeRed;
            this.textBox2.Enabled = false;
            this.textBox2.Location = new System.Drawing.Point(586, 23);
            this.textBox2.Multiline = true;
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(52, 43);
            this.textBox2.TabIndex = 12;
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.Color.LightGreen;
            this.textBox1.Enabled = false;
            this.textBox1.Location = new System.Drawing.Point(169, 23);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(52, 43);
            this.textBox1.TabIndex = 11;
            // 
            // lblInUse
            // 
            this.lblInUse.Font = new System.Drawing.Font("Orbitron", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.lblInUse.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.lblInUse.Location = new System.Drawing.Point(16, 23);
            this.lblInUse.Name = "lblInUse";
            this.lblInUse.Size = new System.Drawing.Size(361, 57);
            this.lblInUse.TabIndex = 10;
            this.lblInUse.Text = "In use";
            // 
            // lblBroken
            // 
            this.lblBroken.Font = new System.Drawing.Font("Orbitron", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.lblBroken.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.lblBroken.Location = new System.Drawing.Point(400, 23);
            this.lblBroken.Name = "lblBroken";
            this.lblBroken.Size = new System.Drawing.Size(361, 57);
            this.lblBroken.TabIndex = 9;
            this.lblBroken.Text = "Broken";
            // 
            // lbBroken
            // 
            this.lbBroken.FormattingEnabled = true;
            this.lbBroken.ItemHeight = 16;
            this.lbBroken.Location = new System.Drawing.Point(400, 101);
            this.lbBroken.Name = "lbBroken";
            this.lbBroken.Size = new System.Drawing.Size(362, 308);
            this.lbBroken.TabIndex = 7;
            // 
            // lbInUse
            // 
            this.lbInUse.Enabled = false;
            this.lbInUse.FormattingEnabled = true;
            this.lbInUse.ItemHeight = 16;
            this.lbInUse.Location = new System.Drawing.Point(16, 101);
            this.lbInUse.Name = "lbInUse";
            this.lbInUse.Size = new System.Drawing.Size(362, 308);
            this.lbInUse.TabIndex = 6;
            // 
            // btnRepair
            // 
            this.btnRepair.Font = new System.Drawing.Font("Orbitron", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.btnRepair.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.btnRepair.Location = new System.Drawing.Point(400, 415);
            this.btnRepair.Name = "btnRepair";
            this.btnRepair.Size = new System.Drawing.Size(362, 57);
            this.btnRepair.TabIndex = 5;
            this.btnRepair.Text = "Repair";
            this.btnRepair.UseVisualStyleBackColor = true;
            this.btnRepair.Click += new System.EventHandler(this.btnRepair_Click);
            // 
            // DevicesWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 508);
            this.Controls.Add(this.panel1);
            this.Name = "DevicesWindow";
            this.Text = "DevicesWindow";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
        }

        private System.Windows.Forms.TextBox textBox2;

        private System.Windows.Forms.TextBox textBox1;

        private System.Windows.Forms.Label lblInUse;

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnRepair;
        private System.Windows.Forms.ListBox lbInUse;
        private System.Windows.Forms.ListBox lbBroken;
        private System.Windows.Forms.Label lblBroken;

        #endregion
    }
}