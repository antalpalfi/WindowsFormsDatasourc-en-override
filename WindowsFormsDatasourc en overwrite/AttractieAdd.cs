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
    public partial class AttractieAdd : Form
    {
        public AttractieAdd(List<Attracties> attracties)
        
        
        {
            InitializeComponent();
            returnListAtt = attracties;
        }
        public List<Attracties> returnListAtt;

        private void button1_Click(object sender, EventArgs e)
        {
            if (txtNaam.Text != "" && txtKleur.Text != "" && numLeef.Value != 0 && numMaxPers.Value != 0)
            {
                Attracties newAttracties = new Attracties(txtNaam.Text, txtKleur.Text, numLeef.DecimalPlaces, numMaxPers.DecimalPlaces);
                this.returnListAtt.Add(newAttracties);
                this.DialogResult = DialogResult.OK;
                Close();
        }
            else
            {
                MessageBox.Show("Vuil alles in");
            }

}

        private void AttractieAdd_Load(object sender, EventArgs e)
        {

        }
    }
}
