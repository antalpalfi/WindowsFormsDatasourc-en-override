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
            TangoList.Add(new TangoMembers("Vastag Alexandra", "40", "Vrouw"));
            TangoList.Add(new TangoMembers("John Taylor", "48", "Man"));
            TangoList.Add(new TangoMembers("Koen Deans", "47", "Man"));

        }

        private void btnKiez_Click(object sender, EventArgs e)
        {

            
            List<string> luckyList = new List<string>();
            Random rand = new Random(DateTime.Now.ToString().GetHashCode());
            int k = 0;
            while (k<6)
            {
                int index = rand.Next(0, TangoList.Count);
                luckyList.Add(TangoList[index].Naam);
                TangoList.RemoveAt(index);
                k++;
            }
            MessageBox.Show($"New group members\n" +
                 $"\n" +
                $"{luckyList[0]}\n" +
                $"{luckyList[1]}\n" +
                $"{luckyList[2]}\n" +
                $"{luckyList[3]}\n" +
                $"{luckyList[4]}\n" +
                $"{luckyList[5]}\n");

        }

    }
}
