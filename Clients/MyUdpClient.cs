using Models;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Reflection;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using static NTP_Ivo_Ojvan.Models.Enums;

namespace NTP_Ivo_ojvan.Clients
{
    class MyUdpClient
    {

        const int PORT_NO = 8080;
        const string SERVER_IP = "127.0.0.1";

        

        public static List<T> send<T>(Message msg)
        {           
            IPEndPoint ep = new IPEndPoint(IPAddress.Parse(SERVER_IP),PORT_NO);

            UdpClient udpClient = new UdpClient();
            udpClient.Connect(SERVER_IP, PORT_NO);

            string textToSend = JsonConvert.SerializeObject(msg);
            Byte[] sendData = Encoding.ASCII.GetBytes(textToSend);
            udpClient.Send(sendData, sendData.Length);

            byte[] receivedBytes = udpClient.Receive(ref ep);

            return JsonConvert.DeserializeObject<List<T>>(Encoding.ASCII.GetString(receivedBytes));            
        }
        
    }
}
