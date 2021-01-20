﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp7
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
	/*
	*Ramazan Fatih Karadeniz
	*2017280029
	*Odev 9.4 && 9.5
	**/
        private void button1_Click(object sender, EventArgs e)
        {
            richTextBox1.Clear();
            int i;
            Random r = new Random();
            if(radioButton1.Checked)
            {
                
                for (i=0;i<10;)
                {
                    int num = r.Next(100);
                    if(num%2==0)
                    {
                        richTextBox1.AppendText(Convert.ToString(num)+Environment.NewLine);
                        i++;
                    }
                }
            }
            else if (radioButton2.Checked)
            {
                
                for (i = 1; i < 10;)
                {
                    int num = r.Next(100);
                    if (num % 2 == 1)
                    {
                        richTextBox1.AppendText(Convert.ToString(num) + Environment.NewLine);
                        i++;
                    }
                }
            }
            else
            {
                
                for (i = 0; i < 10;i++)
                {
                    int num = r.Next(100);
                    richTextBox1.AppendText(Convert.ToString(num) + Environment.NewLine);
                }
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            double toplam, ort;
            int i, n, range, sayi,min,max;
            toplam = ort =sayi= 0;
            min = max = Convert.ToInt32(richTextBox1.Lines[0]);
            n = richTextBox1.Lines.Length;
            for(i=0;i<n-1;i++)
            {
                sayi = Convert.ToInt32(richTextBox1.Lines[i]);
                toplam += sayi;
                if (sayi < min) min = sayi;
                if (sayi > max) max = sayi;

            }
            ort = toplam / n;
            range = max - min;
            if (comboBox1.SelectedIndex == -1) MessageBox.Show("Please Select an operation!", "Error");
            else if (comboBox1.SelectedItem.ToString() == "Mean") textBox1.Text = ort.ToString();
            else if (comboBox1.SelectedItem.ToString() == "Min") textBox1.Text = min.ToString();
            else if (comboBox1.SelectedItem.ToString() == "Max") textBox1.Text = max.ToString();
            else textBox1.Text = range.ToString();
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            richTextBox1.Clear();
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            richTextBox1.Clear();
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            richTextBox1.Clear();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            textBox1.Clear();
        }
    }
}
