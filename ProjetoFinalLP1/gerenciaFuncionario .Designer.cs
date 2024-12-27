namespace ProjetoFinalLP1
{
    partial class gerenciaFuncionario
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(gerenciaFuncionario));
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.arquivoStrip = new System.Windows.Forms.ToolStripDropDownButton();
            this.sairStrip = new System.Windows.Forms.ToolStripMenuItem();
            this.ferramentasStrip = new System.Windows.Forms.ToolStripDropDownButton();
            this.adicionarStrip = new System.Windows.Forms.ToolStripMenuItem();
            this.ajudaStrip = new System.Windows.Forms.ToolStripDropDownButton();
            this.buscaSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.buscaTexto = new System.Windows.Forms.ToolStripTextBox();
            this.buscaBotao = new System.Windows.Forms.ToolStripButton();
            this.buscaSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.buscaExibir = new System.Windows.Forms.DataGridView();
            this.nome = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cpf = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nivel = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.status = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.adicionaFuncionario = new System.Windows.Forms.Button();
            this.removeFuncionario = new System.Windows.Forms.Button();
            this.atualizaBtn = new System.Windows.Forms.Button();
            this.alteraFuncionario = new System.Windows.Forms.Button();
            this.dadoFuncionario = new System.Windows.Forms.Label();
            this.painelFilme = new System.Windows.Forms.Panel();
            this.painelFuncionario = new System.Windows.Forms.Panel();
            this.statusValor = new System.Windows.Forms.TextBox();
            this.statusTxt = new System.Windows.Forms.Label();
            this.nivelValor = new System.Windows.Forms.TextBox();
            this.nivelTxt = new System.Windows.Forms.Label();
            this.cpfValor = new System.Windows.Forms.TextBox();
            this.cpfTxt = new System.Windows.Forms.Label();
            this.nomeValor = new System.Windows.Forms.TextBox();
            this.nomeTxt = new System.Windows.Forms.Label();
            this.foto = new System.Windows.Forms.PictureBox();
            this.toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.buscaExibir)).BeginInit();
            this.painelFilme.SuspendLayout();
            this.painelFuncionario.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.foto)).BeginInit();
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
            this.adicionarStrip});
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
            this.nome,
            this.cpf,
            this.nivel,
            this.status});
            this.buscaExibir.Location = new System.Drawing.Point(12, 124);
            this.buscaExibir.MultiSelect = false;
            this.buscaExibir.Name = "buscaExibir";
            this.buscaExibir.ReadOnly = true;
            this.buscaExibir.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.buscaExibir.Size = new System.Drawing.Size(793, 502);
            this.buscaExibir.TabIndex = 1;
            this.buscaExibir.SelectionChanged += new System.EventHandler(this.buscaExibir_SelectionChanged);
            // 
            // nome
            // 
            this.nome.HeaderText = "Nome";
            this.nome.Name = "nome";
            this.nome.ReadOnly = true;
            // 
            // cpf
            // 
            this.cpf.HeaderText = "CPF";
            this.cpf.Name = "cpf";
            this.cpf.ReadOnly = true;
            // 
            // nivel
            // 
            this.nivel.HeaderText = "Nível";
            this.nivel.Name = "nivel";
            this.nivel.ReadOnly = true;
            // 
            // status
            // 
            this.status.HeaderText = "Status";
            this.status.Name = "status";
            this.status.ReadOnly = true;
            // 
            // adicionaFuncionario
            // 
            this.adicionaFuncionario.Location = new System.Drawing.Point(12, 54);
            this.adicionaFuncionario.Name = "adicionaFuncionario";
            this.adicionaFuncionario.Size = new System.Drawing.Size(75, 64);
            this.adicionaFuncionario.TabIndex = 2;
            this.adicionaFuncionario.Text = "Adicionar";
            this.adicionaFuncionario.UseVisualStyleBackColor = true;
            this.adicionaFuncionario.Click += new System.EventHandler(this.adicionaSala_Click);
            // 
            // removeFuncionario
            // 
            this.removeFuncionario.Location = new System.Drawing.Point(255, 54);
            this.removeFuncionario.Name = "removeFuncionario";
            this.removeFuncionario.Size = new System.Drawing.Size(75, 64);
            this.removeFuncionario.TabIndex = 3;
            this.removeFuncionario.Text = "Remover";
            this.removeFuncionario.UseVisualStyleBackColor = true;
            this.removeFuncionario.Click += new System.EventHandler(this.removeSala_Click);
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
            // alteraFuncionario
            // 
            this.alteraFuncionario.Location = new System.Drawing.Point(93, 54);
            this.alteraFuncionario.Name = "alteraFuncionario";
            this.alteraFuncionario.Size = new System.Drawing.Size(75, 64);
            this.alteraFuncionario.TabIndex = 5;
            this.alteraFuncionario.Text = "Alterar";
            this.alteraFuncionario.UseVisualStyleBackColor = true;
            this.alteraFuncionario.Click += new System.EventHandler(this.alteraSala_Click);
            // 
            // dadoFuncionario
            // 
            this.dadoFuncionario.AutoSize = true;
            this.dadoFuncionario.Location = new System.Drawing.Point(837, 108);
            this.dadoFuncionario.Name = "dadoFuncionario";
            this.dadoFuncionario.Size = new System.Drawing.Size(111, 13);
            this.dadoFuncionario.TabIndex = 9;
            this.dadoFuncionario.Text = "Dados do funcionário:";
            // 
            // painelFilme
            // 
            this.painelFilme.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.painelFilme.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.painelFilme.Controls.Add(this.painelFuncionario);
            this.painelFilme.Controls.Add(this.foto);
            this.painelFilme.Location = new System.Drawing.Point(840, 124);
            this.painelFilme.Name = "painelFilme";
            this.painelFilme.Size = new System.Drawing.Size(253, 502);
            this.painelFilme.TabIndex = 8;
            // 
            // painelFuncionario
            // 
            this.painelFuncionario.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.painelFuncionario.Controls.Add(this.statusValor);
            this.painelFuncionario.Controls.Add(this.statusTxt);
            this.painelFuncionario.Controls.Add(this.nivelValor);
            this.painelFuncionario.Controls.Add(this.nivelTxt);
            this.painelFuncionario.Controls.Add(this.cpfValor);
            this.painelFuncionario.Controls.Add(this.cpfTxt);
            this.painelFuncionario.Controls.Add(this.nomeValor);
            this.painelFuncionario.Controls.Add(this.nomeTxt);
            this.painelFuncionario.Location = new System.Drawing.Point(20, 265);
            this.painelFuncionario.Name = "painelFuncionario";
            this.painelFuncionario.Size = new System.Drawing.Size(200, 204);
            this.painelFuncionario.TabIndex = 1;
            // 
            // statusValor
            // 
            this.statusValor.Location = new System.Drawing.Point(20, 154);
            this.statusValor.Name = "statusValor";
            this.statusValor.ReadOnly = true;
            this.statusValor.Size = new System.Drawing.Size(160, 20);
            this.statusValor.TabIndex = 10;
            // 
            // statusTxt
            // 
            this.statusTxt.AutoSize = true;
            this.statusTxt.Location = new System.Drawing.Point(20, 138);
            this.statusTxt.Name = "statusTxt";
            this.statusTxt.Size = new System.Drawing.Size(40, 13);
            this.statusTxt.TabIndex = 9;
            this.statusTxt.Text = "Status:";
            // 
            // nivelValor
            // 
            this.nivelValor.Location = new System.Drawing.Point(20, 115);
            this.nivelValor.Name = "nivelValor";
            this.nivelValor.ReadOnly = true;
            this.nivelValor.Size = new System.Drawing.Size(160, 20);
            this.nivelValor.TabIndex = 8;
            // 
            // nivelTxt
            // 
            this.nivelTxt.AutoSize = true;
            this.nivelTxt.Location = new System.Drawing.Point(20, 99);
            this.nivelTxt.Name = "nivelTxt";
            this.nivelTxt.Size = new System.Drawing.Size(36, 13);
            this.nivelTxt.TabIndex = 7;
            this.nivelTxt.Text = "Nível:";
            // 
            // cpfValor
            // 
            this.cpfValor.Location = new System.Drawing.Point(20, 76);
            this.cpfValor.Name = "cpfValor";
            this.cpfValor.ReadOnly = true;
            this.cpfValor.Size = new System.Drawing.Size(160, 20);
            this.cpfValor.TabIndex = 6;
            // 
            // cpfTxt
            // 
            this.cpfTxt.AutoSize = true;
            this.cpfTxt.Location = new System.Drawing.Point(20, 60);
            this.cpfTxt.Name = "cpfTxt";
            this.cpfTxt.Size = new System.Drawing.Size(30, 13);
            this.cpfTxt.TabIndex = 5;
            this.cpfTxt.Text = "CPF:";
            // 
            // nomeValor
            // 
            this.nomeValor.Location = new System.Drawing.Point(20, 37);
            this.nomeValor.Name = "nomeValor";
            this.nomeValor.ReadOnly = true;
            this.nomeValor.Size = new System.Drawing.Size(160, 20);
            this.nomeValor.TabIndex = 4;
            // 
            // nomeTxt
            // 
            this.nomeTxt.AutoSize = true;
            this.nomeTxt.Location = new System.Drawing.Point(20, 21);
            this.nomeTxt.Name = "nomeTxt";
            this.nomeTxt.Size = new System.Drawing.Size(38, 13);
            this.nomeTxt.TabIndex = 1;
            this.nomeTxt.Text = "Nome:";
            // 
            // foto
            // 
            this.foto.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.foto.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.foto.Image = global::ProjetoFinalLP1.Properties.Resources.no_photo_or_blank_image_icon_loading_images_or_missing_image_mark_image_not_available_or_image_coming_soon_sign_simple_nature_silhouette_in_frame_isolated_illustration_vector;
            this.foto.Location = new System.Drawing.Point(40, 21);
            this.foto.Name = "foto";
            this.foto.Size = new System.Drawing.Size(160, 160);
            this.foto.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.foto.TabIndex = 0;
            this.foto.TabStop = false;
            // 
            // gerenciaFuncionario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1105, 638);
            this.Controls.Add(this.dadoFuncionario);
            this.Controls.Add(this.painelFilme);
            this.Controls.Add(this.alteraFuncionario);
            this.Controls.Add(this.atualizaBtn);
            this.Controls.Add(this.removeFuncionario);
            this.Controls.Add(this.adicionaFuncionario);
            this.Controls.Add(this.buscaExibir);
            this.Controls.Add(this.toolStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "gerenciaFuncionario";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Gerenciador de Funcionários";
            this.Load += new System.EventHandler(this.gerenciaSala_Load);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.buscaExibir)).EndInit();
            this.painelFilme.ResumeLayout(false);
            this.painelFuncionario.ResumeLayout(false);
            this.painelFuncionario.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.foto)).EndInit();
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
        private System.Windows.Forms.Button adicionaFuncionario;
        private System.Windows.Forms.Button removeFuncionario;
        private System.Windows.Forms.Button atualizaBtn;
        private System.Windows.Forms.Button alteraFuncionario;
        private System.Windows.Forms.ToolStripMenuItem sairStrip;
        private System.Windows.Forms.ToolStripMenuItem adicionarStrip;
        private System.Windows.Forms.DataGridViewTextBoxColumn nome;
        private System.Windows.Forms.DataGridViewTextBoxColumn cpf;
        private System.Windows.Forms.DataGridViewTextBoxColumn nivel;
        private System.Windows.Forms.DataGridViewTextBoxColumn status;
        private System.Windows.Forms.Label dadoFuncionario;
        private System.Windows.Forms.Panel painelFilme;
        private System.Windows.Forms.Panel painelFuncionario;
        private System.Windows.Forms.TextBox nomeValor;
        private System.Windows.Forms.Label nomeTxt;
        private System.Windows.Forms.PictureBox foto;
        private System.Windows.Forms.TextBox nivelValor;
        private System.Windows.Forms.Label nivelTxt;
        private System.Windows.Forms.TextBox cpfValor;
        private System.Windows.Forms.Label cpfTxt;
        private System.Windows.Forms.Label statusTxt;
        private System.Windows.Forms.TextBox statusValor;
    }
}