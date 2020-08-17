using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsDatasourc_en_overwrite
{
    class Pretpark
    {
        public string Naam { get; set; }
        //public List<Werknemers> MijnWerknemers { get; set; }
        //public List<Attracties> MijnAttracties { get; set; }

        //public Pretpark()
        //{
        //    MijnWerknemers = new List<Werknemers>();
        //    MijnAttracties = new List<Attracties>();

        //}
        public Pretpark(string naam)
        {
            Naam = naam;
            
        }
    }
}
