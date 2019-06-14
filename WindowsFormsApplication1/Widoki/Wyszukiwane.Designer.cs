namespace WindowsFormsApplication1
{
    partial class Wyszukiwane
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
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.Szukaj = new System.Windows.Forms.Button();
            this.usun = new System.Windows.Forms.Button();
            this.modyfikacja = new System.Windows.Forms.Button();
            this.zamknij = new System.Windows.Forms.Button();
            this.marka = new System.Windows.Forms.TextBox();
            this.kategoria = new System.Windows.Forms.TextBox();
            this.f3 = new System.Windows.Forms.TextBox();
            this.f2 = new System.Windows.Forms.TextBox();
            this.f1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.zapisz = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.kod = new System.Windows.Forms.TextBox();
            this.ilosc = new System.Windows.Forms.TextBox();
            this.cena = new System.Windows.Forms.TextBox();
            this.Szukanie = new System.Windows.Forms.ComboBox();
            this.wroc = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Kategorie
            // 
            this.Kategorie.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Kategorie.FormattingEnabled = true;
            this.Kategorie.Location = new System.Drawing.Point(203, 30);
            this.Kategorie.Name = "Kategorie";
            this.Kategorie.Size = new System.Drawing.Size(121, 21);
            this.Kategorie.TabIndex = 0;
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.HorizontalScrollbar = true;
            this.listBox1.Location = new System.Drawing.Point(23, 84);
            this.listBox1.Name = "listBox1";
            this.listBox1.ScrollAlwaysVisible = true;
            this.listBox1.Size = new System.Drawing.Size(468, 199);
            this.listBox1.TabIndex = 1;
            // 
            // Szukaj
            // 
            this.Szukaj.Location = new System.Drawing.Point(365, 28);
            this.Szukaj.Name = "Szukaj";
            this.Szukaj.Size = new System.Drawing.Size(84, 23);
            this.Szukaj.TabIndex = 2;
            this.Szukaj.Text = "Szukaj";
            this.Szukaj.UseVisualStyleBackColor = true;
            this.Szukaj.Click += new System.EventHandler(this.Szukaj_Click);
            // 
            // usun
            // 
            this.usun.Location = new System.Drawing.Point(131, 299);
            this.usun.Name = "usun";
            this.usun.Size = new System.Drawing.Size(75, 23);
            this.usun.TabIndex = 3;
            this.usun.Text = "Usuń";
            this.usun.UseVisualStyleBackColor = true;
            this.usun.Click += new System.EventHandler(this.usun_Click);
            // 
            // modyfikacja
            // 
            this.modyfikacja.Location = new System.Drawing.Point(304, 299);
            this.modyfikacja.Name = "modyfikacja";
            this.modyfikacja.Size = new System.Drawing.Size(75, 23);
            this.modyfikacja.TabIndex = 4;
            this.modyfikacja.Text = "Modyfikuj";
            this.modyfikacja.UseVisualStyleBackColor = true;
            this.modyfikacja.Click += new System.EventHandler(this.modyfikacja_Click);
            // 
            // zamknij
            // 
            this.zamknij.Location = new System.Drawing.Point(244, 349);
            this.zamknij.Name = "zamknij";
            this.zamknij.Size = new System.Drawing.Size(75, 23);
            this.zamknij.TabIndex = 5;
            this.zamknij.Text = "Zamknij";
            this.zamknij.UseVisualStyleBackColor = true;
            this.zamknij.Click += new System.EventHandler(this.zamknij_Click);
            // 
            // marka
            // 
            this.marka.Location = new System.Drawing.Point(264, 84);
            this.marka.Name = "marka";
            this.marka.Size = new System.Drawing.Size(100, 20);
            this.marka.TabIndex = 47;
            this.marka.Visible = false;
            // 
            // kategoria
            // 
            this.kategoria.Location = new System.Drawing.Point(104, 84);
            this.kategoria.Name = "kategoria";
            this.kategoria.Size = new System.Drawing.Size(100, 20);
            this.kategoria.TabIndex = 46;
            this.kategoria.Visible = false;
            // 
            // f3
            // 
            this.f3.Location = new System.Drawing.Point(264, 244);
            this.f3.MaxLength = 20;
            this.f3.Name = "f3";
            this.f3.Size = new System.Drawing.Size(100, 20);
            this.f3.TabIndex = 45;
            this.f3.Visible = false;
            // 
            // f2
            // 
            this.f2.Location = new System.Drawing.Point(264, 218);
            this.f2.MaxLength = 20;
            this.f2.Name = "f2";
            this.f2.Size = new System.Drawing.Size(100, 20);
            this.f2.TabIndex = 44;
            this.f2.Visible = false;
            // 
            // f1
            // 
            this.f1.Location = new System.Drawing.Point(264, 192);
            this.f1.MaxLength = 20;
            this.f1.Name = "f1";
            this.f1.Size = new System.Drawing.Size(100, 20);
            this.f1.TabIndex = 43;
            this.f1.Visible = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(293, 176);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 13);
            this.label1.TabIndex = 42;
            this.label1.Text = "Funkcje";
            this.label1.Visible = false;
            // 
            // zapisz
            // 
            this.zapisz.Location = new System.Drawing.Point(244, 289);
            this.zapisz.Name = "zapisz";
            this.zapisz.Size = new System.Drawing.Size(131, 23);
            this.zapisz.TabIndex = 41;
            this.zapisz.Text = "Zapisz zmiany";
            this.zapisz.UseVisualStyleBackColor = true;
            this.zapisz.Visible = false;
            this.zapisz.Click += new System.EventHandler(this.zapisz_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(118, 176);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(71, 13);
            this.label6.TabIndex = 40;
            this.label6.Text = "Kod produktu";
            this.label6.Visible = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(241, 127);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(146, 13);
            this.label5.TabIndex = 39;
            this.label5.Text = "Ilość produktów w magazynie";
            this.label5.Visible = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(118, 127);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(77, 13);
            this.label4.TabIndex = 38;
            this.label4.Text = "Cena produktu";
            this.label4.Visible = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(301, 68);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(37, 13);
            this.label3.TabIndex = 37;
            this.label3.Text = "Marka";
            this.label3.Visible = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(128, 68);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 13);
            this.label2.TabIndex = 36;
            this.label2.Text = "Kategoria";
            this.label2.Visible = false;
            // 
            // kod
            // 
            this.kod.Enabled = false;
            this.kod.Location = new System.Drawing.Point(104, 192);
            this.kod.MaxLength = 12;
            this.kod.Name = "kod";
            this.kod.Size = new System.Drawing.Size(100, 20);
            this.kod.TabIndex = 35;
            this.kod.Visible = false;
            // 
            // ilosc
            // 
            this.ilosc.Location = new System.Drawing.Point(264, 143);
            this.ilosc.MaxLength = 8;
            this.ilosc.Name = "ilosc";
            this.ilosc.Size = new System.Drawing.Size(100, 20);
            this.ilosc.TabIndex = 34;
            this.ilosc.Visible = false;
            // 
            // cena
            // 
            this.cena.Location = new System.Drawing.Point(104, 143);
            this.cena.MaxLength = 6;
            this.cena.Name = "cena";
            this.cena.Size = new System.Drawing.Size(100, 20);
            this.cena.TabIndex = 33;
            this.cena.Visible = false;
            // 
            // Szukanie
            // 
            this.Szukanie.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Szukanie.FormattingEnabled = true;
            this.Szukanie.Items.AddRange(new object[] {
            "Wszystko",
            "Kategoria",
            "Marka",
            "Kraj pochodzenia"});
            this.Szukanie.Location = new System.Drawing.Point(52, 30);
            this.Szukanie.Name = "Szukanie";
            this.Szukanie.Size = new System.Drawing.Size(121, 21);
            this.Szukanie.TabIndex = 48;
            this.Szukanie.SelectedIndexChanged += new System.EventHandler(this.Szukanie_SelectedIndexChanged);
            // 
            // wroc
            // 
            this.wroc.Location = new System.Drawing.Point(416, 289);
            this.wroc.Name = "wroc";
            this.wroc.Size = new System.Drawing.Size(75, 23);
            this.wroc.TabIndex = 49;
            this.wroc.Text = "Wróć";
            this.wroc.UseVisualStyleBackColor = true;
            this.wroc.Visible = false;
            this.wroc.Click += new System.EventHandler(this.wroc_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(49, 14);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(85, 13);
            this.label7.TabIndex = 50;
            this.label7.Text = "Chcę wyszukać:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(200, 14);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(0, 13);
            this.label8.TabIndex = 51;
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(365, 57);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(100, 12);
            this.progressBar1.TabIndex = 52;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(104, 244);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 53;
            this.textBox1.Visible = false;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(104, 289);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(100, 20);
            this.textBox2.TabIndex = 54;
            this.textBox2.Visible = false;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(111, 225);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(89, 13);
            this.label9.TabIndex = 55;
            this.label9.Text = "Kraj pochodzenia";
            this.label9.Visible = false;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(128, 273);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(45, 13);
            this.label10.TabIndex = 56;
            this.label10.Text = "Fabryka";
            this.label10.Visible = false;
            // 
            // Wyszukiwane
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(521, 384);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.wroc);
            this.Controls.Add(this.Szukanie);
            this.Controls.Add(this.marka);
            this.Controls.Add(this.kategoria);
            this.Controls.Add(this.f3);
            this.Controls.Add(this.f2);
            this.Controls.Add(this.f1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.zapisz);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.kod);
            this.Controls.Add(this.ilosc);
            this.Controls.Add(this.cena);
            this.Controls.Add(this.zamknij);
            this.Controls.Add(this.modyfikacja);
            this.Controls.Add(this.usun);
            this.Controls.Add(this.Szukaj);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.Kategorie);
            this.Name = "Wyszukiwane";
            this.Text = "Wyszukiwanie";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox Kategorie;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Button Szukaj;
        private System.Windows.Forms.Button usun;
        private System.Windows.Forms.Button modyfikacja;
        private System.Windows.Forms.Button zamknij;
        private System.Windows.Forms.TextBox marka;
        private System.Windows.Forms.TextBox kategoria;
        private System.Windows.Forms.TextBox f3;
        private System.Windows.Forms.TextBox f2;
        private System.Windows.Forms.TextBox f1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button zapisz;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox kod;
        private System.Windows.Forms.TextBox ilosc;
        private System.Windows.Forms.TextBox cena;
        private System.Windows.Forms.ComboBox Szukanie;
        private System.Windows.Forms.Button wroc;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
    }
}