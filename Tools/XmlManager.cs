using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Linq;
using System.Xml.Serialization;
using System.Xml.Xsl;

namespace NTP_Ivo_Ojvan.Tools
{

    /// <summary>
    /// Works with xml files.
    /// Functions: add, replace, delete, getArticles, getBills, getNextIDArticle
    /// </summary>
    public static class XmlManager
    {
        private static string AllProductsXmlLoaction = @"../../Data/bills.xml";

        private static XDocument AllProductsXml;  

        public static List<T> insert<T>(T objectToAdd)
        {
            load();
           
            if (objectToAdd == null){ return new List<T>(); }

            var articleElement = new XElement(objectToAdd.GetType().Name);

            //Atributes to add
            foreach (var property in objectToAdd.GetType().GetProperties())
            {
            articleElement.Add(new XAttribute(property.Name, property.GetValue(objectToAdd)));
            }

            //Add element
            AllProductsXml.Root.Add(articleElement);

            //Save
            AllProductsXml.Save(AllProductsXmlLoaction);     
            
            return new List<T>{ objectToAdd };


        }

        public static List<T> Get<T>()
        {
            List<T> returnList = new List<T>();

            XmlSerializer serializer = new XmlSerializer(typeof(T));

            load();

            //For it to work each class property needs definition as how will it be stored in xml  
            //Each xElement is presented with a class and its properties with attributes
            foreach (XElement xElement in AllProductsXml.Root.Elements())
            {
                StringReader reader = new StringReader(xElement.ToString());
                returnList.Add((T)serializer.Deserialize(reader));
            }        

            return returnList;
        }     

        public static List<T> update<T>(T objectToUpdate)
        {
            load();

            var target = AllProductsXml.Root.Elements()
                .FirstOrDefault(e => e.Attribute("id").Value == 
                objectToUpdate.GetType().GetProperty("id").GetValue(objectToUpdate).ToString());

            if (target == null) return new List<T>();

            foreach (var property in objectToUpdate.GetType().GetProperties())
            {
                target.Attribute(property.Name).Value = property.GetValue(objectToUpdate).ToString();
            }

            AllProductsXml.Save(AllProductsXmlLoaction);

            return new List<T> { objectToUpdate };
        }

        public static List<T> Delete<T>(T objectToDelete)
        {
            load();

            var target = AllProductsXml.Root.Elements()
                            .FirstOrDefault(e => e.Attribute("id").Value ==
                            objectToDelete.GetType().GetProperty("id").GetValue(objectToDelete).ToString());             

            if (target == null) return new List<T>();

            target.Remove();

            AllProductsXml.Save(AllProductsXmlLoaction);

            return new List<T> { objectToDelete };
        }
        
        private static void load()
        {
            if (!File.Exists(AllProductsXmlLoaction))
            {
                AllProductsXml = new XDocument();
                AllProductsXml.Add(new XElement("Root"));
            }
            else
            {
                AllProductsXml = XDocument.Load(AllProductsXmlLoaction);
            }
        }

     


        






    }
}
