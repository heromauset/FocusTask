using System;
using System.Windows.Forms;

public class Utils
{
    public static void FormataGridTarefas(DataGridView dataGridView)
    {
        // Renomeie as colunas do DataGridView
       
        dataGridView.Columns[1].HeaderText = "Nome";
        dataGridView.Columns[2].HeaderText = "Descrição";
        dataGridView.Columns[3].HeaderText = "Prioridade";
        
        

        //Mapeie valores de prioridade numérica para texto
        dataGridView.CellFormatting += (sender, e) =>
        {
            if (e.ColumnIndex == 3 && e.Value != null)
            {

                var prioridade = e.Value;

                switch (prioridade)
                {
                    case 1:
                        e.Value = "Alta";
                        break;
                    case 2:
                        e.Value = "Média";
                        break;
                    case 3:
                        e.Value = "Baixa";
                        break;
                }
            }
        };

        // Defina as larguras das colunas conforme necessário
        dataGridView.Columns[0].Width = 50;
        dataGridView.Columns[1].Width = 150;
        dataGridView.Columns[2].Width = 200;
        dataGridView.Columns[3].Width = 100;
        dataGridView.Columns[4].Width = 200;
        dataGridView.Columns[5].Width = 150;

        // Configure outros estilos conforme necessário
        dataGridView.BackgroundColor = Color.WhiteSmoke;
        dataGridView.DefaultCellStyle.BackColor = Color.WhiteSmoke;
        dataGridView.DefaultCellStyle.ForeColor = Color.DimGray;
        dataGridView.DefaultCellStyle.SelectionBackColor = Color.DarkGray;
        dataGridView.DefaultCellStyle.SelectionForeColor = Color.White;
        dataGridView.GridColor = Color.LightGray;
        dataGridView.AllowUserToResizeColumns = false;
        dataGridView.RowHeadersVisible = false;
        dataGridView.AllowUserToResizeRows = false;
    }
}
