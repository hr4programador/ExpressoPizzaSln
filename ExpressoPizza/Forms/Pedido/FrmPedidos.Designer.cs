namespace ExpressoPizza.Forms
{
    partial class FrmPedidos
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.TxtNumeroPedido = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.GridItensPedido = new System.Windows.Forms.DataGridView();
            this.Nome = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Preco = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Deletar = new System.Windows.Forms.DataGridViewButtonColumn();
            this.label2 = new System.Windows.Forms.Label();
            this.TxtNomeCliente = new System.Windows.Forms.TextBox();
            this.BtnProcurarCliente = new System.Windows.Forms.Button();
            this.BtnSalvar = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.TxtAnotacoes = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.cboFormaPagamento = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.BtnPedidoEntregue = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.GridItensPedido)).BeginInit();
            this.SuspendLayout();
            // 
            // TxtNumeroPedido
            // 
            this.TxtNumeroPedido.Enabled = false;
            this.TxtNumeroPedido.Location = new System.Drawing.Point(12, 26);
            this.TxtNumeroPedido.Name = "TxtNumeroPedido";
            this.TxtNumeroPedido.ReadOnly = true;
            this.TxtNumeroPedido.Size = new System.Drawing.Size(100, 20);
            this.TxtNumeroPedido.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(12, 6);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Nº Pedido";
            // 
            // GridItensPedido
            // 
            this.GridItensPedido.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GridItensPedido.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Nome,
            this.Preco,
            this.Deletar});
            this.GridItensPedido.Location = new System.Drawing.Point(12, 141);
            this.GridItensPedido.Name = "GridItensPedido";
            this.GridItensPedido.Size = new System.Drawing.Size(718, 150);
            this.GridItensPedido.TabIndex = 2;
            this.GridItensPedido.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.GridItensPedido_CellClick);
            this.GridItensPedido.CellPainting += new System.Windows.Forms.DataGridViewCellPaintingEventHandler(this.GridItensPedido_CellPainting);
            // 
            // Nome
            // 
            this.Nome.DataPropertyName = "Nome";
            this.Nome.HeaderText = "Nome";
            this.Nome.Name = "Nome";
            this.Nome.Width = 380;
            // 
            // Preco
            // 
            this.Preco.DataPropertyName = "Preco";
            this.Preco.HeaderText = "Preço";
            this.Preco.Name = "Preco";
            // 
            // Deletar
            // 
            this.Deletar.HeaderText = "";
            this.Deletar.Name = "Deletar";
            this.Deletar.Width = 25;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(12, 55);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(39, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Cliente";
            // 
            // TxtNomeCliente
            // 
            this.TxtNomeCliente.Enabled = false;
            this.TxtNomeCliente.Location = new System.Drawing.Point(12, 71);
            this.TxtNomeCliente.Name = "TxtNomeCliente";
            this.TxtNomeCliente.ReadOnly = true;
            this.TxtNomeCliente.Size = new System.Drawing.Size(260, 20);
            this.TxtNomeCliente.TabIndex = 4;
            // 
            // BtnProcurarCliente
            // 
            this.BtnProcurarCliente.Location = new System.Drawing.Point(281, 70);
            this.BtnProcurarCliente.Name = "BtnProcurarCliente";
            this.BtnProcurarCliente.Size = new System.Drawing.Size(72, 23);
            this.BtnProcurarCliente.TabIndex = 5;
            this.BtnProcurarCliente.Text = "Procurar";
            this.BtnProcurarCliente.UseVisualStyleBackColor = true;
            this.BtnProcurarCliente.Click += new System.EventHandler(this.BtnProcurarCliente_Click);
            // 
            // BtnSalvar
            // 
            this.BtnSalvar.Location = new System.Drawing.Point(12, 456);
            this.BtnSalvar.Name = "BtnSalvar";
            this.BtnSalvar.Size = new System.Drawing.Size(72, 23);
            this.BtnSalvar.TabIndex = 8;
            this.BtnSalvar.Text = "Salvar";
            this.BtnSalvar.UseVisualStyleBackColor = true;
            this.BtnSalvar.Click += new System.EventHandler(this.BtnSalvar_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(90, 456);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(72, 23);
            this.button3.TabIndex = 9;
            this.button3.Text = "Cancelar";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click_1);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(12, 112);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(100, 23);
            this.button1.TabIndex = 7;
            this.button1.Text = "Adicionar Itens";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.Button1_Click);
            // 
            // TxtAnotacoes
            // 
            this.TxtAnotacoes.Location = new System.Drawing.Point(12, 372);
            this.TxtAnotacoes.Multiline = true;
            this.TxtAnotacoes.Name = "TxtAnotacoes";
            this.TxtAnotacoes.Size = new System.Drawing.Size(718, 71);
            this.TxtAnotacoes.TabIndex = 10;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(12, 356);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(58, 13);
            this.label3.TabIndex = 11;
            this.label3.Text = "Anotações";
            // 
            // cboFormaPagamento
            // 
            this.cboFormaPagamento.FormattingEnabled = true;
            this.cboFormaPagamento.Items.AddRange(new object[] {
            "Dinheiro",
            "Cartão"});
            this.cboFormaPagamento.Location = new System.Drawing.Point(15, 319);
            this.cboFormaPagamento.Name = "cboFormaPagamento";
            this.cboFormaPagamento.Size = new System.Drawing.Size(147, 21);
            this.cboFormaPagamento.TabIndex = 12;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(12, 303);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(93, 13);
            this.label4.TabIndex = 13;
            this.label4.Text = "Forma Pagamento";
            // 
            // BtnPedidoEntregue
            // 
            this.BtnPedidoEntregue.Location = new System.Drawing.Point(165, 456);
            this.BtnPedidoEntregue.Name = "BtnPedidoEntregue";
            this.BtnPedidoEntregue.Size = new System.Drawing.Size(107, 23);
            this.BtnPedidoEntregue.TabIndex = 14;
            this.BtnPedidoEntregue.Text = "Finalizar Pedido";
            this.BtnPedidoEntregue.UseVisualStyleBackColor = true;
            // 
            // FrmPedidos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(742, 508);
            this.Controls.Add(this.BtnPedidoEntregue);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.cboFormaPagamento);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.TxtAnotacoes);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.BtnSalvar);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.BtnProcurarCliente);
            this.Controls.Add(this.TxtNomeCliente);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.GridItensPedido);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.TxtNumeroPedido);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmPedidos";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Pedidos";
            ((System.ComponentModel.ISupportInitialize)(this.GridItensPedido)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox TxtNumeroPedido;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView GridItensPedido;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox TxtNomeCliente;
        private System.Windows.Forms.Button BtnProcurarCliente;
        private System.Windows.Forms.Button BtnSalvar;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox TxtAnotacoes;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nome;
        private System.Windows.Forms.DataGridViewTextBoxColumn Preco;
        private System.Windows.Forms.DataGridViewButtonColumn Deletar;
        private System.Windows.Forms.ComboBox cboFormaPagamento;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button BtnPedidoEntregue;
    }
}