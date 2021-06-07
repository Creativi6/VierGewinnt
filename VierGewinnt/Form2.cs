﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VierGewinnt
{
    public partial class Form2 : Form
    {
        private int X, Y;
        private Graphics g;
       
        public Form2(bool Fullscreen)
        {

            InitializeComponent();

            g = this.CreateGraphics();

            if (Fullscreen == true)
            {
                this.FormBorderStyle = FormBorderStyle.None;
                this.WindowState = FormWindowState.Maximized;
            }
            else
            {
                this.FormBorderStyle = FormBorderStyle.FixedSingle;
                this.WindowState = FormWindowState.Normal;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form1 frm = new Form1();

            frm.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            X = 100;
            Y = 100;
            Kreis(X, Y);
        }

        
        
        private void btn_Up_Click(object sender, EventArgs e)
        {
            g.Clear(Form2.DefaultBackColor);
            Y += 100;
            Kreis(X, Y);
        }

        private void btn_down_Click(object sender, EventArgs e)
        {
            g.Clear(Form2.DefaultBackColor);
            Y -= 100;
            Kreis(X, Y);
        }
        private void  Kreis(int X, int Y)
        {
            
            //g = this.CreateGraphics();
           
            //g.DrawEllipse(new Pen(Color.FromName("Red")), 100, 100, 100, 100);

            Color farbe = Color.Goldenrod;
            using (SolidBrush pinsel = new SolidBrush(farbe))
            {
                g.FillEllipse((pinsel), X, Y, 100, 100);
            }
            
        }
    }
}

//http://www.bildungsgueter.de/CSharp/Pages/Beisp002Seite025.htm