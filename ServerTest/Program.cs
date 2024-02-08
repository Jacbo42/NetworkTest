using System;
using System.Net;
using System.Net.Sockets;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServerTest
{
    internal class Program
    {
        static TcpListener tcpListener;
        static void Main(string[] args)
        {
            Console.CancelKeyPress += new ConsoleCancelEventHandler(CancelKeyPress);

            //Skapa ett TcpListener-objekt, börja lyssna och vänta på anslutning
            IPAddress myIp = IPAddress.Parse("127.0.0.1");
            tcpListener = new TcpListener(myIp, 8001);
            tcpListener.Start();
            Console.WriteLine("Väntar på anslutning...");

            while (true)
            {
                try
                {
                    //Någon försöker ansluta. Acceptera anslutningen
                    Socket socket = tcpListener.AcceptSocket();
                    Console.WriteLine("Anslutning accepterad från " + socket.RemoteEndPoint);

                    //LÄS MER OM SOCKET OCH SOCKET.REMOTEENDPOINT

                    //Tag emot meddelande
                    Byte[] bMessage = new Byte[256];
                    int messageSize = socket.Receive(bMessage);
                    Console.WriteLine("Meddelandet mottogs...");

                    //Läs mer om Socket.Recieve()

                    //Konvertera meddelandet till en string-variabel och skriv ut

                    string message = "";
                    for (int i = 0; i < messageSize; i++)
                    {
                        message += Convert.ToChar(bMessage[i]);
                    }
                    Console.WriteLine("Meddelande: " + message);

                    //skickar tillbaka ett meddelande

                    Byte[] bSend = System.Text.Encoding.ASCII.GetBytes("Tack!");
                    socket.Send(bSend);
                    Console.WriteLine("Svar skickat");

                    //Här ska vi lägga kod för att skicka meddelande till klienten

                    //Stäng anslutningen mot just den har klienten
                    socket.Close();
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Error: " + ex.Message);
                }

            }

            //LÄS MER OM IPADRESS

            //Läs mer om socket.Close() och tcpListener.Stop()


        }

        //================================================
        //CancelKeyPress(), anropas då användaren trycker på Ctrl-C
        //================================================ 

        static void CancelKeyPress(object sender, ConsoleCancelEventArgs e)
        {
            tcpListener.Stop();
            Console.WriteLine("Servern stängdes av!");
        }

    }
}
