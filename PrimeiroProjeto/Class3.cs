namespace ControleLocacao
{
    public class Locacao
    {
        public int Id { get; set; }
        public Cliente Cliente { get; set; }      
        public Item Item { get; set; }           
        public DateTime DataRetirada { get; set; } 
        public DateTime DataPrevistaDevolucao { get; set; }
        public bool Devolvida { get; set; }       

        public Locacao(int id, Cliente cliente, Item item, DateTime dataRetirada, DateTime dataPrevistaDevolucao)
        {
            Id = id;
            Cliente = cliente;
            Item = item;
            DataRetirada = dataRetirada;
            DataPrevistaDevolucao = dataPrevistaDevolucao;
            Devolvida = false; 
        }


        public int CalcularDias()
        {

            return (DataPrevistaDevolucao - DataRetirada).Days;
        }

        public decimal CalcularValorTotal()
        {
            return CalcularDias() * Item.ValorPorDia;
        }

        public override string ToString()
        {
            return $"[{Id}] {Cliente.Nome} | {Item.Nome} | " +
                   $"{DataRetirada:dd/MM/yyyy} → {DataPrevistaDevolucao:dd/MM/yyyy} | " +
                   $"{CalcularDias()} dias | R$ {CalcularValorTotal():F2}";
        }
    }
}