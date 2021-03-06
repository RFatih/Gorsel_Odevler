﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace WindowsFormsApp7
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }
        int min=1, max=6, till=600;
        private void button1_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
           
            try
            {
                min = Convert.ToInt32(textBox1.Text);
                max = Convert.ToInt32(textBox2.Text);
                till = Convert.ToInt32(textBox3.Text);
            }
            catch
            {
                MessageBox.Show("Please enter numbers!\n Otherwise we will calculate it as min=1 && max=6 && till = 600", "Error!");
            }
            Random r = new Random();
            max++;
            for (int i = 0; i < till; i++)
                try
                { listBox1.Items.Add(r.Next(max - min) + min); }
                catch
                {
                    MessageBox.Show("Max must be greater than min value!", "Error!");
                    break;
                }
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form form1 = new Form1();
            form1.Closed += (s, args) => this.Close();
            form1.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            listBox2.Items.Clear();
            listBox3.Items.Clear();
            List<int> frq = new List<int>();
            foreach (int i in listBox1.Items)
            {
                if (!frq.Contains(i))
                    frq.Add(i);
            }
            frq.Sort();
            foreach (int i in frq)
                listBox2.Items.Add(i + "==>");
            List<int> ans = new List<int>();
            int count = 0;
            foreach (int a in frq)
            {
                count++;
                ans.Add(0);
            }
            foreach (int i in listBox1.Items)
            {          
                for (int j = 0; j < count; j++)
                    if (i == frq[j])
                        ans[j]++;                                  
            }
            foreach (int b in ans)
                listBox3.Items.Add(b);
        }
    }
}
