﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace WindowsFormsApp8
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }
        List<string> yolcu= new List<string>();
        bool flag = false;
        private void button1_Click(object sender, EventArgs e)
        {
            
            if (textBox1.Text != "")
            { 
                try
                {
                    int k = Convert.ToInt32(textBox5.Text);
                }
                catch
                {
                    MessageBox.Show("Error! Please enter a seat number.", "Error");
                    return;
                }
                yolcu.Add(textBox1.Text);
                yolcu.Add(textBox2.Text);
                yolcu.Add(textBox3.Text);
                yolcu.Add(textBox4.Text);
                yolcu.Add(textBox5.Text);
                groupBox1.Visible = false;
                MessageBox.Show("Rezervasyon başarı ile yapıldı", "Başarılı");
                foreach (Control control in groupBox1.Controls)
                    control.Text = "";
            }
            else
                groupBox1.Visible = true;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            flag = false;
            if (textBox6.Text != "")
            {


                if (yolcu.Contains(textBox6.Text))
                    MessageBox.Show("Yolcu bulundu!\n" + "İsim: "
                      + yolcu[yolcu.IndexOf(textBox6.Text)] + "\nSoyisim: "
                      + yolcu[yolcu.IndexOf(textBox6.Text) + 1] + "\nKalkış: "
                      + yolcu[yolcu.IndexOf(textBox6.Text) + 2] + "\nVarış: "
                      + yolcu[yolcu.IndexOf(textBox6.Text) + 3] + "\nKoltuk no: "
                      + yolcu[yolcu.IndexOf(textBox6.Text) + 4], "Başarılı");
                else
                    MessageBox.Show("Yolcu bulunamadı rezarvasyon gereki!", "Hata");
                groupBox2.Visible = false;
                textBox6.Text = "";
            }
            else
                groupBox2.Visible = true;
        }

        private void button4_Click(object sender, EventArgs e)
        {

            Form1 form1 = new Form1();
            this.Hide();
            form1.Closed += (s, args) => this.Close();
            form1.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            flag = true;
            if (textBox6.Text != "")
            {


                if (yolcu.Contains(textBox6.Text))
                    MessageBox.Show("Yolcu bulundu!\n" + "İsim: "
                      + yolcu[yolcu.IndexOf(textBox6.Text)-4] + "\nSoyisim: "
                      + yolcu[yolcu.IndexOf(textBox6.Text) -3] + "\nKalkış: "
                      + yolcu[yolcu.IndexOf(textBox6.Text) -2] + "\nVarış: "
                      + yolcu[yolcu.IndexOf(textBox6.Text) -1] + "\nKoltuk no: "
                      + yolcu[yolcu.IndexOf(textBox6.Text) ], "Başarılı");
                else
                    MessageBox.Show("Yolcu bulunamadı rezarvasyon gereki!", "Hata");
                groupBox2.Visible = false;
                textBox6.Text = "";
            }
            else
                groupBox2.Visible = true;
        }

        private void Ara_Click(object sender, EventArgs e)
        {
            if (flag)
                button3_Click(sender,e);
            else
                button2_Click(sender, e);
        }
    }
}
