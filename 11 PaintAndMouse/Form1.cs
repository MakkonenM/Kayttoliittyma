﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _11_PaintAndMouse
{
    public partial class Form1 : Form
    {
        Point piste = new Point(520, 333);

        public Form1()
        {
            InitializeComponent();
        }
        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            if (CloseCancel() == false)
            {
                e.Cancel = true;
            }
        }
        public static bool CloseCancel()
        {
            const string message = "Haluatko varmasti poistua sovelluksesta?";
            const string caption = "Poistu Sovelluksesta";
            var result = MessageBox.Show(message, caption,
                                         MessageBoxButtons.YesNo,
                                         MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
                return true;
            else
                return false;
        }


        private void MainForm1_Paint(object sender, PaintEventArgs e)
        {
            Graphics Graf = e.Graphics;

            // - Pää 
            Graf.FillEllipse(Brushes.IndianRed, piste.X - 4, piste.Y - 8, 49, 49);
            Graf.DrawEllipse(Pens.Black, piste.X - 4, piste.Y - 8, 49, 49);

            // - Selkä 
            Graf.DrawLine(Pens.Black, piste.X + 21, piste.Y + 41,
            piste.X + 21, piste.Y + 131);

            // - Kädet 
            Graf.DrawLine(Pens.Black, piste.X - 30, piste.Y + 60,
            piste.X + 70, piste.Y + 60);

            // - Jalat 
            Graf.DrawLine(Pens.Black, piste.X + 21, piste.Y + 131,
            piste.X - 30, piste.Y + 181);
            Graf.DrawLine(Pens.Black, piste.X + 21, piste.Y + 131,
            piste.X + 70, piste.Y + 181);

            DrawCordinates(Graf);
        }
        private void DrawCordinates(Graphics Graf)
        {
            // Piirretään piirtokoordinaattien arvot näytölle. 
            Graf.DrawString("(" + piste.X + " ," + piste.Y + ")",

            new Font("Arial", 14, System.Drawing.FontStyle.Regular),
            new SolidBrush(Color.Black), 8, 30);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int txtbox1 = int.Parse(textBox1.Text);
            int txtbox2 = int.Parse(textBox2.Text);

            piste.X = txtbox1;
            piste.Y = txtbox2;
               
            Invalidate();
        }
        private void MainForm_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            { 
                piste = e.Location;
                Invalidate();
            }
        }
    }
}
