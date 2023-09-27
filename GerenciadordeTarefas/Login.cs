using GerenciadordeTarefas.Data;
using System.Data.SqlClient;

namespace GerenciadordeTarefas
{
    public partial class Login : Form
    {
        private ConectaBD conectaBD = new ConectaBD(); // Instância da sua classe ConectaBD

        public Login()
        {
            InitializeComponent();

        }

        private void btnEntrar_Click(object sender, EventArgs e)
        {
            string nomeUsuario = txtNomeUsuario.Text;
            string senha = txtSenha.Text;

            // Criptografe a senha antes de validar


            // Realize a validação do nome de usuário e senha no banco de dados
            if (ValidarUsuario(nomeUsuario, senha))
            {
                // Usuário válido, abra a janela Form1 ou outra janela que desejar
                FormSearch form1 = new FormSearch();
                form1.Show();
                this.Hide(); // Esconda a janela de login se necessário
            }
            else
            {
                MessageBox.Show("Nome de usuário ou senha inválidos.");
            }
        }

        private bool ValidarUsuario(string nomeUsuario, string senha)
        {
            using (SqlConnection connection = conectaBD.SqlConn()) // Use sua instância de conexão
            {
                connection.Open();

                string query = "SELECT Senha FROM Usuarios WHERE NomeUsuario = @NomeUsuario";
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@NomeUsuario", nomeUsuario);

                    string senhaArmazenada = (string)command.ExecuteScalar();

                    if (string.IsNullOrEmpty(senhaArmazenada))
                    {
                        // O usuário não existe, insira o usuário no banco de dados
                        InserirUsuario(nomeUsuario, senha);
                        return true; // Autenticação bem-sucedida, pois o usuário agora existe
                    }
                    else
                    {
                        // O usuário existe, verifique a senha
                        return senha == senhaArmazenada;
                    }
                }
            }
        }

        private void InserirUsuario(string nomeUsuario, string senha)
        {
            using (SqlConnection connection = conectaBD.SqlConn()) // Use sua instância de conexão
            {
                connection.Open();

                string query = "INSERT INTO Usuarios (NomeUsuario, Senha) VALUES (@NomeUsuario, @Senha)";
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@NomeUsuario", nomeUsuario);
                    command.Parameters.AddWithValue("@Senha", senha); // Sem criptografia

                    int rowsAffected = command.ExecuteNonQuery();

                    if (rowsAffected > 0)
                    {
                        MessageBox.Show("Usuário inserido com sucesso!");
                    }
                    else
                    {
                        MessageBox.Show("Falha ao inserir o usuário.");
                    }
                }
            }
        }



        private void btnEsqueciSenha_Click(object sender, EventArgs e)
        {
            // Exibe um prompt de entrada para o usuário inserir seu nome de usuário
            string nomeUsuario = Microsoft.VisualBasic.Interaction.InputBox("Insira seu nome de usuário:", "Redefinir Senha");

            if (!string.IsNullOrEmpty(nomeUsuario))
            {
                // Agora, solicite a nova senha
                string novaSenha = Microsoft.VisualBasic.Interaction.InputBox("Insira sua nova senha:", "Redefinir Senha");

                if (!string.IsNullOrEmpty(novaSenha))
                {
                    // Você pode prosseguir com a atualização da senha no banco de dados aqui
                    // Certifique-se de realizar a validação adequada e a atualização da senha

                    // No exemplo a seguir, estamos simulando a atualização da senha no banco de dados:
                    AtualizarSenhaNoBancoDeDados(nomeUsuario, novaSenha);

                    // Exibe uma mensagem de confirmação
                    MessageBox.Show("Senha redefinida com sucesso!");
                }
            }
        }


        private void AtualizarSenhaNoBancoDeDados(string nomeUsuario, string novaSenha)
        {
            try
            {
                using (SqlConnection connection = conectaBD.SqlConn())
                {
                    connection.Open();

                    // Execute um comando SQL para atualizar a senha no banco de dados
                    string query = "UPDATE Usuarios SET Senha = @NovaSenha WHERE NomeUsuario = @NomeUsuario";
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@NovaSenha", novaSenha);
                        command.Parameters.AddWithValue("@NomeUsuario", nomeUsuario);

                        int rowsAffected = command.ExecuteNonQuery();
                        if (rowsAffected > 0)
                        {
                            // Atualização bem-sucedida
                        }
                        else
                        {
                            // Falha na atualização
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                // Trate qualquer exceção que possa ocorrer durante a atualização
            }
        }

    }
}
