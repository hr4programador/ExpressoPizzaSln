namespace ExpressoPizza.Forms
{
    partial class FrmSelecionarCliente
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
            this.BtnProcurarCliente = new System.Windows.Forms.Button();
            this.TxtTelefone = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.BtnConfirmar = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.GridClientes = new System.Windows.Forms.DataGridView();
            this.Nome = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Telefone = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.GridClientes)).BeginInit();
            this.SuspendLayout();
            // 
            // BtnProcurarCliente
            // 
            this.BtnProcurarCliente.Location = new System.Drawing.Point(137, 24);
            this.BtnProcurarCliente.Name = "BtnProcurarCliente";
            this.BtnProcurarCliente.Size = new System.Drawing.Size(72, 23);
            this.BtnProcurarCliente.TabIndex = 13;
            this.BtnProcurarCliente.Text = "Procurar";
            this.BtnProcurarCliente.UseVisualStyleBackColor = true;
            this.BtnProcurarCliente.Click += new System.EventHandler(this.BtnProcurarCliente_Click);
            // 
            // TxtTelefone
            // 
            this.TxtTelefone.Location = new System.Drawing.Point(2, 25);
            this.TxtTelefone.Name = "TxtTelefone";
            this.TxtTelefone.Size = new System.Drawing.Size(129, 20);
            this.TxtTelefone.TabIndex = 12;
            this.TxtTelefone.KeyUp += new System.Windows.Forms.KeyEventHandler(this.TxtTelefone_KeyUp);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(2, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 13);
            this.label2.TabIndex = 11;
            this.label2.Text = "Telefone";
            // 
            // BtnConfirmar
            // 
            this.BtnConfirmar.Location = new System.Drawing.Point(2, 238);
            this.BtnConfirmar.Name = "BtnConfirmar";
            this.BtnConfirmar.Size = new System.Drawing.Size(75, 23);
            this.BtnConfirmar.TabIndex = 10;
            this.BtnConfirmar.Text = "Confirmar";
            this.BtnConfirmar.UseVisualStyleBackColor = true;
            this.BtnConfirmar.Click += new System.EventHandler(this.BtnConfirmar_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(83, 238);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 14;
            this.button1.Text = "Cancelar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // GridClientes
            // 
            this.GridClientes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GridClientes.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Nome,
            this.Telefone});
            this.GridClientes.Location = new System.Drawing.Point(2, 52);
            this.GridClientes.MultiSelect = false;
            this.GridClientes.Name = "GridClientes";
            this.GridClientes.Size = new System.Drawing.Size(522, 180);
            this.GridClientes.TabIndex = 16;
            this.GridClientes.DoubleClick += new System.EventHandler(this.GridClientes_DoubleClick);
            // 
            // Nome
            // 
            this.Nome.DataPropertyName = "Nome";
            this.Nome.HeaderText = "Nome";
            this.Nome.Name = "Nome";
            this.Nome.Width = 360;
            // 
            // Telefone
            // 
            this.Telefone.DataPropertyName = "Telefone";
            this.Telefone.HeaderText = "Telefone";
            this.Telefone.Name = "Telefone";
            // 
            // FrmSelecionarCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(530, 273);
            this.Controls.Add(this.GridClientes);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.BtnProcurarCliente);
            this.Controls.Add(this.TxtTelefone);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.BtnConfirmar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmSelecionarCliente";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Selecionar Cliente";
            ((System.ComponentModel.ISupportInitialize)(this.GridClientes)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BtnProcurarCliente;
        private System.Windows.Forms.TextBox TxtTelefone;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button BtnConfirmar;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridView GridClientes;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nome;
        private System.Windows.Forms.DataGridViewTextBoxColumn Telefone;
    }
}