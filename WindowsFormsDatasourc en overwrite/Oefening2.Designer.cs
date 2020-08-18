namespace WindowsFormsDatasourc_en_overwrite
{
    partial class Oefening2
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.listbDoktors = new System.Windows.Forms.ListBox();
            this.label3 = new System.Windows.Forms.Label();
            this.listbAfspraak = new System.Windows.Forms.ListBox();
            this.btnAfsNew = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(97, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(97, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Hells Pass Hospital";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(42, 36);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Doktors";
            // 
            // listbDoktors
            // 
            this.listbDoktors.FormattingEnabled = true;
            this.listbDoktors.Location = new System.Drawing.Point(1, 52);
            this.listbDoktors.Name = "listbDoktors";
            this.listbDoktors.Size = new System.Drawing.Size(120, 95);
            this.listbDoktors.TabIndex = 2;
            this.listbDoktors.SelectedIndexChanged += new System.EventHandler(this.listbDoktors_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(160, 36);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(96, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Geboekt Afspraak ";
            // 
            // listbAfspraak
            // 
            this.listbAfspraak.FormattingEnabled = true;
            this.listbAfspraak.Location = new System.Drawing.Point(148, 52);
            this.listbAfspraak.Name = "listbAfspraak";
            this.listbAfspraak.Size = new System.Drawing.Size(120, 95);
            this.listbAfspraak.TabIndex = 4;
            // 
            // btnAfsNew
            // 
            this.btnAfsNew.Location = new System.Drawing.Point(1, 153);
            this.btnAfsNew.Name = "btnAfsNew";
            this.btnAfsNew.Size = new System.Drawing.Size(115, 23);
            this.btnAfsNew.TabIndex = 5;
            this.btnAfsNew.Text = "New afspraak";
            this.btnAfsNew.UseVisualStyleBackColor = true;
            this.btnAfsNew.Click += new System.EventHandler(this.btnAfsNew_Click);
            // 
            // Oefening2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(598, 450);
            this.Controls.Add(this.btnAfsNew);
            this.Controls.Add(this.listbAfspraak);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.listbDoktors);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Oefening2";
            this.Text = "Oefening2";
            this.Load += new System.EventHandler(this.Oefening2_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ListBox listbDoktors;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ListBox listbAfspraak;
        private System.Windows.Forms.Button btnAfsNew;
    }
}