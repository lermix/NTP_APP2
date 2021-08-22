using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;
using static NTP_Ivo_Ojvan.Models.Enums;

namespace NTP_Ivo_Ojvan.Models
{
    [Serializable()]
    [XmlRoot("Product")]
    [XmlType("Product")]
    public class Product
    {
        [XmlAttribute("id")]
        public int id { get; set; }
        [XmlAttribute("name")]
        public string name { get; set; }
        [XmlAttribute("brand")]
        public Brand brand { get; set; }
        [XmlAttribute("price")]
        public double price { get; set; }

        public Product() { }

        public Product(int id, string name, Brand brand, double price)
        {
            this.id = id;
            this.name = name;
            this.brand = brand;
            this.price = price;
        }
    }
}
