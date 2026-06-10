using System.Xml.Linq;
using static System.Net.Mime.MediaTypeNames;

namespace ControleLocacao
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            tabControl1 = new TabControl();
            tabPage1 = new TabPage();
            lstClientes = new ListBox();
            btnCadastrarCliente = new Button();
            txtContatoCliente = new TextBox();
            label2 = new Label();
            txtNomeCliente = new TextBox();
            label1 = new Label();
            tabPage2 = new TabPage();
            btnCadastrarItem = new Button();
            lstItens = new ListBox();
            nudValorItem = new NumericUpDown();
            label4 = new Label();
            txtNomeItem = new TextBox();
            label3 = new Label();
            tabPage3 = new TabPage();
            dgvLocacoesAtivas = new DataGridView();
            btnRegistrarLocacao = new Button();
            lblValorCalculado = new Label();
            dtpDevolucao = new DateTimePicker();
            label8 = new Label();
            dtpRetirada = new DateTimePicker();
            label7 = new Label();
            cmbItens = new ComboBox();
            label6 = new Label();
            cmbClientes = new ComboBox();
            label5 = new Label();
            tabPage4 = new TabPage();
            lblStatusDevolucao = new Label();
            btnDevolver = new Button();
            lstLocacoesParaDevolver = new ListBox();
            label9 = new Label();
            tabControl1.SuspendLayout();
            tabPage1.SuspendLayout();
            tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)nudValorItem).BeginInit();
            tabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvLocacoesAtivas).BeginInit();
            tabPage4.SuspendLayout();
            SuspendLayout();
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(tabPage1);
            tabControl1.Controls.Add(tabPage2);
            tabControl1.Controls.Add(tabPage3);
            tabControl1.Controls.Add(tabPage4);
            tabControl1.Location = new Point(-6, -2);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(824, 373);
            tabControl1.TabIndex = 0;
            tabControl1.Click += btnCadastrarItem_Click;
            // 
            // tabPage1
            // 
            tabPage1.Controls.Add(lstClientes);
            tabPage1.Controls.Add(btnCadastrarCliente);
            tabPage1.Controls.Add(txtContatoCliente);
            tabPage1.Controls.Add(label2);
            tabPage1.Controls.Add(txtNomeCliente);
            tabPage1.Controls.Add(label1);
            tabPage1.Location = new Point(4, 24);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3);
            tabPage1.Size = new Size(816, 345);
            tabPage1.TabIndex = 4;
            tabPage1.Text = "Clientes";
            tabPage1.UseVisualStyleBackColor = true;
            // 
            // lstClientes
            // 
            lstClientes.FormattingEnabled = true;
            lstClientes.Location = new Point(197, 184);
            lstClientes.Name = "lstClientes";
            lstClientes.Size = new Size(196, 94);
            lstClientes.TabIndex = 5;
            // 
            // btnCadastrarCliente
            // 
            btnCadastrarCliente.Location = new Point(197, 142);
            btnCadastrarCliente.Name = "btnCadastrarCliente";
            btnCadastrarCliente.Size = new Size(196, 23);
            btnCadastrarCliente.TabIndex = 4;
            btnCadastrarCliente.Text = "Cadastrar";
            btnCadastrarCliente.UseVisualStyleBackColor = true;
            btnCadastrarCliente.Click += btnCadastrarCliente_Click;
            // 
            // txtContatoCliente
            // 
            txtContatoCliente.Location = new Point(293, 99);
            txtContatoCliente.Name = "txtContatoCliente";
            txtContatoCliente.Size = new Size(100, 23);
            txtContatoCliente.TabIndex = 3;
            // 
            // label2
            // 
            label2.Location = new Point(197, 99);
            label2.Name = "label2";
            label2.Size = new Size(64, 19);
            label2.TabIndex = 2;
            label2.Text = "Contato:";
            // 
            // txtNomeCliente
            // 
            txtNomeCliente.Location = new Point(293, 70);
            txtNomeCliente.Name = "txtNomeCliente";
            txtNomeCliente.Size = new Size(100, 23);
            txtNomeCliente.TabIndex = 1;
            // 
            // label1
            // 
            label1.Location = new Point(197, 70);
            label1.Name = "label1";
            label1.Size = new Size(64, 23);
            label1.TabIndex = 0;
            label1.Text = "Nome:";
            // 
            // tabPage2
            // 
            tabPage2.Controls.Add(btnCadastrarItem);
            tabPage2.Controls.Add(lstItens);
            tabPage2.Controls.Add(nudValorItem);
            tabPage2.Controls.Add(label4);
            tabPage2.Controls.Add(txtNomeItem);
            tabPage2.Controls.Add(label3);
            tabPage2.Location = new Point(4, 24);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3);
            tabPage2.Size = new Size(816, 345);
            tabPage2.TabIndex = 5;
            tabPage2.Text = "Itens";
            tabPage2.UseVisualStyleBackColor = true;
            // 
            // btnCadastrarItem
            // 
            btnCadastrarItem.Location = new Point(239, 171);
            btnCadastrarItem.Name = "btnCadastrarItem";
            btnCadastrarItem.Size = new Size(164, 23);
            btnCadastrarItem.TabIndex = 5;
            btnCadastrarItem.Text = "Cadastrar";
            btnCadastrarItem.UseVisualStyleBackColor = true;
            btnCadastrarItem.Click += btnCadastrarItem_Click;
            // 
            // lstItens
            // 
            lstItens.FormattingEnabled = true;
            lstItens.Location = new Point(214, 200);
            lstItens.Name = "lstItens";
            lstItens.Size = new Size(218, 94);
            lstItens.TabIndex = 4;
            lstItens.SelectedIndexChanged += lstItens_SelectedIndexChanged;
            // 
            // nudValorItem
            // 
            nudValorItem.Location = new Point(272, 128);
            nudValorItem.Name = "nudValorItem";
            nudValorItem.Size = new Size(120, 23);
            nudValorItem.TabIndex = 3;
            nudValorItem.ValueChanged += numericUpDown1_ValueChanged;
            // 
            // label4
            // 
            label4.Location = new Point(214, 119);
            label4.Name = "label4";
            label4.Size = new Size(61, 32);
            label4.TabIndex = 2;
            label4.Text = "Valor por dia (R$):";
            // 
            // txtNomeItem
            // 
            txtNomeItem.Location = new Point(272, 82);
            txtNomeItem.Name = "txtNomeItem";
            txtNomeItem.Size = new Size(104, 23);
            txtNomeItem.TabIndex = 1;
            // 
            // label3
            // 
            label3.Location = new Point(214, 82);
            label3.Name = "label3";
            label3.Size = new Size(85, 23);
            label3.TabIndex = 0;
            label3.Text = "Nome:";
            label3.Click += label3_Click;
            // 
            // tabPage3
            // 
            tabPage3.Controls.Add(dgvLocacoesAtivas);
            tabPage3.Controls.Add(btnRegistrarLocacao);
            tabPage3.Controls.Add(lblValorCalculado);
            tabPage3.Controls.Add(dtpDevolucao);
            tabPage3.Controls.Add(label8);
            tabPage3.Controls.Add(dtpRetirada);
            tabPage3.Controls.Add(label7);
            tabPage3.Controls.Add(cmbItens);
            tabPage3.Controls.Add(label6);
            tabPage3.Controls.Add(cmbClientes);
            tabPage3.Controls.Add(label5);
            tabPage3.Location = new Point(4, 24);
            tabPage3.Name = "tabPage3";
            tabPage3.Padding = new Padding(3);
            tabPage3.Size = new Size(816, 345);
            tabPage3.TabIndex = 6;
            tabPage3.Text = "Locações";
            tabPage3.UseVisualStyleBackColor = true;
            // 
            // dgvLocacoesAtivas
            // 
            dgvLocacoesAtivas.AllowUserToAddRows = false;
            dgvLocacoesAtivas.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvLocacoesAtivas.Location = new Point(437, 58);
            dgvLocacoesAtivas.Name = "dgvLocacoesAtivas";
            dgvLocacoesAtivas.ReadOnly = true;
            dgvLocacoesAtivas.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvLocacoesAtivas.Size = new Size(240, 150);
            dgvLocacoesAtivas.TabIndex = 10;
            // 
            // btnRegistrarLocacao
            // 
            btnRegistrarLocacao.Location = new Point(260, 212);
            btnRegistrarLocacao.Name = "btnRegistrarLocacao";
            btnRegistrarLocacao.Size = new Size(121, 23);
            btnRegistrarLocacao.TabIndex = 9;
            btnRegistrarLocacao.Text = "Registrar Locação";
            btnRegistrarLocacao.UseVisualStyleBackColor = true;
            btnRegistrarLocacao.Click += btnRegistrarLocacao_Click;
            // 
            // lblValorCalculado
            // 
            lblValorCalculado.AutoSize = true;
            lblValorCalculado.Location = new Point(176, 193);
            lblValorCalculado.Name = "lblValorCalculado";
            lblValorCalculado.Size = new Size(51, 15);
            lblValorCalculado.TabIndex = 8;
            lblValorCalculado.Text = "Valor: —";
            // 
            // dtpDevolucao
            // 
            dtpDevolucao.Format = DateTimePickerFormat.Short;
            dtpDevolucao.Location = new Point(260, 151);
            dtpDevolucao.Name = "dtpDevolucao";
            dtpDevolucao.Size = new Size(121, 23);
            dtpDevolucao.TabIndex = 7;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(74, 157);
            label8.Name = "label8";
            label8.Size = new Size(153, 15);
            label8.TabIndex = 6;
            label8.Text = "Data Prevista de Devolução:";
            // 
            // dtpRetirada
            // 
            dtpRetirada.Format = DateTimePickerFormat.Short;
            dtpRetirada.Location = new Point(260, 117);
            dtpRetirada.Name = "dtpRetirada";
            dtpRetirada.Size = new Size(121, 23);
            dtpRetirada.TabIndex = 5;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(131, 123);
            label7.Name = "label7";
            label7.Size = new Size(96, 15);
            label7.TabIndex = 4;
            label7.Text = "Data de Retirada:";
            // 
            // cmbItens
            // 
            cmbItens.FormattingEnabled = true;
            cmbItens.Location = new Point(260, 82);
            cmbItens.Name = "cmbItens";
            cmbItens.Size = new Size(121, 23);
            cmbItens.TabIndex = 3;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(193, 90);
            label6.Name = "label6";
            label6.Size = new Size(34, 15);
            label6.TabIndex = 2;
            label6.Text = "item:";
            // 
            // cmbClientes
            // 
            cmbClientes.FormattingEnabled = true;
            cmbClientes.Location = new Point(260, 50);
            cmbClientes.Name = "cmbClientes";
            cmbClientes.Size = new Size(121, 23);
            cmbClientes.TabIndex = 1;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(182, 58);
            label5.Name = "label5";
            label5.Size = new Size(45, 15);
            label5.TabIndex = 0;
            label5.Text = "cliente:";
            // 
            // tabPage4
            // 
            tabPage4.Controls.Add(lblStatusDevolucao);
            tabPage4.Controls.Add(btnDevolver);
            tabPage4.Controls.Add(lstLocacoesParaDevolver);
            tabPage4.Controls.Add(label9);
            tabPage4.Location = new Point(4, 24);
            tabPage4.Name = "tabPage4";
            tabPage4.Padding = new Padding(3);
            tabPage4.Size = new Size(816, 345);
            tabPage4.TabIndex = 7;
            tabPage4.Text = "Devoluções";
            tabPage4.UseVisualStyleBackColor = true;
            // 
            // lblStatusDevolucao
            // 
            lblStatusDevolucao.AutoSize = true;
            lblStatusDevolucao.Location = new Point(159, 206);
            lblStatusDevolucao.Name = "lblStatusDevolucao";
            lblStatusDevolucao.Size = new Size(0, 15);
            lblStatusDevolucao.TabIndex = 3;
            // 
            // btnDevolver
            // 
            btnDevolver.Location = new Point(159, 162);
            btnDevolver.Name = "btnDevolver";
            btnDevolver.Size = new Size(244, 23);
            btnDevolver.TabIndex = 2;
            btnDevolver.Text = "Registrar Devolução";
            btnDevolver.UseVisualStyleBackColor = true;
            btnDevolver.Click += btnDevolver_Click;
            // 
            // lstLocacoesParaDevolver
            // 
            lstLocacoesParaDevolver.FormattingEnabled = true;
            lstLocacoesParaDevolver.Location = new Point(283, 47);
            lstLocacoesParaDevolver.Name = "lstLocacoesParaDevolver";
            lstLocacoesParaDevolver.Size = new Size(120, 94);
            lstLocacoesParaDevolver.TabIndex = 1;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(159, 80);
            label9.Name = "label9";
            label9.Size = new Size(94, 15);
            label9.TabIndex = 0;
            label9.Text = "Locações Ativas:";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSize = true;
            ClientSize = new Size(884, 561);
            Controls.Add(tabControl1);
            Name = "Form1";
            Text = "Sistema de Locação";
            Load += Form1_Load;
            tabControl1.ResumeLayout(false);
            tabPage1.ResumeLayout(false);
            tabPage1.PerformLayout();
            tabPage2.ResumeLayout(false);
            tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)nudValorItem).EndInit();
            tabPage3.ResumeLayout(false);
            tabPage3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvLocacoesAtivas).EndInit();
            tabPage4.ResumeLayout(false);
            tabPage4.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TabControl tabControl1;
        private TabPage tabPage1;
        private TabPage tabPage2;
        private TabPage tabPage3;
        private TabPage tabPage4;
        private Label label1;
        private Button btnCadastrarCliente;
        private TextBox txtContatoCliente;
        private Label label2;
        private TextBox txtNomeCliente;
        private ListBox lstClientes;
        private TextBox txtNomeItem;
        private Label label3;
        private NumericUpDown nudValorItem;
        private Label label4;
        private ListBox lstItens;
        private Label label5;
        private ComboBox cmbClientes;
        private ComboBox cmbItens;
        private Label label6;
        private DateTimePicker dtpRetirada;
        private Label label7;
        private Label lblValorCalculado;
        private DateTimePicker dtpDevolucao;
        private Label label8;
        private DataGridView dgvLocacoesAtivas;
        private Button btnRegistrarLocacao;
        private Button btnDevolver;
        private ListBox lstLocacoesParaDevolver;
        private Label label9;
        private Label lblStatusDevolucao;
        private Button btnCadastrarItem;
    }
}