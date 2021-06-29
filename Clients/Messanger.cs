using Models;
using Newtonsoft.Json;
using NTP_Ivo_ojvan.Clients;
using NTP_Ivo_Ojvan.Models;
using NTP_Ivo_Ojvan.Tools;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static NTP_Ivo_Ojvan.Models.Enums;

namespace NTP_Ivo_Ojvan.Clients
{
    public class Messanger
    {
        public static List<T> insert<T>( T objectToInsert, MessageObjectType objectType)
        {

            switch (AppSettings.databaseType)
            {
                case DatabaseType.MySql:
                    Message msg = new Message(
                        MessageType.Insert,
                        objectType,
                        JsonConvert.SerializeObject(objectToInsert)
                    );

                    switch (AppSettings.serverType)
                    {
                        case ServerType.TCP:
                            return TcpClient.send<T>(msg);
                        case ServerType.UDP:
                            return MyUdpClient.send<T>(msg);
                        case ServerType.HTTP:
                            switch (objectType)
                            {
                                case MessageObjectType.Product:
                                    return MyHttpClient.InsertProduct<T>(JsonConvert.SerializeObject(objectToInsert));
                                case MessageObjectType.User:
                                    return MyHttpClient.InsertUser<T>(JsonConvert.SerializeObject(objectToInsert));
                                default:
                                    return new List<T>();
                            }
                        default:
                            return new List<T>();
                    }
                case DatabaseType.Xml:
                   return XmlManager.insert(objectToInsert);
                default:
                    return new List<T>();
            }

           
        }

        public static List<T> select<T>(MessageObjectType objectType)
        {
            switch (AppSettings.databaseType)
            {
                case DatabaseType.MySql:
                    Message msg = new Message(MessageType.Select, objectType, null);

                    switch (AppSettings.serverType)
                    {
                        case ServerType.TCP:
                            return TcpClient.send<T>(msg);
                        case ServerType.UDP:
                            return MyUdpClient.send<T>(msg);
                        case ServerType.HTTP:
                            switch (objectType)
                            {
                                case MessageObjectType.Product:
                                    return MyHttpClient.GetProducts<T>();
                                case MessageObjectType.User:
                                    return MyHttpClient.GetUsers<T>();
                                default:
                                    return new List<T>();
                            }                            
                        default:
                            return new List<T>();
                    }
                case DatabaseType.Xml:
                    return XmlManager.Get<T>();
                default:
                    return new List<T>();
            }
            
        }

        public static List<T> delete<T>(T objectToDelete, MessageObjectType objectType)
        {

            switch (AppSettings.databaseType)
            {
                case DatabaseType.MySql:
                    Message msg = new Message(
                        MessageType.Delete,
                        objectType,
                        JsonConvert.SerializeObject(objectToDelete)
                        );

                    switch (AppSettings.serverType)
                    {
                        case ServerType.TCP:
                            return TcpClient.send<T>(msg);
                        case ServerType.UDP:
                            return MyUdpClient.send<T>(msg);
                        case ServerType.HTTP:
                            switch (objectType)
                            {
                                case MessageObjectType.Product:
                                    return MyHttpClient.DeleteProduct<T>(JsonConvert.SerializeObject(objectToDelete));
                                case MessageObjectType.User:
                                    return MyHttpClient.DeleteUser<T>(JsonConvert.SerializeObject(objectToDelete));                                    
                                default:
                                    return new List<T>();
                            }
                        default:
                            return new List<T>();
                    }
                case DatabaseType.Xml:
                    return XmlManager.Delete(objectToDelete);
                default:
                    return new List<T>();
            }

            
        }

        public static List<T> update<T>(T objectToupdate, MessageObjectType objectType)
        {
            switch (AppSettings.databaseType)
            {
                case DatabaseType.MySql:
                    Message msg = new Message(
                        MessageType.Update,
                        objectType,
                        JsonConvert.SerializeObject(objectToupdate)
                        );

                    switch (AppSettings.serverType)
                    {
                        case ServerType.TCP:
                            return TcpClient.send<T>(msg);
                        case ServerType.UDP:
                            return MyUdpClient.send<T>(msg);
                        case ServerType.HTTP:
                            switch (objectType)
                            {
                                case MessageObjectType.Product:
                                    return MyHttpClient.UpdateProduct<T>(JsonConvert.SerializeObject(objectToupdate));
                                case MessageObjectType.User:
                                    return MyHttpClient.UpdateUser<T>(JsonConvert.SerializeObject(objectToupdate));
                                default:
                                    return new List<T>();
                            }
                        default:
                            return new List<T>();
                    }
                case DatabaseType.Xml:
                    return XmlManager.update(objectToupdate);
                default:
                    return new List<T>();
            }

            
        }
    }
}
