namespace ProjetoFinalLP1
{
    partial class gerenciaSessao
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(gerenciaSessao));
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.arquivoStrip = new System.Windows.Forms.ToolStripDropDownButton();
            this.sairStrip = new System.Windows.Forms.ToolStripMenuItem();
            this.ferramentasStrip = new System.Windows.Forms.ToolStripDropDownButton();
            this.adicionarStrip = new System.Windows.Forms.ToolStripMenuItem();
            this.alterarStrip = new System.Windows.Forms.ToolStripMenuItem();
            this.ajudaStrip = new System.Windows.Forms.ToolStripDropDownButton();
            this.buscaSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.buscaExibir = new System.Windows.Forms.DataGridView();
            this.codigo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.filme = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sala = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tipoSala = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.horario = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ingressos = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.preço = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.adicionaSala = new System.Windows.Forms.Button();
            this.removeSala = new System.Windows.Forms.Button();
            this.atualizaBtn = new System.Windows.Forms.Button();
            this.alteraSala = new System.Windows.Forms.Button();
            this.dadoFilme = new System.Windows.Forms.Label();
            this.painelFilme = new System.Windows.Forms.Panel();
            this.painel = new System.Windows.Forms.Panel();
            this.codeValor = new System.Windows.Forms.TextBox();
            this.codeTxt = new System.Windows.Forms.Label();
            this.horarioValor = new System.Windows.Forms.TextBox();
            this.horarioTxt = new System.Windows.Forms.Label();
            this.diaValor = new System.Windows.Forms.TextBox();
            this.diaTxt = new System.Windows.Forms.Label();
            this.valorValor = new System.Windows.Forms.TextBox();
            this.valortxt = new System.Windows.Forms.Label();
            this.ingressosValor = new System.Windows.Forms.TextBox();
            this.ingressosTxt = new System.Windows.Forms.Label();
            this.tipoValor = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.nomeValor = new System.Windows.Forms.TextBox();
            this.salaValor = new System.Windows.Forms.TextBox();
            this.nomeTxt = new System.Windows.Forms.Label();
            this.salaTxt = new System.Windows.Forms.Label();
            this.banner = new System.Windows.Forms.PictureBox();
            this.toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.buscaExibir)).BeginInit();
            this.painelFilme.SuspendLayout();
            this.painel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.banner)).BeginInit();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.arquivoStrip,
            this.ferramentasStrip,
            this.ajudaStrip,
            this.buscaSeparator1});
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
            this.codigo,
            this.filme,
            this.sala,
            this.tipoSala,
            this.dia,
            this.horario,
            this.ingressos,
            this.preço});
            this.buscaExibir.Location = new System.Drawing.Point(12, 124);
            this.buscaExibir.MultiSelect = false;
            this.buscaExibir.Name = "buscaExibir";
            this.buscaExibir.ReadOnly = true;
            this.buscaExibir.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.buscaExibir.Size = new System.Drawing.Size(793, 502);
            this.buscaExibir.TabIndex = 1;
            this.buscaExibir.SelectionChanged += new System.EventHandler(this.buscaExibir_SelectionChanged);
            // 
            // codigo
            // 
            this.codigo.HeaderText = "Código da Sessão";
            this.codigo.Name = "codigo";
            this.codigo.ReadOnly = true;
            // 
            // filme
            // 
            this.filme.HeaderText = "Nome do Filme";
            this.filme.Name = "filme";
            this.filme.ReadOnly = true;
            // 
            // sala
            // 
            this.sala.HeaderText = "Sala";
            this.sala.Name = "sala";
            this.sala.ReadOnly = true;
            // 
            // tipoSala
            // 
            this.tipoSala.HeaderText = "Tipo da Sala";
            this.tipoSala.Name = "tipoSala";
            this.tipoSala.ReadOnly = true;
            // 
            // dia
            // 
            this.dia.HeaderText = "Dia";
            this.dia.Name = "dia";
            this.dia.ReadOnly = true;
            // 
            // horario
            // 
            this.horario.HeaderText = "Horário";
            this.horario.Name = "horario";
            this.horario.ReadOnly = true;
            // 
            // ingressos
            // 
            this.ingressos.HeaderText = "Ingressos Disponíveis";
            this.ingressos.Name = "ingressos";
            this.ingressos.ReadOnly = true;
            // 
            // preço
            // 
            this.preço.HeaderText = "Valor";
            this.preço.Name = "preço";
            this.preço.ReadOnly = true;
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
            // dadoFilme
            // 
            this.dadoFilme.AutoSize = true;
            this.dadoFilme.Location = new System.Drawing.Point(840, 105);
            this.dadoFilme.Name = "dadoFilme";
            this.dadoFilme.Size = new System.Drawing.Size(92, 13);
            this.dadoFilme.TabIndex = 9;
            this.dadoFilme.Text = "Dados da sessão:";
            // 
            // painelFilme
            // 
            this.painelFilme.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.painelFilme.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.painelFilme.Controls.Add(this.painel);
            this.painelFilme.Controls.Add(this.banner);
            this.painelFilme.Location = new System.Drawing.Point(840, 124);
            this.painelFilme.Name = "painelFilme";
            this.painelFilme.Size = new System.Drawing.Size(253, 502);
            this.painelFilme.TabIndex = 8;
            // 
            // painel
            // 
            this.painel.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.painel.Controls.Add(this.codeValor);
            this.painel.Controls.Add(this.codeTxt);
            this.painel.Controls.Add(this.horarioValor);
            this.painel.Controls.Add(this.horarioTxt);
            this.painel.Controls.Add(this.diaValor);
            this.painel.Controls.Add(this.diaTxt);
            this.painel.Controls.Add(this.valorValor);
            this.painel.Controls.Add(this.valortxt);
            this.painel.Controls.Add(this.ingressosValor);
            this.painel.Controls.Add(this.ingressosTxt);
            this.painel.Controls.Add(this.tipoValor);
            this.painel.Controls.Add(this.label1);
            this.painel.Controls.Add(this.nomeValor);
            this.painel.Controls.Add(this.salaValor);
            this.painel.Controls.Add(this.nomeTxt);
            this.painel.Controls.Add(this.salaTxt);
            this.painel.Location = new System.Drawing.Point(25, 239);
            this.painel.Name = "painel";
            this.painel.Size = new System.Drawing.Size(200, 229);
            this.painel.TabIndex = 1;
            // 
            // codeValor
            // 
            this.codeValor.Location = new System.Drawing.Point(19, 29);
            this.codeValor.Name = "codeValor";
            this.codeValor.ReadOnly = true;
            this.codeValor.Size = new System.Drawing.Size(52, 20);
            this.codeValor.TabIndex = 17;
            // 
            // codeTxt
            // 
            this.codeTxt.AutoSize = true;
            this.codeTxt.Location = new System.Drawing.Point(16, 13);
            this.codeTxt.Name = "codeTxt";
            this.codeTxt.Size = new System.Drawing.Size(43, 13);
            this.codeTxt.TabIndex = 16;
            this.codeTxt.Text = "Código:";
            // 
            // horarioValor
            // 
            this.horarioValor.Location = new System.Drawing.Point(102, 189);
            this.horarioValor.Name = "horarioValor";
            this.horarioValor.ReadOnly = true;
            this.horarioValor.Size = new System.Drawing.Size(77, 20);
            this.horarioValor.TabIndex = 15;
            // 
            // horarioTxt
            // 
            this.horarioTxt.AutoSize = true;
            this.horarioTxt.Location = new System.Drawing.Point(99, 173);
            this.horarioTxt.Name = "horarioTxt";
            this.horarioTxt.Size = new System.Drawing.Size(44, 13);
            this.horarioTxt.TabIndex = 14;
            this.horarioTxt.Text = "Horário:";
            // 
            // diaValor
            // 
            this.diaValor.Location = new System.Drawing.Point(19, 189);
            this.diaValor.Name = "diaValor";
            this.diaValor.ReadOnly = true;
            this.diaValor.Size = new System.Drawing.Size(77, 20);
            this.diaValor.TabIndex = 13;
            // 
            // diaTxt
            // 
            this.diaTxt.AutoSize = true;
            this.diaTxt.Location = new System.Drawing.Point(16, 173);
            this.diaTxt.Name = "diaTxt";
            this.diaTxt.Size = new System.Drawing.Size(26, 13);
            this.diaTxt.TabIndex = 12;
            this.diaTxt.Text = "Dia:";
            // 
            // valorValor
            // 
            this.valorValor.Location = new System.Drawing.Point(102, 150);
            this.valorValor.Name = "valorValor";
            this.valorValor.ReadOnly = true;
            this.valorValor.Size = new System.Drawing.Size(77, 20);
            this.valorValor.TabIndex = 11;
            // 
            // valortxt
            // 
            this.valortxt.AutoSize = true;
            this.valortxt.Location = new System.Drawing.Point(99, 134);
            this.valortxt.Name = "valortxt";
            this.valortxt.Size = new System.Drawing.Size(34, 13);
            this.valortxt.TabIndex = 10;
            this.valortxt.Text = "Valor:";
            // 
            // ingressosValor
            // 
            this.ingressosValor.Location = new System.Drawing.Point(19, 150);
            this.ingressosValor.Name = "ingressosValor";
            this.ingressosValor.ReadOnly = true;
            this.ingressosValor.Size = new System.Drawing.Size(77, 20);
            this.ingressosValor.TabIndex = 9;
            // 
            // ingressosTxt
            // 
            this.ingressosTxt.AutoSize = true;
            this.ingressosTxt.Location = new System.Drawing.Point(16, 134);
            this.ingressosTxt.Name = "ingressosTxt";
            this.ingressosTxt.Size = new System.Drawing.Size(55, 13);
            this.ingressosTxt.TabIndex = 8;
            this.ingressosTxt.Text = "Ingressos:";
            // 
            // tipoValor
            // 
            this.tipoValor.Location = new System.Drawing.Point(102, 68);
            this.tipoValor.Name = "tipoValor";
            this.tipoValor.ReadOnly = true;
            this.tipoValor.Size = new System.Drawing.Size(77, 20);
            this.tipoValor.TabIndex = 7;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(99, 52);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(31, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Tipo:";
            // 
            // nomeValor
            // 
            this.nomeValor.Location = new System.Drawing.Point(19, 111);
            this.nomeValor.Name = "nomeValor";
            this.nomeValor.ReadOnly = true;
            this.nomeValor.Size = new System.Drawing.Size(160, 20);
            this.nomeValor.TabIndex = 4;
            // 
            // salaValor
            // 
            this.salaValor.Location = new System.Drawing.Point(19, 68);
            this.salaValor.Name = "salaValor";
            this.salaValor.ReadOnly = true;
            this.salaValor.Size = new System.Drawing.Size(77, 20);
            this.salaValor.TabIndex = 3;
            // 
            // nomeTxt
            // 
            this.nomeTxt.AutoSize = true;
            this.nomeTxt.Location = new System.Drawing.Point(16, 95);
            this.nomeTxt.Name = "nomeTxt";
            this.nomeTxt.Size = new System.Drawing.Size(80, 13);
            this.nomeTxt.TabIndex = 1;
            this.nomeTxt.Text = "Nome do Filme:";
            // 
            // salaTxt
            // 
            this.salaTxt.AutoSize = true;
            this.salaTxt.Location = new System.Drawing.Point(16, 52);
            this.salaTxt.Name = "salaTxt";
            this.salaTxt.Size = new System.Drawing.Size(31, 13);
            this.salaTxt.TabIndex = 0;
            this.salaTxt.Text = "Sala:";
            // 
            // banner
            // 
            this.banner.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.banner.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.banner.Image = global::ProjetoFinalLP1.Properties.Resources.no_photo_or_blank_image_icon_loading_images_or_missing_image_mark_image_not_available_or_image_coming_soon_sign_simple_nature_silhouette_in_frame_isolated_illustration_vector;
            this.banner.Location = new System.Drawing.Point(44, 10);
            this.banner.Name = "banner";
            this.banner.Size = new System.Drawing.Size(160, 201);
            this.banner.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.banner.TabIndex = 0;
            this.banner.TabStop = false;
            // 
            // gerenciaSessao
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1105, 638);
            this.Controls.Add(this.dadoFilme);
            this.Controls.Add(this.painelFilme);
            this.Controls.Add(this.alteraSala);
            this.Controls.Add(this.atualizaBtn);
            this.Controls.Add(this.removeSala);
            this.Controls.Add(this.adicionaSala);
            this.Controls.Add(this.buscaExibir);
            this.Controls.Add(this.toolStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "gerenciaSessao";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Gerenciador de Sessões";
            this.Load += new System.EventHandler(this.gerenciaSala_Load);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.buscaExibir)).EndInit();
            this.painelFilme.ResumeLayout(false);
            this.painel.ResumeLayout(false);
            this.painel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.banner)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripSeparator buscaSeparator1;
        private System.Windows.Forms.ToolStripDropDownButton ajudaStrip;
        private System.Windows.Forms.ToolStripDropDownButton arquivoStrip;
        private System.Windows.Forms.ToolStripDropDownButton ferramentasStrip;
        private System.Windows.Forms.DataGridView buscaExibir;
        private System.Windows.Forms.Button adicionaSala;
        private System.Windows.Forms.Button removeSala;
        private System.Windows.Forms.Button atualizaBtn;
        private System.Windows.Forms.Button alteraSala;
        private System.Windows.Forms.ToolStripMenuItem sairStrip;
        private System.Windows.Forms.ToolStripMenuItem adicionarStrip;
        private System.Windows.Forms.ToolStripMenuItem alterarStrip;
        private System.Windows.Forms.DataGridViewTextBoxColumn codigo;
        private System.Windows.Forms.DataGridViewTextBoxColumn filme;
        private System.Windows.Forms.DataGridViewTextBoxColumn sala;
        private System.Windows.Forms.DataGridViewTextBoxColumn tipoSala;
        private System.Windows.Forms.DataGridViewTextBoxColumn dia;
        private System.Windows.Forms.DataGridViewTextBoxColumn horario;
        private System.Windows.Forms.DataGridViewTextBoxColumn ingressos;
        private System.Windows.Forms.DataGridViewTextBoxColumn preço;
        private System.Windows.Forms.Label dadoFilme;
        private System.Windows.Forms.Panel painelFilme;
        private System.Windows.Forms.Panel painel;
        private System.Windows.Forms.TextBox nomeValor;
        private System.Windows.Forms.TextBox salaValor;
        private System.Windows.Forms.Label nomeTxt;
        private System.Windows.Forms.Label salaTxt;
        private System.Windows.Forms.PictureBox banner;
        private System.Windows.Forms.TextBox tipoValor;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox codeValor;
        private System.Windows.Forms.Label codeTxt;
        private System.Windows.Forms.TextBox horarioValor;
        private System.Windows.Forms.Label horarioTxt;
        private System.Windows.Forms.TextBox diaValor;
        private System.Windows.Forms.Label diaTxt;
        private System.Windows.Forms.TextBox valorValor;
        private System.Windows.Forms.Label valortxt;
        private System.Windows.Forms.TextBox ingressosValor;
        private System.Windows.Forms.Label ingressosTxt;
    }
}