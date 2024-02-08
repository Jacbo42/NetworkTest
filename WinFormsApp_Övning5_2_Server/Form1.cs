using System.Net.Sockets;
using System.Net;
using System.Text;

namespace WinFormsApp_Övning5_2_Server
{
    public partial class Form1 : Form
    {
        TcpListener lyssnare;
        TcpClient klient;
        int port = 12345;
        string meddelande;
        public Form1()
        {
            InitializeComponent();
        }

        private void btnStartaServer_Click(object sender, EventArgs e)
        {
            lyssnare = new TcpListener(IPAddress.Any, port);
            lyssnare.Start();
            //Väntar på connect i klienten
            klient = lyssnare.AcceptTcpClient();

            byte[] inData = new byte[256];

            //Väntar på Send i klienten

            int antalByte = klient.GetStream().Read(inData, 0, inData.Length);

            meddelande = Encoding.Unicode.GetString(inData, 0, antalByte);
            klient.Close();
            lyssnare.Stop();
        }

        private void btnTaEmotMeddelande_Click(object sender, EventArgs e)
        {
            tbxInkorg.Text = meddelande;

        }
        private void Form1_Closing(object sender, System.ComponentModel.CancelEventArgs e)
        {
            klient.Close();
            lyssnare.Stop();
        }
    }
}