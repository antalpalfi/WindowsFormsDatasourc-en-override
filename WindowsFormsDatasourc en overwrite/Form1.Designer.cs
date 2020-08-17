namespace WindowsFormsDatasourc_en_overwrite
{
    partial class Form1
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
            this.lbParkNaam = new System.Windows.Forms.Label();
            this.lbWernem = new System.Windows.Forms.ListBox();
            this.lboxAttractie = new System.Windows.Forms.ListBox();
            this.btnWerkNemToe = new System.Windows.Forms.Button();
            this.btnAttractie = new System.Windows.Forms.Button();
            this.btnWerknRem = new System.Windows.Forms.Button();
            this.labelNaam = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.labelGeslacth = new System.Windows.Forms.Label();
            this.btnAtrRemove = new System.Windows.Forms.Button();
            this.labelKleur = new System.Windows.Forms.Label();
            this.labelMinleeft = new System.Windows.Forms.Label();
            this.labelMAxP = new System.Windows.Forms.Label();
            this.pictureBoxPark = new System.Windows.Forms.PictureBox();
            this.lbKleur = new System.Windows.Forms.Label();
            this.lbMinLeef = new System.Windows.Forms.Label();
            this.lbMaxPer = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxPark)).BeginInit();
            this.SuspendLayout();
            // 
            // lbParkNaam
            // 
            this.lbParkNaam.AutoSize = true;
            this.lbParkNaam.Location = new System.Drawing.Point(155, 9);
            this.lbParkNaam.Name = "lbParkNaam";
            this.lbParkNaam.Size = new System.Drawing.Size(0, 13);
            this.lbParkNaam.TabIndex = 0;
            // 
            // lbWernem
            // 
            this.lbWernem.FormattingEnabled = true;
            this.lbWernem.Location = new System.Drawing.Point(3, 82);
            this.lbWernem.Name = "lbWernem";
            this.lbWernem.Size = new System.Drawing.Size(120, 95);
            this.lbWernem.TabIndex = 3;
            this.lbWernem.SelectedIndexChanged += new System.EventHandler(this.lbWernem_SelectedIndexChanged);
            // 
            // lboxAttractie
            // 
            this.lboxAttractie.FormattingEnabled = true;
            this.lboxAttractie.Location = new System.Drawing.Point(240, 82);
            this.lboxAttractie.Name = "lboxAttractie";
            this.lboxAttractie.Size = new System.Drawing.Size(120, 95);
            this.lboxAttractie.TabIndex = 4;
            this.lboxAttractie.SelectedIndexChanged += new System.EventHandler(this.lboxAttractie_SelectedIndexChanged);
            // 
            // btnWerkNemToe
            // 
            this.btnWerkNemToe.Location = new System.Drawing.Point(3, 52);
            this.btnWerkNemToe.Name = "btnWerkNemToe";
            this.btnWerkNemToe.Size = new System.Drawing.Size(55, 23);
            this.btnWerkNemToe.TabIndex = 5;
            this.btnWerkNemToe.Text = "Add";
            this.btnWerkNemToe.UseVisualStyleBackColor = true;
            this.btnWerkNemToe.Click += new System.EventHandler(this.btnWerkNemToe_Click);
            // 
            // btnAttractie
            // 
            this.btnAttractie.Location = new System.Drawing.Point(240, 52);
            this.btnAttractie.Name = "btnAttractie";
            this.btnAttractie.Size = new System.Drawing.Size(54, 23);
            this.btnAttractie.TabIndex = 6;
            this.btnAttractie.Text = "Add";
            this.btnAttractie.UseVisualStyleBackColor = true;
            this.btnAttractie.Click += new System.EventHandler(this.btnAttractie_Click);
            // 
            // btnWerknRem
            // 
            this.btnWerknRem.Location = new System.Drawing.Point(64, 52);
            this.btnWerknRem.Name = "btnWerknRem";
            this.btnWerknRem.Size = new System.Drawing.Size(59, 23);
            this.btnWerknRem.TabIndex = 7;
            this.btnWerknRem.Text = "Remove";
            this.btnWerknRem.UseVisualStyleBackColor = true;
            this.btnWerknRem.Click += new System.EventHandler(this.btnWerknRem_Click);
            // 
            // labelNaam
            // 
            this.labelNaam.AutoSize = true;
            this.labelNaam.Location = new System.Drawing.Point(35, 184);
            this.labelNaam.Name = "labelNaam";
            this.labelNaam.Size = new System.Drawing.Size(0, 13);
            this.labelNaam.TabIndex = 8;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 184);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 13);
            this.label1.TabIndex = 9;
            this.label1.Text = "Age:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 210);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 13);
            this.label2.TabIndex = 10;
            this.label2.Text = "Geslacht:";
            // 
            // labelGeslacth
            // 
            this.labelGeslacth.AutoSize = true;
            this.labelGeslacth.Location = new System.Drawing.Point(58, 210);
            this.labelGeslacth.Name = "labelGeslacth";
            this.labelGeslacth.Size = new System.Drawing.Size(0, 13);
            this.labelGeslacth.TabIndex = 11;
            // 
            // btnAtrRemove
            // 
            this.btnAtrRemove.Location = new System.Drawing.Point(300, 53);
            this.btnAtrRemove.Name = "btnAtrRemove";
            this.btnAtrRemove.Size = new System.Drawing.Size(60, 23);
            this.btnAtrRemove.TabIndex = 12;
            this.btnAtrRemove.Text = "Remove";
            this.btnAtrRemove.UseVisualStyleBackColor = true;
            this.btnAtrRemove.Click += new System.EventHandler(this.btnAtrRemove_Click);
            // 
            // labelKleur
            // 
            this.labelKleur.AutoSize = true;
            this.labelKleur.Location = new System.Drawing.Point(240, 184);
            this.labelKleur.Name = "labelKleur";
            this.labelKleur.Size = new System.Drawing.Size(34, 13);
            this.labelKleur.TabIndex = 13;
            this.labelKleur.Text = "Kleur:";
            // 
            // labelMinleeft
            // 
            this.labelMinleeft.AutoSize = true;
            this.labelMinleeft.Location = new System.Drawing.Point(237, 210);
            this.labelMinleeft.Name = "labelMinleeft";
            this.labelMinleeft.Size = new System.Drawing.Size(60, 13);
            this.labelMinleeft.TabIndex = 14;
            this.labelMinleeft.Text = "Min leeftijd:";
            // 
            // labelMAxP
            // 
            this.labelMAxP.AutoSize = true;
            this.labelMAxP.Location = new System.Drawing.Point(237, 233);
            this.labelMAxP.Name = "labelMAxP";
            this.labelMAxP.Size = new System.Drawing.Size(77, 13);
            this.labelMAxP.TabIndex = 15;
            this.labelMAxP.Text = "Max personen:";
            // 
            // pictureBoxPark
            // 
            this.pictureBoxPark.Location = new System.Drawing.Point(129, 25);
            this.pictureBoxPark.Name = "pictureBoxPark";
            this.pictureBoxPark.Size = new System.Drawing.Size(100, 152);
            this.pictureBoxPark.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxPark.TabIndex = 16;
            this.pictureBoxPark.TabStop = false;
            // 
            // lbKleur
            // 
            this.lbKleur.AutoSize = true;
            this.lbKleur.Location = new System.Drawing.Point(279, 184);
            this.lbKleur.Name = "lbKleur";
            this.lbKleur.Size = new System.Drawing.Size(0, 13);
            this.lbKleur.TabIndex = 17;
            // 
            // lbMinLeef
            // 
            this.lbMinLeef.AutoSize = true;
            this.lbMinLeef.Location = new System.Drawing.Point(297, 210);
            this.lbMinLeef.Name = "lbMinLeef";
            this.lbMinLeef.Size = new System.Drawing.Size(0, 13);
            this.lbMinLeef.TabIndex = 18;
            // 
            // lbMaxPer
            // 
            this.lbMaxPer.AutoSize = true;
            this.lbMaxPer.Location = new System.Drawing.Point(314, 233);
            this.lbMaxPer.Name = "lbMaxPer";
            this.lbMaxPer.Size = new System.Drawing.Size(0, 13);
            this.lbMaxPer.TabIndex = 19;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(449, 305);
            this.Controls.Add(this.lbMaxPer);
            this.Controls.Add(this.lbMinLeef);
            this.Controls.Add(this.lbKleur);
            this.Controls.Add(this.pictureBoxPark);
            this.Controls.Add(this.labelMAxP);
            this.Controls.Add(this.labelMinleeft);
            this.Controls.Add(this.labelKleur);
            this.Controls.Add(this.btnAtrRemove);
            this.Controls.Add(this.labelGeslacth);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.labelNaam);
            this.Controls.Add(this.btnWerknRem);
            this.Controls.Add(this.btnAttractie);
            this.Controls.Add(this.btnWerkNemToe);
            this.Controls.Add(this.lboxAttractie);
            this.Controls.Add(this.lbWernem);
            this.Controls.Add(this.lbParkNaam);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxPark)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbParkNaam;
        private System.Windows.Forms.ListBox lbWernem;
        private System.Windows.Forms.ListBox lboxAttractie;
        private System.Windows.Forms.Button btnWerkNemToe;
        private System.Windows.Forms.Button btnAttractie;
        private System.Windows.Forms.Button btnWerknRem;
        private System.Windows.Forms.Label labelNaam;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label labelGeslacth;
        private System.Windows.Forms.Button btnAtrRemove;
        private System.Windows.Forms.Label labelKleur;
        private System.Windows.Forms.Label labelMinleeft;
        private System.Windows.Forms.Label labelMAxP;
        private System.Windows.Forms.PictureBox pictureBoxPark;
        private System.Windows.Forms.Label lbKleur;
        private System.Windows.Forms.Label lbMinLeef;
        private System.Windows.Forms.Label lbMaxPer;
    }
}

