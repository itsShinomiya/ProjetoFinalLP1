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
            this.dadoFilme = new System.Windows.Forms.Label();
            this.painelFilme = new System.Windows.Forms.Panel();
            this.painel = new System.Windows.Forms.Panel();
            this.codeValor = new System.Windows.Forms.TextBox();
            this.horarioValor = new System.Windows.Forms.TextBox();
            this.diaValor = new System.Windows.Forms.TextBox();
            this.valorValor = new System.Windows.Forms.TextBox();
            this.ingressosValor = new System.Windows.Forms.TextBox();
            this.tipoValor = new System.Windows.Forms.TextBox();
            this.nomeValor = new System.Windows.Forms.TextBox();
            this.salaValor = new System.Windows.Forms.TextBox();
            this.codeTxt = new System.Windows.Forms.Label();
            this.salaTxt = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.nomeTxt = new System.Windows.Forms.Label();
            this.ingressosTxt = new System.Windows.Forms.Label();
            this.valortxt = new System.Windows.Forms.Label();
            this.diaTxt = new System.Windows.Forms.Label();
            this.horarioTxt = new System.Windows.Forms.Label();
            this.banner = new System.Windows.Forms.PictureBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.alteraSala = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.adicionaSala = new System.Windows.Forms.Button();
            this.removeSala = new System.Windows.Forms.Button();
            this.atualizaBtn = new System.Windows.Forms.Button();
            this.toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.buscaExibir)).BeginInit();
            this.painelFilme.SuspendLayout();
            this.painel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.banner)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.arquivoStrip,
            this.ferramentasStrip,
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
            this.buscaExibir.Location = new System.Drawing.Point(265, 30);
            this.buscaExibir.MultiSelect = false;
            this.buscaExibir.Name = "buscaExibir";
            this.buscaExibir.ReadOnly = true;
            this.buscaExibir.RowHeadersWidth = 51;
            this.buscaExibir.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.buscaExibir.Size = new System.Drawing.Size(562, 599);
            this.buscaExibir.TabIndex = 1;
            this.buscaExibir.SelectionChanged += new System.EventHandler(this.buscaExibir_SelectionChanged);
            // 
            // codigo
            // 
            this.codigo.HeaderText = "Código da Sessão";
            this.codigo.MinimumWidth = 6;
            this.codigo.Name = "codigo";
            this.codigo.ReadOnly = true;
            // 
            // filme
            // 
            this.filme.HeaderText = "Nome do Filme";
            this.filme.MinimumWidth = 6;
            this.filme.Name = "filme";
            this.filme.ReadOnly = true;
            // 
            // sala
            // 
            this.sala.HeaderText = "Sala";
            this.sala.MinimumWidth = 6;
            this.sala.Name = "sala";
            this.sala.ReadOnly = true;
            // 
            // tipoSala
            // 
            this.tipoSala.HeaderText = "Tipo da Sala";
            this.tipoSala.MinimumWidth = 6;
            this.tipoSala.Name = "tipoSala";
            this.tipoSala.ReadOnly = true;
            // 
            // dia
            // 
            this.dia.HeaderText = "Dia";
            this.dia.MinimumWidth = 6;
            this.dia.Name = "dia";
            this.dia.ReadOnly = true;
            // 
            // horario
            // 
            this.horario.HeaderText = "Horário";
            this.horario.MinimumWidth = 6;
            this.horario.Name = "horario";
            this.horario.ReadOnly = true;
            // 
            // ingressos
            // 
            this.ingressos.HeaderText = "Ingressos Disponíveis";
            this.ingressos.MinimumWidth = 6;
            this.ingressos.Name = "ingressos";
            this.ingressos.ReadOnly = true;
            // 
            // preço
            // 
            this.preço.HeaderText = "Valor";
            this.preço.MinimumWidth = 6;
            this.preço.Name = "preço";
            this.preço.ReadOnly = true;
            // 
            // dadoFilme
            // 
            this.dadoFilme.AutoSize = true;
            this.dadoFilme.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dadoFilme.Location = new System.Drawing.Point(838, 32);
            this.dadoFilme.Name = "dadoFilme";
            this.dadoFilme.Size = new System.Drawing.Size(96, 13);
            this.dadoFilme.TabIndex = 9;
            this.dadoFilme.Text = "Dados da sessão:";
            // 
            // painelFilme
            // 
            this.painelFilme.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.painelFilme.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.painelFilme.Controls.Add(this.painel);
            this.painelFilme.Controls.Add(this.banner);
            this.painelFilme.Location = new System.Drawing.Point(842, 50);
            this.painelFilme.Name = "painelFilme";
            this.painelFilme.Size = new System.Drawing.Size(253, 578);
            this.painelFilme.TabIndex = 8;
            // 
            // painel
            // 
            this.painel.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.painel.Controls.Add(this.codeValor);
            this.painel.Controls.Add(this.horarioValor);
            this.painel.Controls.Add(this.diaValor);
            this.painel.Controls.Add(this.valorValor);
            this.painel.Controls.Add(this.ingressosValor);
            this.painel.Controls.Add(this.tipoValor);
            this.painel.Controls.Add(this.nomeValor);
            this.painel.Controls.Add(this.salaValor);
            this.painel.Controls.Add(this.codeTxt);
            this.painel.Controls.Add(this.salaTxt);
            this.painel.Controls.Add(this.label1);
            this.painel.Controls.Add(this.nomeTxt);
            this.painel.Controls.Add(this.ingressosTxt);
            this.painel.Controls.Add(this.valortxt);
            this.painel.Controls.Add(this.diaTxt);
            this.painel.Controls.Add(this.horarioTxt);
            this.painel.Location = new System.Drawing.Point(27, 332);
            this.painel.Name = "painel";
            this.painel.Size = new System.Drawing.Size(200, 229);
            this.painel.TabIndex = 1;
            // 
            // codeValor
            // 
            this.codeValor.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.codeValor.Location = new System.Drawing.Point(19, 29);
            this.codeValor.Name = "codeValor";
            this.codeValor.ReadOnly = true;
            this.codeValor.Size = new System.Drawing.Size(52, 21);
            this.codeValor.TabIndex = 17;
            // 
            // horarioValor
            // 
            this.horarioValor.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.horarioValor.Location = new System.Drawing.Point(102, 189);
            this.horarioValor.Name = "horarioValor";
            this.horarioValor.ReadOnly = true;
            this.horarioValor.Size = new System.Drawing.Size(77, 21);
            this.horarioValor.TabIndex = 15;
            // 
            // diaValor
            // 
            this.diaValor.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.diaValor.Location = new System.Drawing.Point(19, 189);
            this.diaValor.Name = "diaValor";
            this.diaValor.ReadOnly = true;
            this.diaValor.Size = new System.Drawing.Size(77, 21);
            this.diaValor.TabIndex = 13;
            // 
            // valorValor
            // 
            this.valorValor.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.valorValor.Location = new System.Drawing.Point(102, 150);
            this.valorValor.Name = "valorValor";
            this.valorValor.ReadOnly = true;
            this.valorValor.Size = new System.Drawing.Size(77, 21);
            this.valorValor.TabIndex = 11;
            // 
            // ingressosValor
            // 
            this.ingressosValor.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ingressosValor.Location = new System.Drawing.Point(19, 150);
            this.ingressosValor.Name = "ingressosValor";
            this.ingressosValor.ReadOnly = true;
            this.ingressosValor.Size = new System.Drawing.Size(77, 21);
            this.ingressosValor.TabIndex = 9;
            // 
            // tipoValor
            // 
            this.tipoValor.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tipoValor.Location = new System.Drawing.Point(102, 68);
            this.tipoValor.Name = "tipoValor";
            this.tipoValor.ReadOnly = true;
            this.tipoValor.Size = new System.Drawing.Size(77, 21);
            this.tipoValor.TabIndex = 7;
            // 
            // nomeValor
            // 
            this.nomeValor.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nomeValor.Location = new System.Drawing.Point(19, 111);
            this.nomeValor.Name = "nomeValor";
            this.nomeValor.ReadOnly = true;
            this.nomeValor.Size = new System.Drawing.Size(160, 21);
            this.nomeValor.TabIndex = 4;
            // 
            // salaValor
            // 
            this.salaValor.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.salaValor.Location = new System.Drawing.Point(19, 68);
            this.salaValor.Name = "salaValor";
            this.salaValor.ReadOnly = true;
            this.salaValor.Size = new System.Drawing.Size(77, 21);
            this.salaValor.TabIndex = 3;
            // 
            // codeTxt
            // 
            this.codeTxt.AutoSize = true;
            this.codeTxt.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.codeTxt.Location = new System.Drawing.Point(16, 12);
            this.codeTxt.Name = "codeTxt";
            this.codeTxt.Size = new System.Drawing.Size(48, 13);
            this.codeTxt.TabIndex = 16;
            this.codeTxt.Text = "Código:";
            // 
            // salaTxt
            // 
            this.salaTxt.AutoSize = true;
            this.salaTxt.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.salaTxt.Location = new System.Drawing.Point(16, 51);
            this.salaTxt.Name = "salaTxt";
            this.salaTxt.Size = new System.Drawing.Size(31, 13);
            this.salaTxt.TabIndex = 0;
            this.salaTxt.Text = "Sala:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(100, 51);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(32, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Tipo:";
            // 
            // nomeTxt
            // 
            this.nomeTxt.AutoSize = true;
            this.nomeTxt.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nomeTxt.Location = new System.Drawing.Point(16, 94);
            this.nomeTxt.Name = "nomeTxt";
            this.nomeTxt.Size = new System.Drawing.Size(87, 13);
            this.nomeTxt.TabIndex = 1;
            this.nomeTxt.Text = "Nome do Filme:";
            this.nomeTxt.Click += new System.EventHandler(this.nomeTxt_Click);
            // 
            // ingressosTxt
            // 
            this.ingressosTxt.AutoSize = true;
            this.ingressosTxt.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ingressosTxt.Location = new System.Drawing.Point(16, 133);
            this.ingressosTxt.Name = "ingressosTxt";
            this.ingressosTxt.Size = new System.Drawing.Size(59, 13);
            this.ingressosTxt.TabIndex = 8;
            this.ingressosTxt.Text = "Ingressos:";
            // 
            // valortxt
            // 
            this.valortxt.AutoSize = true;
            this.valortxt.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.valortxt.Location = new System.Drawing.Point(100, 133);
            this.valortxt.Name = "valortxt";
            this.valortxt.Size = new System.Drawing.Size(36, 13);
            this.valortxt.TabIndex = 10;
            this.valortxt.Text = "Valor:";
            // 
            // diaTxt
            // 
            this.diaTxt.AutoSize = true;
            this.diaTxt.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.diaTxt.Location = new System.Drawing.Point(16, 172);
            this.diaTxt.Name = "diaTxt";
            this.diaTxt.Size = new System.Drawing.Size(27, 13);
            this.diaTxt.TabIndex = 12;
            this.diaTxt.Text = "Dia:";
            // 
            // horarioTxt
            // 
            this.horarioTxt.AutoSize = true;
            this.horarioTxt.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.horarioTxt.Location = new System.Drawing.Point(100, 172);
            this.horarioTxt.Name = "horarioTxt";
            this.horarioTxt.Size = new System.Drawing.Size(49, 13);
            this.horarioTxt.TabIndex = 14;
            this.horarioTxt.Text = "Horário:";
            // 
            // banner
            // 
            this.banner.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.banner.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.banner.Location = new System.Drawing.Point(27, 15);
            this.banner.Name = "banner";
            this.banner.Size = new System.Drawing.Size(201, 294);
            this.banner.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.banner.TabIndex = 0;
            this.banner.TabStop = false;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Gainsboro;
            this.panel2.Controls.Add(this.alteraSala);
            this.panel2.Controls.Add(this.pictureBox1);
            this.panel2.Controls.Add(this.adicionaSala);
            this.panel2.Controls.Add(this.removeSala);
            this.panel2.Controls.Add(this.atualizaBtn);
            this.panel2.Location = new System.Drawing.Point(0, 22);
            this.panel2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(248, 623);
            this.panel2.TabIndex = 10;
            // 
            // alteraSala
            // 
            this.alteraSala.BackColor = System.Drawing.Color.PowderBlue;
            this.alteraSala.Cursor = System.Windows.Forms.Cursors.Hand;
            this.alteraSala.FlatAppearance.BorderSize = 0;
            this.alteraSala.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.alteraSala.Font = new System.Drawing.Font("Segoe UI Semibold", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.alteraSala.Image = ((System.Drawing.Image)(resources.GetObject("alteraSala.Image")));
            this.alteraSala.Location = new System.Drawing.Point(19, 232);
            this.alteraSala.Name = "alteraSala";
            this.alteraSala.Size = new System.Drawing.Size(216, 64);
            this.alteraSala.TabIndex = 5;
            this.alteraSala.Text = "Alterar";
            this.alteraSala.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.alteraSala.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.alteraSala.UseVisualStyleBackColor = false;
            this.alteraSala.Click += new System.EventHandler(this.alteraSala_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(14, -17);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(224, 233);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // adicionaSala
            // 
            this.adicionaSala.BackColor = System.Drawing.Color.PowderBlue;
            this.adicionaSala.Cursor = System.Windows.Forms.Cursors.Hand;
            this.adicionaSala.FlatAppearance.BorderSize = 0;
            this.adicionaSala.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.adicionaSala.Font = new System.Drawing.Font("Segoe UI Semibold", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.adicionaSala.Image = ((System.Drawing.Image)(resources.GetObject("adicionaSala.Image")));
            this.adicionaSala.Location = new System.Drawing.Point(19, 403);
            this.adicionaSala.Name = "adicionaSala";
            this.adicionaSala.Size = new System.Drawing.Size(216, 64);
            this.adicionaSala.TabIndex = 2;
            this.adicionaSala.Text = "Adicionar";
            this.adicionaSala.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.adicionaSala.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.adicionaSala.UseVisualStyleBackColor = false;
            this.adicionaSala.Click += new System.EventHandler(this.adicionaSala_Click);
            // 
            // removeSala
            // 
            this.removeSala.BackColor = System.Drawing.Color.PowderBlue;
            this.removeSala.Cursor = System.Windows.Forms.Cursors.Hand;
            this.removeSala.FlatAppearance.BorderSize = 0;
            this.removeSala.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.removeSala.Font = new System.Drawing.Font("Segoe UI Semibold", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.removeSala.Image = ((System.Drawing.Image)(resources.GetObject("removeSala.Image")));
            this.removeSala.Location = new System.Drawing.Point(19, 492);
            this.removeSala.Name = "removeSala";
            this.removeSala.Size = new System.Drawing.Size(216, 64);
            this.removeSala.TabIndex = 3;
            this.removeSala.Text = "Remover";
            this.removeSala.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.removeSala.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.removeSala.UseVisualStyleBackColor = false;
            this.removeSala.Click += new System.EventHandler(this.removeSala_Click);
            // 
            // atualizaBtn
            // 
            this.atualizaBtn.BackColor = System.Drawing.Color.PowderBlue;
            this.atualizaBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.atualizaBtn.FlatAppearance.BorderSize = 0;
            this.atualizaBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.atualizaBtn.Font = new System.Drawing.Font("Segoe UI Semibold", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.atualizaBtn.Image = ((System.Drawing.Image)(resources.GetObject("atualizaBtn.Image")));
            this.atualizaBtn.Location = new System.Drawing.Point(19, 319);
            this.atualizaBtn.Name = "atualizaBtn";
            this.atualizaBtn.Size = new System.Drawing.Size(216, 64);
            this.atualizaBtn.TabIndex = 4;
            this.atualizaBtn.Text = "Atualizar";
            this.atualizaBtn.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.atualizaBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.atualizaBtn.UseVisualStyleBackColor = false;
            this.atualizaBtn.Click += new System.EventHandler(this.atualizaBtn_Click);
            // 
            // gerenciaSessao
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1105, 638);
            this.Controls.Add(this.dadoFilme);
            this.Controls.Add(this.painelFilme);
            this.Controls.Add(this.buscaExibir);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.panel2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
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
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripSeparator buscaSeparator1;
        private System.Windows.Forms.ToolStripDropDownButton arquivoStrip;
        private System.Windows.Forms.ToolStripDropDownButton ferramentasStrip;
        private System.Windows.Forms.DataGridView buscaExibir;
        private System.Windows.Forms.ToolStripMenuItem sairStrip;
        private System.Windows.Forms.ToolStripMenuItem adicionarStrip;
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
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button adicionaSala;
        private System.Windows.Forms.Button alteraSala;
        private System.Windows.Forms.Button removeSala;
        private System.Windows.Forms.Button atualizaBtn;
    }
}