﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp8
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        /*
         Ramazan Fatih Karadeniz
         2017280029
         */
        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            listBox1.Items.Clear();s
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int sum,i,j=0;
            try
            {
                j = Convert.ToInt32(textBox1.Text);
            }
            catch
            {
                MessageBox.Show("Please enter a number","Error");
            }
            for(i=1;i<j;i++)
            {
                sum = 0;
                for(int n=1;n<i;n++)
                {
                    if (i % n == 0) sum += n;
                }
                if (sum == i) listBox1.Items.Add(sum);
            }
        }
    }
}
