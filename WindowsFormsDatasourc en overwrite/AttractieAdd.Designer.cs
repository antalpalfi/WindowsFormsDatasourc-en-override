namespace WindowsFormsDatasourc_en_overwrite
{
    partial class AttractieAdd
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
            this.txtNaam = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.numLeef = new System.Windows.Forms.NumericUpDown();
            this.numMaxPers = new System.Windows.Forms.NumericUpDown();
            this.button1 = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.txtKleur = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.numLeef)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numMaxPers)).BeginInit();
            this.SuspendLayout();
            // 
            // txtNaam
            // 
            this.txtNaam.Location = new System.Drawing.Point(96, 9);
            this.txtNaam.Name = "txtNaam";
            this.txtNaam.Size = new System.Drawing.Size(120, 20);
            this.txtNaam.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Naam";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 43);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Min leeftijd";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(16, 74);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(74, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Max personen";
            // 
            // numLeef
            // 
            this.numLeef.Location = new System.Drawing.Point(96, 41);
            this.numLeef.Name = "numLeef";
            this.numLeef.Size = new System.Drawing.Size(120, 20);
            this.numLeef.TabIndex = 4;
            // 
            // numMaxPers
            // 
            this.numMaxPers.Location = new System.Drawing.Point(96, 74);
            this.numMaxPers.Name = "numMaxPers";
            this.numMaxPers.Size = new System.Drawing.Size(120, 20);
            this.numMaxPers.TabIndex = 5;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(121, 130);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 6;
            this.button1.Text = "Add";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(19, 111);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(31, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Kleur";
            // 
            // txtKleur
            // 
            this.txtKleur.Location = new System.Drawing.Point(96, 104);
            this.txtKleur.Name = "txtKleur";
            this.txtKleur.Size = new System.Drawing.Size(120, 20);
            this.txtKleur.TabIndex = 8;
            // 
            // AttractieAdd
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(300, 219);
            this.Controls.Add(this.txtKleur);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.numMaxPers);
            this.Controls.Add(this.numLeef);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtNaam);
            this.Name = "AttractieAdd";
            this.Text = "AttractieAdd";
            this.Load += new System.EventHandler(this.AttractieAdd_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numLeef)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numMaxPers)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtNaam;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown numLeef;
        private System.Windows.Forms.NumericUpDown numMaxPers;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtKleur;
    }
}