using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;
using System.Net.Sockets;

namespace Chat_Client
{
    public partial class Form1 : Form
    {
        Socket sck;
        EndPoint epLocal, epRemote;

        public Form1()
        {
            InitializeComponent();

            sck = new Socket(AddressFamily.InterNetwork, SocketType.Dgram, ProtocolType.Udp);
            sck.SetSocketOption(SocketOptionLevel.Socket, SocketOptionName.ReuseAddress, true);

            txtIP_C1.Text = GetLocalIP();
            txtIP_C2.Text = GetLocalIP();
        }

        private string GetLocalIP()
        {
            IPHostEntry host;
            host = Dns.GetHostEntry(Dns.GetHostName());

            foreach (IPAddress ip in host.AddressList)
            {
                if (ip.AddressFamily == AddressFamily.InterNetwork)
                {
                    return ip.ToString();
                }
            }
            return "127.0.0.1";
        }

        private void btnConnect_Click(object sender, EventArgs e)
        {
            try
            {
                epLocal = new IPEndPoint(IPAddress.Parse(txtIP_C1.Text), Convert.ToInt32(txtPort_C1.Text));
                sck.Bind(epLocal);

                epRemote = new IPEndPoint(IPAddress.Parse(txtIP_C2.Text), Convert.ToInt32(txtPort_C2.Text));
                sck.Connect(epRemote);

                byte[] buffer = new byte[1500];
                sck.BeginReceiveFrom(buffer, 0, buffer.Length, SocketFlags.None, ref epRemote, new AsyncCallback(MessageCallBack), buffer);

                btnConnect.Text = "Connected";
                btnConnect.Enabled = false;
                btnSend.Enabled = true;
                txtMessage.Focus();

            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void btnSend_Click(object sender, EventArgs e)
        {
            DateTime now = DateTime.Now;

            if (string.IsNullOrWhiteSpace(txtMessage.Text))
            {
                MessageBox.Show("Enter text");
            }

            try
            {
                System.Text.UTF8Encoding enc = new System.Text.UTF8Encoding();
                byte[] msg = new byte[1500];
                msg = enc.GetBytes(txtMessage.Text);

                sck.Send(msg);

                listMessage.Items.Add(DateTime.Now + " You: " + txtMessage.Text);
                txtMessage.Clear();


            }

            catch
            {
                MessageBox.Show("Host not connected");
            }

        }

        private void txtMessage_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                e.SuppressKeyPress = true;
                e.Handled = true;
                btnSend.PerformClick();
            }

       
        }

        private void Form1_SizeChanged(object sender, EventArgs e)
        {
            if (this.WindowState == FormWindowState.Minimized)
            {

                notifyIcon1.BalloonTipText = "Running in background.";
                notifyIcon1.ShowBalloonTip(500);
            }
            else if (this.WindowState == FormWindowState.Normal)
            {
                notifyIcon1.BalloonTipText = "Normal mode.";
                notifyIcon1.ShowBalloonTip(500);
            }
        }

        private void btnShow_Click(object sender, EventArgs e)
        {
            IPHostEntry host;
            string localIP = "?";
            host = Dns.GetHostEntry(Dns.GetHostName());

            foreach (IPAddress ip in host.AddressList)
            {
                if (ip.AddressFamily.ToString() == "InterNetwork")

                    localIP = ip.ToString();
                listBox1.Items.Add(localIP);
            }
        }

        private void MessageCallBack(IAsyncResult aResult)
        {
            try
            {
                int size = sck.EndReceiveFrom(aResult, ref epRemote);
                if (size > 0)
                {
                    byte[] receivedData = new byte[1464];

                    receivedData = (byte[])aResult.AsyncState;

                    UTF8Encoding eEncoding = new UTF8Encoding();
                    string receivedMessage = eEncoding.GetString(receivedData);

                    listMessage.Items.Add(DateTime.Now + " Friend: " + receivedMessage);
                }
                byte[] buffer = new byte[1500];
                sck.BeginReceiveFrom(buffer, 0, buffer.Length, SocketFlags.None, ref epRemote, new AsyncCallback(MessageCallBack), buffer);
            }

            catch 
            {
                MessageBox.Show("Host Disconnected");
            }
        }
    }
}
