﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp5
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
         */
        private bool flag = false;
        private void button1_Click(object sender, EventArgs e)
        {
            if (!flag)
            {


                for (int i = 0; i < 9; i++)
                {
                    
                    if (listBox1.Items[i].ToString() == "90-100") listBox2.Items.Add("AA");
                    else if (listBox1.Items[i].ToString() == "85-89") listBox2.Items.Add("BA");
                    else if (listBox1.Items[i].ToString() == "80-84") listBox2.Items.Add("BB");
                    else if (listBox1.Items[i].ToString() == "75-79") listBox2.Items.Add("CB");
                    else if (listBox1.Items[i].ToString() == "70-74") listBox2.Items.Add("CC");
                    else if (listBox1.Items[i].ToString() == "65-69") listBox2.Items.Add("DC");
                    else if (listBox1.Items[i].ToString() == "60-64") listBox2.Items.Add("DD");
                    else if (listBox1.Items[i].ToString() == "50-59") listBox2.Items.Add("FD");
                    else listBox2.Items.Add("FF");
                }

                for (int i = 0; i < 9; i++)
                {
                    
                    if (listBox1.Items[i].ToString() == "90-100") listBox3.Items.Add("4.00");
                    else if (listBox1.Items[i].ToString() == "85-89") listBox3.Items.Add("3.50");
                    else if (listBox1.Items[i].ToString() == "80-84") listBox3.Items.Add("3.00");
                    else if (listBox1.Items[i].ToString() == "75-79") listBox3.Items.Add("2.50");
                    else if (listBox1.Items[i].ToString() == "70-74") listBox3.Items.Add("2.00");
                    else if (listBox1.Items[i].ToString() == "65-69") listBox3.Items.Add("1.50");
                    else if (listBox1.Items[i].ToString() == "60-64") listBox3.Items.Add("1.00");
                    else if (listBox1.Items[i].ToString() == "50-59") listBox3.Items.Add("0.50");
                    else listBox3.Items.Add("0.00");
                }
            }
            else MessageBox.Show("Already Created", "Attention!");
            flag = true;
        }
    }
}
