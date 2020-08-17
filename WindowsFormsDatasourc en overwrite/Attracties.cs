using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsDatasourc_en_overwrite
{
    public class Attracties
    {
        public string Naam { get; set; }
        public string Kleur { get; set; }
        public int LeefTijd { get; set; }
        public int MaxPerson { get; set; }

        public Attracties(string naam, string kleur, int leeftijd, int maxperson)
        {
            Naam = naam;
            Kleur = kleur;
            LeefTijd = leeftijd;
            MaxPerson = maxperson;

        }
        public override string ToString()
        {
            return Naam;
        }


    }
}
