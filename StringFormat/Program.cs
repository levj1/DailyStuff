using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringFormat
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
                    SqlCommand cmd = new SqlCommand("Select * from contacts", conn);
                    SqlDataReader reader = cmd.ExecuteReader();
                
                        while (reader.Read())
                        {
                            Console.WriteLine(string.Format("{0} {1} {2}", reader[0].ToString(), reader[1].ToString(), reader[2].ToString()));
                        }
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex);
                }
                
            }

                Console.ReadLine();
        }
    }
}

