﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Odev_5._2_RFatihK
{
    public partial class Odev_5_2 : Form
    {
        public Odev_5_2()
        {
            InitializeComponent();
        }

    private void Blue_MouseHover(object sender, EventArgs e)
        {
            this.BackColor = Color.Blue;
            Blue.BackColor = Color.Blue;
            Blue.ForeColor = Color.White;
        }
    private void Red_MouseHover(object sender, EventArgs e)
        {
            this.BackColor = Color.Red;
            Red.BackColor = Color.Red;
            Red.ForeColor = Color.White;
        }
    private void Green_MouseHover(object sender, EventArgs e)
        {
            this.BackColor = Color.Green;
            Green.BackColor = Color.Green;
            Green.ForeColor = Color.White;
        }

        private void Blue_Click(object sender, EventArgs e)
        {

        }
    }
}
