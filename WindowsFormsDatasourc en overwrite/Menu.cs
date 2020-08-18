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
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
        }

        private void btnOef1_Click(object sender, EventArgs e)
        {
            Oef1 oef1 = new Oef1();
            oef1.Show();
        }

        private void btnOef2_Click(object sender, EventArgs e)
        {
            Oefening2 oef2 = new Oefening2();
            oef2.Show();
        }
    }
}
