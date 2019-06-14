using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
	public partial class Wyszukiwane : Form
	{

		PrzeszukiwanieBazy przeszukiwanie = new PrzeszukiwanieBazy();
		ManipulacjaDanymi manipulacja = new ManipulacjaDanymi();
		DaneDoCombo daneDoCombo = new DaneDoCombo();
		private void Blad(string komunikat)
		{
			MessageBox.Show(komunikat, "Błąd!", MessageBoxButtons.OK);
		}
		public void ModyfOkno()
		{
			label10.Visible = true;
			label9.Visible = true;
			textBox1.Visible = true;
			textBox2.Visible = true;
			progressBar1.Visible = false;
			Szukanie.Visible = false;
			label8.Visible = false;
			label7.Visible = false;
			wroc.Visible = true;
			listBox1.Visible = false;
			ilosc.Visible = true;
			label5.Visible = true;
			label6.Visible = true;
			zapisz.Visible = true;
			f3.Visible = true;
			f2.Visible = true;
			f1.Visible = true;
			Kategorie.Visible = false;
			Szukaj.Visible = false;
			usun.Visible = false;
			modyfikacja.Visible = false;
			label4.Visible = true;
			cena.Visible = true;
			kod.Visible = true;
			label1.Visible = true;
			label2.Visible = true;
			kategoria.Visible = true;
			label3.Visible = true;
			marka.Visible = true;
		}//zmiana wydocznosci elementów, aby pokazać układ okna przeznaczony do modyfikacji elementów
		public void SzukOkno()
		{
			label10.Visible = false;
			label9.Visible = false;
			textBox1.Visible = false;
			textBox2.Visible = false;
			progressBar1.Visible = true;
			Szukanie.Visible = true;
			label7.Visible = true;
			label8.Visible = true;
			wroc.Visible = false;
			kod.Visible = false;
			label1.Visible = false;
			label2.Visible = false;
			kategoria.Visible = false;
			label3.Visible = false;
			marka.Visible = false;
			label4.Visible = false;
			cena.Visible = false;
			ilosc.Visible = false;
			label5.Visible = false;
			label6.Visible = false;
			zapisz.Visible = false;
			f3.Visible = false;
			f2.Visible = false;
			f1.Visible = false;
			Kategorie.Visible = true;
			Szukaj.Visible = true;
			usun.Visible = true;
			modyfikacja.Visible = true;
			listBox1.Visible = true;
		}//zmiana wydocznosci elementów, aby pokazać układ okna przeznaczony do wyszukiwania elementów
		public Wyszukiwane()
		{
			InitializeComponent();
		}

		private void Szukaj_Click(object sender, EventArgs e)
		{
			listBox1.Items.Clear(); //czysci pole z danymi pobranymi z bazy
			this.Text = "Wyszukiwanie";
			string formatWyswietlania = "{0,-15}{1,-22}{2,-22}{3,-10}{4,-8}{5,-70}"; // format wyswietlania wiersza z danymi
			listBox1.Items.Add(string.Format(formatWyswietlania, "Kod", "Kategoria", "Marka", "Cena", "Ilość", "Funkcje")); // dodanie tytułów kolumn
			List<Produkt> listaKategorii = new List<Produkt>();
			if (Szukanie.Text == "Kategoria") //szukanie po kategorii
			{
				if (Kategorie.Text != "")
					listaKategorii = przeszukiwanie.WyszukajKategoria("AGD", "AGDCollection", Kategorie.Text);
				else
					Blad("Nie wybrano kategorii.");
			}
			else if (Szukanie.Text == "Marka") //szukanie po marce
			{
				if (Kategorie.Text != "")
					listaKategorii = przeszukiwanie.WyszukajMarka("AGD", "AGDCollection", Kategorie.Text);
				else
					Blad("Nie wybrano marki.");
			}
			else if (Szukanie.Text == "Kraj pochodzenia") //szukanie po marce
			{
				if (Kategorie.Text != "")
					listaKategorii = przeszukiwanie.WyszukajKraje("AGD", "AGDCollection", Kategorie.Text);
				else
					Blad("Nie wybrano kraju pochodzenia.");

			}
			else if (Szukanie.Text == "Wszystko") // wyswietlenie wszystkiego
				listaKategorii = przeszukiwanie.WyszukajMarka("AGD", "AGDCollection", "Wszystko");

			else //przy braku kryteriów wyszukiwania
			{
				listaKategorii = null;
			}
			if (listaKategorii != null)
			{
				progressBar1.Value = 0;
				progressBar1.Maximum = listaKategorii.Count;
				progressBar1.Step = 1;
				foreach (Produkt item in listaKategorii) //dodawanie elementów do wyswietlanych elementów
				{
					listBox1.Items.Add(string.Format(formatWyswietlania, item.id, item.kategoria, item.marka, item.cena.ToString(), item.ilosc.ToString(), item.funkcje.funkcja1 + " " + item.funkcje.funkcja2 + " " + item.funkcje.funkcja3));
					progressBar1.PerformStep();
				}
			}
			else
				Blad("Nie wybrano kryteriów wyszukiwania");
		}

		private async void usun_Click(object sender, EventArgs e)
		{
			if (listBox1.SelectedIndices.Count == 1 && listBox1.SelectedIndex > 0) //kontrola wybranego elementu
			{
				string message = "Czy jestes pewien, ze chcesz usunac produkt?";
				string caption = "Info";
				MessageBoxButtons buttons = MessageBoxButtons.YesNo;
				DialogResult result;
				result = MessageBox.Show(message, caption, buttons);
				if (result == System.Windows.Forms.DialogResult.Yes) //usuwanie jeżeli użytkownik potwierdzi
				{
					string aa = listBox1.SelectedItem.ToString();
					string id = "";
					for (int i = 0; aa[i] != ' '; i++)
						id += aa[i];
					await manipulacja.UsunDokument("AGD", "AGDCollection", id);
					Szukaj_Click(sender, e);
				}
			}
			else
				Blad("Nie wybrano elementu z listy");
		}

		private void modyfikacja_Click(object sender, EventArgs e)
		{
			if (listBox1.SelectedIndices.Count == 1 && listBox1.SelectedIndex > 0) //kontrola wybranego elementu
			{
				this.Text = "Modyfikacja danych";
				string mod = listBox1.SelectedItem.ToString();
				string produkt = "";
				for (int i = 0; mod[i] != ' '; i++)
				{
					produkt += mod[i];
				}
				Produkt modi = przeszukiwanie.WyszukajPoID("AGD", "AGDCollection", produkt);
				kod.Text = modi.id;
				kategoria.Text = modi.kategoria;
				cena.Text = modi.cena.ToString();
				ilosc.Text = modi.ilosc.ToString();
				marka.Text = modi.marka;
				f1.Text = modi.funkcje.funkcja1;
				f2.Text = modi.funkcje.funkcja2;
				f3.Text = modi.funkcje.funkcja3;
				textBox1.Text = modi.info.krajPochodzenia;
				textBox2.Text = modi.info.fabryka;
				ModyfOkno();
			}
			else
				Blad("Nie wybrano elementu z listy");
		}

		private void zamknij_Click(object sender, EventArgs e)
		{
			this.Close();
		}

		private async void zapisz_Click(object sender, EventArgs e)
		{
			try //modyfikacja produktu i kontrola poprawnosci wykonania
			{

				Produkt pp = new Produkt
				{
					id = kod.Text,
					cena = Convert.ToInt32(cena.Text),
					marka = marka.Text,
					kategoria = kategoria.Text,
					ilosc = Convert.ToInt32(ilosc.Text),
					funkcje = new Funkcje { funkcja1 = f1.Text, funkcja2 = f2.Text, funkcja3 = f3.Text },
					info = new InformacjeOProdukcie { krajPochodzenia = textBox1.Text, fabryka = textBox2.Text }
				};
				await manipulacja.ModyfikujProdukt("AGD", "AGDCollection", kod.Text, pp);
				SzukOkno();
			}
			catch
			{
				Blad("Wystapił nieoczekiwany błąd. Cena i ilość muszą być liczbą, sprawdź czy poprawnie wypełniłeś te komórki.");
			}

			Szukaj_Click(sender, e);
		}

		private void Szukanie_SelectedIndexChanged(object sender, EventArgs e)
		{
			List<string> dane = new List<string>();
			if (Szukanie.Text == "Kategoria")
			{
				Kategorie.Visible = true;
				label8.Text = "Kategoria:";
				dane = daneDoCombo.WezKategorie("AGD", "AGDCollection");
			}
			else if (Szukanie.Text == "Marka")
			{
				Kategorie.Visible = true;
				label8.Text = "Marka:";
				dane = daneDoCombo.WezMarki("AGD", "AGDCollection");
			}
			else if (Szukanie.Text == "Kraj pochodzenia")
			{
				Kategorie.Visible = true;
				label8.Text = "Kraj pochodzenia:";
				dane = daneDoCombo.WezKraje("AGD", "AGDCollection");
			}
			else
			{
				Kategorie.Visible = false;
				label8.Text = "";
			}
			Kategorie.Items.Clear();
			foreach (string item in dane)
				Kategorie.Items.Add(item);
		}

		private void wroc_Click(object sender, EventArgs e)
		{
			this.Text = "Wyszukiwanie";
			SzukOkno();
		}
	}
}
