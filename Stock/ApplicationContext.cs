using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace Stock
{
    public class ApplicationContext
    {
        private DataSet ds;
        private SqlDataAdapter adapter;
        public SqlConnection sqlConnection;

        public ApplicationContext(SqlConnection sqlConnection)
        {
            this.sqlConnection = sqlConnection;
            this.ds = new DataSet();
            this.adapter = new SqlDataAdapter("",sqlConnection.ConnectionString);
        }
        public void OpenConnection()
        {
            if (sqlConnection.State == System.Data.ConnectionState.Closed)
            {
                sqlConnection.Open();
            }
        }
        public void CloseConnection()
        {
            if (sqlConnection.State == System.Data.ConnectionState.Open)
            {
                sqlConnection.Close();
            }
        }
    }
}
