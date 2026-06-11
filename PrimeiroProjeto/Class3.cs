namespace ControleLocacao
{
    public class Locacao
    { //class locacao é o modelo
        public int Id { get; set; } //public significa que o ID é publico e o Get set significa que ele pode ser lido e modificado de fora da classe
        public Cliente Cliente { get; set; }  //public Cliente Cliente é a propriedade do cliente da locacao que é um objeto do tipo Cliente e pode ser lida e modificada de fora da classe
        public Item Item { get; set; }  //public Item Item é a propriedade do item da locacao que é um objeto do tipo Item e pode ser lida e modificada de fora da classe
        public DateTime DataRetirada { get; set; } //public DateTime DataRetirada é a propriedade da data de retirada da locacao que e um objeto do tipo DateTime e pode ser lida e modificada de fora da classe
        public DateTime DataPrevistaDevolucao { get; set; } //public DateTime DataPrevistaDevolucao e a propriedade da data prevista de devolucao da locacao que
                                                            //é um objeto do tipo DateTime e pode ser lida e modificada de fora da classe
        public bool Devolvida { get; set; } //public bool Devolvida e a propriedade que indica se a locacao foi devolvida ou não é um booleano(true ou false)
                                            //e pode ser lida e modificada de fora da classe  

        //Void serve para indicar que o método não retorna nenhum valor
        //ele apenas executa uma ação
        public Locacao(int id, Cliente cliente, Item item, DateTime dataRetirada, DateTime dataPrevistaDevolucao) //constructor(aonde a locacao e criada)
        { //Cliente cliente pega o cliente selecionado na class de clientes e Item item pega o item selecionado na class de itens e as datas são pegas dos DateTimePicker
            this.Id = id;
            this.Cliente = cliente;
            this.Item = item;
            this.DataRetirada = dataRetirada;
            this.DataPrevistaDevolucao = dataPrevistaDevolucao;
            this.Devolvida = false; //quando a locacao é criada ela ainda não foi devolvida então a propriedade Devolvida é setada como false
        } //é tipo o this. no JS


        public int CalcularDias() //calcula a quantidade de dias entre a data de retirada e a data prevista de devolucao usando a propriedade Days do TimeSpan
        {

            return (DataPrevistaDevolucao - DataRetirada).Days;
        } //DataPrevistaDevolucao - DataRetirada retorna um TimeSpan que representa a diferença entre as duas datas e a propriedade Days retorna o número total de dias dessa diferença
            //o que é um timespan? é um tipo de dado que representa um intervalo de tempo
            //ele tem propriedades como Days, hours, sinutes, seconds
        public decimal CalcularValorTotal()
        {
            return CalcularDias() * Item.ValorPorDia; //como nao tem nenhuma variavel pra puxar o valor pra fora, se usa o metodo inteiro .calculardias()
        } //calcula o valor total da locacao multiplicando a quantidade de dias pela valor por dia do item usando a função CalcularDias() e a propriedade ValorPorDia do item

        public override string ToString()
        { //Sem o override fica "ControleLocacao.Locacao" na lista
            //com o override ele mostra o id da locacao, o nome do cliente, o nome do item  as datas de retirada e devolucao, a quantidade de dias e o valor total da locacao
            return $"[{Id}] {Cliente.Nome}.  {Item.Nome}  " + //como o texto do return ficou muito grande eu quebrei ele em duas linhas usando o operador de concatenacao + para juntar as duas partes do texto
                   $"{DataRetirada:dd/MM/yyyy}.  {DataPrevistaDevolucao:dd/MM/yyyy} | " + //o + basicamente junta os textos das linhas 
                   $"{CalcularDias()} dias. R$ {CalcularValorTotal():F2}";
        } //o f2 formata o valor para 2 casas decimais. 10.5 vira 10.50... 10  vira 10.00
          //DataRetirada:dd/MM/yyyy formata a data de retirada para o formato dia/mes/ano e DataPrevistaDevolucao:dd/MM/yyyy formata a data prevista de devolucao para o mesmo formato
    }     // padrao americano pro pradrao brasileiro
}