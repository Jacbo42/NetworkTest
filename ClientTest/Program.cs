using System;
using System.IO;
using System.Net;
using System.Text;
using System.Net.Sockets;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ClientTest
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                string address = "127.0.0.1";
                int port = 8001;

                //Anslut till servern
                Console.WriteLine("Ansluter...");
                TcpClient tcpClient = new TcpClient();
                tcpClient.Connect(address, port);
                Console.WriteLine("Ansluten!");

                //LÄS VAD TcpCLIENT ÄR

                //Skriv in meddelande att skicka:
                Console.WriteLine("Skriv in meddelande");
                string message = Console.ReadLine();

                //Konvertera meddelande till ASCII-bytes
                Byte[] bMessage = System.Text.Encoding.ASCII.GetBytes(message);

                //LÄS MER OM BYTE OCH ENCODING.GETBYTES()

                //Skicka ivåg meddelandet:
                Console.WriteLine("Skickar...");
                NetworkStream tcpStream = tcpClient.GetStream();
                tcpStream.Write(bMessage, 0, bMessage.Length);

                //LÄS MER OM NETWORKSTREAM, STREAM, TcpCLIENT.GETSTREAM() och TcpSTREAM.WRITE()

                //tag emot meddelande från servern

                byte[] bRead = new byte[256];
                int bReadSize = tcpStream.Read(bRead, 0, bRead.Length);

                //Konvertera meddelandet till ett string-objekt och skriv ut:
                string read = "";
                for (int i = 0; i < bReadSize; i++)
                {
                    read += Convert.ToChar(bRead[i]);
                }
                Console.WriteLine("Servern säger: " + read);

                tcpClient.Close();

            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error: {ex.Message}");
            }
        }
    }
}
