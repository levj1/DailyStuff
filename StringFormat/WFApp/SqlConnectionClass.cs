using System.Data;
using System.Data.SqlClient;

namespace WFApp
{
    class SqlDbConnect
    {
        private SqlConnection conn;
        public SqlCommand cmd;
        private SqlDataAdapter da;
        private DataTable dt;

        string connectionString = @"Data Source=DESKTOP-B7NQGH7;Initial Catalog=test; Integrated Security=True";
        public SqlDbConnect()
        {
            conn = new SqlConnection(connectionString);
            conn.Open();
        }

        public void SqlQuery(string queryText)
        {
            cmd = new SqlCommand(queryText, conn);
        }

        public DataTable QueryEx()
        {
            da = new SqlDataAdapter(cmd);
            dt = new DataTable();
            da.Fill(dt);
            return dt;
        }

        public void NonQueryEx()
        {
            cmd.ExecuteNonQuery();
        }
    }
}
