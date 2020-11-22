﻿using System;
using System.Windows.Forms;

namespace Odev_5_3_RFatihK
{
    /*
     Ramazan Fatih Karadeniz
     2017280029
     Exercise 5_3
     */
    public partial class Odev_5_3 : Form
    {
        public double rad;
        public Odev_5_3()
        {
            InitializeComponent();
        }
        private void Calculator(int a)
        {
            try
            {
                rad = Double.Parse(Input.Text);//17 digits
            }
            catch
            {
                toolTip1.Show("Please enter a number", Input);
                return;
            }
            toolTip1.Hide(Input);
            switch(a)
            {
                case 1:
                    Circum.Text = Convert.ToString(rad * Math.PI * 2);
                    break;
                case 2:
                    Areaa.Text = Convert.ToString(Math.Pow( rad,2 ) * Math.PI);
                    break;
                case 3:
                    Volumee.Text = Convert.ToString((Math.Pow( rad,3 ) * Math.PI) *4/3);
                    break;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Calculator(1);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Calculator(2);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Calculator(3);
        }
    }
}