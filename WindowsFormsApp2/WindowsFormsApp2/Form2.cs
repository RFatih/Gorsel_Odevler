﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace WindowsFormsApp2
{
    public partial class odev6_2 : Form
    {

        public odev6_2()
        {
            InitializeComponent();
            weight.Text = "60";
            height.Text = "170";
        }
        /*
      * Ramazan Fatih Karadeniz
      * 2017280029
      * Exercise 6.2
      */
        private double kg, cm;
        private int checking(string age)
        {
            int var;
            try
            {
                var = Convert.ToInt32(age);
            }
            catch
            {
                toolTip1.Show("Please enter a positive number", calc);
                return -1;
            }
            
            if (var <= 0) return -1;
            return var;
        }

        private void back_Click(object sender, EventArgs e)
        {
            this.Hide();
            odev6_1 f2 = new odev6_1();
            f2.Closed += (s, args) => this.Close();
            f2.ShowDialog();
        }

        private void next_Click(object sender, EventArgs e)
        {

            this.Hide();
            odev6_3 f3 = new odev6_3();
            f3.Closed += (s, args) => this.Close();
            f3.ShowDialog();
        }

        private void calc_Click(object sender, EventArgs e)
        {
            
            kg = checking(weight.Text);
            cm = checking(height.Text);
            if (kg == -1 || cm == -1) return;
            else
            {
                toolTip1.Hide(calc);
                double bmi = Math.Round( kg / (Math.Pow(cm / 100, 2)),1);
                ans.Text = Convert.ToString(bmi);
                if (bmi <= 18.5) def.Text = "Underweight";
                else if (bmi <= 24.9) def.Text = "Normal weight";
                else if (bmi <= 29.9) def.Text = "Overweight";
                else def.Text = "Obesity";
            }
        }
    }
}
