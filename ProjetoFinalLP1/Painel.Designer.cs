namespace ProjetoFinalLP1
{
    partial class Painel
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Painel));
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.arquivoStrip = new System.Windows.Forms.ToolStripDropDownButton();
            this.sairToolStrip = new System.Windows.Forms.ToolStripMenuItem();
            this.ferramentasStrip = new System.Windows.Forms.ToolStripDropDownButton();
            this.gerenciaSalas = new System.Windows.Forms.Button();
            this.gerenciaFuncionario = new System.Windows.Forms.Button();
            this.gerenciaVenda = new System.Windows.Forms.Button();
            this.obterAjuda = new System.Windows.Forms.Button();
            this.gerenciaFilme = new System.Windows.Forms.Button();
            this.gerenciaSessão = new System.Windows.Forms.Button();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.arquivoStrip,
            this.ferramentasStrip});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(800, 25);
            this.toolStrip1.TabIndex = 0;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // arquivoStrip
            // 
            this.arquivoStrip.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.arquivoStrip.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.sairToolStrip});
            this.arquivoStrip.Image = ((System.Drawing.Image)(resources.GetObject("arquivoStrip.Image")));
            this.arquivoStrip.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.arquivoStrip.Name = "arquivoStrip";
            this.arquivoStrip.Size = new System.Drawing.Size(62, 22);
            this.arquivoStrip.Text = "&Arquivo";
            // 
            // sairToolStrip
            // 
            this.sairToolStrip.Name = "sairToolStrip";
            this.sairToolStrip.Size = new System.Drawing.Size(93, 22);
            this.sairToolStrip.Text = "&Sair";
            this.sairToolStrip.Click += new System.EventHandler(this.sairToolStripMenuItem_Click);
            // 
            // ferramentasStrip
            // 
            this.ferramentasStrip.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.ferramentasStrip.Image = ((System.Drawing.Image)(resources.GetObject("ferramentasStrip.Image")));
            this.ferramentasStrip.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.ferramentasStrip.Name = "ferramentasStrip";
            this.ferramentasStrip.Size = new System.Drawing.Size(85, 22);
            this.ferramentasStrip.Text = "&Ferramentas";
            // 
            // gerenciaSalas
            // 
            this.gerenciaSalas.Location = new System.Drawing.Point(314, 168);
            this.gerenciaSalas.Name = "gerenciaSalas";
            this.gerenciaSalas.Size = new System.Drawing.Size(127, 118);
            this.gerenciaSalas.TabIndex = 1;
            this.gerenciaSalas.Text = "Gerenciar Salas";
            this.gerenciaSalas.UseVisualStyleBackColor = true;
            this.gerenciaSalas.Click += new System.EventHandler(this.gerenciaSalas_Click);
            // 
            // gerenciaFuncionario
            // 
            this.gerenciaFuncionario.Location = new System.Drawing.Point(172, 310);
            this.gerenciaFuncionario.Name = "gerenciaFuncionario";
            this.gerenciaFuncionario.Size = new System.Drawing.Size(127, 118);
            this.gerenciaFuncionario.TabIndex = 2;
            this.gerenciaFuncionario.Text = "Gerenciar Funcionários";
            this.gerenciaFuncionario.UseVisualStyleBackColor = true;
            this.gerenciaFuncionario.Click += new System.EventHandler(this.gerenciaFuncionario_Click);
            // 
            // gerenciaVenda
            // 
            this.gerenciaVenda.Location = new System.Drawing.Point(28, 310);
            this.gerenciaVenda.Name = "gerenciaVenda";
            this.gerenciaVenda.Size = new System.Drawing.Size(127, 118);
            this.gerenciaVenda.TabIndex = 3;
            this.gerenciaVenda.Text = "Gerenciar Vendas";
            this.gerenciaVenda.UseVisualStyleBackColor = true;
            // 
            // obterAjuda
            // 
            this.obterAjuda.Location = new System.Drawing.Point(314, 310);
            this.obterAjuda.Name = "obterAjuda";
            this.obterAjuda.Size = new System.Drawing.Size(127, 118);
            this.obterAjuda.TabIndex = 4;
            this.obterAjuda.Text = "Ajuda";
            this.obterAjuda.UseVisualStyleBackColor = true;
            // 
            // gerenciaFilme
            // 
            this.gerenciaFilme.Location = new System.Drawing.Point(28, 168);
            this.gerenciaFilme.Name = "gerenciaFilme";
            this.gerenciaFilme.Size = new System.Drawing.Size(127, 118);
            this.gerenciaFilme.TabIndex = 5;
            this.gerenciaFilme.Text = "Gerenciar Filmes";
            this.gerenciaFilme.UseVisualStyleBackColor = true;
            this.gerenciaFilme.Click += new System.EventHandler(this.gerenciaFilme_Click);
            // 
            // gerenciaSessão
            // 
            this.gerenciaSessão.Location = new System.Drawing.Point(172, 168);
            this.gerenciaSessão.Name = "gerenciaSessão";
            this.gerenciaSessão.Size = new System.Drawing.Size(127, 118);
            this.gerenciaSessão.TabIndex = 6;
            this.gerenciaSessão.Text = "Gerenciar Sessões";
            this.gerenciaSessão.UseVisualStyleBackColor = true;
            this.gerenciaSessão.Click += new System.EventHandler(this.gerenciaSessão_Click);
            // 
            // Painel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.obterAjuda);
            this.Controls.Add(this.gerenciaVenda);
            this.Controls.Add(this.gerenciaFuncionario);
            this.Controls.Add(this.gerenciaSalas);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.gerenciaFilme);
            this.Controls.Add(this.gerenciaSessão);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Painel";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Administrador";
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripDropDownButton arquivoStrip;
        private System.Windows.Forms.ToolStripMenuItem sairToolStrip;
        private System.Windows.Forms.Button gerenciaSalas;
        private System.Windows.Forms.Button gerenciaFuncionario;
        private System.Windows.Forms.Button gerenciaVenda;
        private System.Windows.Forms.Button obterAjuda;
        private System.Windows.Forms.Button gerenciaFilme;
        private System.Windows.Forms.Button gerenciaSessão;
        private System.Windows.Forms.ToolStripDropDownButton ferramentasStrip;
    }
}