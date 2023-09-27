using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GerenciadordeTarefas.Data
{
    internal class ConectaBD
    {
        string ConnctionString = @"Data Source=FAUNOPC;" +
            "Initial Catalog=GerenciadorTarefasDB;" +
            "User ID=admin;" +
            "Password='10112020'";
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



 