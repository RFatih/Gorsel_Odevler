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
         * Ramazan Fatih Karadeniz
         * Odev 10
         * 2017280029
         * */
        private int Monte_Carlo_Square(BackgroundWorker worker, DoWorkEventArgs e)
        {
            Control.CheckForIllegalCrossThreadCalls = false;
            double x, y,x1,y1,sum=0;
            progressBar1.Maximum = 1000;
            progressBar1.Step = 1;
            progressBar1.Value = 0;
                Random r = new Random();
                for (int i =0; i<1000;i++)
                {
                    x = r.NextDouble();
                    y = r.NextDouble();
                    x1 = r.NextDouble();
                    y1 = r.NextDouble();
                    if (Math.Sqrt((Math.Pow(Math.Abs(x1 - x), 2) + Math.Pow(Math.Abs(y1 - y), 2)))< 0.8)
                {
                    sum++; 
                    progressBar1.PerformStep();
                }
                        
                    textBox1.Text =(sum/1000).ToString();
                label1.Text = "%" + (sum / 10).ToString();
              
                
                }
            
            return 0;
        }
        private int Monte_Carlo_Walk(BackgroundWorker worker,DoWorkEventArgs e)
        {
            Control.CheckForIllegalCrossThreadCalls = false;
            int x, sum;
            double ans = 0;
            progressBar3.Value = 0;
            progressBar3.Maximum = 1000;
            progressBar3.Step = 1;
            Random r = new Random();
            for(int i=0;i<1000;i++)
            {
                sum = 0;
                for(int j =0;j<100;j++)
                {
                x = r.Next(3) - 1;
                sum += x;
                }
                if (Math.Abs(sum) >= 10)
                { 
                    ans++;
                    progressBar3.PerformStep();
                }
            textBox3.Text = (ans / 1000).ToString();
            label3.Text = "%" + (ans / 10).ToString();
        }
            
            return 0;
        }
        private int Monte_Carlo_Pi(BackgroundWorker worker , DoWorkEventArgs e)
        {
            Control.CheckForIllegalCrossThreadCalls = false;
            double x, y,sum=0;
            progressBar2.Value = 0;
            progressBar2.Maximum = 1000;
            progressBar2.Step=1;
            Random r = new Random();
            for(int i=0;i<1000;i++)
            {
                x = r.NextDouble();
                y = r.NextDouble();
                if (Math.Sqrt(Math.Pow(x, 2) + Math.Pow(y, 2)) <= 1.0)
                {
                    sum++;
                    progressBar2.PerformStep();
                }
                textBox2.Text = (4*sum / 1000).ToString();
                label2.Text = "%" + (sum/ 10).ToString();

            }
            return 0;
        }
        private void button1_Click(object sender, EventArgs e)
        {
            if (!backgroundWorker1.IsBusy)
                backgroundWorker1.RunWorkerAsync();
            if (!backgroundWorker2.IsBusy)
                backgroundWorker2.RunWorkerAsync();
            if (!backgroundWorker3.IsBusy)
                backgroundWorker3.RunWorkerAsync();
        }

        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {
            BackgroundWorker worker = sender as BackgroundWorker;
            Control.CheckForIllegalCrossThreadCalls = false;
            e.Result = Monte_Carlo_Square(worker, e);
        }

        private void backgroundWorker2_DoWork(object sender, DoWorkEventArgs e)
        {
            BackgroundWorker worker = sender as BackgroundWorker;
            Control.CheckForIllegalCrossThreadCalls = false;
            e.Result = Monte_Carlo_Pi(worker, e);
        }

        private void backgroundWorker3_DoWork(object sender, DoWorkEventArgs e)
        {
            BackgroundWorker worker = sender as BackgroundWorker;
            Control.CheckForIllegalCrossThreadCalls = false;
            e.Result = Monte_Carlo_Walk(worker, e);
        }
    }
}
