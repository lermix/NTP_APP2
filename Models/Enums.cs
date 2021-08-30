using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NTP_Ivo_Ojvan.Models
{
    public static class Enums
    {
        public enum Brand
        {
            adidas,
            nike,
            puma,
            reebok
        }

        public enum DatabaseType
        {
            MySql,
            Xml
        }

        public enum ServerType
        {
            TCP,
            UDP,
            HTTP            
        }

        public enum MessageObjectType
        {
            Product,
            User
               
        }

        public enum MessageType
        {
            Insert,
            Select,
            Delete,
            Update
        }

        public enum Encryption
        {
            CES,
            AES
        }

        public enum Languages
        {
            Hrvatski,
            English
        }
    }
}
