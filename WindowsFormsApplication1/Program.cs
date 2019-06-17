using Microsoft.Azure.Documents.Client;
using System;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
	class Program
	{
		#region Dane połączenia
		private const string Adres = "";
		private const string Klucz = "";
		public DocumentClient client = new DocumentClient(new Uri(Adres), Klucz);
		#endregion
		[STAThread]
		static void Main()
		{
			Application.EnableVisualStyles();
			Application.SetCompatibleTextRenderingDefault(false);
			Application.Run(new Form1());
		}
	}
}
