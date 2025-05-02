using System.Data.SqlClient;

namespace GerenciadordeTarefas.Data
{
    internal class ConectaBD
    {
        string ConnctionString = @"Server=tcp:focustasks.database.windows.net,1433;Initial Catalog=gerenciadordetarefasbd;Persist Security Info=False;User ID=adm;Password=password;MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30;";
        public SqlConnection SqlConn()
        {
            {
                SqlConnection sqlConn = new SqlConnection(ConnctionString);
                return sqlConn;
            }

        }
        public void AbreBanco()
        {
            var sqlConn = SqlConn();
            sqlConn.Open();
            if (sqlConn.State == System.Data.ConnectionState.Closed)
            {

            }
        }
    }

}



