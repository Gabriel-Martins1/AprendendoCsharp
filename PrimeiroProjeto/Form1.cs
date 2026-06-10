using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using static System.Resources.ResXFileRef;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace ControleLocacao
{
    public partial class Form1 : Form
    //public quewr dizer que a classe é publica e pode ser acessada em qualquer lugar do projeto
    { //partial quer dizer que a classe foi dividida em mais de um arquivo, nesse caso o Form1.Designer.cs que é gerado automaticamente pelo Visual Studio para separar a parte de design da parte de lógica do código
        private List<Cliente> clientes = new List<Cliente>(); // isso serve para criar uma lista de clientes que é do tipo Cliente e é inicializada como uma nova lista vazia de clientes, o mesmo vale para itens e locacoes
        private List<Item> itens = new List<Item>();
        private List<Locacao> locacoes = new List<Locacao>();

        private int proximoIdCliente = 1;   // essas variáveis servem para gerar IDs únicos para cada cliente, item e locação, começando do 1 e incrementando a cada novo cadastro
        private int proximoIdItem = 1;
        private int proximoIdLocacao = 1;

        public Form1()
        {
            InitializeComponent(); //monta todos os controles visuais na tela. nunca remover
        }


        // ABA CLIENTES


        private void btnCadastrarCliente_Click(object sender, EventArgs e) // object sender, eventargs fazem: Obj Sender ´é referência do elemento que disparou o evento.
                                                                           // Eventargs : Contém os dados ou informações específicas sobre o evento em si
        {
            string nome = txtNomeCliente.Text.Trim(); //trim() serve para remover os espaços em branco no início e no final do texto
            string contato = txtContatoCliente.Text.Trim();

            if (nome == "" || contato == "") // isso serve para verificar se o nome ou contato estão vazios se estiverem exibe uma mensagem de aviso e retorna para nao continuar com o cadastro
            {
                MessageBox.Show("PREENCHA O NOME E CONTATO!!!11", "Aviso!!!!!!!!! ", MessageBoxButtons.OK, MessageBoxIcon.Warning); // MessageBox.Show é um método que exibe uma caixa de mensagem para o usuário
                return;                                                                                              //MessageBoxIcon.Warning);   ícone de triângulo amarelo de aviso

            }

            Cliente novoCliente = new Cliente(proximoIdCliente, nome, contato); // isso serve para criar um novo cliente usando a classe Cliente e passando o próximo ID
                                                                                // nome e contato como parâmetros para o construtor da classe Cliente
            proximoIdCliente++; // incrementa o contador para o próximo cliente ter um ID diferente
            clientes.Add(novoCliente); // adiciona o objeto criado na lista em memória

            AtualizarListaClientes(); // isso serve para atualizar a lista de clientes exibida na parte grafica
            AtualizarComboClientes(); // isso serve para atualizar o combo de clientes exibido na parte grafica

            txtNomeCliente.Text = ""; // isso serve para limpar os campos de texto após o cadastro do cliente
            txtContatoCliente.Text = ""; // isso serve para limpar os campos de texto após o cadastro do cliente
        }

        private void AtualizarListaClientes()
        {
            lstClientes.Items.Clear();
            foreach (Cliente c in clientes)
                // Percorre cada objeto Cliente dentro da lista de clientes
                // "c" é o nome temporário para cada cliente durante o loop
                lstClientes.Items.Add(c);
        }

        private void AtualizarComboClientes()
        {
            cmbClientes.Items.Clear();
            // Items = a coleção de itens dentro da ListBox visual
            // Clear() apaga todos os itens visuais da lista
            // Necessário para não duplicar ao redesenhar

            foreach (Cliente c in clientes) // Percorre cada objeto Cliente dentro da lista de clientes 
                                            // "c" é o nome temporário para cada cliente durante o loop
                cmbClientes.Items.Add(c);
        }

        // ABA ITENS


        private void btnCadastrarItem_Click(object sender, EventArgs e) // object sender, eventargs fazem: Obj Sender ´é referência do elemento que disparou o evento
                                                                        // Eventargs : Contém os dados ou informações específicas sobre o evento em si
        {
            string nome = txtNomeItem.Text.Trim(); //trim() serve para remover os espaços em branco no início e no final do texto
            decimal valor = nudValorItem.Value; //.value serve para pegar o valor do numeric up down
   

            if (nome == "") // isso serve para verificar se o nome do item esta vazio
                            // se estiver exibe uma mensagem de aviso e retorna para nao continuar com o cadastro
            {
                MessageBox.Show("Preencha o nome do item!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return; //MessageBoxIcon.Warning);   ícone de triângulo amarelo de aviso
            }
            if (valor <= 0) //se o valor for menor ou igual a zero exibe uma mensagem de aviso 
            {
                MessageBox.Show("O valor por dia deve ser maior que zero!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return; //MessageBoxIcon.Warning);   ícone de triângulo amarelo de aviso
            }

            Item novoItem = new Item(proximoIdItem, nome, valor); //criando um novo item usando a classe Item
            proximoIdItem++; //pega o id e soma 1 para o próximo item ter um ID diferente
            itens.Add(novoItem); //adiciona o objeto criado na lista em memória (lista la em cima,   private List<Item> itens = new List<Item>();)

            AtualizarListaItens(); // isso serve para atualizar a lista de itens exibida na parte grafica
            AtualizarComboItens(); // isso serve para atualizar o combo de itens exibido na parte grafica   

            txtNomeItem.Text = ""; // isso serve para limpar os campos de texto após o cadastro do item
            nudValorItem.Value = 0; // isso serve para limpar os campos de texto e o numeric up down após o cadastro do item
        }

        private void AtualizarListaItens() 
        {
            lstItens.Items.Clear();
            foreach (Item i in itens) //para cada objeto Item dentro da lista de itens "i", é o nome temporário para cada item durante o loop
                lstItens.Items.Add(i); //Items = a coleção de itens dentro da ListBox visual
                                      //add adiciona um novo item visual na lista
                                      //nesse caso o objeto "i" que é do tipo Item
        }

        private void AtualizarComboItens()
        {
            cmbItens.Items.Clear(); 
            foreach (Item i in itens) //para cada objeto Item dentro da lista de itens, "i" é o nome temporário para cada item durante o loop
                cmbItens.Items.Add(i); //Items = a coleção de itens dentro da combobox visual
                                       //add adiciona um novo item visual na lista
                                       //nesse caso o objeto "i" que é do tipo Item
        }

        // ABA LOCAÇOES

        private void btnRegistrarLocacao_Click(object sender, EventArgs e)
        {
            if (cmbClientes.SelectedItem == null)
            {
                MessageBox.Show("Selecione um cliente!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);  // isso serve para verificar se o usuário selecionou um cliente no combo box
                return; // se não selecionou exibe uma mensagem de aviso e retorna para nao continuar com o cadastro
            }
            if (cmbItens.SelectedItem == null) // isso serve para verificar se o usuário selecionou um item no combo box
            {
                MessageBox.Show("Selecione um item!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return; //MessageBoxIcon.Warning);   ícone de triângulo amarelo de aviso //MessageBoxButtons.OK para mostrar apenas o botão de ok
            }

            //combobox guarda todos os itens como objetos
            Cliente clienteSelecionado = (Cliente)cmbClientes.SelectedItem;
            // SelectedItem = o item que o usuário selecionou no dropdown
            // (Cliente) = cast: converte o tipo genérico "object" para "Cliente"
            Item itemSelecionado = (Item)cmbItens.SelectedItem; // mesmo processo para o item selecionado

            DateTime dataRetirada = dtpRetirada.Value.Date;
            // .Value = pega a data selecionada no DateTimePicker
            // .Date = remove a parte da hora (00:00:00), deixa só dia/mês/ano
            // sem o .Date: 07/06/2026 00:00:00
            // com o .Date:  07/06/2026

            DateTime dataDevolucao = dtpDevolucao.Value.Date; // mesmo processo para a data de devolucao

            if (dataDevolucao <= dataRetirada) // se a data de devolução for menor ou igual a data de retirada exibe uma mensagem de aviso e retorna para nao continuar com o cadastro
            {
                MessageBox.Show("A data de devolução deve ser depois da data de retirada!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return; //MessageBoxIcon.Warning);   ícone de triângulo amarelo de aviso, mensageboxbuttons.ok para mostrar apenas o botão de ok
            }

            if (!itemSelecionado.Disponivel) //se o item selecionado não estiver disponivel exibe uma mensagem de aviso e retorna para nao continuar com o cadastro
            {
                MessageBox.Show(
                    $"O item '{itemSelecionado.Nome}' está indisponível no momento!",  //aparece o nome do item que o usuário tentou alugar e a mensgaem
                    "Item Indisponível", // título da mensagem
                    MessageBoxButtons.OK, // mostra apenas o botão de ok
                    MessageBoxIcon.Warning // ícone de triangulo amarelo de aviso
                );
                return;
            }

            Locacao novaLocacao = new Locacao(proximoIdLocacao, clienteSelecionado, itemSelecionado, dataRetirada, dataDevolucao);
            proximoIdLocacao++; // + 1 no prox id, pra nao ficar igual
            locacoes.Add(novaLocacao); //adiciona na lista da memoria

            AtualizarTabelaLocacoesAtivas();
            AtualizarListaParaDevolver();

            lblValorCalculado.Text = $"✔ Locação registrada! Valor: R$ {novaLocacao.CalcularValorTotal():F2}";
            itemSelecionado.Locar(); // marca o item como indisponível
            AtualizarListaItens();   // atualiza a lista para mostrar o novo status
            AtualizarComboItens();   // atualiza o combo também
        }

        private void AtualizarTabelaLocacoesAtivas()
        {
            //datagridview é uma TABELA
            dgvLocacoesAtivas.Rows.Clear(); //apaga as linhas da tabela 
            dgvLocacoesAtivas.Columns.Clear(); // apaga todas as COLUNAS da tabela

            dgvLocacoesAtivas.Columns.Add("Id", "ID"); // cria uma coluna nova
            dgvLocacoesAtivas.Columns.Add("Cliente", "Cliente"); //nome interno, texto visual
            dgvLocacoesAtivas.Columns.Add("Item", "Item");
            dgvLocacoesAtivas.Columns.Add("Retirada", "Retirada");
            dgvLocacoesAtivas.Columns.Add("Devolucao", "Devolução Prevista");
            dgvLocacoesAtivas.Columns.Add("Dias", "Dias");
            dgvLocacoesAtivas.Columns.Add("Valor", "Valor Total");

            List<Locacao> ativas = locacoes.Where(l => l.Devolvida == false).ToList(); //filtro pra pegar apenas locacoes ativas.
                                                                                       // quando locacoes.devolvidas == false
                                                                                       // .tolist() converte o resultado filtrado de volta para uma lista

            foreach (Locacao loc in ativas) 
            {
                dgvLocacoesAtivas.Rows.Add(  
                    loc.Id,      //adiciona a coluna id
                    loc.Cliente.Nome, // adiciona a coluna cliente
                    loc.Item.Nome, // adiciona a coluna item
                    loc.DataRetirada.ToString("dd/MM/yyyy"), // adiciona a data de retirada
                    loc.DataPrevistaDevolucao.ToString("dd/MM/yyyy"), // adiciona a data devolução 
                    loc.CalcularDias(), //a coluna de quantos dias 
                    $"R$ {loc.CalcularValorTotal():F2}" //o valor 
                );
            }
        }

        // ABA DEVOLUÇÕES

        private void AtualizarListaParaDevolver() // isso serve para atualizar a lista de locações ativas que ainda não foram devolvidas
        {
            lstLocacoesParaDevolver.Items.Clear(); // limpa a lista visual para evitar duplicação
            var ativas = locacoes.Where(l => l.Devolvida == false).ToList(); 
            foreach (Locacao loc in ativas)
                lstLocacoesParaDevolver.Items.Add(loc);
        }

        private void btnDevolver_Click(object sender, EventArgs e) // sender = referência do botão que foi clicado
        {
            if (lstLocacoesParaDevolver.SelectedItem == null) // se nao houver nada selecionado na lista
            {
                MessageBox.Show("Selecione uma locação para devolver!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning); 
                return;
            }

            Locacao locacaoSelecionada = (Locacao)lstLocacoesParaDevolver.SelectedItem; //converte o objeto genérico "object" da ListBox para o tipo "Locacao"
            locacaoSelecionada.Devolvida = true; //  marca a locação como devolvida
            locacaoSelecionada.Item.Devolver(); // marca o item como disponível novamente
            AtualizarListaItens();              // atualiza a lista
            AtualizarComboItens();              // atualiza o combo
            AtualizarListaParaDevolver(); // atualiza a lista de locações para devolver
            AtualizarTabelaLocacoesAtivas(); // atualiza a tabela de locações ativas para remover a que foi devolvida

            lblStatusDevolucao.Text = $"✔ Locação #{locacaoSelecionada.Id} de {locacaoSelecionada.Cliente.Nome} registrada como devolvida!"; 
            
        }




        // MÉTODOS GERADOS PELO DESIGNER — não apagar

        private void button1_Click(object sender, EventArgs e) { }
        private void devolucoes_Click(object sender, EventArgs e) { }
        private void label3_Click(object sender, EventArgs e) { }
        private void numericUpDown1_ValueChanged(object sender, EventArgs e) { }

        private void lstItens_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

    }
}