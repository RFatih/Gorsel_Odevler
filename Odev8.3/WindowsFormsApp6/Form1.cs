﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp6
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        /*
         * Ramazan Fatih Karadeniz
         * 2017280029
         * */
        private void button1_Click(object sender, EventArgs e)
        {
            int i, sum = 0;
            textBox1.Text = "With For=> ";
            for (i = 0; i <= 100; i++) sum += i; 
            textBox1.Text += Convert.ToString(sum)+Environment.NewLine+ "With while=> ";
            sum = i = 0;
           

            while (i <= 100)
            {
                sum += i;
                i++;
            }
            
            textBox1.Text +=  Convert.ToString(sum) + Environment.NewLine + "With do while=> ";
            sum = i = 0;
            do
            {
                sum += i;
                i++;
            }
            while (i <= 100);
            textBox1.Text += Convert.ToString(sum);
        }
    }
}
