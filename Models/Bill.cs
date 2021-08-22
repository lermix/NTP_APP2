using NTP_Ivo_Ojvan.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Xml.Serialization;

namespace Models
{

    [Serializable()]
    [XmlRoot("Bill")]
    public class Bill
    {
        [XmlAttribute("Id")]
        public Guid Id { get; set; }
        [XmlAttribute("Username")]
        public string Username { get; set; }
        [XmlAttribute("TotalPrice")]
        public double TotalPrice { get; set; }
        [XmlAttribute("Date")]
        public string Date { get; set; }


        public Bill() { }

        public Bill(string username, double totalPrice, string date)
        {
            Id = new Guid();
            Username = username;
            this.TotalPrice = totalPrice;
            Date = date;
        }
    }
}
