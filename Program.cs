namespace Vonatprojekt
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<string> megallok = new List<string>() { "Budapest", "Ferihegy", "Cegléd", "Szolnok", "Püspökladány", "Hajdúszoboszló", "Debrecen", "Nyíregyháza", "Kisvárda", "Záhony" };
			Utas u1 = new Utas("János", 2, "Budapest", "Debrecen");
			Utas u2 = new Utas("Juliska", 1, "Budapest", "Szolnok");
			Utas u3 = new Utas("Pista", 1, "Budapest", "Záhony");
			Utas u4 = new Utas("Anna", 1, "Budapest", "Záhony");

			Console.WriteLine(u1);
			Console.WriteLine(u2);

            Kocsi k1 = new Kocsi(32,1);
			Kocsi k2 = new Kocsi(32,2);

            Mozdonyvezeto mv1 = new Mozdonyvezeto("Gyuri", "Budapest-Záhony");
            Mozdony m43 = new Mozdony(mv1, 5);
			Console.WriteLine(m43);
            Kalauz ka1 = new Kalauz("Bettike", 5);


			Vonat v1 = new Vonat(m43, ka1, megallok);
            v1.KocsiCsatolasa(k1);
			v1.KocsiCsatolasa(k2);
			v1.felszall(u1, 1);
			v1.felszall(u2, 1);
			v1.felszall(u3, 2);
			v1.felszall(u4, 2);

			v1.utasokListazasa();







		}
    }
}
