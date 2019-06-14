namespace WindowsFormsApplication1
{
    partial class DodajElement
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
            this.Kategorie = new System.Windows.Forms.ComboBox();
            this.Marki = new System.Windows.Forms.ComboBox();
            this.cena = new System.Windows.Forms.TextBox();
            this.ilosc = new System.Windows.Forms.TextBox();
            this.kod = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.Dodaj_Butt = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.f1 = new System.Windows.Forms.TextBox();
            this.f2 = new System.Windows.Forms.TextBox();
            this.f3 = new System.Windows.Forms.TextBox();
            this.zamknij = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Kategorie
            // 
            this.Kategorie.FormattingEnabled = true;
            this.Kategorie.Location = new System.Drawing.Point(20, 35);
            this.Kategorie.MaxDropDownItems = 20;
            this.Kategorie.MaxLength = 20;
            this.Kategorie.Name = "Kategorie";
            this.Kategorie.Size = new System.Drawing.Size(121, 21);
            this.Kategorie.TabIndex = 1;
            // 
            // Marki
            // 
            this.Marki.FormattingEnabled = true;
            this.Marki.Location = new System.Drawing.Point(183, 35);
            this.Marki.MaxDropDownItems = 20;
            this.Marki.MaxLength = 20;
            this.Marki.Name = "Marki";
            this.Marki.Size = new System.Drawing.Size(121, 21);
            this.Marki.TabIndex = 2;
            // 
            // cena
            // 
            this.cena.Location = new System.Drawing.Point(27, 93);
            this.cena.MaxLength = 6;
            this.cena.Name = "cena";
            this.cena.Size = new System.Drawing.Size(100, 20);
            this.cena.TabIndex = 3;
            // 
            // ilosc
            // 
            this.ilosc.Location = new System.Drawing.Point(187, 93);
            this.ilosc.MaxLength = 8;
            this.ilosc.Name = "ilosc";
            this.ilosc.Size = new System.Drawing.Size(100, 20);
            this.ilosc.TabIndex = 4;
            // 
            // kod
            // 
            this.kod.Location = new System.Drawing.Point(27, 142);
            this.kod.MaxLength = 12;
            this.kod.Name = "kod";
            this.kod.Size = new System.Drawing.Size(100, 20);
            this.kod.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(52, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Kategoria";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(229, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(37, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Marka";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(41, 77);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(77, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Cena produktu";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(164, 77);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(146, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "Ilość produktów w magazynie";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(41, 126);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(71, 13);
            this.label6.TabIndex = 10;
            this.label6.Text = "Kod produktu";
            // 
            // Dodaj_Butt
            // 
            this.Dodaj_Butt.Location = new System.Drawing.Point(167, 245);
            this.Dodaj_Butt.Name = "Dodaj_Butt";
            this.Dodaj_Butt.Size = new System.Drawing.Size(131, 23);
            this.Dodaj_Butt.TabIndex = 11;
            this.Dodaj_Butt.Text = "Dodaj Produkt";
            this.Dodaj_Butt.UseVisualStyleBackColor = true;
            this.Dodaj_Butt.Click += new System.EventHandler(this.Dodaj_Butt_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(216, 126);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 13);
            this.label1.TabIndex = 12;
            this.label1.Text = "Funkcje";
            // 
            // f1
            // 
            this.f1.Location = new System.Drawing.Point(187, 142);
            this.f1.MaxLength = 20;
            this.f1.Name = "f1";
            this.f1.Size = new System.Drawing.Size(100, 20);
            this.f1.TabIndex = 13;
            // 
            // f2
            // 
            this.f2.Location = new System.Drawing.Point(187, 168);
            this.f2.MaxLength = 20;
            this.f2.Name = "f2";
            this.f2.Size = new System.Drawing.Size(100, 20);
            this.f2.TabIndex = 14;
            // 
            // f3
            // 
            this.f3.Location = new System.Drawing.Point(187, 194);
            this.f3.MaxLength = 20;
            this.f3.Name = "f3";
            this.f3.Size = new System.Drawing.Size(100, 20);
            this.f3.TabIndex = 15;
            // 
            // zamknij
            // 
            this.zamknij.Location = new System.Drawing.Point(129, 295);
            this.zamknij.Name = "zamknij";
            this.zamknij.Size = new System.Drawing.Size(75, 23);
            this.zamknij.TabIndex = 16;
            this.zamknij.Text = "Zamknij";
            this.zamknij.UseVisualStyleBackColor = true;
            this.zamknij.Click += new System.EventHandler(this.zamknij_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(27, 185);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 17;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(27, 236);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(100, 20);
            this.textBox2.TabIndex = 18;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(29, 169);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(89, 13);
            this.label7.TabIndex = 19;
            this.label7.Text = "Kraj pochodzenia";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(44, 217);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(45, 13);
            this.label8.TabIndex = 20;
            this.label8.Text = "Fabryka";
            // 
            // DodajElement
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(340, 330);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.zamknij);
            this.Controls.Add(this.f3);
            this.Controls.Add(this.f2);
            this.Controls.Add(this.f1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Dodaj_Butt);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.kod);
            this.Controls.Add(this.ilosc);
            this.Controls.Add(this.cena);
            this.Controls.Add(this.Marki);
            this.Controls.Add(this.Kategorie);
            this.Name = "DodajElement";
            this.Text = "DodajElement";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ComboBox Kategorie;
        private System.Windows.Forms.ComboBox Marki;
        private System.Windows.Forms.TextBox cena;
        private System.Windows.Forms.TextBox ilosc;
        private System.Windows.Forms.TextBox kod;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button Dodaj_Butt;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox f1;
        private System.Windows.Forms.TextBox f2;
        private System.Windows.Forms.TextBox f3;
        private System.Windows.Forms.Button zamknij;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
    }
}