using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsDatasourc_en_overwrite
{
    public class TangoMembers
    {
        public string Naam { get; set; }
        public string Age { get; set; }
        public string Geslacht { get; set; }
        public TangoMembers(string naam, string age, string geslacht)
        {
            Naam = naam;
            Age = age;
            Geslacht = geslacht;

        }
        public override string ToString()
        {
            return Naam;
        }
    }
}
