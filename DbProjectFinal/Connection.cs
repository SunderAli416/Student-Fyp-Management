using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
namespace DbProjectFinal
{
    public static class Connection
    {
        public static string myConnectionString = "server=localhost;database=fypmanagement;uid=root;pwd=;";
        public static MySqlConnection conn = new MySqlConnection(myConnectionString);

        public static void MakeConnection()
        {
            try
            {
                conn.Open();
                Console.WriteLine("Success opening");
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error opening");
            }
        }

        public static void CloseConnection()
        {
            try
            {
                conn.Close();
                Console.WriteLine("Success closing");
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error closing");
            }
        }
    }
}
