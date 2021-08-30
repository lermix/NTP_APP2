using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static NTP_Ivo_Ojvan.Models.Enums;

namespace NTP_Ivo_Ojvan
{
    public static class AppSettings
    {
        public const string DATABASE_TYPE = "DatabaseType";
        public const string SERVER_TYPE = "ServerType";
        public const string ENCRYPTION_TYPE = "EncryptionType";
        public const string LANGUAGE = "Language";
        public const string DEFAULT_SETTINGS_PATH = @"C:\Users\Alen\Desktop\NTP_properties.ini";


        public static DatabaseType databaseType { get; set; } = DatabaseType.MySql;
        public static ServerType serverType { get; set; } = ServerType.TCP;
        public static Encryption encryption { get; set; } = Encryption.AES;
        public static Languages languages { get; set; } = Languages.Hrvatski;
    }
}
