namespace WindowsFormsApplication1
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
            this.dodaj = new System.Windows.Forms.Button();
            this.szukaj = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // dodaj
            // 
            this.dodaj.Location = new System.Drawing.Point(78, 158);
            this.dodaj.Name = "dodaj";
            this.dodaj.Size = new System.Drawing.Size(193, 56);
            this.dodaj.TabIndex = 0;
            this.dodaj.Text = "Dodaj Produkt";
            this.dodaj.UseVisualStyleBackColor = true;
            this.dodaj.Click += new System.EventHandler(this.dodaj_Click);
            // 
            // szukaj
            // 
            this.szukaj.Location = new System.Drawing.Point(78, 54);
            this.szukaj.Name = "szukaj";
            this.szukaj.Size = new System.Drawing.Size(193, 56);
            this.szukaj.TabIndex = 1;
            this.szukaj.Text = "Wyszuaj Produkt";
            this.szukaj.UseVisualStyleBackColor = true;
            this.szukaj.Click += new System.EventHandler(this.szukaj_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(337, 261);
            this.Controls.Add(this.szukaj);
            this.Controls.Add(this.dodaj);
            this.Name = "Form1";
            this.Text = "Zarządznie bazą produktów";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button dodaj;
        private System.Windows.Forms.Button szukaj;
    }
}

