namespace ExpressoPizza.Forms
{
    partial class FrmCliente
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
            this.TxtNome = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.BtnConfirmar = new System.Windows.Forms.Button();
            this.BtnFechar = new System.Windows.Forms.Button();
            this.TxtTelefone = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.GridClientes = new System.Windows.Forms.DataGridView();
            this.Nome = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Telefone = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TxtEndereco = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.GridClientes)).BeginInit();
            this.SuspendLayout();
            // 
            // TxtNome
            // 
            this.TxtNome.Location = new System.Drawing.Point(2, 25);
            this.TxtNome.Name = "TxtNome";
            this.TxtNome.Size = new System.Drawing.Size(255, 20);
            this.TxtNome.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(2, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 11;
            this.label2.Text = "Nome";
            // 
            // BtnConfirmar
            // 
            this.BtnConfirmar.Location = new System.Drawing.Point(2, 94);
            this.BtnConfirmar.Name = "BtnConfirmar";
            this.BtnConfirmar.Size = new System.Drawing.Size(75, 23);
            this.BtnConfirmar.TabIndex = 4;
            this.BtnConfirmar.Text = "Salvar";
            this.BtnConfirmar.UseVisualStyleBackColor = true;
            this.BtnConfirmar.Click += new System.EventHandler(this.BtnConfirmar_Click);
            // 
            // BtnFechar
            // 
            this.BtnFechar.Location = new System.Drawing.Point(83, 94);
            this.BtnFechar.Name = "BtnFechar";
            this.BtnFechar.Size = new System.Drawing.Size(75, 23);
            this.BtnFechar.TabIndex = 5;
            this.BtnFechar.Text = "Fechar";
            this.BtnFechar.UseVisualStyleBackColor = true;
            this.BtnFechar.Click += new System.EventHandler(this.button1_Click);
            // 
            // TxtTelefone
            // 
            this.TxtTelefone.Location = new System.Drawing.Point(265, 25);
            this.TxtTelefone.Name = "TxtTelefone";
            this.TxtTelefone.Size = new System.Drawing.Size(114, 20);
            this.TxtTelefone.TabIndex = 2;
            this.TxtTelefone.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtTelefone_KeyPress);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(265, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 13);
            this.label1.TabIndex = 15;
            this.label1.Text = "Telefone";
            // 
            // GridClientes
            // 
            this.GridClientes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GridClientes.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Nome,
            this.Telefone});
            this.GridClientes.Location = new System.Drawing.Point(2, 123);
            this.GridClientes.Name = "GridClientes";
            this.GridClientes.Size = new System.Drawing.Size(532, 222);
            this.GridClientes.TabIndex = 17;
            // 
            // Nome
            // 
            this.Nome.DataPropertyName = "Nome";
            this.Nome.FillWeight = 200F;
            this.Nome.HeaderText = "Nome";
            this.Nome.Name = "Nome";
            this.Nome.Width = 370;
            // 
            // Telefone
            // 
            this.Telefone.DataPropertyName = "Telefone";
            this.Telefone.HeaderText = "Telefone";
            this.Telefone.Name = "Telefone";
            // 
            // TxtEndereco
            // 
            this.TxtEndereco.Location = new System.Drawing.Point(2, 65);
            this.TxtEndereco.Name = "TxtEndereco";
            this.TxtEndereco.Size = new System.Drawing.Size(377, 20);
            this.TxtEndereco.TabIndex = 3;
            this.TxtEndereco.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtEndereco_KeyPress);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(2, 49);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 13);
            this.label3.TabIndex = 19;
            this.label3.Text = "Endereço";
            // 
            // FrmCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(538, 348);
            this.Controls.Add(this.TxtEndereco);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.GridClientes);
            this.Controls.Add(this.TxtTelefone);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.BtnFechar);
            this.Controls.Add(this.TxtNome);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.BtnConfirmar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmCliente";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cliente";
            ((System.ComponentModel.ISupportInitialize)(this.GridClientes)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox TxtNome;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button BtnConfirmar;
        private System.Windows.Forms.Button BtnFechar;
        private System.Windows.Forms.TextBox TxtTelefone;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView GridClientes;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nome;
        private System.Windows.Forms.DataGridViewTextBoxColumn Telefone;
        private System.Windows.Forms.TextBox TxtEndereco;
        private System.Windows.Forms.Label label3;
    }
}