using System.ComponentModel;

namespace SIMS.View
{
    partial class StationEWindow
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
            this.components = new System.ComponentModel.Container();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.lblRamp = new System.Windows.Forms.Label();
            this.lblTime = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.lblStationsName = new System.Windows.Forms.Label();
            this.lblUsability = new System.Windows.Forms.Label();
            this.lblVehicleType = new System.Windows.Forms.Label();
            this.lblDateAndTime = new System.Windows.Forms.Label();
            this.btnSubmit = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize) (this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.dataGridView1);
            this.panel1.Controls.Add(this.lblRamp);
            this.panel1.Controls.Add(this.lblTime);
            this.panel1.Controls.Add(this.textBox1);
            this.panel1.Controls.Add(this.lblStationsName);
            this.panel1.Controls.Add(this.lblUsability);
            this.panel1.Controls.Add(this.lblVehicleType);
            this.panel1.Controls.Add(this.lblDateAndTime);
            this.panel1.Controls.Add(this.btnSubmit);
            this.panel1.Location = new System.Drawing.Point(35, 41);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(993, 488);
            this.panel1.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Orbitron", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.label1.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.label1.Location = new System.Drawing.Point(33, 333);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(149, 55);
            this.label1.TabIndex = 13;
            this.label1.Text = "Option";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.Disable;
            this.dataGridView1.ColumnHeadersVisible = false;
            this.dataGridView1.Enabled = false;
            this.dataGridView1.EnableHeadersVisualStyles = false;
            this.dataGridView1.Location = new System.Drawing.Point(248, 180);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.ShowEditingIcon = false;
            this.dataGridView1.Size = new System.Drawing.Size(703, 208);
            this.dataGridView1.TabIndex = 12;
            // 
            // lblRamp
            // 
            this.lblRamp.Font = new System.Drawing.Font("Orbitron", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.lblRamp.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.lblRamp.Location = new System.Drawing.Point(33, 290);
            this.lblRamp.Name = "lblRamp";
            this.lblRamp.Size = new System.Drawing.Size(372, 55);
            this.lblRamp.TabIndex = 11;
            this.lblRamp.Text = "Ramp:";
            // 
            // lblTime
            // 
            this.lblTime.Font = new System.Drawing.Font("Orbitron", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.lblTime.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.lblTime.Location = new System.Drawing.Point(248, 125);
            this.lblTime.Name = "lblTime";
            this.lblTime.Size = new System.Drawing.Size(425, 22);
            this.lblTime.TabIndex = 10;
            this.lblTime.Text = "label1";
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.textBox1.Font = new System.Drawing.Font("Orbitron", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.textBox1.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.textBox1.Location = new System.Drawing.Point(248, 70);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(218, 28);
            this.textBox1.TabIndex = 9;
            // 
            // lblStationsName
            // 
            this.lblStationsName.Font = new System.Drawing.Font("Orbitron", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.lblStationsName.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.lblStationsName.Location = new System.Drawing.Point(33, 70);
            this.lblStationsName.Name = "lblStationsName";
            this.lblStationsName.Size = new System.Drawing.Size(372, 55);
            this.lblStationsName.TabIndex = 8;
            this.lblStationsName.Text = "Station:";
            // 
            // lblUsability
            // 
            this.lblUsability.Font = new System.Drawing.Font("Orbitron", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.lblUsability.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.lblUsability.Location = new System.Drawing.Point(33, 235);
            this.lblUsability.Name = "lblUsability";
            this.lblUsability.Size = new System.Drawing.Size(372, 55);
            this.lblUsability.TabIndex = 7;
            this.lblUsability.Text = "Is in use:";
            // 
            // lblVehicleType
            // 
            this.lblVehicleType.Font = new System.Drawing.Font("Orbitron", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.lblVehicleType.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.lblVehicleType.Location = new System.Drawing.Point(33, 180);
            this.lblVehicleType.Name = "lblVehicleType";
            this.lblVehicleType.Size = new System.Drawing.Size(172, 55);
            this.lblVehicleType.TabIndex = 6;
            this.lblVehicleType.Text = "Vehicle type:";
            // 
            // lblDateAndTime
            // 
            this.lblDateAndTime.Font = new System.Drawing.Font("Orbitron", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.lblDateAndTime.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.lblDateAndTime.Location = new System.Drawing.Point(33, 125);
            this.lblDateAndTime.Name = "lblDateAndTime";
            this.lblDateAndTime.Size = new System.Drawing.Size(372, 55);
            this.lblDateAndTime.TabIndex = 5;
            this.lblDateAndTime.Text = "Date and time:";
            // 
            // btnSubmit
            // 
            this.btnSubmit.Font = new System.Drawing.Font("Orbitron", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.btnSubmit.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.btnSubmit.Location = new System.Drawing.Point(248, 413);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(225, 57);
            this.btnSubmit.TabIndex = 4;
            this.btnSubmit.Text = "Submit";
            this.btnSubmit.UseVisualStyleBackColor = true;
            this.btnSubmit.Click += new System.EventHandler(this.btnSubmit_Click);
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick_1);
            // 
            // StationEWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1058, 569);
            this.Controls.Add(this.panel1);
            this.Name = "StationEWindow";
            this.Text = "StationEWindow";
            this.Load += new System.EventHandler(this.StationEWindow_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize) (this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
        }

        private System.Windows.Forms.Label label1;

        private System.Windows.Forms.DataGridView dataGridView1;

        private System.Windows.Forms.Label lblRamp;


        private System.Windows.Forms.Label lblTime;

        private System.Windows.Forms.Timer timer1;

        private System.Windows.Forms.TextBox textBox1;

        private System.Windows.Forms.Label lblVehicleType;
        private System.Windows.Forms.Label lblUsability;
        private System.Windows.Forms.Label lblStationsName;

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnSubmit;
        private System.Windows.Forms.Label lblDateAndTime;

        #endregion
    }
}