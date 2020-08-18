using System;
using System.CodeDom;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsDatasourc_en_overwrite
{
    public class Werknemers
    {
        public string Naam { get; set; }
        public string Gebortd { get; set; }
        public string Geslacth { get; set; }
        public Werknemers(string naam , string geboort, string geslacht)
        {
            Naam = naam;
            Gebortd = geboort;
            Geslacth = geslacht;
        }
        public Werknemers(string naam)
        {
            Naam = naam;
            
        }
        public override string ToString()
        {
            return Naam;
        }


    }
}
