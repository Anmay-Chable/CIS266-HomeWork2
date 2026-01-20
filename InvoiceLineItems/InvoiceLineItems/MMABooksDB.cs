using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Drawing;

namespace InvoiceLineItems
{
    public static class MMABooksDB
    {
        public static SqlConnection GetConnection()
        {
            //Our connection strings for each of our computers. 
            string connectionString =
            //"Data Source=LAPTOP-5QV1IUBC\\SQLEXPRESS;Initial Catalog=MMABooks;Integrated Security=True";
            "Data Source=ST114092;Initial Catalog=MMABooks;Integrated Security=True";
            //"Data Source = ZEN\\MSSQLSERVER2022; Initial Catalog = MMABooks; Integrated Security = True; TrustServerCertificate = True";
            SqlConnection connection = new SqlConnection(connectionString);
            return connection;
        }
    }
}