namespace WindowsFormsDatasourc_en_overwrite
{
    partial class WerknemmersAdd
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
            this.labelNaam = new System.Windows.Forms.Label();
            this.textNaam = new System.Windows.Forms.TextBox();
            this.labelLeef = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textGeslacht = new System.Windows.Forms.TextBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.numLeeftijd = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.numLeeftijd)).BeginInit();
            this.SuspendLayout();
            // 
            // labelNaam
            // 
            this.labelNaam.AutoSize = true;
            this.labelNaam.Location = new System.Drawing.Point(9, 12);
            this.labelNaam.Name = "labelNaam";
            this.labelNaam.Size = new System.Drawing.Size(35, 13);
            this.labelNaam.TabIndex = 0;
            this.labelNaam.Text = "Naam";
            // 
            // textNaam
            // 
            this.textNaam.Location = new System.Drawing.Point(64, 12);
            this.textNaam.Name = "textNaam";
            this.textNaam.Size = new System.Drawing.Size(100, 20);
            this.textNaam.TabIndex = 1;
            // 
            // labelLeef
            // 
            this.labelLeef.AutoSize = true;
            this.labelLeef.Location = new System.Drawing.Point(9, 41);
            this.labelLeef.Name = "labelLeef";
            this.labelLeef.Size = new System.Drawing.Size(41, 13);
            this.labelLeef.TabIndex = 2;
            this.labelLeef.Text = "Leeftijd";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 66);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Geslacth";
            // 
            // textGeslacht
            // 
            this.textGeslacht.Location = new System.Drawing.Point(64, 66);
            this.textGeslacht.Name = "textGeslacht";
            this.textGeslacht.Size = new System.Drawing.Size(100, 20);
            this.textGeslacht.TabIndex = 5;
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(74, 92);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 23);
            this.btnAdd.TabIndex = 6;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // numLeeftijd
            // 
            this.numLeeftijd.Location = new System.Drawing.Point(64, 38);
            this.numLeeftijd.Name = "numLeeftijd";
            this.numLeeftijd.Size = new System.Drawing.Size(120, 20);
            this.numLeeftijd.TabIndex = 7;
            // 
            // WerknemmersAdd
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(211, 129);
            this.Controls.Add(this.numLeeftijd);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.textGeslacht);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.labelLeef);
            this.Controls.Add(this.textNaam);
            this.Controls.Add(this.labelNaam);
            this.Name = "WerknemmersAdd";
            this.Text = "WerknemmersAdd";
            ((System.ComponentModel.ISupportInitialize)(this.numLeeftijd)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelNaam;
        private System.Windows.Forms.TextBox textNaam;
        private System.Windows.Forms.Label labelLeef;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textGeslacht;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.NumericUpDown numLeeftijd;
    }
}