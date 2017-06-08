namespace ExpressoPizza.Forms
{
    partial class FrmPesquisarPedidos
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.GridItensPedido = new System.Windows.Forms.DataGridView();
            this.BtnProcurarCliente = new System.Windows.Forms.Button();
            this.BtnSalvar = new System.Windows.Forms.Button();
            this.TxtTelefoneCliente = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.BtnAdicionarPedido = new System.Windows.Forms.Button();
            this.PedidoId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DataHora = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NumeroTelefoneCliente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EnderecoCliente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FormaPagamento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Visualizar = new System.Windows.Forms.DataGridViewButtonColumn();
            this.Editar = new System.Windows.Forms.DataGridViewButtonColumn();
            ((System.ComponentModel.ISupportInitialize)(this.GridItensPedido)).BeginInit();
            this.SuspendLayout();
            // 
            // GridItensPedido
            // 
            this.GridItensPedido.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GridItensPedido.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.PedidoId,
            this.DataHora,
            this.NumeroTelefoneCliente,
            this.EnderecoCliente,
            this.FormaPagamento,
            this.Visualizar,
            this.Editar});
            this.GridItensPedido.Location = new System.Drawing.Point(12, 67);
            this.GridItensPedido.Name = "GridItensPedido";
            this.GridItensPedido.Size = new System.Drawing.Size(920, 429);
            this.GridItensPedido.TabIndex = 2;
            this.GridItensPedido.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.GridItensPedido_CellClick);
            // 
            // BtnProcurarCliente
            // 
            this.BtnProcurarCliente.Location = new System.Drawing.Point(127, 24);
            this.BtnProcurarCliente.Name = "BtnProcurarCliente";
            this.BtnProcurarCliente.Size = new System.Drawing.Size(72, 23);
            this.BtnProcurarCliente.TabIndex = 5;
            this.BtnProcurarCliente.Text = "Procurar";
            this.BtnProcurarCliente.UseVisualStyleBackColor = true;
            this.BtnProcurarCliente.Click += new System.EventHandler(this.BtnProcurarCliente_Click);
            // 
            // BtnSalvar
            // 
            this.BtnSalvar.Location = new System.Drawing.Point(12, 502);
            this.BtnSalvar.Name = "BtnSalvar";
            this.BtnSalvar.Size = new System.Drawing.Size(72, 23);
            this.BtnSalvar.TabIndex = 8;
            this.BtnSalvar.Text = "Fechar";
            this.BtnSalvar.UseVisualStyleBackColor = true;
            this.BtnSalvar.Click += new System.EventHandler(this.BtnSalvar_Click);
            // 
            // TxtTelefoneCliente
            // 
            this.TxtTelefoneCliente.Location = new System.Drawing.Point(15, 25);
            this.TxtTelefoneCliente.Name = "TxtTelefoneCliente";
            this.TxtTelefoneCliente.Size = new System.Drawing.Size(107, 20);
            this.TxtTelefoneCliente.TabIndex = 10;
            this.TxtTelefoneCliente.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtTelefoneCliente_KeyPress);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 13);
            this.label1.TabIndex = 11;
            this.label1.Text = "Telefone";
            // 
            // BtnAdicionarPedido
            // 
            this.BtnAdicionarPedido.Location = new System.Drawing.Point(203, 24);
            this.BtnAdicionarPedido.Name = "BtnAdicionarPedido";
            this.BtnAdicionarPedido.Size = new System.Drawing.Size(116, 23);
            this.BtnAdicionarPedido.TabIndex = 12;
            this.BtnAdicionarPedido.Text = "Adicionar Pedido";
            this.BtnAdicionarPedido.UseVisualStyleBackColor = true;
            this.BtnAdicionarPedido.Click += new System.EventHandler(this.BtnAdicionarPedido_Click);
            // 
            // PedidoId
            // 
            this.PedidoId.DataPropertyName = "PedidoId";
            this.PedidoId.HeaderText = "Nº Pedido";
            this.PedidoId.Name = "PedidoId";
            this.PedidoId.Width = 80;
            // 
            // DataHora
            // 
            this.DataHora.DataPropertyName = "DataPedido";
            this.DataHora.HeaderText = "DataHora";
            this.DataHora.Name = "DataHora";
            // 
            // NumeroTelefoneCliente
            // 
            this.NumeroTelefoneCliente.DataPropertyName = "NumeroTelefoneCliente";
            this.NumeroTelefoneCliente.HeaderText = "Telefone";
            this.NumeroTelefoneCliente.Name = "NumeroTelefoneCliente";
            // 
            // EnderecoCliente
            // 
            this.EnderecoCliente.DataPropertyName = "EnderecoCliente";
            this.EnderecoCliente.HeaderText = "Endereço";
            this.EnderecoCliente.Name = "EnderecoCliente";
            this.EnderecoCliente.Width = 300;
            // 
            // FormaPagamento
            // 
            this.FormaPagamento.DataPropertyName = "FormaPagamento";
            this.FormaPagamento.HeaderText = "Forma De Pagamento";
            this.FormaPagamento.Name = "FormaPagamento";
            this.FormaPagamento.Width = 150;
            // 
            // Visualizar
            // 
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopCenter;
            this.Visualizar.DefaultCellStyle = dataGridViewCellStyle1;
            this.Visualizar.HeaderText = "";
            this.Visualizar.Name = "Visualizar";
            this.Visualizar.Text = "Visualizar";
            this.Visualizar.UseColumnTextForButtonValue = true;
            this.Visualizar.Width = 60;
            // 
            // Editar
            // 
            this.Editar.HeaderText = "";
            this.Editar.Name = "Editar";
            this.Editar.Text = "Editar";
            this.Editar.UseColumnTextForButtonValue = true;
            this.Editar.Width = 50;
            // 
            // FrmPesquisarPedidos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(970, 544);
            this.Controls.Add(this.BtnAdicionarPedido);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.TxtTelefoneCliente);
            this.Controls.Add(this.BtnSalvar);
            this.Controls.Add(this.BtnProcurarCliente);
            this.Controls.Add(this.GridItensPedido);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmPesquisarPedidos";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Pedidos";
            ((System.ComponentModel.ISupportInitialize)(this.GridItensPedido)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView GridItensPedido;
        private System.Windows.Forms.Button BtnProcurarCliente;
        private System.Windows.Forms.Button BtnSalvar;
        private System.Windows.Forms.TextBox TxtTelefoneCliente;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button BtnAdicionarPedido;
        private System.Windows.Forms.DataGridViewTextBoxColumn PedidoId;
        private System.Windows.Forms.DataGridViewTextBoxColumn DataHora;
        private System.Windows.Forms.DataGridViewTextBoxColumn NumeroTelefoneCliente;
        private System.Windows.Forms.DataGridViewTextBoxColumn EnderecoCliente;
        private System.Windows.Forms.DataGridViewTextBoxColumn FormaPagamento;
        private System.Windows.Forms.DataGridViewButtonColumn Visualizar;
        private System.Windows.Forms.DataGridViewButtonColumn Editar;
    }
}