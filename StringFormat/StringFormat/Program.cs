using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice
{
    class Program
    {
        //T1000\SQLEXPRESS(T1000\JamesLeveille)
        static void Main(string[] args)
        {
            string connectionString = @"Data Source=T1000\SQLEXPRESS;Initial Catalog=test;Integrated Security=True";

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                try
                {
                    SqlCommand cmd = new SqlCommand("select * from contact", conn);
                    SqlDataReader reader = cmd.ExecuteReader();
                    while (reader.Read())
                    {
                        Console.WriteLine(reader[0].ToString() + " - " + reader[1].ToString());
                    }
                }
                catch (Exception)
                {

                    throw;
                }
            }

                Console.ReadLine();
        }
    }
}

