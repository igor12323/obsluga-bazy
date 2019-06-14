using Microsoft.Azure.Documents.Client;
using System.Collections.Generic;
using System.Linq;

namespace WindowsFormsApplication1
{
	class DaneDoCombo
	{
		Program nowy = new Program();
		private List<string> WybieranieDoComboBoxa(List<string> wszystko)
		{
			List<string> kategorie = new List<string>();
			kategorie.Add("Wszystko");
			foreach (string item in wszystko)
			{
				bool czyJest = false;
				foreach (string item1 in kategorie)
				{
					if (item == item1)
					{ czyJest = true; }
				}
				if (!czyJest)
				{
					kategorie.Add(item);
				}
			}

			return kategorie;
		}
		public List<string> WezKategorie(string databaseName, string collectionName)
		{
			FeedOptions opcje = new FeedOptions { MaxItemCount = -1 };
			IQueryable<string> daneDoKategorii = from dane in nowy.client.CreateDocumentQuery<WindowsFormsApplication1.Produkt>(
				   UriFactory.CreateDocumentCollectionUri
				   (databaseName, collectionName), opcje)
												 select dane.kategoria;
			if (daneDoKategorii != null)
				return WybieranieDoComboBoxa(daneDoKategorii.ToList<string>());
			else
				return null;
		}
		public List<string> WezMarki(string databaseName, string collectionName)
		{
			FeedOptions opcje = new FeedOptions { MaxItemCount = -1 };
			IQueryable<string> daneDoMarki = from dane in nowy.client.CreateDocumentQuery<Produkt>(
				   UriFactory.CreateDocumentCollectionUri
				   (databaseName, collectionName), opcje)
											 select dane.marka;
			if (daneDoMarki != null)
				return WybieranieDoComboBoxa(daneDoMarki.ToList<string>());
			else
				return null;
		}
		public List<string> WezKraje(string databaseName, string collectionName)
		{
			FeedOptions queryOptions = new FeedOptions { MaxItemCount = -1 };
			IQueryable<string> wyszukiwanieQuery = from aa in nowy.client.CreateDocumentQuery<Produkt>(
				   UriFactory.CreateDocumentCollectionUri
				   (databaseName, collectionName), queryOptions)
												   select aa.info.krajPochodzenia;
			if (wyszukiwanieQuery != null)
				return WybieranieDoComboBoxa(wyszukiwanieQuery.ToList<string>());
			else
				return null;
		}
	}
}
