using System.Net.Sockets;
using System.Net;
using System.Text;

namespace WinFormsApp_Övning_5_3_Server
{
    public partial class Form1 : Form
    {
        TcpListener lyssnare;
        TcpClient klient;
        int port = 12345;
        public Form1()
        {
            InitializeComponent();
            StartaLyssning();
        }
        private void Form1_Load(object sender, EventArgs e)
        {

        }
        public async void StartaLyssning()
        {
            lyssnare = new TcpListener(IPAddress.Any, port);
            lyssnare.Start();
            try
            {
                klient = await lyssnare.AcceptTcpClientAsync();
            }
            catch (Exception error) { MessageBox.Show(error.Message, Text); return; }
            StartaLäsning(klient);
        }

        public async void StartaLäsning(TcpClient klient)
        {

            try
            {
                byte[] buffert = new byte[1024];
                int n = await klient.GetStream().ReadAsync(buffert, 0, buffert.Length);

                string meddelande = (Encoding.Unicode.GetString(buffert, 0, n));
                tbxInkorg.AppendText(meddelande + "\r\n");

            }
            catch (Exception error) { MessageBox.Show(error.Message, Text); return; }


            StartaLäsning(klient);
        }
    }
}