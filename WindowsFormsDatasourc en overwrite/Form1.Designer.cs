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
            // 
            // btnWerkNemToe
            // 
            this.btnWerkNemToe.Location = new System.Drawing.Point(12, 52);
            this.btnWerkNemToe.Name = "btnWerkNemToe";
            this.btnWerkNemToe.Size = new System.Drawing.Size(75, 23);
            this.btnWerkNemToe.TabIndex = 5;
            this.btnWerkNemToe.Text = "Add";
            this.btnWerkNemToe.UseVisualStyleBackColor = true;
            this.btnWerkNemToe.Click += new System.EventHandler(this.btnWerkNemToe_Click);
            // 
            // btnAttractie
            // 
            this.btnAttractie.Location = new System.Drawing.Point(240, 52);
            this.btnAttractie.Name = "btnAttractie";
            this.btnAttractie.Size = new System.Drawing.Size(75, 23);
            this.btnAttractie.TabIndex = 6;
            this.btnAttractie.Text = "Add";
            this.btnAttractie.UseVisualStyleBackColor = true;
            // 
            // btnWerknRem
            // 
            this.btnWerknRem.Location = new System.Drawing.Point(130, 118);
            this.btnWerknRem.Name = "btnWerknRem";
            this.btnWerknRem.Size = new System.Drawing.Size(75, 23);
            this.btnWerknRem.TabIndex = 7;
            this.btnWerknRem.Text = "Remove";
            this.btnWerknRem.UseVisualStyleBackColor = true;
            this.btnWerknRem.Click += new System.EventHandler(this.btnWerknRem_Click);
            // 
            // labelNaam
            // 
            this.labelNaam.AutoSize = true;
            this.labelNaam.Location = new System.Drawing.Point(44, 184);
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
            this.labelGeslacth.Location = new System.Drawing.Point(65, 210);
            this.labelGeslacth.Name = "labelGeslacth";
            this.labelGeslacth.Size = new System.Drawing.Size(0, 13);
            this.labelGeslacth.TabIndex = 11;
            // 
            // btnAtrRemove
            // 
            this.btnAtrRemove.Location = new System.Drawing.Point(366, 118);
            this.btnAtrRemove.Name = "btnAtrRemove";
            this.btnAtrRemove.Size = new System.Drawing.Size(75, 23);
            this.btnAtrRemove.TabIndex = 12;
            this.btnAtrRemove.Text = "Remove";
            this.btnAtrRemove.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(449, 305);
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
    }
}

