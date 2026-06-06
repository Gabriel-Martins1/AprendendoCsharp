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
            tabControl1.SuspendLayout();
            tabPage1.SuspendLayout();
            tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)nudValorItem).BeginInit();
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
            btnCadastrarCliente.Location = new Point(293, 143);
            btnCadastrarCliente.Name = "btnCadastrarCliente";
            btnCadastrarCliente.Size = new Size(100, 23);
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
            nudValorItem.Location = new Point(281, 128);
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
            lstItens.Size = new Size(241, 94);
            lstItens.TabIndex = 4;
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
            ((System.ComponentModel.ISupportInitialize)nudValorItem).EndInit();
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
    }
}
