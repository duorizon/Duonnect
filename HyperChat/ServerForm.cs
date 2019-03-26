using System;
using System.Net;
using System.Text;
using System.Windows.Forms;
using SimpleTCP;

namespace HyperChat
{
    public partial class ServerForm : Form
    {
        SimpleTcpServer server;

        public ServerForm()
        {
            InitializeComponent();
        }

        private void ServerForm_Load(object sender, EventArgs e)
        {
            server = new SimpleTcpServer();
            server.Delimiter = 0x13;
            server.StringEncoder = Encoding.UTF8;
            server.DataReceived += Server_DataReceived;
        }

        private void Server_DataReceived(object sender, SimpleTCP.Message e)
        {
            txtStatus.Invoke((MethodInvoker)delegate ()
            {
                txtStatus.Text += e.MessageString;
                //e.ReplyLine(String.Format("You: {0}", e.MessageString));
                server.Broadcast(String.Format(e.MessageString));
            });
        }

        private void StartButton_Click(object sender, EventArgs e)
        {
            txtStatus.Text += "Server Started...";
            IPAddress ip = IPAddress.Parse(hostInput.Text);
            server.Start(ip, Convert.ToInt32(portInput.Text));
            StartButton.Enabled = false;
        }

        private void StopButton_Click(object sender, EventArgs e)
        {
            if (server.IsStarted)
            {
                server.Stop();
            }
        }
    }
}
