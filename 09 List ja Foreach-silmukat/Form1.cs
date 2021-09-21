using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _09_List_ja_Foreach_silmukat
{
    public partial class Form1 : Form
    {
        List<String> nimi;

        public Form1()
        {
            InitializeComponent();
        }

        private void btnLuoLista_Click(object sender, EventArgs e)
        {
            nimi = new List<string>();
        }
        private void btnLisää_Click(object sender, EventArgs e)
        {
            nimi.Add(textBox1.Text);
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
  
        }

        private void btnHaku_Click(object sender, EventArgs e)
        {
            foreach (Control x in this.Controls)
            {
                if (x is TextBox)
                {
                    ((TextBox)x).Text = string.Empty;
                    comboBox1.Items.Add(nimi);
                }
            }
            //comboBox1.Items.Add(textBox1);   
            //comboBox1.DataSource = nimi;
            //comboBox1.Update();
        }
    }
}
