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
        private void btnLuoLista_Click(object sender, EventArgs e)
        {
            nimi = new List<string>();
        }
        private void btnLisää_Click(object sender, EventArgs e)
        {
            foreach (TextBox kentta in Controls.OfType<TextBox>())
            {
                nimi.Add(textBox1.Text);
            }
        }
        private void btnHaku_Click(object sender, EventArgs e)
        {  
            comboBox1.DataSource = nimi;
        }
    }
}
