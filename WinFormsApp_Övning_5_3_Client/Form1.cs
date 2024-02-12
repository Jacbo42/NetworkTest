using System.Net;
using System.Net.Sockets;
using System.Text;

namespace WinFormsApp_Övning_5_3_Client
{
    public partial class Form1 : Form
    {
        TcpClient klient = new TcpClient();
        int port = 12345;
        public Form1()
        {
            InitializeComponent();
            klient.NoDelay = true;
        }

        private void btnAnslut_Click(object sender, EventArgs e)
        {

            if (!klient.Connected) StartaAnslutning();
        }

        private void btnSend_Click(object sender, EventArgs e)
        {
            StartaSändning(tbxUtkorg.Text);
        }

        public async void StartaAnslutning()
        {
            try
            {
                IPAddress adress = IPAddress.Parse(tbxIPadress.Text);
                await klient.ConnectAsync(adress, port);
                btnSend.Enabled = true;
                btnAnslut.Enabled = false;

            }
            catch (Exception error) { MessageBox.Show(error.Message, Text); return; }

        }

        public async void StartaSändning(string message)
        {
            if (klient.Connected)
            {
                byte[] utData = Encoding.Unicode.GetBytes(tbxUtkorg.Text);

                try
                {
                    await klient.GetStream().WriteAsync(utData, 0, utData.Length);
                }
                catch (Exception error) { MessageBox.Show(error.Message, Text); return; }
            }
        }
    }
}