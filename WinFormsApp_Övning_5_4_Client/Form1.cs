using System.Net;
using System.Net.Sockets;
using System.Text;

namespace WinFormsApp_Övning_5_4_Client
{
    public partial class Form1 : Form
    {
        TcpClient klient = new TcpClient();
        NetworkStream stream;
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
        public async void StartaAnslutning()
        {
            try
            {
                IPAddress adress = IPAddress.Parse(tbxIPadress.Text);
                await klient.ConnectAsync(adress, port);
                btnUpp.Enabled = true;
                btnNer.Enabled = true;
                btnVänster.Enabled = true;
                btnHöger.Enabled = true;
                btnAnslut.Enabled = false;

            }
            catch (Exception error) { MessageBox.Show(error.Message, Text); return; }

        }

        private async void SkickaInstruktion(int instruktion)
        {
            try
            {
                NetworkStream stream = klient.GetStream();
                byte[] data = BitConverter.GetBytes(instruktion);
                await stream.WriteAsync(data, 0, data.Length);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnUpp_Click(object sender, EventArgs e)
        {
            SkickaInstruktion(0);
        }

        private void btnVänster_Click(object sender, EventArgs e)
        {
            SkickaInstruktion(3);
        }

        private void btnNer_Click(object sender, EventArgs e)
        {
            SkickaInstruktion(1);
        }

        private void btnHöger_Click(object sender, EventArgs e)
        {
            SkickaInstruktion(2);
        }
    }
}