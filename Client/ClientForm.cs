using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SimpleTCP;

namespace Client
{
    public partial class ClientForm : Form
    {
        Messages sm;
        SimpleTcpClient client;

        public ClientForm()
        {
            InitializeComponent();
        }

        private void ClientForm_Load(object sender, EventArgs e)
        {
            client = new SimpleTcpClient();
            client.StringEncoder = Encoding.UTF8;
            client.DataReceived += Client_DataReceived;
        }

        private void SendMessageInput_Click(object sender, EventArgs e)
        {
            client.WriteLine(String.Format("{0}: {1}", NameInput.Text, MessageInput.Text));
        }

        private void StartInput_Click(object sender, EventArgs e)
        {
            StartInput.Enabled = false;
            client.Connect(HostInput.Text, Convert.ToInt32(PortInput.Text));
        }

        public void Client_DataReceived(Object sender, SimpleTCP.Message e)
        {
            txtStatus.Invoke((MethodInvoker)delegate ()
            {
                txtStatus.Text += Environment.NewLine + e.MessageString;
            }); 
        }
    }
}
