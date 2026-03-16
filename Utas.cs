using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vonatprojekt
{
	internal class Utas
	{
		private string nev;
		private int poggyaszSzam;
		private string felszallasHelye;
		private string leszallasHelye;

		public Utas(string nev, int poggyaszSzam, string felszallasHelye, string leszallasHelye)
		{
			this.nev = nev;
			this.poggyaszSzam = poggyaszSzam;
			this.felszallasHelye = felszallasHelye;
			this.leszallasHelye = leszallasHelye;
		}

		public string Nev { get => nev; }
		public int PoggyaszSzam { get => poggyaszSzam; set => poggyaszSzam = value; }
		public string FelszallasHelye { get => felszallasHelye;  }
		public string LeszallasHelye { get => leszallasHelye; set => leszallasHelye = value; }


		public override string ToString()
		{
			return $"{this.nev} felszáll a vonatra:{this.felszallasHelye} {this.poggyaszSzam} csomaggal, és leszáll: {this.leszallasHelye}";
		}
	}
}
