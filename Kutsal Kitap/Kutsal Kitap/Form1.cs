using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Kutsal_Kitap
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            timer1.Start();
        }

        private void btnIncil_Click(object sender, EventArgs e)
        {
            webBrowser1.Navigate("http://incil.info");
        }

        private void btnBible_Click(object sender, EventArgs e)
        {
            webBrowser1.Navigate("http://www.bibleserver.com");
        }

        private void btnYouTube_Click(object sender, EventArgs e)
        {
            webBrowser1.Navigate("http://www.youtube.com");
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            label1.Text = DateTime.Now.ToLongTimeString();
            label2.Text = DateTime.Now.ToLongDateString();
            
        }

  
        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            About about = new About();
            about.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            webBrowser1.Navigate("https://www.youtube.com/results?search_query=" + textBox1.Text);
        }
    }
}
