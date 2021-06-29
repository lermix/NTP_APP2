using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;
using Models;
using Newtonsoft.Json;
using static NTP_Ivo_Ojvan.Models.Enums;

namespace NTP_Ivo_Ojvan.Clients
{
    class TcpClient
    {
        const int PORT_NO = 23117;
        const string SERVER_IP = "127.0.0.1";
        public static List<T> send<T>(Message msg)
        {
            string textToSend = JsonConvert.SerializeObject(msg);
            //---create a TCPClient object at the IP and port no.---
            System.Net.Sockets.TcpClient client = new System.Net.Sockets.TcpClient(SERVER_IP, PORT_NO);
            NetworkStream nwStream = client.GetStream();
            byte[] bytesToSend = ASCIIEncoding.ASCII.GetBytes(textToSend);

            //---send the text---
            Console.WriteLine("Sending : " + textToSend);
            nwStream.Write(bytesToSend, 0, bytesToSend.Length);

            //---read back the text---
            byte[] bytesToRead = new byte[client.ReceiveBufferSize];
            int bytesRead = nwStream.Read(bytesToRead, 0, client.ReceiveBufferSize);

            string serverResponse = Encoding.ASCII.GetString(bytesToRead, 0, bytesRead);
            Console.WriteLine("Received : " + serverResponse);        

            client.Close();

            return JsonConvert.DeserializeObject<List<T>>(serverResponse);
        }
    }
}
