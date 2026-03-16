using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vonatprojekt
{
	internal class Kalauz
	{
		private string nev;
		private int buntetesiHajlandosag;// max 10, minél nagyobb , annál hajlandóbb büntetni

		public Kalauz(string nev, int buntetesiHajlandosag)
		{
			this.nev = nev;
			this.buntetesiHajlandosag = buntetesiHajlandosag;
		}

		public string Nev { get => nev; set => nev = value; }
		public int BuntetesiHajlandosag { get => buntetesiHajlandosag; set => buntetesiHajlandosag = value; }
		public override string ToString()
		{
			return $"{this.nev} kalauz buntetési hajlandósága: {this.buntetesiHajlandosag} ";
		}
	}
}
