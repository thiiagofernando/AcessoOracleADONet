using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Oracle.ManagedDataAccess.Types;
using Oracle.ManagedDataAccess.Client;


namespace AcessoOracleADO
{
    class Program
    {
        public const string stContexao = "Data Source=(DESCRIPTION=(ADDRESS=(PROTOCOL=TCP)(HOST=192.168.56.102)(PORT=1521))(CONNECT_DATA=(SERVER=DEDICATED)(SERVICE_NAME=XE)));User ID=DBSISTEMA;Password=12345678;";
        static void Main(string[] args)
        {
            
            using (var conn = new OracleConnection(stContexao))
            {
                conn.Open();
                using (var comm = conn.CreateCommand())
                {
                    comm.Connection = conn;
                    comm.CommandText = "INSERT INTO CLIENTE(NOME) VALUES('Thiago')";
                    comm.ExecuteNonQuery();
                }
            }
        }
    }
}
