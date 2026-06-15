namespace ControleLocacao.Models
{
    public class Item //class item é o modelo
    {
        //atributos da classe item
        public int Id { get; set; } 
        //public significa que o ID é publico e o Get set significa que ele pode ser lido e modificado de fora da classe
        public string Nome { get; set; }
        //public string Nome é a propriedade do nome do item que e uma string e pode ser lida e modificada de fora da classe
        public decimal ValorPorDia { get; set; }
        //public decimal ValorPorDia é a propriedade do valor por dia do item que é um decimal e pode ser lida e modificada de fora da classe

        public bool Disponivel { get; set; }
        //public bool Disponivel é a propriedade que indica se o item está disponível para locação ou não é um booleano(true ou false) e pode ser lida e modificada de fora da classe

        public Item(int id, string nome, decimal valorPorDia)
        //construtor da classe item que recebe o id, nome e valor por dia como parametros e atribui esses valores as propriedades da classe
        {
            this.Id = id; //atribui o valor do id recebido como parametro a propriedade Id da classe
            this.Nome = nome; //atribui o valor do nome recebido como parametro a propriedade Nome da classe
            this.ValorPorDia = valorPorDia; //atribui o valor do valor por dia recebido como parametro a propriedade ValorPorDia da classe
            this.Disponivel = true; //sempre que um item é criado ele comeca como disponivel, entao é setado como true
        } //é tipo o this. no JS

        //METODOS
        //Void serve para indicar que o método não retorna nenhum valor
        //ele apenas executa uma ação
        public void Locar()
        // Chamado quando o item é locado muda para indisponível
        {
            Disponivel = false;
        }
       
        public void Devolver()
        // Chamado quando o item é devolvido volta para disponível
        {
            Disponivel = true;
        }

        public override string ToString() //Sem o override fica "ControleLocacao.Item" na lista
        {                                 //com o override ele mostra o nome do item e o valor por dia
            return $"[{Id}] {Nome}  R$ {ValorPorDia:F2}/dia"; //o f2 formata o valor para arredondar. 10.5 vira 10.50, 17 vira 17.00
        }
    }
}