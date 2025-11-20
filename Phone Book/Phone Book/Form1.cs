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

namespace Phone_Book
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnNew_Click(object sender, EventArgs e)
        {

            try
            {
                panel1.Enabled = true;
                App.PhoneBook.AddPhoneBookRow(App.PhoneBook.NewPhoneBookRow());
                phoneBookBindingSource.MoveLast();
                txtPhone.Focus();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                App.PhoneBook.RejectChanges();
            }

        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            panel1.Enabled = true;
            txtPhone.Focus();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            phoneBookBindingSource.ResetBindings(false);
            panel1.Enabled = false;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                phoneBookBindingSource.EndEdit();
                App.PhoneBook.AcceptChanges();
                App.PhoneBook.WriteXml(string.Format("{0}//data.dat", Application.StartupPath));
                panel1.Enabled = false;
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                App.PhoneBook.RejectChanges();
            }
        }

    static AppData db;

        protected static AppData App
        {
            get
            {
                if (db == null)
                    db = new AppData();
                return db;
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            string filename = string.Format("{0}//data.dat", Application.StartupPath);
            if (File.Exists(filename))
                App.PhoneBook.ReadXml(filename);
            phoneBookBindingSource.DataSource = App.PhoneBook;
            panel1.Enabled = false;
        }

        private void dataGridView1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Delete)
            {
                if (MessageBox.Show("Are you sure you want to delete this record?", "Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    phoneBookBindingSource.RemoveCurrent();
                App.PhoneBook.AcceptChanges();
                App.PhoneBook.WriteXml(string.Format("{0}//data.dat", Application.StartupPath));
            }
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)13)
            {

                if (!string.IsNullOrEmpty(textBox1.Text))
                {
                    var query = from o in App.PhoneBook
                                where o.PhoneNumber == textBox1.Text || o.FullName.Contains(textBox1.Text) || o.Email == textBox1.Text
                                select o;
                    dataGridView1.DataSource = query.ToList();

                }
                else
                {
                    dataGridView1.DataSource = phoneBookBindingSource;
                }
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure you want to delete this record?", "Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                phoneBookBindingSource.RemoveCurrent();
            App.PhoneBook.AcceptChanges();
            App.PhoneBook.WriteXml(string.Format("{0}//data.dat", Application.StartupPath));

        }
    }
}
