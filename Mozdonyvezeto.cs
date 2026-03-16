using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vonatprojekt
{
	internal class Mozdonyvezeto
	{
		private string nev;
		private string utvonalEnegedely;

		public Mozdonyvezeto(string nev, string utvonalEnegedely)
		{
			this.nev = nev;
			this.utvonalEnegedely = utvonalEnegedely;
		}

		public string Nev { get => nev; set => nev = value; }
		public string UtvonalEnegedely { get => utvonalEnegedely; set => utvonalEnegedely = value; }

		public override string ToString()
		{
			return $"{this.nev}, engedélye: {this.utvonalEnegedely}";
		}
	}


}
