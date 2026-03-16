using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vonatprojekt
{
	internal class Vonat
	{
		private List<Kocsi> kocsik;
		private Mozdony mozdony;
		private Kalauz kalauz;
		private List<string> megallok;

		public Vonat( Mozdony mozdony, Kalauz kalauz, List<string> megallok)
		{
			this.kocsik = new List<Kocsi>();
			this.mozdony = mozdony;
			this.kalauz = kalauz;
			this.megallok = megallok;
		}

		public List<string> Megallok { get => megallok; set => megallok = value; }
		internal List<Kocsi> Kocsik { get => kocsik; set => kocsik = value; }
		internal Mozdony Mozdony { get => mozdony; set => mozdony = value; }
		internal Kalauz Kalauz { get => kalauz; set => kalauz = value; }

		public void KocsiCsatolasa(Kocsi k)
		{
			if (mozdony.MaxKocsikSzama > kocsik.Count)
			{
				kocsik.Add(k);
			}
			
		}
		public void felszall(Utas u, int kocsiszam)
		{
			foreach(var item in kocsik)
			{
				if(item.KocsiSzam == kocsiszam)
				{
					item.Beszall(u);
				}
			}
		}
		public void utasokListazasa()
		{
			foreach (var item in kocsik)
			{
				Console.WriteLine(item.UtasokListazasa());
			}
		}
	}
}
