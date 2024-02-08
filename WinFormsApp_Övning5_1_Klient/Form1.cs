using System.Net;
using System.Text;
using System.Net.Sockets;

namespace WinFormsApp_Övning5_1_Klient
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        protected void btnSend_Click(object sender, EventArgs e)
        {

            IPAddress serverIP = IPAddress.Parse(tbxIPAdress.Text);
            int port = int.Parse(tbxPortnummer.Text);
            IPEndPoint destination = new IPEndPoint(serverIP, port);
            byte[] message = Encoding.Unicode.GetBytes(tbxUtkorg.Text);
            UdpClient klient = new UdpClient();
            klient.Send(message, message.Length, destination);
            klient.Close();

        }
    }
}