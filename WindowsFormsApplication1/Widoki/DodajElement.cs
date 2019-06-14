using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
	public partial class DodajElement : Form
	{

		public void Wyczysc()
		{
			textBox1.Text = "";
			textBox2.Text = "";
			cena.Text = "";
			ilosc.Text = "";
			Kategorie.Text = "";
			kod.Text = "";
			f1.Text = "";
			f2.Text = "";
			f3.Text = "";
			Marki.Text = "";
		}
		public DodajElement()
		{
			DaneDoCombo dane = new DaneDoCombo();
			List<string> katsy = dane.WezKategorie("AGD", "AGDCollection");
			katsy.Remove("Wszystko");
			List<string> marki = dane.WezMarki("AGD", "AGDCollection");
			marki.Remove("Wszystko");
			InitializeComponent();
			foreach (string item in katsy)
				Kategorie.Items.Add(item);
			foreach (string item in marki)
				Marki.Items.Add(item);
		}

		private async void Dodaj_Butt_Click(object sender, EventArgs e)
		{
			ManipulacjaDanymi manipulacja = new ManipulacjaDanymi();
			if (Kategorie.Text == "" || Marki.Text == "" || cena.Text == "" || ilosc.Text == "" || kod.Text == "" || textBox1.Text == "")
			{
				string message = "Należy wypełnić pola: Kategoria, Marka, Cena, Ilosc, Kod Produktu oraz Kraj pochodzenia. Produkt nie został dodany.";
				string caption = "Błąd!";
				MessageBoxButtons buttons = MessageBoxButtons.OK;
				MessageBox.Show(message, caption, buttons);
			}
			else
			{
				try
				{
					await manipulacja.DodawanieProduktu(kod.Text, Convert.ToInt32(cena.Text), Marki.Text,
						 Kategorie.Text, Convert.ToInt32(ilosc.Text), new List<string>
						 { f1.Text,f2.Text,f3.Text}, new List<string> { textBox1.Text, textBox2.Text });
					Wyczysc();
				}
				catch
				{
					string message = "Wystapił nieoczekiwany błąd. Cena i ilość muszą być liczbą, sprawdź czy poprawnie wypełniłeś te komórki.";
					string caption = "Błąd!";
					MessageBoxButtons buttons = MessageBoxButtons.OK;
					MessageBox.Show(message, caption, buttons);
				}
			}
		}

		private void zamknij_Click(object sender, EventArgs e)
		{
			this.Close();
		}
	}
}
