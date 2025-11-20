using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace Address_Book
{
    public partial class Login : Form
    {
        public Login()
        {
      
            InitializeComponent();
            
        }

       
        

        private void txtUsername_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)13)
                txtPass.Focus();

        }

        private void txtPass_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)13)
                btnLogin.PerformClick();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtUsername.Text))
            {
                MessageBox.Show("Enter username", "Message", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtUsername.Focus();
                return;
            }
            
            string username = "Himmet";
            string password = "admin";

            if ((txtUsername.Text == username) && (txtPass.Text == password))
            {
                MessageBox.Show("You have successfully logged in!", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Hide();
                //Main1 frmMain = new Main1("Welcome " + txtUsername.Text);
               // frmMain.ShowDialog();
                this.Close();
            }
            else 
            {
                MessageBox.Show("Enter valid password", "Message", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
   
        }

        private void Login_Load(object sender, EventArgs e)
        {
            txtUsername.Focus();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Login_FormClosing(object sender, FormClosingEventArgs e)
        {

            Application.Exit();
        }

        private void Login_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void txtUsername_MouseHover(object sender, EventArgs e)
        {
            txtUsername.Focus();
        } 
    } 
}
