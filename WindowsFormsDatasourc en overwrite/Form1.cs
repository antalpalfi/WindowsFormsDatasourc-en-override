﻿using System;
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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        public List<Werknemers> werkList = new List<Werknemers>();
        private void Form1_Load(object sender, EventArgs e)
        {

            Pretpark mijnPretpark = new Pretpark("Antal Park");
            lbParkNaam.Text = mijnPretpark.Naam;

            werkList.Add(new Werknemers("John", 30,"Man"));
            werkList.Add(new Werknemers("Patricia",20,"Vrouw"));
            lbWernem.DataSource = werkList;


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
            RefreshList();
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
                RefreshList();

            }
        }
       public void RefreshList()
        {
            lbWernem.DataSource = null;
            lbWernem.DataSource = werkList;
        }
    }
}