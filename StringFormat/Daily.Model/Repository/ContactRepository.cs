using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Daily.Model.Repository
{
    public class ContactRepository
    {
        public string ConnStr = @"Data Source=DESKTOP-B7NQGH7;Initial Catalog=test;Integrated Security=True";
        //public string ConnStr1 = @"Data Source=DESKTOP-B7NQGH7;Initial Catalog=test; Integrated Security=True";

        public void AddContact(Contact contact)
        {
            using (SqlConnection conn = new SqlConnection(ConnStr))
            {
                try
                {
                    string query = "INSERT INTO Contact(firstname, lastname, email, AddressLine1, AddressLine2, City, state, zipcode) " +
                                   "values(@firstname, @lastname, @email, @AddressLine1, @AddressLine2, @City, @state, @zipcode)";
                    using (SqlCommand cmd = new SqlCommand(query))
                    {
                        conn.Open();
                        cmd.Connection = conn;
                        cmd.Parameters.AddWithValue("@firstname", contact.FirstName);
                        cmd.Parameters.AddWithValue("@lastname", contact.LastName);
                        cmd.Parameters.AddWithValue("@email", contact.Email);
                        cmd.Parameters.AddWithValue("@AddressLine1", contact.Address.AddressLine1);
                        cmd.Parameters.AddWithValue("@AddressLine2", contact.Address.AddressLine2);
                        cmd.Parameters.AddWithValue("@City", contact.Address.City);
                        cmd.Parameters.AddWithValue("@state", contact.Address.State);
                        cmd.Parameters.AddWithValue("@zipcode", contact.Address.ZipCode);

                        cmd.ExecuteNonQuery();
                    }

                }
                catch (Exception ex)
                {

                    throw ex;
                }
            }
        }

        private void RemoveContact(int contactID)
        {

        }
        private void UpdateContact(int contactID)
        {

        }
    }
}
