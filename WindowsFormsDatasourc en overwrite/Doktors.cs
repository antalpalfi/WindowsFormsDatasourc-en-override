using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsDatasourc_en_overwrite
{
    public class Doktors
    {
        public List<Afspraak> AfspraakList { get; set; }
        public string DoktorNaam { get; set; }
        public Doktors(string doktornaam)
        {
            DoktorNaam = doktornaam;
        }
        public override string ToString()
        {
            return DoktorNaam;
        }
        public Doktors()
        {
            AfspraakList = new List<Afspraak>();
        }
    }
    
}
