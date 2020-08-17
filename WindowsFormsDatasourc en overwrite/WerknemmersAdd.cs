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
    public partial class WerknemmersAdd : Form
    {
        public WerknemmersAdd(List<Werknemers> werknemers)
        {
            InitializeComponent();
            returnLijst = werknemers;
        }
        public List<Werknemers> returnLijst;

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (textNaam.Text!="" && numLeeftijd.Value !=0 && textGeslacht.Text!="")
            {
                Werknemers nieuwWerknemers = new Werknemers(textNaam.Text, numLeeftijd.DecimalPlaces, textGeslacht.Text);
                this.returnLijst.Add(nieuwWerknemers);
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            else
            {
                MessageBox.Show("Vuil alles in");
            }
            
        }
    }
}
