﻿namespace WindowsFormsDatasourc_en_overwrite
{
    partial class Menu
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

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
            this.btnOef1 = new System.Windows.Forms.Button();
            this.btnOef2 = new System.Windows.Forms.Button();
            this.btnOef3 = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnOef1
            // 
            this.btnOef1.Location = new System.Drawing.Point(41, 12);
            this.btnOef1.Name = "btnOef1";
            this.btnOef1.Size = new System.Drawing.Size(75, 23);
            this.btnOef1.TabIndex = 0;
            this.btnOef1.Text = "Oefening1";
            this.btnOef1.UseVisualStyleBackColor = true;
            this.btnOef1.Click += new System.EventHandler(this.btnOef1_Click);
            // 
            // btnOef2
            // 
            this.btnOef2.Location = new System.Drawing.Point(41, 41);
            this.btnOef2.Name = "btnOef2";
            this.btnOef2.Size = new System.Drawing.Size(75, 23);
            this.btnOef2.TabIndex = 1;
            this.btnOef2.Text = "Oefening2";
            this.btnOef2.UseVisualStyleBackColor = true;
            this.btnOef2.Click += new System.EventHandler(this.btnOef2_Click);
            // 
            // btnOef3
            // 
            this.btnOef3.Location = new System.Drawing.Point(41, 70);
            this.btnOef3.Name = "btnOef3";
            this.btnOef3.Size = new System.Drawing.Size(75, 23);
            this.btnOef3.TabIndex = 2;
            this.btnOef3.Text = "Oefening3";
            this.btnOef3.UseVisualStyleBackColor = true;
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(41, 100);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(75, 23);
            this.btnClose.TabIndex = 3;
            this.btnClose.Text = "Sluit";
            this.btnClose.UseVisualStyleBackColor = true;
            // 
            // Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(150, 135);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnOef3);
            this.Controls.Add(this.btnOef2);
            this.Controls.Add(this.btnOef1);
            this.Name = "Menu";
            this.Text = "Menu";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnOef1;
        private System.Windows.Forms.Button btnOef2;
        private System.Windows.Forms.Button btnOef3;
        private System.Windows.Forms.Button btnClose;
    }
}