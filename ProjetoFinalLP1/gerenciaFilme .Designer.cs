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
            this.ajudaStrip,
            this.buscaSeparator1});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(1473, 27);
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
            this.arquivoStrip.Size = new System.Drawing.Size(75, 24);
            this.arquivoStrip.Text = "&Arquivo";
            // 
            // sairStrip
            // 
            this.sairStrip.Name = "sairStrip";
            this.sairStrip.Size = new System.Drawing.Size(117, 26);
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
            this.ferramentasStrip.Size = new System.Drawing.Size(104, 24);
            this.ferramentasStrip.Text = "&Ferramentas";
            // 
            // adicionarStrip
            // 
            this.adicionarStrip.Name = "adicionarStrip";
            this.adicionarStrip.Size = new System.Drawing.Size(156, 26);
            this.adicionarStrip.Text = "&Adicionar";
            this.adicionarStrip.Click += new System.EventHandler(this.adicionarStrip_Click);
            // 
            // alterarStrip
            // 
            this.alterarStrip.Name = "alterarStrip";
            this.alterarStrip.Size = new System.Drawing.Size(156, 26);
            this.alterarStrip.Text = "&Alterar";
            this.alterarStrip.Click += new System.EventHandler(this.alterarStrip_Click);
            // 
            // ajudaStrip
            // 
            this.ajudaStrip.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.ajudaStrip.Image = ((System.Drawing.Image)(resources.GetObject("ajudaStrip.Image")));
            this.ajudaStrip.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.ajudaStrip.Name = "ajudaStrip";
            this.ajudaStrip.Size = new System.Drawing.Size(62, 24);
            this.ajudaStrip.Text = "&Ajuda";
            // 
            // buscaSeparator1
            // 
            this.buscaSeparator1.Name = "buscaSeparator1";
            this.buscaSeparator1.Size = new System.Drawing.Size(6, 27);
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
            this.buscaExibir.Location = new System.Drawing.Point(353, 46);
            this.buscaExibir.Margin = new System.Windows.Forms.Padding(4);
            this.buscaExibir.MultiSelect = false;
            this.buscaExibir.Name = "buscaExibir";
            this.buscaExibir.ReadOnly = true;
            this.buscaExibir.RowHeadersWidth = 51;
            this.buscaExibir.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.buscaExibir.Size = new System.Drawing.Size(743, 724);
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
            this.adicionaFilme.Location = new System.Drawing.Point(18, 490);
            this.adicionaFilme.Margin = new System.Windows.Forms.Padding(4);
            this.adicionaFilme.Name = "adicionaFilme";
            this.adicionaFilme.Size = new System.Drawing.Size(298, 79);
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
            this.removeFilme.Location = new System.Drawing.Point(18, 600);
            this.removeFilme.Margin = new System.Windows.Forms.Padding(4);
            this.removeFilme.Name = "removeFilme";
            this.removeFilme.Size = new System.Drawing.Size(298, 79);
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
            this.atualizaBtn.Location = new System.Drawing.Point(18, 387);
            this.atualizaBtn.Margin = new System.Windows.Forms.Padding(4);
            this.atualizaBtn.Name = "atualizaBtn";
            this.atualizaBtn.Size = new System.Drawing.Size(298, 79);
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
            this.alteraFilme.Location = new System.Drawing.Point(18, 287);
            this.alteraFilme.Margin = new System.Windows.Forms.Padding(4);
            this.alteraFilme.Name = "alteraFilme";
            this.alteraFilme.Size = new System.Drawing.Size(298, 79);
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
            this.painelFilme.Location = new System.Drawing.Point(1120, 76);
            this.painelFilme.Margin = new System.Windows.Forms.Padding(4);
            this.painelFilme.Name = "painelFilme";
            this.painelFilme.Size = new System.Drawing.Size(337, 694);
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
            this.panel1.Location = new System.Drawing.Point(37, 365);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(267, 311);
            this.panel1.TabIndex = 1;
            // 
            // descricaoValor
            // 
            this.descricaoValor.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.descricaoValor.Location = new System.Drawing.Point(25, 146);
            this.descricaoValor.Margin = new System.Windows.Forms.Padding(4);
            this.descricaoValor.Name = "descricaoValor";
            this.descricaoValor.ReadOnly = true;
            this.descricaoValor.Size = new System.Drawing.Size(212, 147);
            this.descricaoValor.TabIndex = 5;
            this.descricaoValor.Text = "";
            // 
            // nomeValor
            // 
            this.nomeValor.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nomeValor.Location = new System.Drawing.Point(25, 94);
            this.nomeValor.Margin = new System.Windows.Forms.Padding(4);
            this.nomeValor.Name = "nomeValor";
            this.nomeValor.ReadOnly = true;
            this.nomeValor.Size = new System.Drawing.Size(212, 25);
            this.nomeValor.TabIndex = 4;
            // 
            // codeValor
            // 
            this.codeValor.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.codeValor.Location = new System.Drawing.Point(25, 41);
            this.codeValor.Margin = new System.Windows.Forms.Padding(4);
            this.codeValor.Name = "codeValor";
            this.codeValor.ReadOnly = true;
            this.codeValor.Size = new System.Drawing.Size(68, 25);
            this.codeValor.TabIndex = 3;
            // 
            // codeTxt
            // 
            this.codeTxt.AutoSize = true;
            this.codeTxt.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.codeTxt.Location = new System.Drawing.Point(21, 19);
            this.codeTxt.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.codeTxt.Name = "codeTxt";
            this.codeTxt.Size = new System.Drawing.Size(56, 19);
            this.codeTxt.TabIndex = 0;
            this.codeTxt.Text = "Código:";
            // 
            // nomeTxt
            // 
            this.nomeTxt.AutoSize = true;
            this.nomeTxt.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nomeTxt.Location = new System.Drawing.Point(21, 73);
            this.nomeTxt.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.nomeTxt.Name = "nomeTxt";
            this.nomeTxt.Size = new System.Drawing.Size(49, 19);
            this.nomeTxt.TabIndex = 1;
            this.nomeTxt.Text = "Nome:";
            // 
            // descricaoTxt
            // 
            this.descricaoTxt.AutoSize = true;
            this.descricaoTxt.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.descricaoTxt.Location = new System.Drawing.Point(21, 126);
            this.descricaoTxt.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.descricaoTxt.Name = "descricaoTxt";
            this.descricaoTxt.Size = new System.Drawing.Size(67, 19);
            this.descricaoTxt.TabIndex = 2;
            this.descricaoTxt.Text = "Descrição";
            // 
            // banner
            // 
            this.banner.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.banner.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.banner.Location = new System.Drawing.Point(36, 14);
            this.banner.Margin = new System.Windows.Forms.Padding(4);
            this.banner.Name = "banner";
            this.banner.Size = new System.Drawing.Size(267, 340);
            this.banner.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.banner.TabIndex = 0;
            this.banner.TabStop = false;
            this.banner.Click += new System.EventHandler(this.banner_Click);
            // 
            // dadoFilme
            // 
            this.dadoFilme.AutoSize = true;
            this.dadoFilme.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dadoFilme.Location = new System.Drawing.Point(1115, 54);
            this.dadoFilme.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.dadoFilme.Name = "dadoFilme";
            this.dadoFilme.Size = new System.Drawing.Size(104, 19);
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
            this.panel2.Location = new System.Drawing.Point(0, 21);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(331, 767);
            this.panel2.TabIndex = 8;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(18, -21);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(298, 287);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // gerenciaFilme
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1473, 785);
            this.Controls.Add(this.dadoFilme);
            this.Controls.Add(this.painelFilme);
            this.Controls.Add(this.buscaExibir);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.panel2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
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
        private System.Windows.Forms.ToolStripDropDownButton ajudaStrip;
        private System.Windows.Forms.ToolStripDropDownButton arquivoStrip;
        private System.Windows.Forms.ToolStripDropDownButton ferramentasStrip;
        private System.Windows.Forms.DataGridView buscaExibir;
        private System.Windows.Forms.Button adicionaFilme;
        private System.Windows.Forms.Button removeFilme;
        private System.Windows.Forms.Button atualizaBtn;
        private System.Windows.Forms.Button alteraFilme;
        private System.Windows.Forms.ToolStripMenuItem sairStrip;
        private System.Windows.Forms.ToolStripMenuItem adicionarStrip;
        private System.Windows.Forms.ToolStripMenuItem alterarStrip;
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