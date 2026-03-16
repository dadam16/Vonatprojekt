using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vonatprojekt
{
	internal class Mozdony
	{
		private Mozdonyvezeto mozdonyvezeto;
		private int maxKocsikSzama;

		public Mozdony(Mozdonyvezeto mozdonyvezeto, int maxKocsikSzama)
		{
			this.mozdonyvezeto = mozdonyvezeto;
			this.maxKocsikSzama = maxKocsikSzama;
		}

		public int MaxKocsikSzama { get => maxKocsikSzama; set => maxKocsikSzama = value; }
		internal Mozdonyvezeto Mozdonyvezeto { get => mozdonyvezeto; set => mozdonyvezeto = value; }

		public override string ToString()
		{
			return $"{this.mozdonyvezeto}, max kocsik száma: {this.maxKocsikSzama}";
		}
	}
}
