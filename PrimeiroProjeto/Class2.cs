namespace ControleLocacao
{
    public class Item
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public decimal ValorPorDia { get; set; } 

        public Item(int id, string nome, decimal valorPorDia)
        {
            Id = id;
            Nome = nome;
            ValorPorDia = valorPorDia;
        }

        public override string ToString()
        {
            return $"[{Id}] {Nome} — R$ {ValorPorDia:F2}/dia";
        }
    }
}