﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace for_dongusu_ornek6___826
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnYaz_Click(object sender, EventArgs e)
        {
            int sayi1 = Convert.ToInt32(txtBaslangic.Text);
            int sayi2 = Convert.ToInt32(txtBitis.Text);
            for (int i = sayi1; i <= sayi2; i++)
            
            if (sayi2 % 2 == 0)
            {
                    lbCift.Items.Add(i);
                }
                else
                {
                    lbTek.Items.Add(i);
                }
        }
    }
}
