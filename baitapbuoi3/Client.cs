using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp2
{
    public partial class Client : Form
    {
        public Client()
        {
            InitializeComponent();
        }

        private void btnSend_Click(object sender, EventArgs e)
        {
            UdpClient udpClient = new UdpClient();
            udpClient.Connect(txtInput.Text, 8081);
            Byte[] sendBytes = Encoding.UTF8.GetBytes("");
            udpClient.Send(sendBytes, sendBytes.Length);
        }
    }
}
