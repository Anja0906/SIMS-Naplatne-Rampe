using System.ComponentModel;

namespace SIMS.View
{
    partial class TollCollectingWindow
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
            this.lblPrice = new System.Windows.Forms.Label();
            this.cbCategory = new System.Windows.Forms.ComboBox();
            this.lblSpeedLimit = new System.Windows.Forms.Label();
            this.lblChange = new System.Windows.Forms.Label();
            this.tbSpeedLimit = new System.Windows.Forms.TextBox();
            this.tbChange = new System.Windows.Forms.TextBox();
            this.lblDriversAmount = new System.Windows.Forms.Label();
            this.lblCategory = new System.Windows.Forms.Label();
            this.tbDriversAmount = new System.Windows.Forms.TextBox();
            this.tbNumOfPlates = new System.Windows.Forms.TextBox();
            this.lblNumOfPlates = new System.Windows.Forms.Label();
            this.tbEntryTime = new System.Windows.Forms.TextBox();
            this.lblEntryTime = new System.Windows.Forms.Label();
            this.btnSubmit = new System.Windows.Forms.Button();
            this.tbEntryPlace = new System.Windows.Forms.TextBox();
            this.lblEntryPlace = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.panel1.Controls.Add(this.lblPrice);
            this.panel1.Controls.Add(this.cbCategory);
            this.panel1.Controls.Add(this.lblSpeedLimit);
            this.panel1.Controls.Add(this.lblChange);
            this.panel1.Controls.Add(this.tbSpeedLimit);
            this.panel1.Controls.Add(this.tbChange);
            this.panel1.Controls.Add(this.lblDriversAmount);
            this.panel1.Controls.Add(this.lblCategory);
            this.panel1.Controls.Add(this.tbDriversAmount);
            this.panel1.Controls.Add(this.tbNumOfPlates);
            this.panel1.Controls.Add(this.lblNumOfPlates);
            this.panel1.Controls.Add(this.tbEntryTime);
            this.panel1.Controls.Add(this.lblEntryTime);
            this.panel1.Controls.Add(this.btnSubmit);
            this.panel1.Controls.Add(this.tbEntryPlace);
            this.panel1.Controls.Add(this.lblEntryPlace);
            this.panel1.Location = new System.Drawing.Point(35, 41);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(730, 430);
            this.panel1.TabIndex = 2;
            // 
            // lblPrice
            // 
            this.lblPrice.Font = new System.Drawing.Font("Orbitron", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.lblPrice.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.lblPrice.Location = new System.Drawing.Point(80, 336);
            this.lblPrice.Name = "lblPrice";
            this.lblPrice.Size = new System.Drawing.Size(209, 37);
            this.lblPrice.TabIndex = 18;
            this.lblPrice.Text = "Price:";
            // 
            // cbCategory
            // 
            this.cbCategory.FormattingEnabled = true;
            this.cbCategory.Location = new System.Drawing.Point(362, 169);
            this.cbCategory.Name = "cbCategory";
            this.cbCategory.Size = new System.Drawing.Size(224, 24);
            this.cbCategory.TabIndex = 17;
            // 
            // lblSpeedLimit
            // 
            this.lblSpeedLimit.Font = new System.Drawing.Font("Orbitron", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.lblSpeedLimit.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.lblSpeedLimit.Location = new System.Drawing.Point(80, 277);
            this.lblSpeedLimit.Name = "lblSpeedLimit";
            this.lblSpeedLimit.Size = new System.Drawing.Size(209, 37);
            this.lblSpeedLimit.TabIndex = 15;
            this.lblSpeedLimit.Text = "Speed limit:";
            // 
            // lblChange
            // 
            this.lblChange.Font = new System.Drawing.Font("Orbitron", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.lblChange.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.lblChange.Location = new System.Drawing.Point(80, 240);
            this.lblChange.Name = "lblChange";
            this.lblChange.Size = new System.Drawing.Size(209, 37);
            this.lblChange.TabIndex = 14;
            this.lblChange.Text = "Change:";
            // 
            // tbSpeedLimit
            // 
            this.tbSpeedLimit.Enabled = false;
            this.tbSpeedLimit.Font = new System.Drawing.Font("Orbitron", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.tbSpeedLimit.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.tbSpeedLimit.Location = new System.Drawing.Point(362, 277);
            this.tbSpeedLimit.Name = "tbSpeedLimit";
            this.tbSpeedLimit.Size = new System.Drawing.Size(31, 28);
            this.tbSpeedLimit.TabIndex = 13;
            // 
            // tbChange
            // 
            this.tbChange.Enabled = false;
            this.tbChange.Font = new System.Drawing.Font("Orbitron", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.tbChange.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.tbChange.Location = new System.Drawing.Point(362, 240);
            this.tbChange.Name = "tbChange";
            this.tbChange.Size = new System.Drawing.Size(225, 28);
            this.tbChange.TabIndex = 12;
            // 
            // lblDriversAmount
            // 
            this.lblDriversAmount.Font = new System.Drawing.Font("Orbitron", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.lblDriversAmount.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.lblDriversAmount.Location = new System.Drawing.Point(80, 203);
            this.lblDriversAmount.Name = "lblDriversAmount";
            this.lblDriversAmount.Size = new System.Drawing.Size(209, 37);
            this.lblDriversAmount.TabIndex = 11;
            this.lblDriversAmount.Text = "Drivers amount:";
            // 
            // lblCategory
            // 
            this.lblCategory.Font = new System.Drawing.Font("Orbitron", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.lblCategory.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.lblCategory.Location = new System.Drawing.Point(80, 166);
            this.lblCategory.Name = "lblCategory";
            this.lblCategory.Size = new System.Drawing.Size(209, 37);
            this.lblCategory.TabIndex = 10;
            this.lblCategory.Text = "Category:";
            // 
            // tbDriversAmount
            // 
            this.tbDriversAmount.Font = new System.Drawing.Font("Orbitron", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.tbDriversAmount.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.tbDriversAmount.Location = new System.Drawing.Point(362, 203);
            this.tbDriversAmount.Name = "tbDriversAmount";
            this.tbDriversAmount.Size = new System.Drawing.Size(225, 28);
            this.tbDriversAmount.TabIndex = 9;
            this.tbDriversAmount.TextChanged += new System.EventHandler(this.tbDriversAmount_TextChanged);
            // 
            // tbNumOfPlates
            // 
            this.tbNumOfPlates.Enabled = false;
            this.tbNumOfPlates.Font = new System.Drawing.Font("Orbitron", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.tbNumOfPlates.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.tbNumOfPlates.Location = new System.Drawing.Point(363, 129);
            this.tbNumOfPlates.Name = "tbNumOfPlates";
            this.tbNumOfPlates.Size = new System.Drawing.Size(225, 28);
            this.tbNumOfPlates.TabIndex = 8;
            // 
            // lblNumOfPlates
            // 
            this.lblNumOfPlates.Font = new System.Drawing.Font("Orbitron", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.lblNumOfPlates.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.lblNumOfPlates.Location = new System.Drawing.Point(80, 129);
            this.lblNumOfPlates.Name = "lblNumOfPlates";
            this.lblNumOfPlates.Size = new System.Drawing.Size(209, 37);
            this.lblNumOfPlates.TabIndex = 7;
            this.lblNumOfPlates.Text = "Number of plates:";
            // 
            // tbEntryTime
            // 
            this.tbEntryTime.Enabled = false;
            this.tbEntryTime.Font = new System.Drawing.Font("Orbitron", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.tbEntryTime.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.tbEntryTime.Location = new System.Drawing.Point(363, 95);
            this.tbEntryTime.Name = "tbEntryTime";
            this.tbEntryTime.Size = new System.Drawing.Size(225, 28);
            this.tbEntryTime.TabIndex = 6;
            // 
            // lblEntryTime
            // 
            this.lblEntryTime.Font = new System.Drawing.Font("Orbitron", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.lblEntryTime.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.lblEntryTime.Location = new System.Drawing.Point(80, 92);
            this.lblEntryTime.Name = "lblEntryTime";
            this.lblEntryTime.Size = new System.Drawing.Size(175, 37);
            this.lblEntryTime.TabIndex = 5;
            this.lblEntryTime.Text = "Time of entry:";
            // 
            // btnSubmit
            // 
            this.btnSubmit.Font = new System.Drawing.Font("Orbitron", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.btnSubmit.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.btnSubmit.Location = new System.Drawing.Point(363, 320);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(225, 57);
            this.btnSubmit.TabIndex = 4;
            this.btnSubmit.Text = "Submit";
            this.btnSubmit.UseVisualStyleBackColor = true;
            this.btnSubmit.Click += new System.EventHandler(this.btnSubmit_Click);
            // 
            // tbEntryPlace
            // 
            this.tbEntryPlace.Enabled = false;
            this.tbEntryPlace.Font = new System.Drawing.Font("Orbitron", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.tbEntryPlace.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.tbEntryPlace.Location = new System.Drawing.Point(363, 55);
            this.tbEntryPlace.Name = "tbEntryPlace";
            this.tbEntryPlace.Size = new System.Drawing.Size(225, 28);
            this.tbEntryPlace.TabIndex = 1;
            // 
            // lblEntryPlace
            // 
            this.lblEntryPlace.Font = new System.Drawing.Font("Orbitron", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.lblEntryPlace.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.lblEntryPlace.Location = new System.Drawing.Point(80, 55);
            this.lblEntryPlace.Name = "lblEntryPlace";
            this.lblEntryPlace.Size = new System.Drawing.Size(175, 37);
            this.lblEntryPlace.TabIndex = 0;
            this.lblEntryPlace.Text = "Entry place:";
            // 
            // TollCollectingWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 501);
            this.Controls.Add(this.panel1);
            this.Name = "TollCollectingWindow";
            this.Text = "TollCollectingWindow";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
        }

        private System.Windows.Forms.Label lblPrice;

        private System.Windows.Forms.ComboBox cbCategory;

        private System.Windows.Forms.Label lblSpeedLimit;

        private System.Windows.Forms.Label lblChange;

        private System.Windows.Forms.TextBox tbChange;
        private System.Windows.Forms.TextBox tbSpeedLimit;

        private System.Windows.Forms.Label lblDriversAmount;

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnSubmit;
        private System.Windows.Forms.TextBox tbEntryPlace;
        private System.Windows.Forms.Label lblEntryPlace;
        private System.Windows.Forms.Label lblEntryTime;
        private System.Windows.Forms.TextBox tbEntryTime;
        private System.Windows.Forms.Label lblNumOfPlates;
        private System.Windows.Forms.TextBox tbNumOfPlates;
        private System.Windows.Forms.TextBox tbDriversAmount;
        private System.Windows.Forms.Label lblCategory;

        #endregion
    }
}