using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;

namespace _05_For
{
    public partial class Form1 : Form
    {
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
            const string message = "Haluatko varmasti lähteä sovelluksesta...?";
            const string caption = "Exit Application";
            var result = MessageBox.Show(message, caption,
                                         MessageBoxButtons.YesNo,
                                         MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
                return true;
            else
                return false;
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            int b;
            b = int.Parse(textBox1.Text);
            for (int i = 0; i < b; i++)
            {
                label1.Text = textBox1.Text;
                Thread.Sleep(500);
                Update();
            }
        }
    }
}
