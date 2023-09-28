using GerenciadordeTarefas.Data;
using System.Data;

namespace GerenciadordeTarefas
{
    public partial class FormSearch : Form
    {
        public FormSearch()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            // Crie uma instância da segunda Form (FormNew)
            FormNew form2 = new FormNew();

            this.Close();// Exiba a segunda Form
            form2.Show();
            

        }

        private void btnBuscaTarefa(object sender, EventArgs e)
        {
            DataTask dataTask = new DataTask();
            dataTask.Nome = txtBusca.Text == "" ? "" : txtBusca.Text;

            DataTarefa oDatatarefa = new DataTarefa();
            var tarefas = oDatatarefa.BuscarTarefa(dataTask);

            tarefas = tarefas.OrderBy(tarefa => tarefa.Prioridade).ToList();

            dataGridView1.DataSource = tarefas;

            Utils.FormataGridTarefas(dataGridView1);

            dataGridView1.Columns["Id"].Visible = false;
            dataGridView1.Columns["DataHoraCriacao"].Visible = false;
            dataGridView1.Columns["Categoria"].Visible = false;

           
        }
        private void DataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                // Obtenha a tarefa selecionada na linha clicada
                DataTask tarefaSelecionada = dataGridView1.Rows[e.RowIndex].DataBoundItem as DataTask;

                if (tarefaSelecionada != null)
                {
                    // Crie uma instância do FormUpdate e defina a propriedade TarefaSelecionada
                    FormUpdate formUpdate = new FormUpdate();
                    formUpdate.TarefaSelecionada = tarefaSelecionada;

                    // Exiba o FormUpdate
                    this.Close();
                    formUpdate.Show();
                    
                }
            }
        }
    }
}


