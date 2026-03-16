using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vonatprojekt
{
	internal class Kocsi
	{
		private int kocsiSzam;
		private int maxÜlesszam;
		private List<Utas> utaslista;
		public Kocsi(int maxÜlesszam, int kocsiSzam)
		{
			this.maxÜlesszam = maxÜlesszam;
			this.utaslista = new List<Utas>();
			this.kocsiSzam = kocsiSzam;
		}

		public int MaxÜlesszam { get => maxÜlesszam; set => maxÜlesszam = value; }
		internal List<Utas> Utaslista { get => utaslista; set => utaslista = value; }
		public int KocsiSzam { get => kocsiSzam; set => kocsiSzam = value; }
		public int UtasSzam
		{
			get
			{
				return utaslista.Count;
			}
		}



		public void Beszall(Utas utas)
		{
			if (UtasSzam < maxÜlesszam)
			{
				this.utaslista.Add(utas);
				Console.WriteLine($"{utas.Nev} felszállt a vonatra, integet!");
			}
			else
			{
				Console.WriteLine("Nincs elég hely!");
			}

		}
		public Utas Leszall(string nev)
		{
			Utas s = null;
			foreach (var item in utaslista)
			{
				if (item.Nev == nev)
				{
					s = item;
				}
			}
			utaslista.Remove(s);
			return s;
		}

		public string UtasokListazasa()
		{
			string s = $"{this.kocsiSzam}. kocsi: \n";
			
			foreach (var item in utaslista)
			{
				s += $"\t{item}\n";
			}
			return s;
		}

	}
}
