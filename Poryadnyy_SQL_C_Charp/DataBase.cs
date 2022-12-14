using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Poryadnyy_SQL_C_Charp
{
    class DataBase
    {
        SqlConnection sqlConnection;
        public DataBase(string host, string baseid)
        {
            sqlConnection = new SqlConnection($"Data Source={host}; Initial Catalog={baseid}; Integrated Security=True");
        }
        public void openConnection()
        {
            if (sqlConnection.State == System.Data.ConnectionState.Closed)
            {
                sqlConnection.Open();
            }
        }
        public void closeConnection()
        {
            if (sqlConnection.State == System.Data.ConnectionState.Open)
            {
                sqlConnection.Close();
            }
        }
        public SqlConnection GetConnection()
        {
            return sqlConnection;
        }
    }
}
