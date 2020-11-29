﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace WindowsFormsApp2
{
    public partial class odev6_4 : Form
    {
        public odev6_4()
        {
            InitializeComponent();
        }
 	/*
       * Ramazan Fatih Karadeniz
       * 2017280029
       * Exercise 6.4
       */
        private double a, b;
        private double[] a1,b1 = new double[2];
        private double [] checking(string age)
        {
            double[] ans = new double[2];
            double var;
            try
            {
                var = Convert.ToDouble(age);
                ans[0]= var;
            }
            catch
            {
                toolTip1.Show("Please enter a positive number", calc);
                ans[1] = -1;
                return ans;
            }

            
            return ans;
        }
        private void calc_Click(object sender, EventArgs e)
        {
            a1 = checking(textBox1.Text);
            
            b1 = checking(textBox2.Text);
            
            if (a1[1] == -1|| b1[1]==-1) return;
            else
            {
                a = a1[0]; b = b1[0];
                if (sum.Checked) textBox3.Text = Convert.ToString(a + b);
                else if (mines.Checked) textBox3.Text = Convert.ToString(a - b);
                else if (prod.Checked) textBox3.Text = Convert.ToString(a * b);
                else
                {
                    if(b==0)
                    {
                        textBox3.Text = "Undefined";
                        return;
                    }
                    textBox3.Text = Convert.ToString(a / b);
                }
            }
        }

        private void back_Click(object sender, EventArgs e)
        {
            this.Hide();
            odev6_3 f2 = new odev6_3();
            f2.Closed += (s, args) => this.Close();
            f2.ShowDialog();
        }
    

        private void next_Click(object sender, EventArgs e)
        {
            this.Hide();
            odev6_5 f3 = new odev6_5();
            f3.Closed += (s, args) => this.Close();
            f3.ShowDialog();
        }
    
    }
}
