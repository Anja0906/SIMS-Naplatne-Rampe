using System.ComponentModel;

namespace SIMS.View
{
    partial class AddStationWindow
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
            this.btnDeletePlace = new System.Windows.Forms.Button();
            this.btnUpdatePlace = new System.Windows.Forms.Button();
            this.btnSubmit = new System.Windows.Forms.Button();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.lblPlaces = new System.Windows.Forms.Label();
            this.tbName = new System.Windows.Forms.TextBox();
            this.btnAddPlace = new System.Windows.Forms.Button();
            this.lblName = new System.Windows.Forms.Label();
            this.tbId = new System.Windows.Forms.TextBox();
            this.lblId = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.panel1.Controls.Add(this.btnDeletePlace);
            this.panel1.Controls.Add(this.btnUpdatePlace);
            this.panel1.Controls.Add(this.btnSubmit);
            this.panel1.Controls.Add(this.listBox1);
            this.panel1.Controls.Add(this.lblPlaces);
            this.panel1.Controls.Add(this.tbName);
            this.panel1.Controls.Add(this.btnAddPlace);
            this.panel1.Controls.Add(this.lblName);
            this.panel1.Controls.Add(this.tbId);
            this.panel1.Controls.Add(this.lblId);
            this.panel1.Location = new System.Drawing.Point(35, 41);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(885, 457);
            this.panel1.TabIndex = 2;
            // 
            // btnDeletePlace
            // 
            this.btnDeletePlace.Font = new System.Drawing.Font("Orbitron", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.btnDeletePlace.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.btnDeletePlace.Location = new System.Drawing.Point(633, 274);
            this.btnDeletePlace.Name = "btnDeletePlace";
            this.btnDeletePlace.Size = new System.Drawing.Size(225, 57);
            this.btnDeletePlace.TabIndex = 10;
            this.btnDeletePlace.Text = "Delete place";
            this.btnDeletePlace.UseVisualStyleBackColor = true;
            this.btnDeletePlace.Click += new System.EventHandler(this.btnDeletePlace_Click);
            // 
            // btnUpdatePlace
            // 
            this.btnUpdatePlace.Font = new System.Drawing.Font("Orbitron", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.btnUpdatePlace.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.btnUpdatePlace.Location = new System.Drawing.Point(633, 172);
            this.btnUpdatePlace.Name = "btnUpdatePlace";
            this.btnUpdatePlace.Size = new System.Drawing.Size(225, 57);
            this.btnUpdatePlace.TabIndex = 9;
            this.btnUpdatePlace.Text = "Update place";
            this.btnUpdatePlace.UseVisualStyleBackColor = true;
            this.btnUpdatePlace.Click += new System.EventHandler(this.btnUpdatePlace_Click);
            // 
            // btnSubmit
            // 
            this.btnSubmit.Font = new System.Drawing.Font("Orbitron", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.btnSubmit.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.btnSubmit.Location = new System.Drawing.Point(633, 372);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(225, 57);
            this.btnSubmit.TabIndex = 8;
            this.btnSubmit.Text = "Submit";
            this.btnSubmit.UseVisualStyleBackColor = true;
            this.btnSubmit.Click += new System.EventHandler(this.btnSubmit_Click);
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.HorizontalScrollbar = true;
            this.listBox1.ItemHeight = 16;
            this.listBox1.Location = new System.Drawing.Point(49, 233);
            this.listBox1.Name = "listBox1";
            this.listBox1.ScrollAlwaysVisible = true;
            this.listBox1.Size = new System.Drawing.Size(550, 196);
            this.listBox1.TabIndex = 7;
            // 
            // lblPlaces
            // 
            this.lblPlaces.Font = new System.Drawing.Font("Orbitron", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.lblPlaces.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.lblPlaces.Location = new System.Drawing.Point(49, 188);
            this.lblPlaces.Name = "lblPlaces";
            this.lblPlaces.Size = new System.Drawing.Size(148, 37);
            this.lblPlaces.TabIndex = 6;
            this.lblPlaces.Text = "Places:";
            // 
            // tbName
            // 
            this.tbName.Font = new System.Drawing.Font("Orbitron", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.tbName.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.tbName.Location = new System.Drawing.Point(230, 124);
            this.tbName.Name = "tbName";
            this.tbName.Size = new System.Drawing.Size(225, 28);
            this.tbName.TabIndex = 5;
            // 
            // btnAddPlace
            // 
            this.btnAddPlace.Font = new System.Drawing.Font("Orbitron", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.btnAddPlace.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.btnAddPlace.Location = new System.Drawing.Point(633, 65);
            this.btnAddPlace.Name = "btnAddPlace";
            this.btnAddPlace.Size = new System.Drawing.Size(225, 57);
            this.btnAddPlace.TabIndex = 4;
            this.btnAddPlace.Text = "Add place";
            this.btnAddPlace.UseVisualStyleBackColor = true;
            this.btnAddPlace.Click += new System.EventHandler(this.btnAddPlace_Click);
            // 
            // lblName
            // 
            this.lblName.Font = new System.Drawing.Font("Orbitron", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.lblName.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.lblName.Location = new System.Drawing.Point(49, 124);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(148, 37);
            this.lblName.TabIndex = 2;
            this.lblName.Text = "Name:";
            // 
            // tbId
            // 
            this.tbId.Font = new System.Drawing.Font("Orbitron", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.tbId.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.tbId.Location = new System.Drawing.Point(230, 65);
            this.tbId.Name = "tbId";
            this.tbId.Size = new System.Drawing.Size(225, 28);
            this.tbId.TabIndex = 1;
            // 
            // lblId
            // 
            this.lblId.Font = new System.Drawing.Font("Orbitron", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.lblId.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.lblId.Location = new System.Drawing.Point(49, 65);
            this.lblId.Name = "lblId";
            this.lblId.Size = new System.Drawing.Size(129, 37);
            this.lblId.TabIndex = 0;
            this.lblId.Text = "Id:";
            // 
            // AddStationWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(944, 510);
            this.Controls.Add(this.panel1);
            this.Name = "AddStationWindow";
            this.Text = "AddStationWindow";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
        }

        private System.Windows.Forms.Button btnUpdatePlace;
        private System.Windows.Forms.Button btnDeletePlace;

        private System.Windows.Forms.Button btnAddPlace;

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnSubmit;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.TextBox tbId;
        private System.Windows.Forms.Label lblId;
        private System.Windows.Forms.TextBox tbName;
        private System.Windows.Forms.Label lblPlaces;
        private System.Windows.Forms.ListBox listBox1;

        #endregion
    }
}