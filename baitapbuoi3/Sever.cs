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
using System.Threading;

namespace WindowsFormsApp2
{
    public partial class Sever : Form
    {
        public Sever()
        {
            InitializeComponent();
        }

        private void Sever_Load(object sender, EventArgs e)
        {
            Thread thdUDPServer = new Thread(new ThreadStart(serverThread));
            thdUDPServer.Start();
        }

        public void serverThread()
        {
            UdpClient udpClient = new UdpClient(8081);
            while (true)
            {
                IPEndPoint RemoteIpEndPoint = new IPEndPoint(IPAddress.Any, 0);
                Byte[] receiveBytes = udpClient.Receive(ref RemoteIpEndPoint);
                string returnData = Encoding.UTF8.GetString(receiveBytes);
                this.Invoke((MethodInvoker)delegate {
                    lbConnections.Items.Add(RemoteIpEndPoint.Address.ToString() + ":" + returnData.ToString());
                });
            }
        }

    }
}
