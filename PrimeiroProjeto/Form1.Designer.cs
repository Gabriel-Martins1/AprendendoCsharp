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
            tabPage2 = new TabPage();
            tabPage3 = new TabPage();
            tabPage4 = new TabPage();
            label1 = new Label();
            txtNomeCliente = new TextBox();
            label2 = new Label();
            txtContatoCliente = new TextBox();
            btnCadastrarCliente = new Button();
            lstClientes = new ListBox();
            label3 = new Label();
            txtNomeItem = new TextBox();
            label4 = new Label();
            nudValorItem = new NumericUpDown();
            lstItens = new ListBox();
            label5 = new Label();
            cmbClientes = new ComboBox();
            label6 = new Label();
            cmbItens = new ComboBox();
            label7 = new Label();
            dtpRetirada = new DateTimePicker();
            label8 = new Label();
            dateTimePicker1 = new DateTimePicker();
            lblValorCalculado = new Label();
            btnRegistrarLocacao = new Button();
            dataGridView1 = new DataGridView();
            tabControl1.SuspendLayout();
            tabPage1.SuspendLayout();
            tabPage2.SuspendLayout();
            tabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)nudValorItem).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
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
            // tabPage2
            // 
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
            // tabPage3
            // 
            tabPage3.Controls.Add(dataGridView1);
            tabPage3.Controls.Add(btnRegistrarLocacao);
            tabPage3.Controls.Add(lblValorCalculado);
            tabPage3.Controls.Add(dateTimePicker1);
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
            // tabPage4
            // 
            tabPage4.Location = new Point(4, 24);
            tabPage4.Name = "tabPage4";
            tabPage4.Padding = new Padding(3);
            tabPage4.Size = new Size(816, 345);
            tabPage4.TabIndex = 7;
            tabPage4.Text = "Devoluções";
            tabPage4.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            label1.Location = new Point(197, 70);
            label1.Name = "label1";
            label1.Size = new Size(64, 23);
            label1.TabIndex = 0;
            label1.Text = "Nome:";
            // 
            // txtNomeCliente
            // 
            txtNomeCliente.Location = new Point(293, 70);
            txtNomeCliente.Name = "txtNomeCliente";
            txtNomeCliente.Size = new Size(100, 23);
            txtNomeCliente.TabIndex = 1;
            // 
            // label2
            // 
            label2.Location = new Point(197, 99);
            label2.Name = "label2";
            label2.Size = new Size(64, 19);
            label2.TabIndex = 2;
            label2.Text = "Contato:";
            // 
            // txtContatoCliente
            // 
            txtContatoCliente.Location = new Point(293, 99);
            txtContatoCliente.Name = "txtContatoCliente";
            txtContatoCliente.Size = new Size(100, 23);
            txtContatoCliente.TabIndex = 3;
            // 
            // btnCadastrarCliente
            // 
            btnCadastrarCliente.Location = new Point(197, 142);
            btnCadastrarCliente.Name = "btnCadastrarCliente";
            btnCadastrarCliente.Size = new Size(196, 23);
            btnCadastrarCliente.TabIndex = 4;
            btnCadastrarCliente.Text = "Cadastrar";
            btnCadastrarCliente.UseVisualStyleBackColor = true;
            btnCadastrarCliente.Click += button1_Click_1;
            // 
            // lstClientes
            // 
            lstClientes.FormattingEnabled = true;
            lstClientes.Location = new Point(197, 184);
            lstClientes.Name = "lstClientes";
            lstClientes.Size = new Size(196, 94);
            lstClientes.TabIndex = 5;
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
            // txtNomeItem
            // 
            txtNomeItem.Location = new Point(272, 82);
            txtNomeItem.Name = "txtNomeItem";
            txtNomeItem.Size = new Size(104, 23);
            txtNomeItem.TabIndex = 1;
            // 
            // label4
            // 
            label4.Location = new Point(214, 119);
            label4.Name = "label4";
            label4.Size = new Size(61, 32);
            label4.TabIndex = 2;
            label4.Text = "Valor por dia (R$):";
            // 
            // nudValorItem
            // 
            nudValorItem.Location = new Point(272, 128);
            nudValorItem.Name = "nudValorItem";
            nudValorItem.Size = new Size(120, 23);
            nudValorItem.TabIndex = 3;
            nudValorItem.ValueChanged += numericUpDown1_ValueChanged;
            // 
            // lstItens
            // 
            lstItens.FormattingEnabled = true;
            lstItens.Location = new Point(214, 175);
            lstItens.Name = "lstItens";
            lstItens.Size = new Size(218, 94);
            lstItens.TabIndex = 4;
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
            // cmbClientes
            // 
            cmbClientes.FormattingEnabled = true;
            cmbClientes.Location = new Point(260, 50);
            cmbClientes.Name = "cmbClientes";
            cmbClientes.Size = new Size(121, 23);
            cmbClientes.TabIndex = 1;
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
            // cmbItens
            // 
            cmbItens.FormattingEnabled = true;
            cmbItens.Location = new Point(260, 82);
            cmbItens.Name = "cmbItens";
            cmbItens.Size = new Size(121, 23);
            cmbItens.TabIndex = 3;
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
            // dtpRetirada
            // 
            dtpRetirada.Format = DateTimePickerFormat.Short;
            dtpRetirada.Location = new Point(260, 117);
            dtpRetirada.Name = "dtpRetirada";
            dtpRetirada.Size = new Size(121, 23);
            dtpRetirada.TabIndex = 5;
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
            // dateTimePicker1
            // 
            dateTimePicker1.Format = DateTimePickerFormat.Short;
            dateTimePicker1.Location = new Point(260, 151);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(121, 23);
            dateTimePicker1.TabIndex = 7;
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
            // btnRegistrarLocacao
            // 
            btnRegistrarLocacao.Location = new Point(260, 212);
            btnRegistrarLocacao.Name = "btnRegistrarLocacao";
            btnRegistrarLocacao.Size = new Size(121, 23);
            btnRegistrarLocacao.TabIndex = 9;
            btnRegistrarLocacao.Text = "Registrar Locação";
            btnRegistrarLocacao.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(437, 58);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView1.Size = new Size(240, 150);
            dataGridView1.TabIndex = 10;
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
            tabControl1.ResumeLayout(false);
            tabPage1.ResumeLayout(false);
            tabPage1.PerformLayout();
            tabPage2.ResumeLayout(false);
            tabPage2.PerformLayout();
            tabPage3.ResumeLayout(false);
            tabPage3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)nudValorItem).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
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
        private DateTimePicker dateTimePicker1;
        private Label label8;
        private DataGridView dataGridView1;
        private Button btnRegistrarLocacao;
    }
}
