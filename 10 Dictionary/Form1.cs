using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _10_Dictionary
{
    public partial class Form1 : Form
    {
        IDictionary<string, string> keyValues;
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
        private void btnLuoDictionary_Click(object sender, EventArgs e)
        {
          keyValues =  new Dictionary<string, string>();
        }
        private void btnHae_Click(object sender, EventArgs e)
        {
            textBox4.Text = keyValues.TryGetValue(textBox3.Text, out textBox4.Text);
        }
        private void btnLisää_Click(object sender, EventArgs e)
        {
            keyValues.Add(new KeyValuePair<string, string>(textBox1.Text, textBox2.Text));

        }
    }
}
