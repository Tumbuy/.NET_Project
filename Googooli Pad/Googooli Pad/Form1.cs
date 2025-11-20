using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Googooli_Pad
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private RichTextBox GetrichTextBox()
        {
            RichTextBox rtb = null;
            TabPage tp = tabControl1.SelectedTab;

            if (tp != null)
            {
                rtb = tp.Controls[0] as RichTextBox;
            }

            return rtb;
        }

        private void newToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TabPage tp = new TabPage("New Document");
            RichTextBox rtb = new RichTextBox();
            rtb.Dock = DockStyle.Fill;

            tp.Controls.Add(rtb);
            tabControl1.TabPages.Add(tp);
        }

        private void cutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            GetrichTextBox().Cut();
        }

        private void copyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            GetrichTextBox().Copy();
        }

        private void pasteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            GetrichTextBox().Paste();
        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Stream myStream;
            OpenFileDialog opeopenFileDialog1 = new OpenFileDialog();

            if (openFileDialog1.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                if ((myStream = openFileDialog1.OpenFile()) != null)
                {
                    string strfilename = openFileDialog1.FileName;
                    string filetext = File.ReadAllText(strfilename);
                    GetrichTextBox().Text = filetext;

                    tabControl1.SelectedTab.Text = Path.GetFileName(openFileDialog1.FileName);
                }
            }
        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog1 = new SaveFileDialog();
            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                using (Stream s = File.Open(saveFileDialog1.FileName, FileMode.CreateNew))
                using (StreamWriter sw = new StreamWriter(s))
                {
                    sw.Write(GetrichTextBox().Text);
                }
            }
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            int index = 0;
            String temp = GetrichTextBox().Text;
            GetrichTextBox().Text = "";
            GetrichTextBox().Text = temp;

            while (index < GetrichTextBox().Text.LastIndexOf(toolStripTextBox1.Text))
            {
                GetrichTextBox().Find(toolStripTextBox1.Text, index, GetrichTextBox().TextLength, RichTextBoxFinds.None);
                GetrichTextBox().SelectionBackColor = Color.Orange;
                index = GetrichTextBox().Text.IndexOf(toolStripTextBox1.Text, index) + 1;
            }
        }
    }
}
