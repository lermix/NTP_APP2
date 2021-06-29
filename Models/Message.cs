using System;
using System.Collections.Generic;
using System.Text;
using static NTP_Ivo_Ojvan.Models.Enums;

namespace Models
{
    public class Message
    {
        public MessageObjectType objectType { get; set; }
        public MessageType messageType { get; set; }
        public string message { get; set; }

        public Message(MessageType messageType, MessageObjectType objectType, string message)
        {
            this.objectType = objectType;
            this.message = message;
            this.messageType = messageType;
        }
    }
}
