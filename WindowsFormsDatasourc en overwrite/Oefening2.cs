using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsDatasourc_en_overwrite
{
    public partial class Oefening2 : Form
    {
        public Oefening2()
        {
            InitializeComponent();
        }
        
        
        private void Oefening2_Load(object sender, EventArgs e)
        {
            ZiekenHuis doktors = new ZiekenHuis();
            Doktors newd = new Doktors("Dr. Antal Palfi");
            Doktors newd2 = new Doktors("Dr. John Taylor");
            Doktors newd3 = new Doktors("Dr. Gyorgy Kokeny");
            doktors.DoktersList.Add(newd);
            doktors.DoktersList.Add(newd2);
            doktors.DoktersList.Add(newd3);
            listbDoktors.DataSource = doktors.DoktersList;
            Doktors afsprak = new Doktors();
            Afspraak newAf = new Afspraak("16/03/2020", "14hh", "Eszter");
            afsprak.AfspraakList.Add(newAf);
            listbAfspraak.DataSource = afsprak.AfspraakList;

        }

        private void btnAfsNew_Click(object sender, EventArgs e)
        {
            Doktors afsprak = new Doktors();
            using (Afspraak_maken newAfsprak = new Afspraak_maken(afsprak.AfspraakList))
            {
                var result = newAfsprak.ShowDialog();
                if (result == DialogResult.OK)
                {
                    
                    afsprak.AfspraakList = newAfsprak.returnAfsprakList;
                }
                RefreshAfLIst();
                

            }
        }
        private void RefreshAfLIst()
        {
            Doktors afsprak = new Doktors();
            listbAfspraak.DataSource = null;
            listbAfspraak.DataSource = afsprak.AfspraakList;

        }

        private void listbDoktors_SelectedIndexChanged(object sender, EventArgs e)
        {
            //Doktors afsprak = new Doktors();
            //if (listbAfspraak.DataSource != null)
            //{
            //    listbAfspraak.Text = afsprak.AfspraakList[listbDoktors.SelectedIndex].NaamClient.ToString();
                
            //}
        }
    }
}
