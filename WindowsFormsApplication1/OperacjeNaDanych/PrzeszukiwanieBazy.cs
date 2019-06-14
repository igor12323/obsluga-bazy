using Microsoft.Azure.Documents.Client;
using System.Collections.Generic;
using System.Linq;

namespace WindowsFormsApplication1
{
	class PrzeszukiwanieBazy
	{
		Program nowy = new Program();
		FeedOptions opcje = new FeedOptions { MaxItemCount = -1 };
		private List<Produkt> Wszystko(string nazwaBazy, string nazwaKolekcji)
		{
			IQueryable<Produkt> wyszukiwanie = nowy.client.CreateDocumentQuery<Produkt>(
				UriFactory.CreateDocumentCollectionUri(nazwaBazy, nazwaKolekcji),
				"SELECT * FROM Produkt", opcje);
			List<Produkt> dane = wyszukiwanie.ToList();
			return dane;
		}
		public List<Produkt> WyszukajKategoria(string nazwaBazy, string nazwaKolekcji, string szukane)
		{
			if (szukane == "Wszystko")
				return Wszystko(nazwaBazy, nazwaKolekcji);
			IQueryable<Produkt> wyszukiwanie = nowy.client.CreateDocumentQuery<Produkt>(
			UriFactory.CreateDocumentCollectionUri(nazwaBazy, nazwaKolekcji),
			"SELECT * FROM Produkt WHERE Produkt.kategoria='" + szukane + "'",
			opcje);
			List<Produkt> dane = wyszukiwanie.ToList();
			return dane;
		}
		public List<Produkt> WyszukajMarka(string nazwaBazy, string nazwaKolekcji, string szukane)
		{
			if (szukane == "Wszystko")
				return Wszystko(nazwaBazy, nazwaKolekcji);
			IQueryable<Produkt> wyszukiwanie = nowy.client.CreateDocumentQuery<Produkt>(
			UriFactory.CreateDocumentCollectionUri(nazwaBazy, nazwaKolekcji),
			"SELECT * FROM Produkt WHERE Produkt.marka='" + szukane + "'",
			opcje);
			List<Produkt> dane = wyszukiwanie.ToList();
			return dane;
		}
		public Produkt WyszukajPoID(string databaseName, string collectionName, string szukane)
		{
			IQueryable<Produkt> wyszukiwanieQuery = nowy.client.CreateDocumentQuery<Produkt>(
			UriFactory.CreateDocumentCollectionUri(databaseName, collectionName),
			"SELECT * FROM Produkt WHERE Produkt.id = '" + szukane + "'",
			opcje);
			List<Produkt> dane = wyszukiwanieQuery.ToList();
			Produkt produkt = dane[0];
			return produkt;
		}
		public List<Produkt> WyszukajKraje(string nazwaBazy, string nazwaKolekcji, string szukane)
		{
			if (szukane == "Wszystko")
				return Wszystko(nazwaBazy, nazwaKolekcji);
			IQueryable<Produkt> wyszukiwanieQuery = nowy.client.CreateDocumentQuery<Produkt>(
			UriFactory.CreateDocumentCollectionUri(nazwaBazy, nazwaKolekcji),
			"SELECT * FROM Produkt WHERE Produkt.info.krajPochodzenia='" + szukane + "'",
			opcje);
			List<Produkt> dane = wyszukiwanieQuery.ToList();
			return dane;
		}
	}
}
