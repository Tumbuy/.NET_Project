using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;


namespace Notes
{
    public partial class Main1 : Form
    {
        
        public Main1()
        {
         
            InitializeComponent();
            //lblLoggedIn.Text = username;
            
        }

       

        List<Person> People = new List<Person>();
        private void Main_Load(object sender, EventArgs e)
        {



            string path = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData);
            if (!Directory.Exists(path + "\\Notes - Googooli"))
                Directory.CreateDirectory(path + "\\Notes - Googooli");
            if (!File.Exists(path + "\\Notes - Googooli\\settings.xml"))

            {
                XmlTextWriter xW = new XmlTextWriter(path + "\\Notes - Googooli\\settings.xml", Encoding.UTF8);
                xW.WriteStartElement("People");
                xW.WriteEndElement();
                xW.Close();
            }

            XmlDocument xDoc = new XmlDocument();
            xDoc.Load(path + "\\Notes - Googooli\\settings.xml");


            foreach (XmlNode xNode in xDoc.SelectNodes("People/Person"))
            {

                Person p = new Person();
                p.Name = xNode.SelectSingleNode("Name").InnerText;
                p.Address = xNode.SelectSingleNode("Address").InnerText;
                p.Phone = xNode.SelectSingleNode("Phone").InnerText;
                p.Email = xNode.SelectSingleNode("Email").InnerText;
                p.Birthday = DateTime.FromFileTime(Convert.ToInt64(xNode.SelectSingleNode("Birthday").InnerText));
                p.Notes = xNode.SelectSingleNode("Notes").InnerText;
                People.Add(p);
                listPeople.Items.Add(p.Name);

            }

        }

      

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtName.Text))
            {
                MessageBox.Show("Enter a name of your note to continue.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {

                Person p = new Person();
                p.Name = txtName.Text;
                p.Address = txtAddress.Text;
                p.Phone = txtPhone.Text;
                p.Email = txtEmail.Text;
                p.Birthday = DateTimePicker.Value;
                p.Notes = txtNotes.Text;



                People.Add(p);
                listPeople.Items.Add(p.Name);

                txtName.Text = "";
                txtAddress.Text = "";
                txtEmail.Text = "";
                txtPhone.Text = "";
                txtNotes.Text = "";
                DateTimePicker.Value = DateTime.Now;
                MessageBox.Show("Contact Added", "Saved", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
        }

        private void listPeople_SelectedIndexChanged(object sender, EventArgs e)
        {
          
            try
            {
                if (listPeople.SelectedItems.Count == 0) return;
                txtName.Text = People[listPeople.SelectedItems[0].Index].Name;
                txtAddress.Text = People[listPeople.SelectedItems[0].Index].Address;
                txtPhone.Text = People[listPeople.SelectedItems[0].Index].Phone;
                txtEmail.Text = People[listPeople.SelectedItems[0].Index].Email;
                DateTimePicker.Value = People[listPeople.SelectedItems[0].Index].Birthday;
                txtNotes.Text = People[listPeople.SelectedItems[0].Index].Notes;
            }
            catch { }
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
        
            Remove();
            
        }

        void Remove()
        {
            
            try
            {

                People.RemoveAt(listPeople.SelectedItems[0].Index);
                listPeople.Items.Remove(listPeople.SelectedItems[0]);

                txtName.Clear();
                txtAddress.Clear();
                txtEmail.Clear();
                txtNotes.Clear();
                txtPhone.Clear();
                DateTimePicker.Value = DateTime.Now;


            }
                
            catch { }
            
        }
        
        private void removeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Remove();

        }



        private void btnSave_Click(object sender, EventArgs e)
        {
            string path = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData);
            XmlDocument xDoc = new XmlDocument();
            xDoc.Load(path + "\\Notes - Googooli\\settings.xml");
            XmlNode xNode = xDoc.SelectSingleNode("People");
            xNode.RemoveAll();
            foreach (Person p in People)
            {
                XmlNode xTop = xDoc.CreateElement("Person");
                XmlNode xName = xDoc.CreateElement("Name");
                XmlNode xAddress = xDoc.CreateElement("Address");
                XmlNode xPhone = xDoc.CreateElement("Phone");
                XmlNode xEmail = xDoc.CreateElement("Email");
                XmlNode xBirthday = xDoc.CreateElement("Birthday");
                XmlNode xNotes = xDoc.CreateElement("Notes");
                xName.InnerText = p.Name;
                xAddress.InnerText = p.Address;
                xPhone.InnerText = p.Phone;
                xEmail.InnerText = p.Email;
                xBirthday.InnerText = p.Birthday.ToFileTime().ToString();
                xNotes.InnerText = p.Notes;
                xTop.AppendChild(xName);
                xTop.AppendChild(xAddress);
                xTop.AppendChild(xPhone);
                xTop.AppendChild(xEmail);
                xTop.AppendChild(xBirthday);
                xTop.AppendChild(xNotes);
                xDoc.DocumentElement.AppendChild(xTop);

            }

            xDoc.Save(path + "\\Notes - Googooli\\settings.xml"); 

             if (listPeople.SelectedItems.Count == 0) return;
            People[listPeople.SelectedItems[0].Index].Name = txtName.Text;
            People[listPeople.SelectedItems[0].Index].Address = txtAddress.Text;
            People[listPeople.SelectedItems[0].Index].Phone = txtPhone.Text;
            People[listPeople.SelectedItems[0].Index].Email = txtEmail.Text;
            People[listPeople.SelectedItems[0].Index].Birthday = DateTimePicker.Value;
            People[listPeople.SelectedItems[0].Index].Notes = txtNotes.Text;
            listPeople.SelectedItems[0].Text = txtName.Text;
            MessageBox.Show("Changes Saved", "Saved", MessageBoxButtons.OK, MessageBoxIcon.Information);   
        }

        private void Main1_FormClosing(object sender, FormClosingEventArgs e)
        {


            string path = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData);
            XmlDocument xDoc = new XmlDocument();
            xDoc.Load(path + "\\Notes - Googooli\\settings.xml");
            XmlNode xNode = xDoc.SelectSingleNode("People");
            xNode.RemoveAll();
            foreach (Person p in People)
            {
                XmlNode xTop = xDoc.CreateElement("Person");
                XmlNode xName = xDoc.CreateElement("Name");
                XmlNode xAddress = xDoc.CreateElement("Address");
                XmlNode xPhone = xDoc.CreateElement("Phone");
                XmlNode xEmail = xDoc.CreateElement("Email");
                XmlNode xBirthday = xDoc.CreateElement("Birthday");
                XmlNode xNotes = xDoc.CreateElement("Notes");
                xName.InnerText = p.Name;
                xAddress.InnerText = p.Address;
                xPhone.InnerText = p.Phone;
                xEmail.InnerText = p.Email;
                xBirthday.InnerText = p.Birthday.ToFileTime().ToString();
                xNotes.InnerText = p.Notes;
                xTop.AppendChild(xName);
                xTop.AppendChild(xAddress);
                xTop.AppendChild(xPhone);
                xTop.AppendChild(xEmail);
                xTop.AppendChild(xBirthday);
                xTop.AppendChild(xNotes);
                xDoc.DocumentElement.AppendChild(xTop);

            }

            xDoc.Save(path + "\\Notes - Googooli\\settings.xml");
            notifyIcon1.Icon = null;
            Application.Exit();
        }
        
        class Person
        {
            internal string Notes;

            public string Name
            {
                get;
                set;
            }

            public string Email
            {
                get;
                set;
            }

            public string Phone
            {
                get;
                set;
            }

            public string Address
            {
                get;
                set;
            }

            public DateTime Birthday
            {
                get;
                set;
            }

            public string AdditionNotes
            {
                get;
                set;
            }
            
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            txtName.Clear();
            txtAddress.Clear();
            txtEmail.Clear();
            txtPhone.Clear();
            txtNotes.Clear();
            DateTimePicker.Value = DateTime.Now;
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
                
                    Application.Exit();
            
            
        }

        private void newToolStripMenuItem_Click(object sender, EventArgs e)
        {

            txtName.Clear();
            txtAddress.Clear();
            txtEmail.Clear();
            txtPhone.Clear();
            txtNotes.Clear();
            DateTimePicker.Value = DateTime.Now;


        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            About about = new About();
            about.ShowDialog();
        }


        private void exportToFileToolStripMenuItem_Click(object sender, EventArgs e)
        {

            SaveFileDialog sfd = new SaveFileDialog();
            sfd.Title = "Save Text File";
            sfd.DefaultExt = ".txt";
            sfd.InitialDirectory = Application.StartupPath;
            sfd.Filter = "Text Files (*.txt)|*.txt";
            DialogResult result = sfd.ShowDialog();
            if (result == DialogResult.Cancel)
                return;
            TextWriter sw = new StreamWriter(sfd.FileName, false, Encoding.Unicode);
            for (int i = 1; i < listPeople.Items.Count; ++i)
            {
                string name = listPeople.Items[i].SubItems[1].Text;
                sw.WriteLine("-" + name);
            }
            sw.Close();
        }

        private void exportToFileToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Stream myStream;
            SaveFileDialog saveFileDialog1 = new SaveFileDialog();

            saveFileDialog1.Filter = "All files (*.*)|*.*|txt files (*.txt)|*.txt";
            saveFileDialog1.FilterIndex = 2;
            saveFileDialog1.RestoreDirectory = true;

            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                if ((myStream = saveFileDialog1.OpenFile()) != null)
                {

                    myStream.Close();
                }
            }
            }

        private void txtPhone_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;

            if (!Char.IsDigit(ch) && ch != 8 && ch != 46)
            {
                e.Handled = true;
            }
          
        }

        private void Form1_SizeChanged(object sender, EventArgs e)
        {
     
        }

        private void notifyIcon1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            this.Show();
            this.WindowState = FormWindowState.Normal;
    
            notifyIcon1.BalloonTipText = "Normal mode";
            notifyIcon1.ShowBalloonTip(100);
        }

        private void contextMenuStrip2_Opening(object sender, CancelEventArgs e)
        {

        }

        private void exitToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void aboutToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            About about = new About();
            about.ShowDialog();
        }

        private void txtName_TextChanged(object sender, EventArgs e)
        {
            txtName.BackColor = Color.White;
            
        }

        private void txtAddress_TextChanged(object sender, EventArgs e)
        {
            txtAddress.BackColor = Color.White;
        }

        private void txtPhone_TextChanged(object sender, EventArgs e)
        {
            txtPhone.BackColor = Color.White;

        }

     

        private void btnExport_Click_1(object sender, EventArgs e)
        {
 


            
        }

        private void txtName_MouseHover(object sender, EventArgs e)
        {
            if (txtName.Text == "")
            {
                txtName.BackColor = Color.Silver;
            }
            else
            {
                txtName.BackColor = Color.White;
            }
        }

        private void txtName_MouseLeave(object sender, EventArgs e)
        {
            txtName.BackColor = Color.White;
        }

        private void txtAddress_MouseHover(object sender, EventArgs e)
        {
            if (txtAddress.Text == "")
            {
                txtAddress.BackColor = Color.Silver;
            }
            else
            {
                txtAddress.BackColor = Color.White;
            }
        }

        private void txtAddress_MouseLeave(object sender, EventArgs e)
        {
            txtAddress.BackColor = Color.White;
        }

        private void txtPhone_MouseHover(object sender, EventArgs e)
        {
            if (txtPhone.Text == "")
            {
                txtPhone.BackColor = Color.Silver;
            }
            else
            {
                txtPhone.BackColor = Color.White;
            }
        }

        private void txtPhone_MouseLeave(object sender, EventArgs e)
        {
            txtPhone.BackColor = Color.White;
        }

        private void txtEmail_MouseHover(object sender, EventArgs e)
        {
            if (txtEmail.Text == "")
            {
                txtEmail.BackColor = Color.Silver;
            }
            else
            {
                txtEmail.BackColor = Color.White;
            }
        }

        private void txtEmail_MouseLeave(object sender, EventArgs e)
        {
            txtEmail.BackColor = Color.White;
        }

        private void Main1_FormClosed(object sender, FormClosedEventArgs e)
        {
           
            Application.Exit();
        }

        private void lblBirthday_Click(object sender, EventArgs e)
        {

        }


     


        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;

        [DllImportAttribute("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
        [DllImportAttribute("user32.dll")]
        public static extern bool ReleaseCapture();

        private void Main1_MouseDown(object sender, System.Windows.Forms.MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }

        private void xToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {
            this.Hide();
            this.WindowState = FormWindowState.Minimized;
            notifyIcon1.BalloonTipText = "Running in background";
            notifyIcon1.ShowBalloonTip(100);
        }

        private void toolStripMenuItem1_DoubleClick(object sender, EventArgs e)
        {
            
           
        }

        private void btnFont_Click(object sender, EventArgs e)
        {
            FontDialog fontdialog1 = new FontDialog();
            fontdialog1.ShowColor = true;
            if (fontdialog1.ShowDialog()==DialogResult.OK & !String.IsNullOrEmpty(txtNotes.Text)) {

                txtNotes.SelectionFont = fontdialog1.Font;
                txtNotes.SelectionColor = fontdialog1.Color;
                txtNotes.SelectionProtected = true;
                
                
            }
        }

        private void txtNotes_FontChanged(RichTextBox control)
        {
           
        }

        Reminder dlg = new Reminder();
        private DateTime myRemindTime;
        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if (dlg.ShowDialog() == DialogResult.OK)
            {

                myRemindTime = dlg.MyMonthCalendar.SelectionStart.AddHours(dlg.MyTimePicker.Value.Hour).AddMinutes(dlg.MyTimePicker.Value.Minute).AddSeconds(dlg.MyTimePicker.Value.Second);
                this.Visible = false;
               
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (myRemindTime.CompareTo(DateTime.Now) < 0)
            {
                this.Visible = true;
               
            }
          
        }

        private void label2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            this.Hide();
            this.WindowState = FormWindowState.Minimized;
            notifyIcon1.BalloonTipText = "Running in background";
            notifyIcon1.ShowBalloonTip(100);
        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void label2_MouseHover(object sender, EventArgs e)
        {
            label2.ForeColor = Color.Gray;
            label2.BackColor = Color.Black;
            
        }

        private void label2_MouseLeave(object sender, EventArgs e)
        {
            label2.BackColor = Color.Transparent;
            label2.ForeColor = Color.Black;
            
        }

        private void label1_MouseHover(object sender, EventArgs e)
        {
            label1.ForeColor = Color.Gray;
            label1.BackColor = Color.Black;
        }

        private void label1_MouseLeave(object sender, EventArgs e)
        {
            label1.BackColor = Color.Transparent;
            label1.ForeColor = Color.Black;
        }

        private void copyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            txtNotes.Copy();
        }

        private void cutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            txtNotes.Cut();
        }

        private void pasteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            txtNotes.Paste();
        }

        private void contextMenuStrip1_Opening(object sender, CancelEventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://www.paypal.com/cgi-bin/webscr?cmd=_s-xclick&hosted_button_id=7BEQ8JZPWWBF4");
        }
    }
}
