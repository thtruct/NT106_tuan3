using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Sockets;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UDP
{
    public partial class UDP_Client : Form
    {
        public UDP_Client()
        {
            InitializeComponent();
        }
        private bool ValidateIpAddress(string ipAddressString, out IPAddress ipAddress)
        {
            if (!IPAddress.TryParse(ipAddressString, out ipAddress))
            {
                MessageBox.Show("Địa chỉ IP không hợp lệ");
                return false;
            }
            if (ipAddress.AddressFamily != AddressFamily.InterNetwork)
            {
                MessageBox.Show("Địa chỉ IP không đúng định dạng.");
                return false;
            }
            return true;
        }

        private void button1_Click(object sender, EventArgs e)
        {

            string ip = txtIPRemoteHost.Text;
            if (!ValidateIpAddress(ip, out IPAddress address))
            {
                return;
            }

            using (UdpClient client = new UdpClient())
            {

                if (!int.TryParse(txtPort.Text, out int port))
                {
                    MessageBox.Show("Port phải là 1 con số nguyên");
                    return;
                }

                byte[] sendMessage = Encoding.UTF8.GetBytes(rMessages.Text);
                client.Send(sendMessage, sendMessage.Length, txtIPRemoteHost.Text, port);
            }
        }
    }
}
