﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _12_Keyboard
{
    public partial class Form1 : Form
    {
        Point piste = new Point(370, 150);
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

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.D)
            {
                piste.X += 5;
            }
            else if (e.KeyData == Keys.A)
            {
                piste.X -= 5;
            }
            else if (e.KeyData == Keys.W)
            {
                piste.Y -= 5;
            }
            else if (e.KeyData == Keys.S)
            {
                piste.Y += 5;
            }
        }

        private void Form1_KeyUp(object sender, KeyEventArgs e)
        {
            Invalidate();
            
        }
    }
}
