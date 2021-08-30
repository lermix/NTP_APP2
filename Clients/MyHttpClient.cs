using Newtonsoft.Json;
using NTP_Ivo_Ojvan.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace NTP_Ivo_Ojvan.Clients
{
    public class MyHttpClient
    {
        public static List<T> GetProducts<T>()
        {
            HttpClient client = new HttpClient();
            client.BaseAddress = new Uri("https://localhost:44332/");
            // Add an Accept header for JSON format.    
            client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
            HttpResponseMessage response = client.GetAsync("Product/Select").Result;  // Blocking call!    
            if (response.IsSuccessStatusCode)
            {
                 return JsonConvert.DeserializeObject<List<T>>(response.Content.ReadAsStringAsync().Result);
            }
            else
            {
                Console.WriteLine("{0} ({1})", (int)response.StatusCode, response.ReasonPhrase);
            }

            return new List<T>();
        }

        public static List<T> InsertProduct<T>(string productJson)
        {
            HttpClient client = new HttpClient();
            client.BaseAddress = new Uri("https://localhost:44332/");
            // Add an Accept header for JSON format.    
            client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));

            var buffer = System.Text.Encoding.UTF8.GetBytes(productJson);
            var byteContent = new ByteArrayContent(buffer);
            byteContent.Headers.ContentType = new MediaTypeHeaderValue("application/json");


            HttpResponseMessage response = client.PostAsync("Product/Insert", byteContent).Result;  // Blocking call!    
            if (response.IsSuccessStatusCode)
            {
                return JsonConvert.DeserializeObject<List<T>>(response.Content.ReadAsStringAsync().Result);
            }
            else
            {
                Console.WriteLine("{0} ({1})", (int)response.StatusCode, response.ReasonPhrase);
            }

            return new List<T>();
        }

        public static List<T> DeleteProduct<T>(string productJson)
        {
            HttpClient client = new HttpClient();
            client.BaseAddress = new Uri("https://localhost:44332/");
            // Add an Accept header for JSON format.    
            client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));

            var buffer = System.Text.Encoding.UTF8.GetBytes(productJson);
            var byteContent = new ByteArrayContent(buffer);
            byteContent.Headers.ContentType = new MediaTypeHeaderValue("application/json");


            HttpResponseMessage response = client.PostAsync("Product/Delete", byteContent).Result;  // Blocking call!    
            if (response.IsSuccessStatusCode)
            {
                return JsonConvert.DeserializeObject<List<T>>(response.Content.ReadAsStringAsync().Result);
            }
            else
            {
                Console.WriteLine("{0} ({1})", (int)response.StatusCode, response.ReasonPhrase);
            }

            return new List<T>();
        }

        public static List<T> UpdateProduct<T>(string productJson)
        {
            HttpClient client = new HttpClient();
            client.BaseAddress = new Uri("https://localhost:44332/");
            // Add an Accept header for JSON format.    
            client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));

            var buffer = System.Text.Encoding.UTF8.GetBytes(productJson);
            var byteContent = new ByteArrayContent(buffer);
            byteContent.Headers.ContentType = new MediaTypeHeaderValue("application/json");


            HttpResponseMessage response = client.PostAsync("Product/Update", byteContent).Result;  // Blocking call!    
            if (response.IsSuccessStatusCode)
            {
                return JsonConvert.DeserializeObject<List<T>>(response.Content.ReadAsStringAsync().Result);
            }
            else
            {
                Console.WriteLine("{0} ({1})", (int)response.StatusCode, response.ReasonPhrase);
            }

            return new List<T>();
        }

        public static void putProductToSale<T>(string productJson)
        {
            HttpClient client = new HttpClient();
            client.BaseAddress = new Uri("https://localhost:44332/");
            // Add an Accept header for JSON format.    
            client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));

            var buffer = System.Text.Encoding.UTF8.GetBytes(productJson);
            var byteContent = new ByteArrayContent(buffer);
            byteContent.Headers.ContentType = new MediaTypeHeaderValue("application/json");

            HttpResponseMessage response = client.PostAsync("Product/CurrentlyOnSale", byteContent).Result;  // Blocking call!    
        }

        public static List<T> GetUsers<T>()
        {
            HttpClient client = new HttpClient();
            client.BaseAddress = new Uri("https://localhost:44332/");
            // Add an Accept header for JSON format.    
            client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
            HttpResponseMessage response = client.GetAsync("User/Select").Result;  // Blocking call!    
            if (response.IsSuccessStatusCode)
            {
                return JsonConvert.DeserializeObject<List<T>>(response.Content.ReadAsStringAsync().Result);
            }
            else
            {
                Console.WriteLine("{0} ({1})", (int)response.StatusCode, response.ReasonPhrase);
            }

            return new List<T>();
        }

        public static List<T> InsertUser<T>(string productJson)
        {
            HttpClient client = new HttpClient();
            client.BaseAddress = new Uri("https://localhost:44332/");
            // Add an Accept header for JSON format.    
            client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));

            var buffer = System.Text.Encoding.UTF8.GetBytes(productJson);
            var byteContent = new ByteArrayContent(buffer);
            byteContent.Headers.ContentType = new MediaTypeHeaderValue("application/json");


            HttpResponseMessage response = client.PostAsync("User/Insert", byteContent).Result;  // Blocking call!    
            if (response.IsSuccessStatusCode)
            {
                return JsonConvert.DeserializeObject<List<T>>(response.Content.ReadAsStringAsync().Result);
            }
            else
            {
                Console.WriteLine("{0} ({1})", (int)response.StatusCode, response.ReasonPhrase);
            }

            return new List<T>();
        }

        public static List<T> DeleteUser<T>(string productJson)
        {
            HttpClient client = new HttpClient();
            client.BaseAddress = new Uri("https://localhost:44332/");
            // Add an Accept header for JSON format.    
            client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));

            var buffer = System.Text.Encoding.UTF8.GetBytes(productJson);
            var byteContent = new ByteArrayContent(buffer);
            byteContent.Headers.ContentType = new MediaTypeHeaderValue("application/json");


            HttpResponseMessage response = client.PostAsync("User/Delete", byteContent).Result;  // Blocking call!    
            if (response.IsSuccessStatusCode)
            {
                return JsonConvert.DeserializeObject<List<T>>(response.Content.ReadAsStringAsync().Result);
            }
            else
            {
                Console.WriteLine("{0} ({1})", (int)response.StatusCode, response.ReasonPhrase);
            }

            return new List<T>();
        }

        public static List<T> UpdateUser<T>(string productJson)
        {
            HttpClient client = new HttpClient();
            client.BaseAddress = new Uri("https://localhost:44332/");
            // Add an Accept header for JSON format.    
            client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));

            var buffer = System.Text.Encoding.UTF8.GetBytes(productJson);
            var byteContent = new ByteArrayContent(buffer);
            byteContent.Headers.ContentType = new MediaTypeHeaderValue("application/json");


            HttpResponseMessage response = client.PostAsync("User/Update", byteContent).Result;  // Blocking call!    
            if (response.IsSuccessStatusCode)
            {
                return JsonConvert.DeserializeObject<List<T>>(response.Content.ReadAsStringAsync().Result);
            }
            else
            {
                Console.WriteLine("{0} ({1})", (int)response.StatusCode, response.ReasonPhrase);
            }

            return new List<T>();
        }
    }
}
