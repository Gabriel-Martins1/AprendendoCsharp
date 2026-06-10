namespace ControleLocacao
{
    public class Cliente  //class cliente é o modelo
    {
        //atributos da classe cliente
        public int Id { get; set; }
        //public significa que o ID é publico e o Get set significa que ele pode ser lido e modificado de fora da classe
        public string Nome { get; set; }
        //public string Nome é a propriedade do nome do cliente que e uma string e pode ser lida e modificada de fora da classe
        public string Contato { get; set; }
        //public string Contato e a propriedade do contato do cliente que é uma string e pode ser lida e modificada de fora da classe

        public Cliente(int id, string nome, string contato) //aqui é onde o cliente é criado! No constructor  
        //construtor da classe cliente que recebe o id, nome e contato como parametros e atribui esses valores as propriedades da classe
        {
            this.Id = id; //atribui o valor do id recebido como parametro a propriedade Id da classe
            this.Nome = nome; //atribui o valor do nome recebido como parametro a propriedade Nome da classe
            this.Contato = contato; //atribui o valor do contato recebido como parametro a propriedade Contato da classe
        }  //é tipo o this. no JS





        public override string ToString() //Sem o override fica "ControleLocacao.Cliente" na lista
                                          //com o override ele mostra o nome do cliente e o contato
        {
            return $"[{Id}] {Nome} — {Contato}"; //retorna uma string formatada com o id, nome e contato do cliente
        }
    }
}