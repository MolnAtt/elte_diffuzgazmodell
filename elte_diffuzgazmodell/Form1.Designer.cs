
namespace elte_diffuzgazmodell
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.vaszon = new System.Windows.Forms.PictureBox();
            this.gomb_folytonos = new System.Windows.Forms.Button();
            this.gomb_lepesenkent = new System.Windows.Forms.Button();
            this.gomb_csendes = new System.Windows.Forms.Button();
            this.gomb_vege = new System.Windows.Forms.Button();
            this.label_cim = new System.Windows.Forms.Label();
            this.label_cimke_lepesszam = new System.Windows.Forms.Label();
            this.label_lepesszam = new System.Windows.Forms.Label();
            this.tb_molekulaszám = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.gomb_uj = new System.Windows.Forms.Button();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.numericUpDown2 = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.vaszon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tb_molekulaszám)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown2)).BeginInit();
            this.SuspendLayout();
            // 
            // vaszon
            // 
            this.vaszon.BackColor = System.Drawing.Color.White;
            this.vaszon.Location = new System.Drawing.Point(12, 12);
            this.vaszon.Name = "vaszon";
            this.vaszon.Size = new System.Drawing.Size(10, 10);
            this.vaszon.TabIndex = 0;
            this.vaszon.TabStop = false;
            // 
            // gomb_folytonos
            // 
            this.gomb_folytonos.Location = new System.Drawing.Point(12, 274);
            this.gomb_folytonos.Name = "gomb_folytonos";
            this.gomb_folytonos.Size = new System.Drawing.Size(120, 44);
            this.gomb_folytonos.TabIndex = 1;
            this.gomb_folytonos.Text = "Folytonos";
            this.gomb_folytonos.UseVisualStyleBackColor = true;
            this.gomb_folytonos.Click += new System.EventHandler(this.gomb_folytonos_Click);
            // 
            // gomb_lepesenkent
            // 
            this.gomb_lepesenkent.Location = new System.Drawing.Point(143, 274);
            this.gomb_lepesenkent.Name = "gomb_lepesenkent";
            this.gomb_lepesenkent.Size = new System.Drawing.Size(120, 44);
            this.gomb_lepesenkent.TabIndex = 2;
            this.gomb_lepesenkent.Text = "Lépésenként";
            this.gomb_lepesenkent.UseVisualStyleBackColor = true;
            this.gomb_lepesenkent.Click += new System.EventHandler(this.gomb_lepesenkent_Click);
            // 
            // gomb_csendes
            // 
            this.gomb_csendes.Location = new System.Drawing.Point(274, 274);
            this.gomb_csendes.Name = "gomb_csendes";
            this.gomb_csendes.Size = new System.Drawing.Size(120, 44);
            this.gomb_csendes.TabIndex = 3;
            this.gomb_csendes.Text = "Csendes";
            this.gomb_csendes.UseVisualStyleBackColor = true;
            // 
            // gomb_vege
            // 
            this.gomb_vege.Location = new System.Drawing.Point(405, 274);
            this.gomb_vege.Name = "gomb_vege";
            this.gomb_vege.Size = new System.Drawing.Size(120, 44);
            this.gomb_vege.TabIndex = 4;
            this.gomb_vege.Text = "Vége";
            this.gomb_vege.UseVisualStyleBackColor = true;
            this.gomb_vege.Click += new System.EventHandler(this.gomb_vege_Click);
            // 
            // label_cim
            // 
            this.label_cim.AutoSize = true;
            this.label_cim.Location = new System.Drawing.Point(649, 12);
            this.label_cim.Name = "label_cim";
            this.label_cim.Size = new System.Drawing.Size(29, 15);
            this.label_cim.TabIndex = 5;
            this.label_cim.Text = "Cím";
            // 
            // label_cimke_lepesszam
            // 
            this.label_cimke_lepesszam.AutoSize = true;
            this.label_cimke_lepesszam.Location = new System.Drawing.Point(577, 50);
            this.label_cimke_lepesszam.Name = "label_cimke_lepesszam";
            this.label_cimke_lepesszam.Size = new System.Drawing.Size(85, 15);
            this.label_cimke_lepesszam.TabIndex = 6;
            this.label_cimke_lepesszam.Text = "Lépések száma";
            // 
            // label_lepesszam
            // 
            this.label_lepesszam.AutoSize = true;
            this.label_lepesszam.Location = new System.Drawing.Point(668, 50);
            this.label_lepesszam.Name = "label_lepesszam";
            this.label_lepesszam.Size = new System.Drawing.Size(13, 15);
            this.label_lepesszam.TabIndex = 7;
            this.label_lepesszam.Text = "0";
            // 
            // tb_molekulaszám
            // 
            this.tb_molekulaszám.Location = new System.Drawing.Point(577, 117);
            this.tb_molekulaszám.Maximum = new decimal(new int[] {
            10000000,
            0,
            0,
            0});
            this.tb_molekulaszám.Name = "tb_molekulaszám";
            this.tb_molekulaszám.Size = new System.Drawing.Size(120, 23);
            this.tb_molekulaszám.TabIndex = 8;
            this.tb_molekulaszám.Value = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(577, 90);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(101, 15);
            this.label1.TabIndex = 9;
            this.label1.Text = "Molekulák száma:";
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(577, 162);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(60, 19);
            this.checkBox1.TabIndex = 10;
            this.checkBox1.Text = "debug";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // gomb_uj
            // 
            this.gomb_uj.Location = new System.Drawing.Point(531, 274);
            this.gomb_uj.Name = "gomb_uj";
            this.gomb_uj.Size = new System.Drawing.Size(120, 44);
            this.gomb_uj.TabIndex = 11;
            this.gomb_uj.Text = "Új";
            this.gomb_uj.UseVisualStyleBackColor = true;
            this.gomb_uj.Click += new System.EventHandler(this.gomb_uj_Click);
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Location = new System.Drawing.Point(577, 191);
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(60, 23);
            this.numericUpDown1.TabIndex = 12;
            this.numericUpDown1.Value = new decimal(new int[] {
            50,
            0,
            0,
            0});
            // 
            // numericUpDown2
            // 
            this.numericUpDown2.Location = new System.Drawing.Point(643, 191);
            this.numericUpDown2.Name = "numericUpDown2";
            this.numericUpDown2.Size = new System.Drawing.Size(54, 23);
            this.numericUpDown2.TabIndex = 13;
            this.numericUpDown2.Value = new decimal(new int[] {
            50,
            0,
            0,
            0});
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.numericUpDown2);
            this.Controls.Add(this.numericUpDown1);
            this.Controls.Add(this.gomb_uj);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tb_molekulaszám);
            this.Controls.Add(this.label_lepesszam);
            this.Controls.Add(this.label_cimke_lepesszam);
            this.Controls.Add(this.label_cim);
            this.Controls.Add(this.gomb_vege);
            this.Controls.Add(this.gomb_csendes);
            this.Controls.Add(this.gomb_lepesenkent);
            this.Controls.Add(this.gomb_folytonos);
            this.Controls.Add(this.vaszon);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.vaszon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tb_molekulaszám)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox vaszon;
        private System.Windows.Forms.Button gomb_folytonos;
        private System.Windows.Forms.Button gomb_lepesenkent;
        private System.Windows.Forms.Button gomb_csendes;
        private System.Windows.Forms.Button gomb_vege;
        private System.Windows.Forms.Label label_cim;
        private System.Windows.Forms.Label label_cimke_lepesszam;
        private System.Windows.Forms.Label label_lepesszam;
        private System.Windows.Forms.NumericUpDown tb_molekulaszám;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.Button gomb_uj;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.NumericUpDown numericUpDown2;
    }
}

