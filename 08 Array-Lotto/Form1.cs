using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _08_Array_Lotto
{
    public partial class Form1 : Form
    {
        const int lukujenMaara = 7;
        const int SuurinPallo = 41;
        int[] oikeaRivi = new int[lukujenMaara];
        public Form1()
        {
            InitializeComponent();
            label1.Text = "";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Random noppa = new Random();
            for (int i = 0; i < oikeaRivi.Length; i++)
                oikeaRivi[i] = noppa.Next(1, SuurinPallo + 1);

            for (int i = 0; i < oikeaRivi.Length; i++)
            {
                label1.Text = label1.Text + oikeaRivi[i].ToString() + ", ";
                if (i < 6)
                {
                    label1 = label1 
                }
            }
        }
    }
}
        
        //label1.Text = oikeaRivi[1].ToString + ", " + oikeaRivi[2].toString();
