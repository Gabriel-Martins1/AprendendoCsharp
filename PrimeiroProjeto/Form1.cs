using System;
using System.Collections.Generic;
using System.Windows.Forms;
using ControleLocacao.Models;
using ControleLocacao.Repositories;

namespace ControleLocacao
{
    public partial class Form1 : Form
    //public quer dizer que a classe é publica e pode ser acessada em qualquer lugar do projeto
    { //partial quer dizer que a classe foi dividida em mais de um arquivo, nesse caso o Form1.Designer.cs que é gerado automaticamente pelo Visual Studio para separar a parte de design da parte de lógica do código

        // repositories substituem as listas em memória — agora os dados vão pro banco
        private readonly ClienteRepository _clienteRepo = new ClienteRepository();
        private readonly ItemRepository _itemRepo = new ItemRepository();
        private readonly LocacaoRepository _locacaoRepo = new LocacaoRepository();

        public Form1()
        {
            InitializeComponent(); //monta todos os controles visuais na tela. nunca remover
        }

        // ABA CLIENTES

        private void btnCadastrarCliente_Click(object sender, EventArgs e) // object sender, eventargs fazem: Obj Sender é referência do elemento que disparou o evento.
                                                                           // Eventargs : Contém os dados ou informações específicas sobre o evento em si
        {
            string nome = txtNomeCliente.Text.Trim(); //trim() serve para remover os espaços em branco no início e no final do texto
            string contato = txtContatoCliente.Text.Trim();

            if (nome == "" || contato == "") // isso serve para verificar se o nome ou contato estão vazios se estiverem exibe uma mensagem de aviso e retorna para nao continuar com o cadastro
            {
                MessageBox.Show("PREENCHA O NOME E CONTATO!!!11", "Aviso!!!!!!!!! ", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return; //MessageBoxIcon.Warning);   ícone de triângulo amarelo de aviso
            }

            _clienteRepo.Inserir(new Cliente(0, nome, contato));
            // passa ID 0 pois o banco gera o ID automaticamente (AUTOINCREMENT)
            // antes criávamos new Cliente(proximoIdCliente, ...) — agora o banco controla o ID

            AtualizarListaClientes(); // isso serve para atualizar a lista de clientes exibida na parte grafica
            AtualizarComboClientes(); // isso serve para atualizar o combo de clientes exibido na parte grafica

            txtNomeCliente.Text = ""; // isso serve para limpar os campos de texto após o cadastro do cliente
            txtContatoCliente.Text = ""; // isso serve para limpar os campos de texto após o cadastro do cliente
        }

        private void AtualizarListaClientes()
        {
            lstClientes.Items.Clear(); // Items = a coleção de itens dentro da ListBox visual
                                       //no caso, lstClientes é o nome da ListBox visual que exibe os clientes
                                       //items já existe automaticamente dentro de toda ListBox, ele se refere aos itens dentro da listbox
            foreach (var c in _clienteRepo.ListarTodos())
                // agora busca do banco em vez da lista em memória
                // "c" é o nome temporário para cada cliente durante o loop
                lstClientes.Items.Add(c);
        }

        private void AtualizarComboClientes()
        {
            cmbClientes.Items.Clear();
            // Items = a coleção de itens dentro da ListBox visual
            // Clear() apaga todos os itens visuais da lista
            // Necessário para não duplicar ao redesenhar

            foreach (var c in _clienteRepo.ListarTodos()) // Percorre cada objeto Cliente vindo do banco
                                                          // "c" é o nome temporário para cada cliente durante o loop
                cmbClientes.Items.Add(c);
        }
        // ABA ITENS
     

        private void btnCadastrarItem_Click(object sender, EventArgs e) // object sender, eventargs fazem: Obj Sender é referência do elemento que disparou o evento
                                                                        // Eventargs : Contém os dados ou informações específicas sobre o evento em si
        {
            string nome = txtNomeItem.Text.Trim(); //trim() serve para remover os espaços em branco no início e no final do texto
            decimal valor = nudValorItem.Value; //.value serve para pegar o valor do numeric up down, que é do tipo decimal

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

            _itemRepo.Inserir(new Item(0, nome, valor));
            // passa ID 0 pois o banco gera o ID automaticamente (AUTOINCREMENT)

            AtualizarListaItens(); // isso serve para atualizar a lista de itens exibida na parte grafica
            AtualizarComboItens(); // isso serve para atualizar o combo de itens exibido na parte grafica   

            txtNomeItem.Text = ""; // isso serve para limpar os campos de texto após o cadastro do item
            nudValorItem.Value = 0; // isso serve para limpar os campos de texto e o numeric up down após o cadastro do item
        }

        private void AtualizarListaItens()
        {
            lstItens.Items.Clear();
            foreach (var i in _itemRepo.ListarTodos()) //para cada objeto Item vindo do banco, "i" é o nome temporário para cada item durante o loop
                lstItens.Items.Add(i); //Items = a coleção de itens dentro da ListBox visual
                                       //add adiciona um novo item visual na lista
                                       //nesse caso o objeto "i" que é do tipo Item
        }

        private void AtualizarComboItens()
        {
            cmbItens.Items.Clear();
            foreach (var i in _itemRepo.ListarTodos()) //para cada objeto Item vindo do banco, "i" é o nome temporário para cada item durante o loop
                cmbItens.Items.Add(i); //Items = a coleção de itens dentro da combobox visual
                                       //add adiciona um novo item visual na lista
                                       //nesse caso o objeto "i" que é do tipo Item
        }

        // ABA LOCAÇÕES

        private void btnRegistrarLocacao_Click(object sender, EventArgs e)
        {
            if (cmbClientes.SelectedItem == null) //SelectedItem é uma propriedade nativa do ComboBox que retorna o item atualmente selecionado pelo usuário
                                                  //se nao há nada selecionado, aparece a mensagem de aviso
            {
                MessageBox.Show("Selecione um cliente!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return; // se não selecionou exibe uma mensagem de aviso e retorna para nao continuar com o cadastro
            }
            if (cmbItens.SelectedItem == null) // isso serve para verificar se o usuário selecionou um item no combo box
            {
                MessageBox.Show("Selecione um item!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return; //MessageBoxIcon.Warning);   ícone de triângulo amarelo de aviso //MessageBoxButtons.OK para mostrar apenas o botão de ok
            }

            Cliente clienteSelecionado = (Cliente)cmbClientes.SelectedItem;
            //combobox guarda todos os itens como objetos GENERICOS
            // SelectedItem = o item que o usuário selecionou no dropdown
            // (Cliente) = converte o tipo genérico "object" para um objeto da class cliente "Cliente"

            Item itemSelecionado = (Item)cmbItens.SelectedItem;
            //combobox guarda todos os itens como objetos GENERICOS
            //SelectedItem é o item que o usuario selecionou 
            // (Item) converte o tipo genérico "object" para um objeto da class item "Item"

            if (!itemSelecionado.Disponivel) //se o item selecionado não estiver disponivel exibe uma mensagem de aviso e retorna para nao continuar com o cadastro
            {
                MessageBox.Show(
                    $"O item '{itemSelecionado.Nome}' está indisponível no momento!",  //aparece o nome do item que o usuário tentou alugar e a mensagem
                    "Item Indisponível", // título da mensagem
                    MessageBoxButtons.OK, // mostra apenas o botão de ok
                    MessageBoxIcon.Warning // ícone de triangulo amarelo de aviso
                );
                return;
            }

            DateTime dataRetirada = dtpRetirada.Value.Date;
            // .Value = pega a data selecionada no DateTimePicker (literalmente a data que o usuário escolheu)
            // .Date = remove as HORAS e deixa APENAS o dia    
            // sem o .Date: 07/06/2026 00:00:00
            // com o .Date:  07/06/2026

            DateTime dataDevolucao = dtpDevolucao.Value.Date; // mesmo processo para a data de devolucao

            if (dataDevolucao <= dataRetirada) // se a data de devolução for menor ou igual a data de retirada exibe uma mensagem de aviso e retorna para nao continuar com o cadastro
            {
                MessageBox.Show("A data de devolução deve ser depois da data de retirada!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var novaLocacao = new Locacao(0, clienteSelecionado, itemSelecionado, dataRetirada, dataDevolucao);
            // passa ID 0 pois o banco gera o ID automaticamente (AUTOINCREMENT)

            _locacaoRepo.Inserir(novaLocacao); // salva a locação no banco
            _itemRepo.AtualizarDisponibilidade(itemSelecionado.Id, false); // marca o item como indisponível no banco

            AtualizarTabelaLocacoesAtivas();
            AtualizarListaParaDevolver();
            AtualizarListaItens();   // atualiza a lista para mostrar o novo status
            AtualizarComboItens();   // atualiza o combo também

            lblValorCalculado.Text = $"✔ Locação registrada! Valor: R$ {novaLocacao.CalcularValorTotal():F2}";
            //essa lblvalorcalculado é a LABEL escrito "VALOR -" lá na aba de locacoes
            // :F2 serve para formatar o valor com 2 casas decimais
        }

        private void AtualizarTabelaLocacoesAtivas()
        {
            //datagridview é uma TABELA
            //criacao das colunas da tabela, cada coluna tem um nome interno e um texto visual
            dgvLocacoesAtivas.Rows.Clear(); //apaga as linhas da tabela 
            dgvLocacoesAtivas.Columns.Clear(); // apaga todas as COLUNAS da tabela
            //esse nome interno só se usa pra mudar o valor da coluna depois (mudar a altura de uma coluna por exemplo)
            dgvLocacoesAtivas.Columns.Add("Id", "ID"); // cria uma coluna nova
            dgvLocacoesAtivas.Columns.Add("Cliente", "Cliente"); //nome interno, texto visual
            dgvLocacoesAtivas.Columns.Add("Item", "Item");
            dgvLocacoesAtivas.Columns.Add("Retirada", "Retirada");
            dgvLocacoesAtivas.Columns.Add("Devolucao", "Devolução Prevista");
            dgvLocacoesAtivas.Columns.Add("Dias", "Dias");
            dgvLocacoesAtivas.Columns.Add("Valor", "Valor Total");

            var clientes = _clienteRepo.ListarTodos();
            var itens = _itemRepo.ListarTodos();
            var ativas = _locacaoRepo.ListarAtivas(clientes, itens);
            // a locacao ativa é JUSTAMENTE a que nao foi devolvida
            // agora busca do banco em vez de filtrar lista em memória

            foreach (var loc in ativas)
            {   //aqui é onde a gente preenche a tabela com as locações ativas
                dgvLocacoesAtivas.Rows.Add( //rows.add serve para adicionar uma nova linha na tabela
                                            //rows == linhas da tabela
                                            //o row nao adiciona pelo NOME, mas sim pela ORDEM
                    loc.Id,
                    loc.Cliente.Nome,
                    loc.Item.Nome,
                    loc.DataRetirada.ToString("dd/MM/yyyy"),
                    loc.DataPrevistaDevolucao.ToString("dd/MM/yyyy"),
                    loc.CalcularDias(),
                    $"R$ {loc.CalcularValorTotal():F2}"
                );
            }
        }

        // ABA DEVOLUÇÕES


        private void AtualizarListaParaDevolver() // isso serve para atualizar a lista de locações que estao ativas e podem ser devolvidas
        {
            lstLocacoesParaDevolver.Items.Clear(); // Limpa a lista visual

            var clientes = _clienteRepo.ListarTodos();
            var itens = _itemRepo.ListarTodos();
            var ativas = _locacaoRepo.ListarAtivas(clientes, itens);
            // Filtra as locações para pegar apenas as que não foram devolvidas (ativas)
            // se a locação esta ativa é pq ela nao foi devolvida

            foreach (var loc in ativas)
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

            _locacaoRepo.RegistrarDevolucao(locacaoSelecionada.Id); // marca como devolvida no banco
            _itemRepo.AtualizarDisponibilidade(locacaoSelecionada.Item.Id, true); // item volta a ficar disponível no banco
            // pega o ITEM da locação selecionada e transforma o Disponivel em TRUE no banco

            AtualizarListaItens();           // atualiza a lista dnv
            AtualizarComboItens();           // atualiza o combo dnv
            AtualizarListaParaDevolver();    // atualiza a lista de locações para devolver
            AtualizarTabelaLocacoesAtivas(); // atualiza a tabela de locações ativas para remover a que foi devolvida

            lblStatusDevolucao.Text = $"✔ Locação #{locacaoSelecionada.Id} de {locacaoSelecionada.Cliente.Nome} registrada como devolvida!";
        }

        // MÉTODOS GERADOS PELO DESIGNER

        private void button1_Click(object sender, EventArgs e) { }
        private void devolucoes_Click(object sender, EventArgs e) { }
        private void label3_Click(object sender, EventArgs e) { }
        private void numericUpDown1_ValueChanged(object sender, EventArgs e) { }
        private void lstItens_SelectedIndexChanged(object sender, EventArgs e) { }
        private void Form1_Load(object sender, EventArgs e) { }
    }
}