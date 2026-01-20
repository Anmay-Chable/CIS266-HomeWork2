using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace InvoiceLineItems
{
    public static class MMABooksDB
    {
        public static SqlConnection GetConnection()
        {
            string connectionString =
                "Data Source=ST114092;Initial Catalog=MMABooks;Integrated Security=True";
            SqlConnection connection = new SqlConnection(connectionString);
            return connection;
        }
    }
}
