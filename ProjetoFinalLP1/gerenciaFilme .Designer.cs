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
            this.buscaSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.buscaExibir = new System.Windows.Forms.DataGridView();
            this.codigo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nome = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.descricao = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.adicionaFilme = new System.Windows.Forms.Button();
            this.removeFilme = new System.Windows.Forms.Button();
            this.atualizaBtn = new System.Windows.Forms.Button();
            this.alteraFilme = new System.Windows.Forms.Button();
            this.painelFilme = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.descricaoValor = new System.Windows.Forms.RichTextBox();
            this.nomeValor = new System.Windows.Forms.TextBox();
            this.codeValor = new System.Windows.Forms.TextBox();
            this.codeTxt = new System.Windows.Forms.Label();
            this.nomeTxt = new System.Windows.Forms.Label();
            this.descricaoTxt = new System.Windows.Forms.Label();
            this.banner = new System.Windows.Forms.PictureBox();
            this.dadoFilme = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.buscaExibir)).BeginInit();
            this.painelFilme.SuspendLayout();
            this.panel1.SuspendLayout();
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
            this.nome,
            this.descricao});
            this.buscaExibir.Location = new System.Drawing.Point(265, 37);
            this.buscaExibir.MultiSelect = false;
            this.buscaExibir.Name = "buscaExibir";
            this.buscaExibir.ReadOnly = true;
            this.buscaExibir.RowHeadersWidth = 51;
            this.buscaExibir.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.buscaExibir.Size = new System.Drawing.Size(557, 588);
            this.buscaExibir.TabIndex = 1;
            this.buscaExibir.SelectionChanged += new System.EventHandler(this.buscaExibir_SelectionChanged);
            // 
            // codigo
            // 
            this.codigo.HeaderText = "Código do Filme";
            this.codigo.MinimumWidth = 6;
            this.codigo.Name = "codigo";
            this.codigo.ReadOnly = true;
            // 
            // nome
            // 
            this.nome.HeaderText = "Nome do Filme";
            this.nome.MinimumWidth = 6;
            this.nome.Name = "nome";
            this.nome.ReadOnly = true;
            // 
            // descricao
            // 
            this.descricao.HeaderText = "Descrição";
            this.descricao.MinimumWidth = 6;
            this.descricao.Name = "descricao";
            this.descricao.ReadOnly = true;
            // 
            // adicionaFilme
            // 
            this.adicionaFilme.BackColor = System.Drawing.Color.PowderBlue;
            this.adicionaFilme.Cursor = System.Windows.Forms.Cursors.Hand;
            this.adicionaFilme.FlatAppearance.BorderSize = 0;
            this.adicionaFilme.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.adicionaFilme.Font = new System.Drawing.Font("Segoe UI Semibold", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.adicionaFilme.Image = ((System.Drawing.Image)(resources.GetObject("adicionaFilme.Image")));
            this.adicionaFilme.Location = new System.Drawing.Point(14, 398);
            this.adicionaFilme.Name = "adicionaFilme";
            this.adicionaFilme.Size = new System.Drawing.Size(224, 64);
            this.adicionaFilme.TabIndex = 2;
            this.adicionaFilme.Text = "Adicionar";
            this.adicionaFilme.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.adicionaFilme.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.adicionaFilme.UseVisualStyleBackColor = false;
            this.adicionaFilme.Click += new System.EventHandler(this.adicionaSala_Click);
            // 
            // removeFilme
            // 
            this.removeFilme.BackColor = System.Drawing.Color.PowderBlue;
            this.removeFilme.Cursor = System.Windows.Forms.Cursors.Hand;
            this.removeFilme.FlatAppearance.BorderSize = 0;
            this.removeFilme.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.removeFilme.Font = new System.Drawing.Font("Segoe UI Semibold", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.removeFilme.Image = ((System.Drawing.Image)(resources.GetObject("removeFilme.Image")));
            this.removeFilme.Location = new System.Drawing.Point(14, 488);
            this.removeFilme.Name = "removeFilme";
            this.removeFilme.Size = new System.Drawing.Size(224, 64);
            this.removeFilme.TabIndex = 3;
            this.removeFilme.Text = "Remover";
            this.removeFilme.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.removeFilme.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.removeFilme.UseVisualStyleBackColor = false;
            this.removeFilme.Click += new System.EventHandler(this.removeSala_Click);
            // 
            // atualizaBtn
            // 
            this.atualizaBtn.BackColor = System.Drawing.Color.PowderBlue;
            this.atualizaBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.atualizaBtn.FlatAppearance.BorderSize = 0;
            this.atualizaBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.atualizaBtn.Font = new System.Drawing.Font("Segoe UI Semibold", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.atualizaBtn.Image = ((System.Drawing.Image)(resources.GetObject("atualizaBtn.Image")));
            this.atualizaBtn.Location = new System.Drawing.Point(14, 314);
            this.atualizaBtn.Name = "atualizaBtn";
            this.atualizaBtn.Size = new System.Drawing.Size(224, 64);
            this.atualizaBtn.TabIndex = 4;
            this.atualizaBtn.Text = "Atualizar";
            this.atualizaBtn.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.atualizaBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.atualizaBtn.UseVisualStyleBackColor = false;
            this.atualizaBtn.Click += new System.EventHandler(this.atualizaBtn_Click);
            // 
            // alteraFilme
            // 
            this.alteraFilme.BackColor = System.Drawing.Color.PowderBlue;
            this.alteraFilme.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.alteraFilme.Cursor = System.Windows.Forms.Cursors.Hand;
            this.alteraFilme.FlatAppearance.BorderSize = 0;
            this.alteraFilme.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.alteraFilme.Font = new System.Drawing.Font("Segoe UI Semibold", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.alteraFilme.Image = ((System.Drawing.Image)(resources.GetObject("alteraFilme.Image")));
            this.alteraFilme.Location = new System.Drawing.Point(14, 233);
            this.alteraFilme.Name = "alteraFilme";
            this.alteraFilme.Size = new System.Drawing.Size(224, 64);
            this.alteraFilme.TabIndex = 5;
            this.alteraFilme.Text = "Alterar";
            this.alteraFilme.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.alteraFilme.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.alteraFilme.UseVisualStyleBackColor = false;
            this.alteraFilme.Click += new System.EventHandler(this.alteraSala_Click);
            // 
            // painelFilme
            // 
            this.painelFilme.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.painelFilme.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.painelFilme.Controls.Add(this.panel1);
            this.painelFilme.Controls.Add(this.banner);
            this.painelFilme.Location = new System.Drawing.Point(840, 62);
            this.painelFilme.Name = "painelFilme";
            this.painelFilme.Size = new System.Drawing.Size(253, 564);
            this.painelFilme.TabIndex = 6;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.panel1.Controls.Add(this.descricaoValor);
            this.panel1.Controls.Add(this.nomeValor);
            this.panel1.Controls.Add(this.codeValor);
            this.panel1.Controls.Add(this.codeTxt);
            this.panel1.Controls.Add(this.nomeTxt);
            this.panel1.Controls.Add(this.descricaoTxt);
            this.panel1.Location = new System.Drawing.Point(28, 297);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(200, 253);
            this.panel1.TabIndex = 1;
            // 
            // descricaoValor
            // 
            this.descricaoValor.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.descricaoValor.Location = new System.Drawing.Point(19, 119);
            this.descricaoValor.Name = "descricaoValor";
            this.descricaoValor.ReadOnly = true;
            this.descricaoValor.Size = new System.Drawing.Size(160, 120);
            this.descricaoValor.TabIndex = 5;
            this.descricaoValor.Text = "";
            // 
            // nomeValor
            // 
            this.nomeValor.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nomeValor.Location = new System.Drawing.Point(19, 76);
            this.nomeValor.Name = "nomeValor";
            this.nomeValor.ReadOnly = true;
            this.nomeValor.Size = new System.Drawing.Size(160, 21);
            this.nomeValor.TabIndex = 4;
            // 
            // codeValor
            // 
            this.codeValor.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.codeValor.Location = new System.Drawing.Point(19, 33);
            this.codeValor.Name = "codeValor";
            this.codeValor.ReadOnly = true;
            this.codeValor.Size = new System.Drawing.Size(52, 21);
            this.codeValor.TabIndex = 3;
            // 
            // codeTxt
            // 
            this.codeTxt.AutoSize = true;
            this.codeTxt.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.codeTxt.Location = new System.Drawing.Point(16, 15);
            this.codeTxt.Name = "codeTxt";
            this.codeTxt.Size = new System.Drawing.Size(48, 13);
            this.codeTxt.TabIndex = 0;
            this.codeTxt.Text = "Código:";
            // 
            // nomeTxt
            // 
            this.nomeTxt.AutoSize = true;
            this.nomeTxt.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nomeTxt.Location = new System.Drawing.Point(16, 59);
            this.nomeTxt.Name = "nomeTxt";
            this.nomeTxt.Size = new System.Drawing.Size(40, 13);
            this.nomeTxt.TabIndex = 1;
            this.nomeTxt.Text = "Nome:";
            // 
            // descricaoTxt
            // 
            this.descricaoTxt.AutoSize = true;
            this.descricaoTxt.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.descricaoTxt.Location = new System.Drawing.Point(16, 102);
            this.descricaoTxt.Name = "descricaoTxt";
            this.descricaoTxt.Size = new System.Drawing.Size(56, 13);
            this.descricaoTxt.TabIndex = 2;
            this.descricaoTxt.Text = "Descrição";
            // 
            // banner
            // 
            this.banner.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.banner.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.banner.Location = new System.Drawing.Point(27, 11);
            this.banner.Name = "banner";
            this.banner.Size = new System.Drawing.Size(201, 277);
            this.banner.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.banner.TabIndex = 0;
            this.banner.TabStop = false;
            this.banner.Click += new System.EventHandler(this.banner_Click);
            // 
            // dadoFilme
            // 
            this.dadoFilme.AutoSize = true;
            this.dadoFilme.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dadoFilme.Location = new System.Drawing.Point(836, 44);
            this.dadoFilme.Name = "dadoFilme";
            this.dadoFilme.Size = new System.Drawing.Size(88, 13);
            this.dadoFilme.TabIndex = 7;
            this.dadoFilme.Text = "Dados do filme:";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Gainsboro;
            this.panel2.Controls.Add(this.pictureBox1);
            this.panel2.Controls.Add(this.adicionaFilme);
            this.panel2.Controls.Add(this.removeFilme);
            this.panel2.Controls.Add(this.atualizaBtn);
            this.panel2.Controls.Add(this.alteraFilme);
            this.panel2.Location = new System.Drawing.Point(0, 17);
            this.panel2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(248, 623);
            this.panel2.TabIndex = 8;
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
            // gerenciaFilme
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
            this.Name = "gerenciaFilme";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Gerenciador de Filmes";
            this.Load += new System.EventHandler(this.gerenciaSala_Load);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.buscaExibir)).EndInit();
            this.painelFilme.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
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
        private System.Windows.Forms.Button adicionaFilme;
        private System.Windows.Forms.Button removeFilme;
        private System.Windows.Forms.Button atualizaBtn;
        private System.Windows.Forms.Button alteraFilme;
        private System.Windows.Forms.ToolStripMenuItem sairStrip;
        private System.Windows.Forms.ToolStripMenuItem adicionarStrip;
        private System.Windows.Forms.DataGridViewTextBoxColumn codigo;
        private System.Windows.Forms.DataGridViewTextBoxColumn nome;
        private System.Windows.Forms.DataGridViewTextBoxColumn descricao;
        private System.Windows.Forms.Panel painelFilme;
        private System.Windows.Forms.PictureBox banner;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label nomeTxt;
        private System.Windows.Forms.Label codeTxt;
        private System.Windows.Forms.Label descricaoTxt;
        private System.Windows.Forms.RichTextBox descricaoValor;
        private System.Windows.Forms.TextBox nomeValor;
        private System.Windows.Forms.Label dadoFilme;
        private System.Windows.Forms.TextBox codeValor;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}