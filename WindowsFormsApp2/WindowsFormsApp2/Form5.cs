﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace WindowsFormsApp2
{
    public partial class odev7_1 : Form
    {
        public odev7_1()
        {
            InitializeComponent();
        }
 	/*
       * Ramazan Fatih Karadeniz
       * 2017280029
       * Exercise 7.1
       */
        private void add_Click(object sender, EventArgs e)
        {
            if (!items.Items.Contains(element.Text))
            {
                toolTip1.Hide(element);
                items.Items.Add(element.Text);
            }
                
            else
                toolTip1.Show("This item already added", element);
        }

        private void back_Click(object sender, EventArgs e)
        {

            this.Hide();
            odev6_5 f2 = new odev6_5();
            f2.Closed += (s, args) => this.Close();
            f2.ShowDialog();
        }

        private void next_Click(object sender, EventArgs e)
        {

            this.Hide();
            odev7_2 f3 = new odev7_2();
            f3.Closed += (s, args) => this.Close();
            f3.ShowDialog();
        }
    }
}
