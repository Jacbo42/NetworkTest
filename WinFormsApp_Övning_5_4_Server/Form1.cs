using System.Net.Sockets;
using System.Net;
using System.Text;
using System.IO;
using System.Windows.Forms;

namespace WinFormsApp_Övning_5_4_Server
{
    public partial class Form1 : Form
    {
        TcpListener lyssnare;
        TcpClient klient;
        NetworkStream stream;
        int port = 12345;
        public Form1()
        {
            InitializeComponent();
            StartaLyssning();
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
            stream = klient.GetStream();
            await Task.Run(() => HandleClient());

        }


        private void HandleClient()
        {
            try
            {
                byte[] buffer = new byte[sizeof(int)];
                int bytesRead;

                while ((bytesRead = stream.Read(buffer, 0, buffer.Length)) > 0)
                {
                    int instruction = BitConverter.ToInt32(buffer, 0);
                    MovePictureBox(instruction);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void MovePictureBox(int instruction)
        {

            if (pbxToteninsel.InvokeRequired)
            {
               
                pbxToteninsel.Invoke(new Action(() => MovePictureBox(instruction)));
                return;
            }
            switch (instruction)
            {
                case 0:
                    pbxToteninsel.Location = new Point(pbxToteninsel.Location.X, pbxToteninsel.Location.Y - 20);
                    break;
                case 1:
                    pbxToteninsel.Location = new Point(pbxToteninsel.Location.X, pbxToteninsel.Location.Y + 20);
                    break;
                case 2:
                    pbxToteninsel.Location = new Point(pbxToteninsel.Location.X + 20, pbxToteninsel.Location.Y);
                    break;
                case 3:
                    pbxToteninsel.Location = new Point(pbxToteninsel.Location.X - 20, pbxToteninsel.Location.Y);
                    break;
                default:
                    // Handle unknown instruction
                    break;
            }
        }


    }
}