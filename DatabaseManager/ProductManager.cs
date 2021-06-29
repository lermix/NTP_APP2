using DatabaseManagers;
using MySql.Data.MySqlClient;
using NTP_Ivo_Ojvan.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Text;
using static NTP_Ivo_Ojvan.Models.Enums;

namespace DatabaseManager
{
    public class ProductManager : DatabaseConnection
    {
        public static List<Product> GetProducts()
        {
            MySqlCommand cmd = new MySqlCommand("GetAllProducts", new MySqlConnection(connectionString));

            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Connection.Open();

            MySqlDataReader rdr = cmd.ExecuteReader(CommandBehavior.CloseConnection);

            List<Product> products = new List<Product>();

            while (rdr.Read())
            {
                Product product = new Product();

                product.id = int.Parse(rdr[0].ToString());
                product.name = rdr[1].ToString();
                product.brand = (Brand)int.Parse(rdr[2].ToString());
                product.price = double.Parse(rdr[3].ToString());

                products.Add(product);

            }
            rdr.Close();

            return products;
        }

        public static void InsertProduct(Product product)

        {            
            MySqlCommand cmd = new MySqlCommand("InsertProduct", new MySqlConnection(connectionString));

            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.Add(new MySqlParameter("_id", product.id));
            cmd.Parameters.Add(new MySqlParameter("_name", product.name));
            cmd.Parameters.Add(new MySqlParameter("_brand", product.brand));
            cmd.Parameters.Add(new MySqlParameter("_price", product.price));

            cmd.Connection.Open();
            cmd.ExecuteNonQuery();
            cmd.Connection.Close();

        }


        public static int DeleteProduct(int id)

        {

            MySqlCommand cmd = new MySqlCommand("deleteProduct", new MySqlConnection(connectionString));

            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.Add(new MySqlParameter("_id", id));

            cmd.Connection.Open();

            int i = cmd.ExecuteNonQuery();

            cmd.Connection.Close();

            return i;

        }
        

        public static int UpdateProduct(Product product)

        {
            MySqlCommand cmd = new MySqlCommand("updateProduct", new MySqlConnection(connectionString));

            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.Add(new MySqlParameter("_id", product.id));
            cmd.Parameters.Add(new MySqlParameter("_name", product.name));
            cmd.Parameters.Add(new MySqlParameter("_brand", product.brand));
            cmd.Parameters.Add(new MySqlParameter("_price", product.price));

            cmd.Connection.Open();

            int i = cmd.ExecuteNonQuery();

            cmd.Connection.Close();

            return i;

        }
    }
}
