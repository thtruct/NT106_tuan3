using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;
using System.Net.Sockets;

namespace UDP
{
    public partial class UDP_Server : Form
    {
        private Thread UDP;
        private bool shouldRun;
        public UDP_Server()
        {
            InitializeComponent();
            shouldRun = false;
            UDP = new Thread(new ThreadStart(ListenUdpThread));
            b_Connect.Enabled = true;
        }
        private void b_Connect_Click(object sender, EventArgs e)
        {
            if (!UDP.IsAlive)
            {
                int port;
                if (!ValidatePortNumber(txtPort.Text, out port))
                {
                    return;
                }
                shouldRun = true;
                UDP = new Thread(new ThreadStart(ListenUdpThread));
                UDP.Start();
                b_Connect.Enabled = true;
                b_Connect.Text = "Disconnect";
            }
            else
            {
                shouldRun = false;
                UDP.Join();
                b_Connect.Enabled = true;
                b_Connect.Text = "Connect";
            }
        }



        private bool ValidatePortNumber(string portString, out int port)
        {
            if (!int.TryParse(portString, out port))
            {
                MessageBox.Show("Số port nhập vào phải là 1 số nguyên");
                return false;
            }
            b_Connect.Enabled = true;
            return true;
        }
        private void ListenUdpThread()
        {
            using (UdpClient client = new UdpClient())
            {
                int port;
                if (!ValidatePortNumber(txtPort.Text, out port))
                {
                    return;
                }

                client.Client.Bind(new IPEndPoint(IPAddress.Any, port));
                client.Client.ReceiveTimeout = 1000;

                while (shouldRun)
                {
                    try
                    {
                        IPEndPoint remoteEp = new IPEndPoint(IPAddress.Any, 0);
                        byte[] receiveData = client.Receive(ref remoteEp);
                        string message = Encoding.UTF8.GetString(receiveData);
                        string data = String.Format("{0}:{1}", remoteEp.Address, message);

                        Action updateUI = () => rReceiveMessages.AppendText(Environment.NewLine + data);
                        this.BeginInvoke(updateUI);
                    }
                    catch (SocketException ex)
                    {
                        if (ex.SocketErrorCode != SocketError.TimedOut)
                        {
                            MessageBox.Show("Lỗi kết nối: " + ex.Message);
                            break;
                        }
                    }
                }
            }
        }
        
    }
}
