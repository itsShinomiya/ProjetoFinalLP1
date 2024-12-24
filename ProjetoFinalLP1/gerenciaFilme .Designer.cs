namespace ProjetoFinalLP1
{
    partial class gerenciaFilme
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(gerenciaFilme));
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.arquivoStrip = new System.Windows.Forms.ToolStripDropDownButton();
            this.sairStrip = new System.Windows.Forms.ToolStripMenuItem();
            this.ferramentasStrip = new System.Windows.Forms.ToolStripDropDownButton();
            this.adicionarStrip = new System.Windows.Forms.ToolStripMenuItem();
            this.alterarStrip = new System.Windows.Forms.ToolStripMenuItem();
            this.ajudaStrip = new System.Windows.Forms.ToolStripDropDownButton();
            this.buscaSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.buscaTexto = new System.Windows.Forms.ToolStripTextBox();
            this.buscaBotao = new System.Windows.Forms.ToolStripButton();
            this.buscaSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.buscaExibir = new System.Windows.Forms.DataGridView();
            this.numero = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tipo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.assentos = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.adicionaSala = new System.Windows.Forms.Button();
            this.removeSala = new System.Windows.Forms.Button();
            this.atualizaBtn = new System.Windows.Forms.Button();
            this.alteraSala = new System.Windows.Forms.Button();
            this.toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.buscaExibir)).BeginInit();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.arquivoStrip,
            this.ferramentasStrip,
            this.ajudaStrip,
            this.buscaSeparator1,
            this.buscaTexto,
            this.buscaBotao,
            this.buscaSeparator2});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(1105, 25);
            this.toolStrip1.TabIndex = 0;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // arquivoStrip
            // 
            this.arquivoStrip.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.arquivoStrip.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.sairStrip});
            this.arquivoStrip.Image = ((System.Drawing.Image)(resources.GetObject("arquivoStrip.Image")));
            this.arquivoStrip.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.arquivoStrip.Name = "arquivoStrip";
            this.arquivoStrip.Size = new System.Drawing.Size(62, 22);
            this.arquivoStrip.Text = "&Arquivo";
            // 
            // sairStrip
            // 
            this.sairStrip.Name = "sairStrip";
            this.sairStrip.Size = new System.Drawing.Size(93, 22);
            this.sairStrip.Text = "&Sair";
            this.sairStrip.Click += new System.EventHandler(this.sairToolStripMenuItem_Click);
            // 
            // ferramentasStrip
            // 
            this.ferramentasStrip.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.ferramentasStrip.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.adicionarStrip,
            this.alterarStrip});
            this.ferramentasStrip.Image = ((System.Drawing.Image)(resources.GetObject("ferramentasStrip.Image")));
            this.ferramentasStrip.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.ferramentasStrip.Name = "ferramentasStrip";
            this.ferramentasStrip.Size = new System.Drawing.Size(85, 22);
            this.ferramentasStrip.Text = "&Ferramentas";
            // 
            // adicionarStrip
            // 
            this.adicionarStrip.Name = "adicionarStrip";
            this.adicionarStrip.Size = new System.Drawing.Size(125, 22);
            this.adicionarStrip.Text = "&Adicionar";
            this.adicionarStrip.Click += new System.EventHandler(this.adicionarStrip_Click);
            // 
            // alterarStrip
            // 
            this.alterarStrip.Name = "alterarStrip";
            this.alterarStrip.Size = new System.Drawing.Size(125, 22);
            this.alterarStrip.Text = "&Alterar";
            this.alterarStrip.Click += new System.EventHandler(this.alterarStrip_Click);
            // 
            // ajudaStrip
            // 
            this.ajudaStrip.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.ajudaStrip.Image = ((System.Drawing.Image)(resources.GetObject("ajudaStrip.Image")));
            this.ajudaStrip.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.ajudaStrip.Name = "ajudaStrip";
            this.ajudaStrip.Size = new System.Drawing.Size(51, 22);
            this.ajudaStrip.Text = "&Ajuda";
            // 
            // buscaSeparator1
            // 
            this.buscaSeparator1.Name = "buscaSeparator1";
            this.buscaSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // buscaTexto
            // 
            this.buscaTexto.AutoSize = false;
            this.buscaTexto.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.buscaTexto.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.buscaTexto.Name = "buscaTexto";
            this.buscaTexto.Size = new System.Drawing.Size(100, 23);
            // 
            // buscaBotao
            // 
            this.buscaBotao.Image = ((System.Drawing.Image)(resources.GetObject("buscaBotao.Image")));
            this.buscaBotao.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.buscaBotao.Name = "buscaBotao";
            this.buscaBotao.Size = new System.Drawing.Size(62, 22);
            this.buscaBotao.Text = "&Buscar";
            // 
            // buscaSeparator2
            // 
            this.buscaSeparator2.Name = "buscaSeparator2";
            this.buscaSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // buscaExibir
            // 
            this.buscaExibir.AllowUserToAddRows = false;
            this.buscaExibir.AllowUserToDeleteRows = false;
            this.buscaExibir.AllowUserToResizeColumns = false;
            this.buscaExibir.AllowUserToResizeRows = false;
            this.buscaExibir.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.buscaExibir.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.buscaExibir.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.buscaExibir.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.numero,
            this.tipo,
            this.assentos});
            this.buscaExibir.Location = new System.Drawing.Point(12, 124);
            this.buscaExibir.MultiSelect = false;
            this.buscaExibir.Name = "buscaExibir";
            this.buscaExibir.ReadOnly = true;
            this.buscaExibir.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.buscaExibir.Size = new System.Drawing.Size(793, 502);
            this.buscaExibir.TabIndex = 1;
            // 
            // numero
            // 
            this.numero.HeaderText = "Número da Sala";
            this.numero.Name = "numero";
            this.numero.ReadOnly = true;
            // 
            // tipo
            // 
            this.tipo.HeaderText = "Tipo";
            this.tipo.Name = "tipo";
            this.tipo.ReadOnly = true;
            // 
            // assentos
            // 
            this.assentos.HeaderText = "Número de Assentos";
            this.assentos.Name = "assentos";
            this.assentos.ReadOnly = true;
            // 
            // adicionaSala
            // 
            this.adicionaSala.Location = new System.Drawing.Point(12, 54);
            this.adicionaSala.Name = "adicionaSala";
            this.adicionaSala.Size = new System.Drawing.Size(75, 64);
            this.adicionaSala.TabIndex = 2;
            this.adicionaSala.Text = "Adicionar";
            this.adicionaSala.UseVisualStyleBackColor = true;
            this.adicionaSala.Click += new System.EventHandler(this.adicionaSala_Click);
            // 
            // removeSala
            // 
            this.removeSala.Location = new System.Drawing.Point(255, 54);
            this.removeSala.Name = "removeSala";
            this.removeSala.Size = new System.Drawing.Size(75, 64);
            this.removeSala.TabIndex = 3;
            this.removeSala.Text = "Remover";
            this.removeSala.UseVisualStyleBackColor = true;
            this.removeSala.Click += new System.EventHandler(this.removeSala_Click);
            // 
            // atualizaBtn
            // 
            this.atualizaBtn.Location = new System.Drawing.Point(174, 54);
            this.atualizaBtn.Name = "atualizaBtn";
            this.atualizaBtn.Size = new System.Drawing.Size(75, 64);
            this.atualizaBtn.TabIndex = 4;
            this.atualizaBtn.Text = "Atualizar";
            this.atualizaBtn.UseVisualStyleBackColor = true;
            this.atualizaBtn.Click += new System.EventHandler(this.atualizaBtn_Click);
            // 
            // alteraSala
            // 
            this.alteraSala.Location = new System.Drawing.Point(93, 54);
            this.alteraSala.Name = "alteraSala";
            this.alteraSala.Size = new System.Drawing.Size(75, 64);
            this.alteraSala.TabIndex = 5;
            this.alteraSala.Text = "Alterar";
            this.alteraSala.UseVisualStyleBackColor = true;
            this.alteraSala.Click += new System.EventHandler(this.alteraSala_Click);
            // 
            // gerenciaFilme
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1105, 638);
            this.Controls.Add(this.alteraSala);
            this.Controls.Add(this.atualizaBtn);
            this.Controls.Add(this.removeSala);
            this.Controls.Add(this.adicionaSala);
            this.Controls.Add(this.buscaExibir);
            this.Controls.Add(this.toolStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "gerenciaFilme";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Gerenciador de Filmes";
            this.Load += new System.EventHandler(this.gerenciaSala_Load);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.buscaExibir)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripSeparator buscaSeparator1;
        private System.Windows.Forms.ToolStripTextBox buscaTexto;
        private System.Windows.Forms.ToolStripButton buscaBotao;
        private System.Windows.Forms.ToolStripSeparator buscaSeparator2;
        private System.Windows.Forms.ToolStripDropDownButton ajudaStrip;
        private System.Windows.Forms.ToolStripDropDownButton arquivoStrip;
        private System.Windows.Forms.ToolStripDropDownButton ferramentasStrip;
        private System.Windows.Forms.DataGridView buscaExibir;
        private System.Windows.Forms.Button adicionaSala;
        private System.Windows.Forms.Button removeSala;
        private System.Windows.Forms.Button atualizaBtn;
        private System.Windows.Forms.Button alteraSala;
        private System.Windows.Forms.DataGridViewTextBoxColumn numero;
        private System.Windows.Forms.DataGridViewTextBoxColumn tipo;
        private System.Windows.Forms.DataGridViewTextBoxColumn assentos;
        private System.Windows.Forms.ToolStripMenuItem sairStrip;
        private System.Windows.Forms.ToolStripMenuItem adicionarStrip;
        private System.Windows.Forms.ToolStripMenuItem alterarStrip;
    }
}