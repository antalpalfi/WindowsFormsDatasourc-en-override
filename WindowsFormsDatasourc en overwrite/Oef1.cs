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
    public partial class Oef1 : Form
    {
        public Oef1()
        {
            InitializeComponent();
        }
        public List<Werknemers> werkList = new List<Werknemers>();
        public List<Attracties> MijnAttracties = new List<Attracties>();
        private void Form1_Load(object sender, EventArgs e)
        {
            pictureBoxPark.Image= Image.FromFile("Mario.jpg");
            Pretpark mijnPretpark = new Pretpark("Antal Park");
            lbParkNaam.Text = mijnPretpark.Naam;

            werkList.Add(new Werknemers("John", 30,"Man"));
            werkList.Add(new Werknemers("Patricia",20,"Vrouw"));
            lbWernem.DataSource = werkList;

            MijnAttracties.Add(new Attracties("King Kong", "Red", 18, 10));
            MijnAttracties.Add(new Attracties("T-rex", "Blue", 14, 21));
            lboxAttractie.DataSource = MijnAttracties;


        }

        private void lbWernem_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lbWernem.DataSource != null)
            {
                labelNaam.Text = werkList[lbWernem.SelectedIndex].Gebortd.ToString();
                labelGeslacth.Text = werkList[lbWernem.SelectedIndex].Geslacth.ToString();
            }
        }

        private void btnWerknRem_Click(object sender, EventArgs e)
        {
            werkList.RemoveAt(lbWernem.SelectedIndex);
            lbWernem.Items.Remove(lbWernem.SelectedIndex);
            RefreshListWerk();
        }

        private void btnWerkNemToe_Click(object sender, EventArgs e)
        {
            using (WerknemmersAdd werkadd = new WerknemmersAdd(werkList))
            {
                var result = werkadd.ShowDialog();
                if (result == DialogResult.OK)
                {
                    werkList = werkadd.returnLijst;
                   
                }
                RefreshListWerk();

            }
        }
       public void RefreshListWerk()
        {
            lbWernem.DataSource = null;
            lbWernem.DataSource = werkList;
        }

        private void btnAttractie_Click(object sender, EventArgs e)
        {
            using (AttractieAdd attAdd = new AttractieAdd(MijnAttracties))
            {
                var result = attAdd.ShowDialog();
                if (result==DialogResult.OK)
                {
                    MijnAttracties = attAdd.returnListAtt;
                }
                RefreshListAtt();
            }
        }
        public void RefreshListAtt()
        {
            lboxAttractie.DataSource = null;
            lboxAttractie.DataSource = MijnAttracties;
        }

        private void btnAtrRemove_Click(object sender, EventArgs e)
        {
            MijnAttracties.RemoveAt(lboxAttractie.SelectedIndex);
            lboxAttractie.Items.Remove(lboxAttractie.SelectedIndex);
            RefreshListAtt();
        }

        private void lboxAttractie_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lboxAttractie.DataSource!= null)
            {
                lbKleur.Text = MijnAttracties[lboxAttractie.SelectedIndex].Kleur.ToString();
                lbMinLeef.Text = MijnAttracties[lboxAttractie.SelectedIndex].LeefTijd.ToString();
                lbMaxPer.Text = MijnAttracties[lboxAttractie.SelectedIndex].MaxPerson.ToString();
            }
           
        }
    }
}
