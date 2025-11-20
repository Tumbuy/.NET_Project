using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Youtube___Lyrics
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnAra_Click(object sender, EventArgs e)
        {
            webBrowser1.Navigate("http://sarki.alternatifim.com/listele.asp?fsarkici=" + txtSarkici.Text + "&fsarki=" + txtSarki.Text);
        }

        private void btnTemizle_Click(object sender, EventArgs e)
        {
            txtSarki.Clear();
            txtSarkici.Clear();
        }

        private void txtSarki_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnAra.PerformClick();
                e.SuppressKeyPress = true;
            }
        }

        private void txtSarkici_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnAra.PerformClick();
                e.SuppressKeyPress = true;
            }
        }

        private void webBrowser1_NewWindow(object sender, CancelEventArgs e)
        {
            webBrowser1.Navigate(webBrowser1.StatusText);
            e.Cancel = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            webBrowser2.Navigate("https://www.youtube.com/results?search_query=" + textBox1.Text);
        }

        private void btnYouTube_Click(object sender, EventArgs e)
        {
            webBrowser2.Navigate("https://www.youtube.com/");
        }
    }
}
