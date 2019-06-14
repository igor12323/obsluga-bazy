using Microsoft.Azure.Documents;
using Microsoft.Azure.Documents.Client;
using System.Collections.Generic;
using System.Net;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
	class ManipulacjaDanymi
	{
		Program nowy = new Program();
		public async Task DodawanieProduktu(string nazwa, int cen, string mar, string kat, int ilo, List<string> fun, List<string> inf)
		{
			await nowy.client.CreateDatabaseIfNotExistsAsync
				(new Database { Id = "AGD" }); //tworzenie bazy
			await nowy.client.CreateDocumentCollectionIfNotExistsAsync
				(UriFactory.CreateDatabaseUri("AGD"), new DocumentCollection { Id = "AGDCollection" }); //tworzenie kolekcji);
			Produkt produktDodawany = new Produkt
			{ id = nazwa, cena = cen, marka = mar, kategoria = kat, ilosc = ilo, funkcje = new Funkcje { funkcja1 = fun[0], funkcja2 = fun[1], funkcja3 = fun[2] }, info = new InformacjeOProdukcie { krajPochodzenia = inf[0], fabryka = inf[1] } };
			await TworzenieDokumentuJezeliNieIstnieje("AGD", "AGDCollection", produktDodawany);
		}
		private async Task TworzenieDokumentuJezeliNieIstnieje(string databaseName, string collectionName, Produkt produkt)
		{
			try
			{
				await nowy.client.ReadDocumentAsync(UriFactory.CreateDocumentUri(databaseName, collectionName, produkt.id));
				string message = "Produkt jest juz w bazie. Jeżeli chcesz go zmodyfikować przejdź do wyszukiwania produktu.";
				string caption = "Błąd!";
				MessageBoxButtons buttons = MessageBoxButtons.OK;
				MessageBox.Show(message, caption, buttons);
			}
			catch (DocumentClientException de)
			{
				if (de.StatusCode == HttpStatusCode.NotFound)
				{
					string message = "Produkt zostal dodany do bazy";
					string caption = "Sukces!";
					MessageBoxButtons buttons = MessageBoxButtons.OK;
					MessageBox.Show(message, caption, buttons);
					await nowy.client.CreateDocumentAsync(UriFactory.CreateDocumentCollectionUri(databaseName, collectionName), produkt);
				}
				else
				{
					throw;
				}
			}
		}
		public async Task UsunDokument(string databaseName, string collectionName, string documentName)
		{
			await nowy.client.DeleteDocumentAsync(UriFactory.CreateDocumentUri(databaseName, collectionName, documentName));
		}
		public async Task ModyfikujProdukt(string databaseName, string collectionName, string produktName, Produkt updatedProdukt)
		{
			await nowy.client.ReplaceDocumentAsync(UriFactory.CreateDocumentUri(databaseName, collectionName, produktName), updatedProdukt);
			string message = "Dokument zostal zmodyfikowany";
			string caption = "OK!";
			MessageBoxButtons buttons = MessageBoxButtons.OK;
			MessageBox.Show(message, caption, buttons);
		}
	}
}
