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
    public partial class Oefening3 : Form
    {
        public Oefening3()
        {
            InitializeComponent();
        }
        public List<TangoMembers> TangoList = new List<TangoMembers>();

        private void btnRegist_Click(object sender, EventArgs e)
        {
            if (txtNaam.Text != "" && numAge.Value >= 18 && rdbMan.Checked)
            {
                TangoList.Add(new TangoMembers(txtNaam.Text, numAge.Value.ToString(), rdbMan.Text.ToString()));
                MessageBox.Show($"Mr {txtNaam.Text} u bent registerd");
            }
            else if (txtNaam.Text != "" && numAge.Value >= 18 && rdbVrouw.Checked)
            {
                TangoList.Add(new TangoMembers(txtNaam.Text, numAge.Value.ToString(), rdbVrouw.Text.ToString()));
                MessageBox.Show($"Ms {txtNaam.Text} u bent registerd");

            }
            else
            {
                MessageBox.Show("U bent te jong");
            }
            txtNaam.Clear();
            numAge.Value = 0;
            rdbMan.Checked = false;
            rdbVrouw.Checked = false;

        }

        private void Oefening3_Load(object sender, EventArgs e)
        {
            TangoList.Add(new TangoMembers("Palfi Antal", "21", "Man"));
            TangoList.Add(new TangoMembers("Palfi Tamas", "28", "Man"));
            TangoList.Add(new TangoMembers("Vigh Krisztina", "21", "Vrouw"));
            TangoList.Add(new TangoMembers("Szabo Anna", "24", "Vrouw"));
            TangoList.Add(new TangoMembers("Vas Adam", "35", "Man"));
            TangoList.Add(new TangoMembers("Torocsik Bela", "55", "Man"));
            TangoList.Add(new TangoMembers("Schneider Andrea", "41", "Vrouw"));

        }

        private void btnKiez_Click(object sender, EventArgs e)
        {

            //MessageBox.Show(TangoList[0].Naam);
            //Random rng = new Random();
            //int a = rng.Next(0, TangoList.Count);
            //System.Threading.Thread.Sleep(50);
            //Random rng2 = new Random();
            //int b = rng2.Next(0, TangoList.Count);
            //System.Threading.Thread.Sleep(50);
            //Random rng3 = new Random();
            //int c = rng3.Next(0, TangoList.Count);
            //System.Threading.Thread.Sleep(50);
            //Random rng4 = new Random();
            //int d = rng4.Next(0, TangoList.Count);
            //System.Threading.Thread.Sleep(50);
            //Random rng5 = new Random();
            //int k = rng5.Next(0, TangoList.Count);
            //System.Threading.Thread.Sleep(50);
            //Random rng6 = new Random();
            //int f = rng6.Next(0, TangoList.Count);
            //MessageBox.Show($"{a} {b} {c} {f} {d} {d}");

            Random rand = new Random(DateTime.Now.ToString().GetHashCode());
            int k = 0;
            while (k<6)
            {
                int index = rand.Next(0, TangoList.Count);
                MessageBox.Show($"{TangoList[index].Naam} u bent gekozen");
                TangoList.RemoveAt(index);
                k++;
            }

        }

    }
}
