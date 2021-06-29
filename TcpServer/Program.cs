using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;
using Models;
using System.Runtime.Serialization.Formatters.Binary;
using System.IO;
using System.Collections;
using NTP_Ivo_Ojvan.Models;
using Newtonsoft.Json;
using static NTP_Ivo_Ojvan.Models.Enums;

namespace TCPServer
{
    class Program
    {
        const int PORT_NO = 23117;
        const string SERVER_IP = "127.0.0.1";

        static void Main(string[] args)
        {
            //---listen at the specified IP and port no.---
            IPAddress localAdd = IPAddress.Parse(SERVER_IP);
            TcpListener listener = new TcpListener(localAdd, PORT_NO);

            Console.WriteLine("Listening...");
            listener.Start();

            while (true)
            {

                //---incoming client connected---
                TcpClient client = listener.AcceptTcpClient();

                //---get the incoming data through a network stream---
                NetworkStream nwStream = client.GetStream();
                byte[] buffer = new byte[client.ReceiveBufferSize];

                //---read incoming stream---
                int bytesRead = nwStream.Read(buffer, 0, client.ReceiveBufferSize);

                //---convert the data received into a string---
                string dataReceived = Encoding.ASCII.GetString(buffer, 0, bytesRead);
                Console.WriteLine("Received : " + dataReceived);


                Message msg = JsonConvert.DeserializeObject<Message>(dataReceived);
                

                switch (msg.objectType)
                {
                    case NTP_Ivo_Ojvan.Models.Enums.MessageObjectType.Product:
                        
                        List<Product> products = new List<Product>();
                        Product productReceived = new Product();

                        switch (msg.messageType)
                        {
                            case MessageType.Insert:
                                productReceived = JsonConvert.DeserializeObject<Product>(msg.message);
                                DatabaseManager.ProductManager.InsertProduct(productReceived);
                                products.Add(productReceived);
                                break;
                            case MessageType.Select:
                                products =  DatabaseManager.ProductManager.GetProducts();
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
                        nwStream.Write(responseBuffer, 0, responseBuffer.Length);
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
                        nwStream.Write(responseBufferUser, 0, responseBufferUser.Length);
                        break;

                    default:
                        break;
                }
            }
        }

    }
}
