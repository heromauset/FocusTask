using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using Dapper;
using GerenciadordeTarefas.Data;
using System.Data.SqlClient;
using System.Threading.Tasks;
using System.Windows.Forms;


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

            {
                oTarefa.Nome = txtNome.Text.ToLower();
                oTarefa.Descricao = txtDescricao.Text.ToLower();
                oTarefa.Prioridade = Convert.ToInt32(txtPrioridade.Text);

                //INSTANCIANDO CLASSE DATACLIENTE
                DataTarefa dataTarefa = new DataTarefa();

                //CHAMANDO METODO INSERIR NA CLASSE DATACLIENTE
                dataTarefa.Inserir(oTarefa);
            }
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