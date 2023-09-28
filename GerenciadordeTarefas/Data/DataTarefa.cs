using Dapper;
using System.Data;
using System.Data.SqlClient;
using System.ComponentModel.DataAnnotations.Schema;

namespace GerenciadordeTarefas.Data
{
    class DataTarefa
    {
        readonly ConectaBD oConenctaBD = new ConectaBD();
        readonly SqlCommand sqlCMD = new SqlCommand();
        public int Inserir(DataTask tarefa)
        {
            var oRetorno = 0;
            //sqlConn.AbreBanco();
            var conn = oConenctaBD.SqlConn();
            conn.Open();
            sqlCMD.Connection = conn;
            //ADICIONA OS PARAMETROS
            sqlCMD.Parameters.AddWithValue("@Nome", tarefa.Nome);
            sqlCMD.Parameters.AddWithValue("@Descricao", tarefa.Descricao);
            sqlCMD.Parameters.AddWithValue("@Prioridade", tarefa.Prioridade);
            sqlCMD.Parameters.AddWithValue("@DataHoraCriacao", DateTime.UtcNow.ToString("yyyy-MM-ddTHH:mm:ss.fffZ"));
            //COMANDO PARA VERIFICAR SE O USUARIO EXISTE
            string strCMD = "SELECT 1 FROM Tarefas WHERE Nome = @Nome";
            sqlCMD.CommandText = strCMD;
            //DATAREADER RECEBE O COMANDO SQLCMD.EXECUTEREADER
            IDataReader dtreader = sqlCMD.ExecuteReader();
            //INSTANCIA O OBJETO DATATABLE 
            DataTable dtResult = new DataTable();
            //EXECUTA A LEITURA DO DATAREADER PARA POPULAR O DATATABLE
            dtResult.Load(dtreader);
            //VERIFICA O RETORNO POSIÇÃO 0 É A PRIMEIRA POSIÇÃO DE RETORNO
            //COMO O SELECT RETORNA 1 SE EXISTIR E NADA SE NÃO EXISTIR
            //if(dtResult.Rows[0].ItemArray[0].ToString() == "1")

            if (dtResult.Rows.Count > 0 && tarefa.ID == 0)
            {
                ///CODIGO PARA INFORMAR QUE O USUARIO JÁ EXISTE...
                ///sqlCMD.ExecuteNonQuery();
                oRetorno = 1;
                MessageBox.Show("Tarefa já existe");

            }
            else if (tarefa.ID != 0) //se existir o id ele executa o update
            {
                //LOGICA PARA ALTERAR CLIENTE NÃO PERMITINDO ALTERAÇÃO DO USUARIO
                strCMD = "SELECT * FROM Tarefas WHERE Nome ='" + tarefa.Nome.ToString() + "'";
                //LOGICA PARA ALTERAR CLIENTE PERMITINDO ALTERAÇÃO DO USUARIO


                

                //QUANDO USUARIO EXISTE E É DO MESMO ID PODE ALTERAR...
                //QUANDO USUARIO EXISTE E ID É DIFERENTE NÃO PODE...
                //QUANDO USUARIO NÃO EXISTE O MESMO ID NÃO VAI EXISTIR...
                var podeAlterar = conn.Query<DataTask>(strCMD).ToList().
                                       Where(x => x.ID == tarefa.ID).
                                       Count() == 1 ? true : false;

                if (podeAlterar)
                {
                    // Atualize a consulta SQL para usar o valor real do Id
                    strCMD = "UPDATE Tarefas SET Nome=@Nome, Descricao=@Descricao, Prioridade=@Prioridade WHERE Id = @ID";

                    // Defina o valor do parâmetro @Id com o valor real do Id
                    sqlCMD.Parameters.AddWithValue("@Id", tarefa.ID);

                    sqlCMD.CommandText = strCMD;
                    sqlCMD.ExecuteNonQuery();
                    oRetorno = 2;
                }


                else
                {
                    oRetorno = 1;
                }
            }
            else //se não existir o id ele executa o insert
            {
                strCMD = "INSERT INTO Tarefas(Nome,Descricao,Prioridade,DataHoraCriacao) " +
                "VALUES(@Nome,@Descricao,@Prioridade,@DataHoraCriacao)";

                sqlCMD.CommandText = strCMD;
                sqlCMD.ExecuteNonQuery();
                oRetorno = 3;
                MessageBox.Show("Tarefa Criada");
            }

            conn.Close();
            conn.Dispose();
            conn = null;

            return oRetorno;

        }
        public List<DataTask> BuscarTarefa(DataTask tarefa)
        {
            try
            {
                ConectaBD oConectaBD = new ConectaBD();
                var conn = oConectaBD.SqlConn();
                conn.Open();
                string strCMD = "SELECT * FROM Tarefas WHERE Nome like '%" + tarefa.Nome.ToString() + "%'";
                //USANDO DAPPER
                var tarefas = conn.Query<DataTask>(strCMD).ToList();
                return tarefas;
            }
            catch (Exception ex)
            {
                throw;
            }
        }
        public DataTask BuscarTarefaPorNome(string nome)
        {
            using (var conn = oConenctaBD.SqlConn())
            {
                conn.Open();

                string query = "SELECT * FROM Tarefas WHERE Nome = @Nome";
                return conn.QueryFirstOrDefault<DataTask>(query, new { Nome = nome });
            }
        }
        public bool Excluir(string id)
        {
            bool oRetorno;
            try
            {
                ConectaBD oConectaBD = new ConectaBD();
                var conn = oConectaBD.SqlConn();
                conn.Open();
                string strCMD = "DELETE Tarefas WHERE Id = " + id;
                oRetorno = conn.Execute(strCMD).ToString() == "1" ? true : false;
            }
            catch
            {
                oRetorno = false;
            }
            return oRetorno;
        }
    }
}