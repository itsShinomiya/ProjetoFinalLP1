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
            this.buscaSeparator1 = new System.Windows.Forms.ToolStripSeparator();
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
            this.nivelValor = new System.Windows.Forms.TextBox();
            this.cpfValor = new System.Windows.Forms.TextBox();
            this.nomeValor = new System.Windows.Forms.TextBox();
            this.nomeTxt = new System.Windows.Forms.Label();
            this.cpfTxt = new System.Windows.Forms.Label();
            this.nivelTxt = new System.Windows.Forms.Label();
            this.statusTxt = new System.Windows.Forms.Label();
            this.foto = new System.Windows.Forms.PictureBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.buscaExibir)).BeginInit();
            this.painelFilme.SuspendLayout();
            this.painelFuncionario.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.foto)).BeginInit();
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
            this.nome,
            this.cpf,
            this.nivel,
            this.status});
            this.buscaExibir.Location = new System.Drawing.Point(266, 39);
            this.buscaExibir.MultiSelect = false;
            this.buscaExibir.Name = "buscaExibir";
            this.buscaExibir.ReadOnly = true;
            this.buscaExibir.RowHeadersWidth = 51;
            this.buscaExibir.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.buscaExibir.Size = new System.Drawing.Size(542, 587);
            this.buscaExibir.TabIndex = 1;
            this.buscaExibir.SelectionChanged += new System.EventHandler(this.buscaExibir_SelectionChanged);
            // 
            // nome
            // 
            this.nome.HeaderText = "Nome";
            this.nome.MinimumWidth = 6;
            this.nome.Name = "nome";
            this.nome.ReadOnly = true;
            // 
            // cpf
            // 
            this.cpf.HeaderText = "CPF";
            this.cpf.MinimumWidth = 6;
            this.cpf.Name = "cpf";
            this.cpf.ReadOnly = true;
            // 
            // nivel
            // 
            this.nivel.HeaderText = "Nível";
            this.nivel.MinimumWidth = 6;
            this.nivel.Name = "nivel";
            this.nivel.ReadOnly = true;
            // 
            // status
            // 
            this.status.HeaderText = "Status";
            this.status.MinimumWidth = 6;
            this.status.Name = "status";
            this.status.ReadOnly = true;
            // 
            // adicionaFuncionario
            // 
            this.adicionaFuncionario.BackColor = System.Drawing.Color.PowderBlue;
            this.adicionaFuncionario.Cursor = System.Windows.Forms.Cursors.Hand;
            this.adicionaFuncionario.FlatAppearance.BorderSize = 0;
            this.adicionaFuncionario.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.adicionaFuncionario.Font = new System.Drawing.Font("Segoe UI Semibold", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.adicionaFuncionario.Image = ((System.Drawing.Image)(resources.GetObject("adicionaFuncionario.Image")));
            this.adicionaFuncionario.Location = new System.Drawing.Point(14, 403);
            this.adicionaFuncionario.Name = "adicionaFuncionario";
            this.adicionaFuncionario.Size = new System.Drawing.Size(224, 64);
            this.adicionaFuncionario.TabIndex = 2;
            this.adicionaFuncionario.Text = "Adicionar";
            this.adicionaFuncionario.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.adicionaFuncionario.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.adicionaFuncionario.UseVisualStyleBackColor = false;
            this.adicionaFuncionario.Click += new System.EventHandler(this.adicionaSala_Click);
            // 
            // removeFuncionario
            // 
            this.removeFuncionario.BackColor = System.Drawing.Color.PowderBlue;
            this.removeFuncionario.Cursor = System.Windows.Forms.Cursors.Hand;
            this.removeFuncionario.FlatAppearance.BorderSize = 0;
            this.removeFuncionario.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.removeFuncionario.Font = new System.Drawing.Font("Segoe UI Semibold", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.removeFuncionario.Image = ((System.Drawing.Image)(resources.GetObject("removeFuncionario.Image")));
            this.removeFuncionario.Location = new System.Drawing.Point(14, 488);
            this.removeFuncionario.Name = "removeFuncionario";
            this.removeFuncionario.Size = new System.Drawing.Size(224, 64);
            this.removeFuncionario.TabIndex = 3;
            this.removeFuncionario.Text = "Remover";
            this.removeFuncionario.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.removeFuncionario.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.removeFuncionario.UseVisualStyleBackColor = false;
            this.removeFuncionario.Click += new System.EventHandler(this.removeSala_Click);
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
            // alteraFuncionario
            // 
            this.alteraFuncionario.BackColor = System.Drawing.Color.PowderBlue;
            this.alteraFuncionario.Cursor = System.Windows.Forms.Cursors.Hand;
            this.alteraFuncionario.FlatAppearance.BorderSize = 0;
            this.alteraFuncionario.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.alteraFuncionario.Font = new System.Drawing.Font("Segoe UI Semibold", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.alteraFuncionario.Image = ((System.Drawing.Image)(resources.GetObject("alteraFuncionario.Image")));
            this.alteraFuncionario.Location = new System.Drawing.Point(14, 233);
            this.alteraFuncionario.Name = "alteraFuncionario";
            this.alteraFuncionario.Size = new System.Drawing.Size(224, 64);
            this.alteraFuncionario.TabIndex = 5;
            this.alteraFuncionario.Text = "Alterar";
            this.alteraFuncionario.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.alteraFuncionario.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.alteraFuncionario.UseVisualStyleBackColor = false;
            this.alteraFuncionario.Click += new System.EventHandler(this.alteraSala_Click);
            // 
            // dadoFuncionario
            // 
            this.dadoFuncionario.AutoSize = true;
            this.dadoFuncionario.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dadoFuncionario.Location = new System.Drawing.Point(826, 38);
            this.dadoFuncionario.Name = "dadoFuncionario";
            this.dadoFuncionario.Size = new System.Drawing.Size(123, 13);
            this.dadoFuncionario.TabIndex = 9;
            this.dadoFuncionario.Text = "Dados do funcionário:";
            // 
            // painelFilme
            // 
            this.painelFilme.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.painelFilme.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.painelFilme.Controls.Add(this.painelFuncionario);
            this.painelFilme.Controls.Add(this.foto);
            this.painelFilme.Location = new System.Drawing.Point(830, 55);
            this.painelFilme.Name = "painelFilme";
            this.painelFilme.Size = new System.Drawing.Size(253, 571);
            this.painelFilme.TabIndex = 8;
            // 
            // painelFuncionario
            // 
            this.painelFuncionario.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.painelFuncionario.Controls.Add(this.statusValor);
            this.painelFuncionario.Controls.Add(this.nivelValor);
            this.painelFuncionario.Controls.Add(this.cpfValor);
            this.painelFuncionario.Controls.Add(this.nomeValor);
            this.painelFuncionario.Controls.Add(this.nomeTxt);
            this.painelFuncionario.Controls.Add(this.cpfTxt);
            this.painelFuncionario.Controls.Add(this.nivelTxt);
            this.painelFuncionario.Controls.Add(this.statusTxt);
            this.painelFuncionario.Location = new System.Drawing.Point(26, 335);
            this.painelFuncionario.Name = "painelFuncionario";
            this.painelFuncionario.Size = new System.Drawing.Size(200, 204);
            this.painelFuncionario.TabIndex = 1;
            // 
            // statusValor
            // 
            this.statusValor.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.statusValor.Location = new System.Drawing.Point(20, 154);
            this.statusValor.Name = "statusValor";
            this.statusValor.ReadOnly = true;
            this.statusValor.Size = new System.Drawing.Size(160, 21);
            this.statusValor.TabIndex = 10;
            // 
            // nivelValor
            // 
            this.nivelValor.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nivelValor.Location = new System.Drawing.Point(20, 115);
            this.nivelValor.Name = "nivelValor";
            this.nivelValor.ReadOnly = true;
            this.nivelValor.Size = new System.Drawing.Size(160, 21);
            this.nivelValor.TabIndex = 8;
            // 
            // cpfValor
            // 
            this.cpfValor.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cpfValor.Location = new System.Drawing.Point(20, 76);
            this.cpfValor.Name = "cpfValor";
            this.cpfValor.ReadOnly = true;
            this.cpfValor.Size = new System.Drawing.Size(160, 21);
            this.cpfValor.TabIndex = 6;
            // 
            // nomeValor
            // 
            this.nomeValor.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nomeValor.Location = new System.Drawing.Point(20, 37);
            this.nomeValor.Name = "nomeValor";
            this.nomeValor.ReadOnly = true;
            this.nomeValor.Size = new System.Drawing.Size(160, 21);
            this.nomeValor.TabIndex = 4;
            // 
            // nomeTxt
            // 
            this.nomeTxt.AutoSize = true;
            this.nomeTxt.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nomeTxt.Location = new System.Drawing.Point(17, 20);
            this.nomeTxt.Name = "nomeTxt";
            this.nomeTxt.Size = new System.Drawing.Size(40, 13);
            this.nomeTxt.TabIndex = 1;
            this.nomeTxt.Text = "Nome:";
            // 
            // cpfTxt
            // 
            this.cpfTxt.AutoSize = true;
            this.cpfTxt.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cpfTxt.Location = new System.Drawing.Point(17, 59);
            this.cpfTxt.Name = "cpfTxt";
            this.cpfTxt.Size = new System.Drawing.Size(29, 13);
            this.cpfTxt.TabIndex = 5;
            this.cpfTxt.Text = "CPF:";
            // 
            // nivelTxt
            // 
            this.nivelTxt.AutoSize = true;
            this.nivelTxt.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nivelTxt.Location = new System.Drawing.Point(17, 98);
            this.nivelTxt.Name = "nivelTxt";
            this.nivelTxt.Size = new System.Drawing.Size(35, 13);
            this.nivelTxt.TabIndex = 7;
            this.nivelTxt.Text = "Nível:";
            // 
            // statusTxt
            // 
            this.statusTxt.AutoSize = true;
            this.statusTxt.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.statusTxt.Location = new System.Drawing.Point(17, 137);
            this.statusTxt.Name = "statusTxt";
            this.statusTxt.Size = new System.Drawing.Size(42, 13);
            this.statusTxt.TabIndex = 9;
            this.statusTxt.Text = "Status:";
            // 
            // foto
            // 
            this.foto.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.foto.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.foto.Location = new System.Drawing.Point(27, 27);
            this.foto.Name = "foto";
            this.foto.Size = new System.Drawing.Size(201, 270);
            this.foto.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.foto.TabIndex = 0;
            this.foto.TabStop = false;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Gainsboro;
            this.panel2.Controls.Add(this.pictureBox1);
            this.panel2.Controls.Add(this.atualizaBtn);
            this.panel2.Controls.Add(this.removeFuncionario);
            this.panel2.Controls.Add(this.adicionaFuncionario);
            this.panel2.Controls.Add(this.alteraFuncionario);
            this.panel2.Location = new System.Drawing.Point(0, 17);
            this.panel2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(248, 623);
            this.panel2.TabIndex = 10;
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
            // gerenciaFuncionario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1105, 638);
            this.Controls.Add(this.painelFilme);
            this.Controls.Add(this.buscaExibir);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.dadoFuncionario);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
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
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}