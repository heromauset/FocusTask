using GerenciadordeTarefas.Data;

namespace GerenciadordeTarefas
{
    public partial class FormNew : Form
    {
        public DataTask oTarefa = new DataTask();

        public FormNew()
        {
            InitializeComponent();
        }

        public void BtnInserir(object sender, EventArgs e)
        {
            oTarefa.Nome = txtNome.Text.ToLower();
            oTarefa.Descricao = txtDescricao.Text.ToLower();

            // Determine a prioridade com base nos radio buttons selecionados
            if (radioButtonAlta.Checked)
            {
                oTarefa.Prioridade = 1; // Prioridade Alta
            }
            else if (radioButtonMedia.Checked)
            {
                oTarefa.Prioridade = 2; // Prioridade Média
            }
            else if (radioButtonBaixa.Checked)
            {
                oTarefa.Prioridade = 3; // Prioridade Baixa
            }
            else
            {
                MessageBox.Show("Selecione uma prioridade antes de inserir a tarefa.");
                return;
            }

            //INSTANCIANDO CLASSE DATACLIENTE
            DataTarefa dataTarefa = new DataTarefa();


            //CHAMANDO METODO INSERIR NA CLASSE DATACLIENTE
            dataTarefa.Inserir(oTarefa);

          this.Close(); 

            FormSearch formSearch = new FormSearch();
            formSearch.ShowDialog();
        }

        private void FecharTela(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BTNhome(object sender, EventArgs e)
        {
            FormUpdate closeform = new FormUpdate();
            closeform.Close();
        }


    }
}
