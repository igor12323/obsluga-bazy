using Newtonsoft.Json;

namespace WindowsFormsApplication1
{
	public class Produkt
	{
		[JsonProperty(PropertyName = "id")]
		public string id { get; set; }
		public string kategoria { get; set; }
		public string marka { get; set; }
		public InformacjeOProdukcie info { get; set; }
		public Funkcje funkcje { get; set; }
		public int cena { get; set; }
		public int ilosc { get; set; }
	}
}
