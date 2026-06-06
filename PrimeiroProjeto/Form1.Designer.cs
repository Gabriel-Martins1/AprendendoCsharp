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
            Clientes = new TabPage();
            Itens = new TabPage();
            locacoes = new TabPage();
            devolucoes = new TabPage();
            tabControl1.SuspendLayout();
            SuspendLayout();
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(Clientes);
            tabControl1.Controls.Add(Itens);
            tabControl1.Controls.Add(locacoes);
            tabControl1.Controls.Add(devolucoes);
            tabControl1.Location = new Point(-6, -2);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(824, 373);
            tabControl1.TabIndex = 0;
            // 
            // Clientes
            // 
            Clientes.Location = new Point(4, 24);
            Clientes.Name = "Clientes";
            Clientes.Padding = new Padding(3);
            Clientes.Size = new Size(816, 345);
            Clientes.TabIndex = 0;
            Clientes.Text = "Clientes";
            Clientes.UseVisualStyleBackColor = true;
            // 
            // Itens
            // 
            Itens.Location = new Point(4, 24);
            Itens.Name = "Itens";
            Itens.Padding = new Padding(3);
            Itens.Size = new Size(816, 345);
            Itens.TabIndex = 1;
            Itens.Text = "Itens";
            Itens.UseVisualStyleBackColor = true;
            // 
            // locacoes
            // 
            locacoes.Location = new Point(4, 24);
            locacoes.Name = "locacoes";
            locacoes.Padding = new Padding(3);
            locacoes.Size = new Size(816, 345);
            locacoes.TabIndex = 2;
            locacoes.Text = "Locações";
            locacoes.UseVisualStyleBackColor = true;
            // 
            // devolucoes
            // 
            devolucoes.Location = new Point(4, 24);
            devolucoes.Name = "devolucoes";
            devolucoes.Padding = new Padding(3);
            devolucoes.Size = new Size(816, 345);
            devolucoes.TabIndex = 3;
            devolucoes.Text = "Devoluções";
            devolucoes.UseVisualStyleBackColor = true;
            devolucoes.Click += devolucoes_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(814, 450);
            Controls.Add(tabControl1);
            Name = "Form1";
            Text = "Sistema de Locação";
            tabControl1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private TabControl tabControl1;
        private TabPage Clientes;
        private TabPage Itens;
        private TabPage locacoes;
        private TabPage devolucoes;
    }
}
