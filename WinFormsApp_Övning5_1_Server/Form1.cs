using System.Net;
using System.Text;
using System.Net.Sockets;

namespace WinFormsApp_Övning5_1_Server
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        protected void btnTagEmot_Click(object sender, EventArgs e)
        {
            int port = int.Parse(tbxServerPortnummer.Text);
            IPEndPoint klientEndPoint = new IPEndPoint(IPAddress.Any, 0);
            UdpClient klient = new UdpClient(port);
            byte[] inström = klient.Receive(ref klientEndPoint);
            string meddelandeText = Encoding.Unicode.GetString(inström);
            tbxInkorg.AppendText(meddelandeText + "\r\n");
        }
    }
}