using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace aktie_NathiNugget
{
    /// <summary>
    /// Aktie klasse
    /// </summary>
    public class Aktie
    {
        private int antalAktier;
        private int salgsKurs;
        private int koebskurs;

        /// <summary>
        /// Konstruktør for klassen, properties initialiseres
        /// </summary>
        /// <param name="aktieNavn">Navn for aktien</param>
        /// <param name="koebskurs">Kurs aktien købes for</param>
        /// <param name="salgsKurs">Kurs for salg</param>
        /// <param name="antalAktier">Antallet af tilgængelige aktier for denne</param>
        public Aktie(string aktieNavn, int koebskurs, int salgsKurs, int antalAktier)
        {
            AktieNavn = aktieNavn;
            Koebskurs = koebskurs;
            SalgsKurs = salgsKurs;
            AntalAktier = antalAktier;
        }


        /// <summary>
        /// Navn
        /// </summary>
        public string AktieNavn { get; set; }
        /// <summary>
        /// Kurs
        /// </summary>
        public int Koebskurs { get => koebskurs; set => koebskurs = value; }
        /// <summary>
        /// Salg
        /// </summary>
        public int SalgsKurs { get => salgsKurs; set => salgsKurs = value; }
        /// <summary>
        /// Antal
        /// </summary>
        public int AntalAktier { get => antalAktier; set => antalAktier = value; }

        /// <summary>
        /// Metode som returnerer afkast udregnet via properties
        /// 
        /// </summary>
        /// <returns>Afkast i kroner</returns>
        public int Afkast() => antalAktier * (SalgsKurs - Koebskurs); 
    }
}
