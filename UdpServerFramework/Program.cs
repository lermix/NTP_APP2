using kolokvij;
using System;
using System.Data.SqlClient;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading;
using MySql.Data.MySqlClient;
using Newtonsoft.Json;
using Models;
using System.Collections.Generic;
using NTP_Ivo_Ojvan.Models;
using static NTP_Ivo_Ojvan.Models.Enums;

namespace UdpServerFramework
{
    class Program
    {
        const int PORT_NO = 8080;
        const string SERVER_IP = "127.0.0.1";

        static void Main(string[] args)
        {

            UdpClient udpServer = new UdpClient(PORT_NO);
            while (true)
            {
                Console.WriteLine("Listening...");

                IPEndPoint RemoteIpEndPoint = new IPEndPoint(IPAddress.Any, 0);
                Byte[] receiveBytes = udpServer.Receive(ref RemoteIpEndPoint);

                string dataReceived = Encoding.ASCII.GetString(receiveBytes);

                Message msg = JsonConvert.DeserializeObject<Message>(dataReceived);
                Console.WriteLine("RECEIVED: " + dataReceived);


                switch (msg.objectType)
                {
                    case NTP_Ivo_Ojvan.Models.Enums.MessageObjectType.Product:

                        List<Product> products = new List<Product>();

                        switch (msg.messageType)
                        {
                            case MessageType.Insert:
                                Product productReceived = JsonConvert.DeserializeObject<Product>(msg.message);
                                DatabaseManager.ProductManager.InsertProduct(productReceived);
                                products.Add(productReceived);
                                break;
                            case MessageType.Select:
                                products = DatabaseManager.ProductManager.GetProducts();
                                break;
                            case MessageType.Delete:
                                productReceived = JsonConvert.DeserializeObject<Product>(msg.message);
                                DatabaseManager.ProductManager.DeleteProduct(productReceived.id);
                                products.Add(productReceived);
                                break;
                            case MessageType.Update:
                                productReceived = JsonConvert.DeserializeObject<Product>(msg.message);
                                DatabaseManager.ProductManager.UpdateProduct(productReceived);
                                products.Add(productReceived);
                                break;
                            default:
                                break;
                        }

                        Console.WriteLine("SENDING BACK: " + JsonConvert.SerializeObject(products));
                        byte[] responseBuffer = Encoding.ASCII.GetBytes(JsonConvert.SerializeObject(products));
                        udpServer.Send(responseBuffer, responseBuffer.Length, RemoteIpEndPoint);
                        break;
                    case MessageObjectType.User:
                        List<User> users = new List<User>();
                        User userReceived = new User();

                        switch (msg.messageType)
                        {
                            case MessageType.Insert:
                                userReceived = JsonConvert.DeserializeObject<User>(msg.message);
                                DatabaseManager.UserManager.InserUser(userReceived);
                                users.Add(userReceived);
                                break;
                            case MessageType.Select:
                                users = DatabaseManager.UserManager.GetUsers();
                                break;
                            case MessageType.Delete:
                                userReceived = JsonConvert.DeserializeObject<User>(msg.message);
                                DatabaseManager.UserManager.DeleteUser(userReceived.id);
                                users.Add(userReceived);
                                break;
                            case MessageType.Update:
                                userReceived = JsonConvert.DeserializeObject<User>(msg.message);
                                DatabaseManager.UserManager.UpdateUser(userReceived);
                                users.Add(userReceived);
                                break;
                            default:
                                break;
                        }

                        Console.WriteLine("SENDING BACK: " + JsonConvert.SerializeObject(users));
                        byte[] responseBufferUser = Encoding.ASCII.GetBytes(JsonConvert.SerializeObject(users));
                        udpServer.Send(responseBufferUser, responseBufferUser.Length, RemoteIpEndPoint);
                        break;
                    default:
                        break;
                }

            }
        }
    }
}
