using System.Net;
using System.Net.Sockets;
using System.Text;

namespace WinFormsApp_Övning5_2_Client
{
    public partial class Form1 : Form
    {
        TcpClient klient;
        int port = 12345;
        public Form1()
        {
            InitializeComponent();
        }

        private void btnAnslut_Click(object sender, EventArgs e)
        {
            IPAddress adress = IPAddress.Parse(tbxIPadress.Text);
            klient = new TcpClient();
            klient.NoDelay = true;
            klient.Connect(adress, port);

            if (klient.Connected)
            {
                MessageBox.Show("Anslutning lyckades");
            }

        }

        private void btnSend_Click(object sender, EventArgs e)
        {
            if (klient.Connected)
            {
                byte[] utData = Encoding.Unicode.GetBytes(tbxInput.Text);
                klient.GetStream().Write(utData, 0, utData.Length);
                klient.Close();
            }
        }

        private void Form1_Closing(object sender, System.ComponentModel.CancelEventArgs e)
        {
            klient.Close();
        } 
    }
}