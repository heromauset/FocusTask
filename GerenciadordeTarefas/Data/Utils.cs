using System.Data.Common;
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
                        e.CellStyle.BackColor = Color.LightSalmon;
                        break;
                    case 2:
                        e.Value = "Média";
                        e.CellStyle.BackColor = Color.LightYellow;
                        break;
                    case 3:
                        e.Value = "Baixa";
                        e.CellStyle.BackColor = Color.LightGreen;
                        break;
                }
            }
        };

        // Defina as larguras das colunas conforme necessário
        
        dataGridView.Columns[1].Width = 150;
        dataGridView.Columns[2].Width = 328;
        dataGridView.Columns[3].Width = 100;
        

        // Configure outros estilos conforme necessário
        dataGridView.BackgroundColor = Color.WhiteSmoke;
        dataGridView.DefaultCellStyle.BackColor = Color.WhiteSmoke;
        dataGridView.DefaultCellStyle.ForeColor = Color.Black;
        dataGridView.DefaultCellStyle.SelectionBackColor = Color.DarkGray;
        dataGridView.DefaultCellStyle.SelectionForeColor = Color.White;
        dataGridView.GridColor = Color.LightGray;
        dataGridView.AllowUserToResizeColumns = false;
        dataGridView.RowHeadersVisible = false;
        dataGridView.AllowUserToResizeRows = false;
        dataGridView.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
        dataGridView.CellBorderStyle = DataGridViewCellBorderStyle.None;
        dataGridView.Columns[1].ReadOnly = true;

        // Defina a coluna Descrição como somente leitura (índice da coluna 2)
        dataGridView.Columns[2].ReadOnly = true;

        // Defina a coluna Prioridade como somente leitura (índice da coluna 3)
        dataGridView.Columns[3].ReadOnly = true;
    }

}
