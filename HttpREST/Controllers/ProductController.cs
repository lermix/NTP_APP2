using Newtonsoft.Json;
using NTP_Ivo_Ojvan.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace HttpREST.Controllers
{
    public class ProductController : Controller
    {
        [HttpGet]
        public string Select()
        {
            return JsonConvert.SerializeObject(DatabaseManager.ProductManager.GetProducts());
        }
        [HttpPost]
        public string Insert(Product product)
        {
            DatabaseManager.ProductManager.InsertProduct(product);
            return JsonConvert.SerializeObject(new List<Product> { product});
        }

        [HttpPost]
        public string Delete(Product product)
        {
            DatabaseManager.ProductManager.DeleteProduct(product.id);
            return JsonConvert.SerializeObject(new List<Product> { product });
        }

        [HttpPost]
        public string Update(Product product)
        {
            DatabaseManager.ProductManager.UpdateProduct(product);
            return JsonConvert.SerializeObject(new List<Product> { product });
        }

        [HttpPost]
        public void CurrentlyOnSale(Product product)
        {
            ProductHolder.product = product.name;
        }
    }
}