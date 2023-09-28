namespace GerenciadordeTarefas.Data
{
    public class DataTask
    {
        public int ID { get; set; }
        public string Nome { get; set; }
        public string Descricao { get; set; }
        public int Prioridade { get; set; }
        public DateTime DataHoraCriacao { get; set; }
        public string Categoria { get; set; }
    }

}
