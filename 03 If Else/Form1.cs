using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _01_Windows_Forms
{
    public partial class Form1 : Form

    {
        string currentYear = DateTime.Now.Year.ToString();
        public Form1()
        {
            InitializeComponent();
            this.ActiveControl = textBox4;
            textBox2.Focus();
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
        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            textBox1.ReadOnly = true;
        }
        private void PoistuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        private void infoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Tämän sovelluksen on tehnyt Mikael Makkonen");
        }
        private void tiedostoToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
        private void button1_Click(object sender, EventArgs e)
        {
            textBox1.Text = "0";
            textBox2.Text = "[Syötä elokuvan nimi]";
            textBox3.Text = currentYear;
            textBox4.Text = "0";
            richTextBox1.Text = "[Kirjoita arvio tähän]";

            textBox2.Focus();
        }
        private void textBox2_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                textBox4.Focus();
            }
        }
        private void textBox4_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                richTextBox1.Focus();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int parsedValue;

            if (string.IsNullOrEmpty(textBox2.Text))
            {
                MessageBox.Show("Et ole syöttänyt mitään nimi-kenttään!");
            }
            else if (string.IsNullOrEmpty(textBox3.Text))
            {
                MessageBox.Show("Et ole syöttänyt mitään julkaisuvuosi-kenttään!");
            }
            else if (!int.TryParse(textBox3.Text, out parsedValue))
            {
                MessageBox.Show("Julkaisuvuosi-kenttä hyväksyy ainoastaan kirjaimia!");
            }
            else if (string.IsNullOrEmpty(textBox4.Text))
            {
                MessageBox.Show("Et ole syöttänyt mitään kesto-kenttään!");
            }
            else if (!int.TryParse(textBox4.Text, out parsedValue))
            {
                MessageBox.Show("Julkaisuvuosi-kenttä hyväksyy ainoastaan kirjaimia!");
            }
            else
            {
                MessageBox.Show("Checck OK!");
            }
        }

        // Toimisi ehkä myös tällä taktiikalla

        // if methodi joka ei hyväksy kirjaimia

        //private void textBox1_keyPress(object sender, KeyPressEventArgs e)
        //{
        //    if (e.Handled = !char.IsDigit(e.KeyChar))
        //    {
        //        MessageBox.Show("Hyväksytään pelkkiä numeroita");
        //    }
        //}

        // ei anna käyttäjän kirjottaa kirjaimia (pelkästään numeroita)

        //private void textBox3_KeyPress(object sender, KeyPressEventArgs e)
        //{
        //    if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
        //    {
        //        e.Handled = true;
        //    }

        //    if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
        //    {
        //        e.Handled = true;
        //    }
        //}

        //private void textBox4_KeyPress(object sender, KeyPressEventArgs e)
        //{
        //    if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
        //    {
        //        e.Handled = true;
        //    }

        //    if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
        //    {
        //        e.Handled = true;
        //    }
        //}
    }
}
