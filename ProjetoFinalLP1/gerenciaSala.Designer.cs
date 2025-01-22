namespace ProjetoFinalLP1
{
    partial class gerenciaSala
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(gerenciaSala));
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.arquivoStrip = new System.Windows.Forms.ToolStripDropDownButton();
            this.sairStrip = new System.Windows.Forms.ToolStripMenuItem();
            this.ferramentasStrip = new System.Windows.Forms.ToolStripDropDownButton();
            this.adicionarStrip = new System.Windows.Forms.ToolStripMenuItem();
            this.alterarStrip = new System.Windows.Forms.ToolStripMenuItem();
            this.ajudaStrip = new System.Windows.Forms.ToolStripDropDownButton();
            this.buscaSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.buscaExibir = new System.Windows.Forms.DataGridView();
            this.numero = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tipo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.assentos = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.adicionaSala = new System.Windows.Forms.Button();
            this.removeSala = new System.Windows.Forms.Button();
            this.atualizaBtn = new System.Windows.Forms.Button();
            this.alteraSala = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.buscaExibir)).BeginInit();
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
            this.numero,
            this.tipo,
            this.assentos});
            this.buscaExibir.Location = new System.Drawing.Point(348, 31);
            this.buscaExibir.Margin = new System.Windows.Forms.Padding(4);
            this.buscaExibir.MultiSelect = false;
            this.buscaExibir.Name = "buscaExibir";
            this.buscaExibir.ReadOnly = true;
            this.buscaExibir.RowHeadersWidth = 51;
            this.buscaExibir.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.buscaExibir.Size = new System.Drawing.Size(1112, 741);
            this.buscaExibir.TabIndex = 1;
            // 
            // numero
            // 
            this.numero.HeaderText = "Número da Sala";
            this.numero.MinimumWidth = 6;
            this.numero.Name = "numero";
            this.numero.ReadOnly = true;
            // 
            // tipo
            // 
            this.tipo.HeaderText = "Tipo";
            this.tipo.MinimumWidth = 6;
            this.tipo.Name = "tipo";
            this.tipo.ReadOnly = true;
            // 
            // assentos
            // 
            this.assentos.HeaderText = "Número de Assentos";
            this.assentos.MinimumWidth = 6;
            this.assentos.Name = "assentos";
            this.assentos.ReadOnly = true;
            // 
            // adicionaSala
            // 
            this.adicionaSala.BackColor = System.Drawing.Color.PowderBlue;
            this.adicionaSala.FlatAppearance.BorderSize = 0;
            this.adicionaSala.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.adicionaSala.Font = new System.Drawing.Font("Segoe UI Semibold", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.adicionaSala.Image = ((System.Drawing.Image)(resources.GetObject("adicionaSala.Image")));
            this.adicionaSala.Location = new System.Drawing.Point(16, 514);
            this.adicionaSala.Margin = new System.Windows.Forms.Padding(4);
            this.adicionaSala.Name = "adicionaSala";
            this.adicionaSala.Size = new System.Drawing.Size(298, 79);
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
            this.removeSala.FlatAppearance.BorderSize = 0;
            this.removeSala.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.removeSala.Font = new System.Drawing.Font("Segoe UI Semibold", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.removeSala.Image = ((System.Drawing.Image)(resources.GetObject("removeSala.Image")));
            this.removeSala.Location = new System.Drawing.Point(16, 621);
            this.removeSala.Margin = new System.Windows.Forms.Padding(4);
            this.removeSala.Name = "removeSala";
            this.removeSala.Size = new System.Drawing.Size(298, 79);
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
            this.atualizaBtn.FlatAppearance.BorderSize = 0;
            this.atualizaBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.atualizaBtn.Font = new System.Drawing.Font("Segoe UI Semibold", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.atualizaBtn.Image = ((System.Drawing.Image)(resources.GetObject("atualizaBtn.Image")));
            this.atualizaBtn.Location = new System.Drawing.Point(16, 411);
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
            // alteraSala
            // 
            this.alteraSala.BackColor = System.Drawing.Color.PowderBlue;
            this.alteraSala.FlatAppearance.BorderSize = 0;
            this.alteraSala.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.alteraSala.Font = new System.Drawing.Font("Segoe UI Semibold", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.alteraSala.Image = ((System.Drawing.Image)(resources.GetObject("alteraSala.Image")));
            this.alteraSala.Location = new System.Drawing.Point(16, 308);
            this.alteraSala.Margin = new System.Windows.Forms.Padding(4);
            this.alteraSala.Name = "alteraSala";
            this.alteraSala.Size = new System.Drawing.Size(298, 79);
            this.alteraSala.TabIndex = 5;
            this.alteraSala.Text = "Alterar";
            this.alteraSala.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.alteraSala.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.alteraSala.UseVisualStyleBackColor = false;
            this.alteraSala.Click += new System.EventHandler(this.alteraSala_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Gainsboro;
            this.panel2.Controls.Add(this.pictureBox1);
            this.panel2.Location = new System.Drawing.Point(0, 21);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(331, 767);
            this.panel2.TabIndex = 9;
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
            // gerenciaSala
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1473, 785);
            this.Controls.Add(this.alteraSala);
            this.Controls.Add(this.atualizaBtn);
            this.Controls.Add(this.removeSala);
            this.Controls.Add(this.adicionaSala);
            this.Controls.Add(this.buscaExibir);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.panel2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.Name = "gerenciaSala";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Gerenciador de Salas";
            this.Load += new System.EventHandler(this.gerenciaSala_Load);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.buscaExibir)).EndInit();
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
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}