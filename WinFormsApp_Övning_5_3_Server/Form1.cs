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
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            try
            {
                lyssnare = new TcpListener(IPAddress.Any, port);
                lyssnare.Start();
            }
            catch(Exception error) { MessageBox.Show(error.Message, Text); return; }
            StartaMottagning();
        }

        public async void StartaMottagning()
        {
            try
            {
                klient = await lyssnare.AcceptTcpClientAsync();
            }
            catch (Exception error) { MessageBox.Show(error.Message, Text); return; }
            StartaLäsning(klient);
        }

        public async void StartaLäsning(TcpClient klient)
        {
            byte[] buffert = new byte[1024];

            int n = 0;

            try
            {
                n = await klient.GetStream().ReadAsync(buffert, 0, buffert.Length);
            }
            catch (Exception error) { MessageBox.Show(error.Message, Text); return; }

            tbxInkorg.AppendText(Encoding.Unicode.GetString(buffert, 0, n));

            StartaLäsning(klient);
        }
    }
}