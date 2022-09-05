using System.ComponentModel;

namespace SIMS.View
{
    partial class EntryChooseWindow
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
            this.cbVehicleType = new System.Windows.Forms.ComboBox();
            this.cbStation = new System.Windows.Forms.ComboBox();
            this.btnSubmit = new System.Windows.Forms.Button();
            this.lblVehicleType = new System.Windows.Forms.Label();
            this.lblEntryStation = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.panel1.Controls.Add(this.cbVehicleType);
            this.panel1.Controls.Add(this.cbStation);
            this.panel1.Controls.Add(this.btnSubmit);
            this.panel1.Controls.Add(this.lblVehicleType);
            this.panel1.Controls.Add(this.lblEntryStation);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(776, 357);
            this.panel1.TabIndex = 2;
            // 
            // cbVehicleType
            // 
            this.cbVehicleType.FormattingEnabled = true;
            this.cbVehicleType.Location = new System.Drawing.Point(383, 153);
            this.cbVehicleType.Name = "cbVehicleType";
            this.cbVehicleType.Size = new System.Drawing.Size(223, 24);
            this.cbVehicleType.TabIndex = 6;
            // 
            // cbStation
            // 
            this.cbStation.FormattingEnabled = true;
            this.cbStation.Location = new System.Drawing.Point(383, 89);
            this.cbStation.Name = "cbStation";
            this.cbStation.Size = new System.Drawing.Size(223, 24);
            this.cbStation.TabIndex = 5;
            // 
            // btnSubmit
            // 
            this.btnSubmit.Font = new System.Drawing.Font("Orbitron", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.btnSubmit.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.btnSubmit.Location = new System.Drawing.Point(383, 229);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(223, 57);
            this.btnSubmit.TabIndex = 4;
            this.btnSubmit.Text = "Submit";
            this.btnSubmit.UseVisualStyleBackColor = true;
            this.btnSubmit.Click += new System.EventHandler(this.btnSubmit_Click);
            // 
            // lblVehicleType
            // 
            this.lblVehicleType.Font = new System.Drawing.Font("Orbitron", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.lblVehicleType.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.lblVehicleType.Location = new System.Drawing.Point(86, 153);
            this.lblVehicleType.Name = "lblVehicleType";
            this.lblVehicleType.Size = new System.Drawing.Size(172, 37);
            this.lblVehicleType.TabIndex = 2;
            this.lblVehicleType.Text = "Vehicle type:";
            // 
            // lblEntryStation
            // 
            this.lblEntryStation.Font = new System.Drawing.Font("Orbitron", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.lblEntryStation.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.lblEntryStation.Location = new System.Drawing.Point(86, 89);
            this.lblEntryStation.Name = "lblEntryStation";
            this.lblEntryStation.Size = new System.Drawing.Size(172, 37);
            this.lblEntryStation.TabIndex = 0;
            this.lblEntryStation.Text = "Entry station:";
            // 
            // EntryChooseWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 389);
            this.Controls.Add(this.panel1);
            this.Name = "EntryChooseWindow";
            this.Text = "EntryChooseWindow";
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
        }

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnSubmit;
        private System.Windows.Forms.Label lblVehicleType;
        private System.Windows.Forms.Label lblEntryStation;
        private System.Windows.Forms.ComboBox cbStation;
        private System.Windows.Forms.ComboBox cbVehicleType;

        #endregion
    }
}