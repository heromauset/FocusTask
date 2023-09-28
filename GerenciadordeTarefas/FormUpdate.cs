using GerenciadordeTarefas.Data;
using System;
using System.Windows.Forms;

namespace GerenciadordeTarefas
{
    public partial class FormUpdate : Form
    {
        private DataTarefa dataTarefa;
        public DataTask TarefaSelecionada { get; set; }

        public FormUpdate()
        {
            InitializeComponent();
            dataTarefa = new DataTarefa();
        }

        private void FormUpdate_Load(object sender, EventArgs e)
        {
            // Verifique se a TarefaSelecionada não é nula
            if (TarefaSelecionada != null)
            {
                // Preencha as TextBox com os dados da tarefa selecionada
                TextBoxNome.Text = TarefaSelecionada.Nome;
                TextBoxDescricao.Text = TarefaSelecionada.Descricao;
                int prioridade = TarefaSelecionada.Prioridade;

                // Verifique a prioridade e marque o RadioButton apropriado
                if (prioridade == 1)
                {
                    radioButtonAlta.Checked = true;
                }
                else if (prioridade == 2)
                {
                    radioButtonMedia.Checked = true;
                }
                else if (prioridade == 3)
                {
                    radioButtonBaixa.Checked = true;
                }

                TextBoxDthr.Text = TarefaSelecionada.DataHoraCriacao.ToString(); // Certifique-se de que isso seja formatado corretamente
            }
        }

        private DataTask LerDadosDosCampos()
        {
            DataTask tarefa = new DataTask();

            // Lê os valores das TextBoxes e define-os na instância de DataTask
            tarefa.Nome = TextBoxNome.Text;
            tarefa.Descricao = TextBoxDescricao.Text;

            // Define a prioridade com base no RadioButton selecionado
            if (radioButtonAlta.Checked)
            {
                tarefa.Prioridade = 1;
            }
            else if (radioButtonMedia.Checked)
            {
                tarefa.Prioridade = 2;
            }
            else if (radioButtonBaixa.Checked)
            {
                tarefa.Prioridade = 3;
            }

            // Você pode continuar lendo outros campos da mesma maneira

            return tarefa;
        }

        private void buttonSalvar_Click(object sender, EventArgs e)
        {
            // Pergunte ao usuário se ele tem certeza de que deseja atualizar ou criar a tarefa
            DialogResult result = MessageBox.Show("Tem certeza de que deseja atualizar ou criar esta tarefa?", "Confirmar Operação", MessageBoxButtons.YesNo);

            if (result == DialogResult.Yes)
            {
                // Ler os dados dos campos do formulário
                DataTask tarefa = LerDadosDosCampos();

                // Verificar se o nome da tarefa já existe
                DataTask tarefaExistente = dataTarefa.BuscarTarefaPorNome(tarefa.Nome);

                if (tarefaExistente != null)
                {
                    // Se a tarefa com o mesmo nome já existe, atualize-a em vez de criar uma nova
                    tarefa.ID = tarefaExistente.ID; // Defina o ID da tarefa existente
                    int resultado = dataTarefa.Inserir(tarefa); // Isso agora será uma atualização

                    if (resultado == 2)
                    {
                        MessageBox.Show("Tarefa atualizada com sucesso.");
                        this.Close(); // Feche o formulário após a atualização
                    }
                    else
                    {
                        MessageBox.Show("Erro ao atualizar a tarefa.");
                    }
                }
                else
                {
                    // Se o nome da tarefa não existe, crie uma nova tarefa
                    int resultado = dataTarefa.Inserir(tarefa);

                    if (resultado == 3)
                    {
                        MessageBox.Show("Tarefa criada com sucesso.");
                        this.Close(); // Feche o formulário após a criação
                    }
                    else if (resultado == 1)
                    {
                        MessageBox.Show("Erro ao criar a tarefa. Verifique se o nome já existe.");
                    }
                    else
                    {
                        MessageBox.Show("Erro ao criar a tarefa.");
                    }
                }
          
            }
            this.Close();
            FormSearch formSearch = new FormSearch(); 
            formSearch.ShowDialog();
        
        }


        private void buttonExcluir_Click(object sender, EventArgs e)
        {
            // Perguntar ao usuário se ele tem certeza
            DialogResult result = MessageBox.Show("Tem certeza de que deseja excluir esta tarefa?", "Confirmar Exclusão", MessageBoxButtons.YesNo);

            if (result == DialogResult.Yes)
            {
                // Chamar o método Excluir do DataTarefa
                bool excluiu = dataTarefa.Excluir(TarefaSelecionada.ID.ToString());

                if (excluiu)
                {
                    MessageBox.Show("Tarefa excluída com sucesso");
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Erro ao excluir a tarefa");
                }

                // Fechar o FormUpdate ou realizar outras ações necessárias
                this.Close();
                FormSearch formSearch = new FormSearch();
                formSearch.ShowDialog();
            }
        }
        private void buttonConcluir_Click(object sender, EventArgs e)
        {
            // Perguntar ao usuário se ele tem certeza de que deseja concluir a tarefa
            DialogResult result = MessageBox.Show("Tem certeza de que deseja concluir esta tarefa?", "Confirmar Conclusão", MessageBoxButtons.YesNo);

            if (result == DialogResult.Yes)
            {
                // Chamar o método Excluir do DataTarefa para excluir a tarefa
                bool excluiu = dataTarefa.Excluir(TarefaSelecionada.ID.ToString());

                if (excluiu)
                {
                    MessageBox.Show("Parabéns! Você concluiu a tarefa com sucesso.");
                    this.Close(); // Feche o formulário após a conclusão
                }
                else
                {
                    MessageBox.Show("Erro ao concluir a tarefa. Verifique se a tarefa existe.");
                }
          

           
            }
            this.Close();
            FormSearch formSearch = new FormSearch();
            formSearch.ShowDialog();


        }

    }
}
