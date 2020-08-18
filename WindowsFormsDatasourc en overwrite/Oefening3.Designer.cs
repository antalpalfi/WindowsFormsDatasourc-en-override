namespace WindowsFormsDatasourc_en_overwrite
{
    partial class Oefening3
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
            this.txtNaam = new System.Windows.Forms.TextBox();
            this.numAge = new System.Windows.Forms.NumericUpDown();
            this.rdbMan = new System.Windows.Forms.RadioButton();
            this.rdbVrouw = new System.Windows.Forms.RadioButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btnRegist = new System.Windows.Forms.Button();
            this.btnKiez = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.numAge)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(60, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(78, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Tango Milonga";
            // 
            // txtNaam
            // 
            this.txtNaam.Location = new System.Drawing.Point(64, 39);
            this.txtNaam.Name = "txtNaam";
            this.txtNaam.Size = new System.Drawing.Size(120, 20);
            this.txtNaam.TabIndex = 1;
            // 
            // numAge
            // 
            this.numAge.Location = new System.Drawing.Point(64, 65);
            this.numAge.Name = "numAge";
            this.numAge.Size = new System.Drawing.Size(120, 20);
            this.numAge.TabIndex = 2;
            // 
            // rdbMan
            // 
            this.rdbMan.AutoSize = true;
            this.rdbMan.Location = new System.Drawing.Point(6, 19);
            this.rdbMan.Name = "rdbMan";
            this.rdbMan.Size = new System.Drawing.Size(46, 17);
            this.rdbMan.TabIndex = 3;
            this.rdbMan.TabStop = true;
            this.rdbMan.Text = "Man";
            this.rdbMan.UseVisualStyleBackColor = true;
            // 
            // rdbVrouw
            // 
            this.rdbVrouw.AutoSize = true;
            this.rdbVrouw.Location = new System.Drawing.Point(6, 41);
            this.rdbVrouw.Name = "rdbVrouw";
            this.rdbVrouw.Size = new System.Drawing.Size(55, 17);
            this.rdbVrouw.TabIndex = 4;
            this.rdbVrouw.TabStop = true;
            this.rdbVrouw.Text = "Vrouw";
            this.rdbVrouw.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rdbVrouw);
            this.groupBox1.Controls.Add(this.rdbMan);
            this.groupBox1.Location = new System.Drawing.Point(63, 91);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(121, 70);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "groupBox1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 39);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Naam";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 67);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Leeftijd";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 110);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(49, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Geslacht";
            // 
            // btnRegist
            // 
            this.btnRegist.Location = new System.Drawing.Point(28, 176);
            this.btnRegist.Name = "btnRegist";
            this.btnRegist.Size = new System.Drawing.Size(75, 23);
            this.btnRegist.TabIndex = 9;
            this.btnRegist.Text = "Register";
            this.btnRegist.UseVisualStyleBackColor = true;
            this.btnRegist.Click += new System.EventHandler(this.btnRegist_Click);
            // 
            // btnKiez
            // 
            this.btnKiez.Location = new System.Drawing.Point(126, 176);
            this.btnKiez.Name = "btnKiez";
            this.btnKiez.Size = new System.Drawing.Size(75, 23);
            this.btnKiez.TabIndex = 10;
            this.btnKiez.Text = "Kiezen";
            this.btnKiez.UseVisualStyleBackColor = true;
            this.btnKiez.Click += new System.EventHandler(this.btnKiez_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(190, 67);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(39, 13);
            this.label5.TabIndex = 11;
            this.label5.Text = "Min 18";
            // 
            // Oefening3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(262, 206);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btnKiez);
            this.Controls.Add(this.btnRegist);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.numAge);
            this.Controls.Add(this.txtNaam);
            this.Controls.Add(this.label1);
            this.Name = "Oefening3";
            this.Text = "Oefening3";
            this.Load += new System.EventHandler(this.Oefening3_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numAge)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtNaam;
        private System.Windows.Forms.NumericUpDown numAge;
        private System.Windows.Forms.RadioButton rdbMan;
        private System.Windows.Forms.RadioButton rdbVrouw;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnRegist;
        private System.Windows.Forms.Button btnKiez;
        private System.Windows.Forms.Label label5;
    }
}