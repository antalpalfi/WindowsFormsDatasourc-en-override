using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsDatasourc_en_overwrite
{
    public class ZiekenHuis
    {
        public List<Doktors> DoktersList { get; set; }
       
        
        public string DatumAfspraak { get; set; }
        public string UurAfspraak { get; set; }
        public string NaamClient { get; set; }
       
        public ZiekenHuis()
        {
            DoktersList = new List<Doktors>();


        }
        //public ZiekenHuis(string datumafspraak, string uurafspraak, string naamclient)
        //{
        //    DatumAfspraak = datumafspraak;
        //    UurAfspraak = uurafspraak;
        //    NaamClient = naamclient;
        //}
       

    }
}
