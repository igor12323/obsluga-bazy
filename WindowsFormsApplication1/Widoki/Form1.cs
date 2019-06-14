using System;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
		}

		private void dodaj_Click(object sender, EventArgs e)
		{
			DodajElement dodawanie = new DodajElement(); //tworzenie nowego okna do dodawania elementu
			dodawanie.Show(); // pokazanie stworzonego okna
		}

		private void szukaj_Click(object sender, EventArgs e)
		{
			Wyszukiwane wyszukiwanie = new Wyszukiwane(); //tworzenie okna do wyszukiwania
			wyszukiwanie.Show(); // pokazanie stworzonego okna
		}
	}
}
