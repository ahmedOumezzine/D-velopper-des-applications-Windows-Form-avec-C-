using DotNetTN.Connector.SQL;
using DotNetTN.Connector.SQL.Entities;

namespace DemoApplication.Base
{
    public class DotNetTNBase
    {
        public static string ConnectionString = "server=localhost;Database=workshop;Uid=root;Pwd=";

        public static SqlClient GetInstance()
        {
            SqlClient db = new SqlClient(
                new Config()
                {
                    ConnectionString = ConnectionString,
                    DbType = DbType.MySql,
                    IsAutoCloseConnection = true
                }
           );

            return db;
        }
    }
}