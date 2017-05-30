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
            this.Txt = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.GridItensPedido = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.TxtNomeCliente = new System.Windows.Forms.TextBox();
            this.BtnProcurarCliente = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.Nome = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Preco = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.GridItensPedido)).BeginInit();
            this.SuspendLayout();
            // 
            // Txt
            // 
            this.Txt.Enabled = false;
            this.Txt.Location = new System.Drawing.Point(12, 26);
            this.Txt.Name = "Txt";
            this.Txt.ReadOnly = true;
            this.Txt.Size = new System.Drawing.Size(100, 20);
            this.Txt.TabIndex = 0;
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
            this.Preco});
            this.GridItensPedido.Location = new System.Drawing.Point(12, 141);
            this.GridItensPedido.Name = "GridItensPedido";
            this.GridItensPedido.Size = new System.Drawing.Size(718, 150);
            this.GridItensPedido.TabIndex = 2;
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
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(12, 297);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(72, 23);
            this.button2.TabIndex = 8;
            this.button2.Text = "Fechar";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(90, 297);
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
            // FrmPedidos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(742, 331);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.BtnProcurarCliente);
            this.Controls.Add(this.TxtNomeCliente);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.GridItensPedido);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Txt);
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

        private System.Windows.Forms.TextBox Txt;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView GridItensPedido;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox TxtNomeCliente;
        private System.Windows.Forms.Button BtnProcurarCliente;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nome;
        private System.Windows.Forms.DataGridViewTextBoxColumn Preco;
    }
}