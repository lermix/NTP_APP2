using DatabaseManagers;
using Models;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Text;

namespace DatabaseManager
{
    public class UserManager : DatabaseConnection
    {
        public static List<User> GetUsers()
        {
            MySqlCommand cmd = new MySqlCommand("getUsers", new MySqlConnection(connectionString));

            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Connection.Open();

            MySqlDataReader rdr = cmd.ExecuteReader(CommandBehavior.CloseConnection);

            List<User> users = new List<User>();

            while (rdr.Read())
            {
                User user = new User();

                user.id = int.Parse(rdr[0].ToString());
                user.username = rdr[1].ToString();
                user.password = rdr[2].ToString();

                users.Add(user);

            }
            rdr.Close();

            return users;
        }

        public static void InserUser(User user)

        {
            MySqlCommand cmd = new MySqlCommand("insertUser", new MySqlConnection(connectionString));

            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.Add(new MySqlParameter("_username", user.username));
            cmd.Parameters.Add(new MySqlParameter("_password", user.password));

            cmd.Connection.Open();
            cmd.ExecuteNonQuery();
            cmd.Connection.Close();

        }


        public static int DeleteUser(int id)

        {

            MySqlCommand cmd = new MySqlCommand("deleteUser", new MySqlConnection(connectionString));

            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.Add(new MySqlParameter("_id", id));

            cmd.Connection.Open();

            int i = cmd.ExecuteNonQuery();

            cmd.Connection.Close();

            return i;

        }


        public static int UpdateUser(User user)

        {
            MySqlCommand cmd = new MySqlCommand("updateUser", new MySqlConnection(connectionString));

            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.Add(new MySqlParameter("_username", user.username));
            cmd.Parameters.Add(new MySqlParameter("_password", user.password));
            cmd.Parameters.Add(new MySqlParameter("_id", user.id));

            cmd.Connection.Open();

            int i = cmd.ExecuteNonQuery();

            cmd.Connection.Close();

            return i;

        }
    }
}
