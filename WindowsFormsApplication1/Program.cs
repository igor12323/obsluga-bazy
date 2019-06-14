using Microsoft.Azure.Documents.Client;
using System;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
	class Program
	{
		#region Dane połączenia
		private const string Adres = "https://igordb2.documents.azure.com:443/";
		private const string Klucz = "IEtEcVq0GiFOSOslmCiR0BeFfUF93AOYSLg3AFzs3Go0BFylY6CgU2a5wrchKf7DCpF99nxJs4jgTN11CwuCuA==";
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
