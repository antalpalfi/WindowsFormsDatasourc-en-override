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
    public partial class Afspraak_maken : Form
    {
        
        public Afspraak_maken(List<Afspraak> afspraak)
        {
            InitializeComponent();
            returnAfsprakList = afspraak;
        }

       

        public List<Afspraak> returnAfsprakList;


        private void button1_Click(object sender, EventArgs e)
        {
            if (txtNaam.Text != "" && numUrrAfsp.Value != 0)
            {
                Afspraak newAfspraak = new Afspraak(dtPAfspraak.CustomFormat, numUrrAfsp.Value.ToString(), txtNaam.Text);
                this.returnAfsprakList.Add(newAfspraak);
                this.DialogResult = DialogResult.OK;
                Close();
                MessageBox.Show($"{txtNaam.Text} uw nieuw afspraak {dtPAfspraak.Value.ToString("dd/MM/yyyy")} op {numUrrAfsp.Value}uur");

            }
            else
            {
                MessageBox.Show("Vuil alles in aub.");
            }
        }
    }
}
