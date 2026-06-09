namespace PrimeiroProjeto
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
            label10 = new Label();
            lstClientes = new ListBox();
            btnCadastrarCliente = new Button();
            txtContatoCliente = new TextBox();
            label2 = new Label();
            txtNomeCliente = new TextBox();
            label1 = new Label();
            tabPage2 = new TabPage();
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
            btnDevolver = new Button();
            lstLocacoesParaDevolver = new ListBox();
            label9 = new Label();
            btnCadastrarItem = new Button();
            lblStatusDevolucao = new Label();
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
            tabControl1.Location = new Point(-7, -3);
            tabControl1.Margin = new Padding(3, 4, 3, 4);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(1028, 540);
            tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            tabPage1.Controls.Add(label10);
            tabPage1.Controls.Add(lstClientes);
            tabPage1.Controls.Add(btnCadastrarCliente);
            tabPage1.Controls.Add(txtContatoCliente);
            tabPage1.Controls.Add(label2);
            tabPage1.Controls.Add(txtNomeCliente);
            tabPage1.Controls.Add(label1);
            tabPage1.Location = new Point(4, 29);
            tabPage1.Margin = new Padding(3, 4, 3, 4);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3, 4, 3, 4);
            tabPage1.Size = new Size(1020, 507);
            tabPage1.TabIndex = 4;
            tabPage1.Text = "Clientes";
            tabPage1.UseVisualStyleBackColor = true;
            tabPage1.Click += tabPage1_Click;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(681, 194);
            label10.Name = "label10";
            label10.Size = new Size(0, 20);
            label10.TabIndex = 6;
            // 
            // lstClientes
            // 
            lstClientes.FormattingEnabled = true;
            lstClientes.Location = new Point(225, 245);
            lstClientes.Margin = new Padding(3, 4, 3, 4);
            lstClientes.Name = "lstClientes";
            lstClientes.Size = new Size(223, 124);
            lstClientes.TabIndex = 5;
            // 
            // btnCadastrarCliente
            // 
            btnCadastrarCliente.Location = new Point(225, 189);
            btnCadastrarCliente.Margin = new Padding(3, 4, 3, 4);
            btnCadastrarCliente.Name = "btnCadastrarCliente";
            btnCadastrarCliente.Size = new Size(224, 31);
            btnCadastrarCliente.TabIndex = 4;
            btnCadastrarCliente.Text = "Cadastrar";
            btnCadastrarCliente.UseVisualStyleBackColor = true;
            btnCadastrarCliente.Click += button1_Click_1;
            // 
            // txtContatoCliente
            // 
            txtContatoCliente.Location = new Point(335, 132);
            txtContatoCliente.Margin = new Padding(3, 4, 3, 4);
            txtContatoCliente.Name = "txtContatoCliente";
            txtContatoCliente.Size = new Size(114, 27);
            txtContatoCliente.TabIndex = 3;
            txtContatoCliente.TextChanged += txtContatoCliente_TextChanged;
            // 
            // label2
            // 
            label2.Location = new Point(225, 132);
            label2.Name = "label2";
            label2.Size = new Size(73, 25);
            label2.TabIndex = 2;
            label2.Text = "Contato:";
            // 
            // txtNomeCliente
            // 
            txtNomeCliente.Location = new Point(335, 93);
            txtNomeCliente.Margin = new Padding(3, 4, 3, 4);
            txtNomeCliente.Name = "txtNomeCliente";
            txtNomeCliente.PlaceholderText = "Gabriel";
            txtNomeCliente.Size = new Size(114, 27);
            txtNomeCliente.TabIndex = 5;
            txtNomeCliente.TextChanged += txtNomeCliente_TextChanged;
            // 
            // label1
            // 
            label1.Location = new Point(225, 93);
            label1.Name = "label1";
            label1.Size = new Size(73, 31);
            label1.TabIndex = 3;
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
            tabPage2.Location = new Point(4, 29);
            tabPage2.Margin = new Padding(3, 4, 3, 4);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3, 4, 3, 4);
            tabPage2.Size = new Size(1020, 507);
            tabPage2.TabIndex = 5;
            tabPage2.Text = "Itens";
            tabPage2.UseVisualStyleBackColor = true;
            // 
            // lstItens
            // 
            lstItens.FormattingEnabled = true;
            lstItens.Location = new Point(347, 298);
            lstItens.Margin = new Padding(3, 4, 3, 4);
            lstItens.Name = "lstItens";
            lstItens.Size = new Size(224, 124);
            lstItens.TabIndex = 4;
            // 
            // nudValorItem
            // 
            nudValorItem.Location = new Point(423, 159);
            nudValorItem.Margin = new Padding(3, 4, 3, 4);
            nudValorItem.Name = "nudValorItem";
            nudValorItem.Size = new Size(137, 27);
            nudValorItem.TabIndex = 3;
            nudValorItem.ValueChanged += numericUpDown1_ValueChanged;
            // 
            // label4
            // 
            label4.Location = new Point(347, 143);
            label4.Name = "label4";
            label4.Size = new Size(70, 43);
            label4.TabIndex = 2;
            label4.Text = "Valor por dia (R$):";
            // 
            // txtNomeItem
            // 
            txtNomeItem.Location = new Point(423, 97);
            txtNomeItem.Margin = new Padding(3, 4, 3, 4);
            txtNomeItem.Name = "txtNomeItem";
            txtNomeItem.Size = new Size(137, 27);
            txtNomeItem.TabIndex = 1;
            // 
            // label3
            // 
            label3.Location = new Point(347, 97);
            label3.Name = "label3";
            label3.Size = new Size(97, 31);
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
            tabPage3.Location = new Point(4, 29);
            tabPage3.Margin = new Padding(3, 4, 3, 4);
            tabPage3.Name = "tabPage3";
            tabPage3.Padding = new Padding(3, 4, 3, 4);
            tabPage3.Size = new Size(1020, 507);
            tabPage3.TabIndex = 6;
            tabPage3.Text = "Locações";
            tabPage3.UseVisualStyleBackColor = true;
            // 
            // dgvLocacoesAtivas
            // 
            dgvLocacoesAtivas.AllowUserToAddRows = false;
            dgvLocacoesAtivas.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvLocacoesAtivas.Location = new Point(499, 77);
            dgvLocacoesAtivas.Margin = new Padding(3, 4, 3, 4);
            dgvLocacoesAtivas.Name = "dgvLocacoesAtivas";
            dgvLocacoesAtivas.ReadOnly = true;
            dgvLocacoesAtivas.RowHeadersWidth = 51;
            dgvLocacoesAtivas.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvLocacoesAtivas.Size = new Size(274, 200);
            dgvLocacoesAtivas.TabIndex = 10;
            // 
            // btnRegistrarLocacao
            // 
            btnRegistrarLocacao.Location = new Point(297, 283);
            btnRegistrarLocacao.Margin = new Padding(3, 4, 3, 4);
            btnRegistrarLocacao.Name = "btnRegistrarLocacao";
            btnRegistrarLocacao.Size = new Size(138, 31);
            btnRegistrarLocacao.TabIndex = 9;
            btnRegistrarLocacao.Text = "Registrar Locação";
            btnRegistrarLocacao.UseVisualStyleBackColor = true;
            // 
            // lblValorCalculado
            // 
            lblValorCalculado.AutoSize = true;
            lblValorCalculado.Location = new Point(201, 257);
            lblValorCalculado.Name = "lblValorCalculado";
            lblValorCalculado.Size = new Size(65, 20);
            lblValorCalculado.TabIndex = 8;
            lblValorCalculado.Text = "Valor: —";
            // 
            // dtpDevolucao
            // 
            dtpDevolucao.Format = DateTimePickerFormat.Short;
            dtpDevolucao.Location = new Point(297, 201);
            dtpDevolucao.Margin = new Padding(3, 4, 3, 4);
            dtpDevolucao.Name = "dtpDevolucao";
            dtpDevolucao.Size = new Size(138, 27);
            dtpDevolucao.TabIndex = 7;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(85, 209);
            label8.Name = "label8";
            label8.Size = new Size(195, 20);
            label8.TabIndex = 6;
            label8.Text = "Data Prevista de Devolução:";
            // 
            // dtpRetirada
            // 
            dtpRetirada.Format = DateTimePickerFormat.Short;
            dtpRetirada.Location = new Point(297, 156);
            dtpRetirada.Margin = new Padding(3, 4, 3, 4);
            dtpRetirada.Name = "dtpRetirada";
            dtpRetirada.Size = new Size(138, 27);
            dtpRetirada.TabIndex = 5;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(150, 164);
            label7.Name = "label7";
            label7.Size = new Size(125, 20);
            label7.TabIndex = 4;
            label7.Text = "Data de Retirada:";
            // 
            // cmbItens
            // 
            cmbItens.FormattingEnabled = true;
            cmbItens.Location = new Point(297, 109);
            cmbItens.Margin = new Padding(3, 4, 3, 4);
            cmbItens.Name = "cmbItens";
            cmbItens.Size = new Size(138, 28);
            cmbItens.TabIndex = 3;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(221, 120);
            label6.Name = "label6";
            label6.Size = new Size(42, 20);
            label6.TabIndex = 2;
            label6.Text = "item:";
            // 
            // cmbClientes
            // 
            cmbClientes.FormattingEnabled = true;
            cmbClientes.Location = new Point(297, 67);
            cmbClientes.Margin = new Padding(3, 4, 3, 4);
            cmbClientes.Name = "cmbClientes";
            cmbClientes.Size = new Size(138, 28);
            cmbClientes.TabIndex = 1;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(208, 77);
            label5.Name = "label5";
            label5.Size = new Size(56, 20);
            label5.TabIndex = 0;
            label5.Text = "cliente:";
            // 
            // tabPage4
            // 
            tabPage4.Controls.Add(lblStatusDevolucao);
            tabPage4.Controls.Add(btnDevolver);
            tabPage4.Controls.Add(lstLocacoesParaDevolver);
            tabPage4.Controls.Add(label9);
            tabPage4.Location = new Point(4, 29);
            tabPage4.Margin = new Padding(3, 4, 3, 4);
            tabPage4.Name = "tabPage4";
            tabPage4.Padding = new Padding(3, 4, 3, 4);
            tabPage4.Size = new Size(1020, 507);
            tabPage4.TabIndex = 7;
            tabPage4.Text = "Devoluções";
            tabPage4.UseVisualStyleBackColor = true;
            // 
            // btnDevolver
            // 
            btnDevolver.Location = new Point(402, 291);
            btnDevolver.Margin = new Padding(3, 4, 3, 4);
            btnDevolver.Name = "btnDevolver";
            btnDevolver.Size = new Size(86, 31);
            btnDevolver.TabIndex = 0;
            btnDevolver.Text = "Devolver";
            btnDevolver.UseVisualStyleBackColor = true;
            // 
            // lstLocacoesParaDevolver
            // 
            lstLocacoesParaDevolver.FormattingEnabled = true;
            lstLocacoesParaDevolver.Location = new Point(447, 98);
            lstLocacoesParaDevolver.Margin = new Padding(3, 4, 3, 4);
            lstLocacoesParaDevolver.Name = "lstLocacoesParaDevolver";
            lstLocacoesParaDevolver.Size = new Size(137, 124);
            lstLocacoesParaDevolver.TabIndex = 2;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(306, 142);
            label9.Name = "label9";
            label9.Size = new Size(117, 20);
            label9.TabIndex = 0;
            label9.Text = "Locações Ativas:";
            // 
            // btnCadastrarItem
            // 
            btnCadastrarItem.Location = new Point(347, 226);
            btnCadastrarItem.Margin = new Padding(3, 4, 3, 4);
            btnCadastrarItem.Name = "btnCadastrarItem";
            btnCadastrarItem.Size = new Size(224, 40);
            btnCadastrarItem.TabIndex = 5;
            btnCadastrarItem.Text = "Cadastrar";
            btnCadastrarItem.UseVisualStyleBackColor = true;
            // 
            // lblStatusDevolucao
            // 
            lblStatusDevolucao.AutoSize = true;
            lblStatusDevolucao.Location = new Point(414, 247);
            lblStatusDevolucao.Name = "lblStatusDevolucao";
            lblStatusDevolucao.Size = new Size(0, 20);
            lblStatusDevolucao.TabIndex = 3;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSize = true;
            ClientSize = new Size(1010, 748);
            Controls.Add(tabControl1);
            Margin = new Padding(3, 4, 3, 4);
            Name = "Form1";
            Text = "10";
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
        private Label label10;
        private Button btnCadastrarItem;
        private Label lblStatusDevolucao;
    }
}
