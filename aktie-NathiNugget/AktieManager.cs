using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace aktie_NathiNugget
{
    /// <summary>
    /// Klasse der håndterer aktier
    /// </summary>
    public class AktieManager
    {

        /// <summary>
        /// Konstruktør initialiserer aktier til den statiske liste
        /// </summary>
        public AktieManager()
        {
            AddAktie(new Aktie("Ambu", 131, 132, 202779));
            AddAktie(new Aktie("Bavian", 132, 134, 200));
            AddAktie(new Aktie("Ambu", 50, 43, 100));
            AddAktie(new Aktie("Carlsberg", 772, 773, 56876));
            AddAktie(new Aktie("Danske Bank", 131, 132, 202779));
            AddAktie(new Aktie("DSV", 1254, 1100, 200));
        }

        /// <summary>
        /// Statisk liste som indeholder aktier
        /// </summary>
        public static List<Aktie> AktieList { get; set; } = new List<Aktie> { };

        /// <summary>
        /// Tilføjer aktie til den statiske liste
        /// </summary>
        /// <param name="a"></param>
        public void AddAktie(Aktie a)
        {
            AktieList.Add(a);
        }

        /// <summary>
        /// Metode til at finde total afkast for alle aktier i den statiske liste
        /// </summary>
        /// <returns>Total afkast i kroner</returns>
        public int TotalAfkast()
        {
            return AktieList.Sum(a => a.Afkast());
        }



    }
}
