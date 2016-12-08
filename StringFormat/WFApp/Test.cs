using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace WFApp
{
    public partial class Test : Form
    {
        private SqlDbConnect con;
        public Test()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            con = new SqlDbConnect();
            con.SqlQuery("insert into test (name) values (@nameP)");
            con.cmd.Parameters.AddWithValue("@nameP", textBox1.Text.Trim());
            con.NonQueryEx();

            con.SqlQuery("select * from test");
            comboBox1.Items.Clear();
            foreach (DataRow dr in con.QueryEx().Rows)
            {
                comboBox1.Items.Add(dr[1].ToString());
            }
        }
    }
}
