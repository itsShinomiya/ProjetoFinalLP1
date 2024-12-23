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
            this.buscaTexto = new System.Windows.Forms.ToolStripTextBox();
            this.buscaBotao = new System.Windows.Forms.ToolStripButton();
            this.buscaSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.buscaSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.ajudaStrip = new System.Windows.Forms.ToolStripDropDownButton();
            this.arquivoStrip = new System.Windows.Forms.ToolStripDropDownButton();
            this.ferramentasStrip = new System.Windows.Forms.ToolStripDropDownButton();
            this.buscaExibir = new System.Windows.Forms.DataGridView();
            this.adicionarBtn = new System.Windows.Forms.Button();
            this.removerBtn = new System.Windows.Forms.Button();
            this.atualizarBtn = new System.Windows.Forms.Button();
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
            // buscaTexto
            // 
            this.buscaTexto.AutoSize = false;
            this.buscaTexto.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.buscaTexto.Name = "buscaTexto";
            this.buscaTexto.Size = new System.Drawing.Size(100, 25);
            // 
            // buscaBotao
            // 
            this.buscaBotao.Image = ((System.Drawing.Image)(resources.GetObject("buscaBotao.Image")));
            this.buscaBotao.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.buscaBotao.Name = "buscaBotao";
            this.buscaBotao.Size = new System.Drawing.Size(62, 22);
            this.buscaBotao.Text = "&Buscar";
            // 
            // buscaSeparator1
            // 
            this.buscaSeparator1.Name = "buscaSeparator1";
            this.buscaSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // buscaSeparator2
            // 
            this.buscaSeparator2.Name = "buscaSeparator2";
            this.buscaSeparator2.Size = new System.Drawing.Size(6, 25);
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
            // arquivoStrip
            // 
            this.arquivoStrip.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.arquivoStrip.Image = ((System.Drawing.Image)(resources.GetObject("arquivoStrip.Image")));
            this.arquivoStrip.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.arquivoStrip.Name = "arquivoStrip";
            this.arquivoStrip.Size = new System.Drawing.Size(62, 22);
            this.arquivoStrip.Text = "&Arquivo";
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
            // buscaExibir
            // 
            this.buscaExibir.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.buscaExibir.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.buscaExibir.Location = new System.Drawing.Point(0, 124);
            this.buscaExibir.Name = "buscaExibir";
            this.buscaExibir.Size = new System.Drawing.Size(805, 514);
            this.buscaExibir.TabIndex = 1;
            // 
            // adicionarBtn
            // 
            this.adicionarBtn.Location = new System.Drawing.Point(0, 54);
            this.adicionarBtn.Name = "adicionarBtn";
            this.adicionarBtn.Size = new System.Drawing.Size(75, 64);
            this.adicionarBtn.TabIndex = 2;
            this.adicionarBtn.Text = "Adicionar";
            this.adicionarBtn.UseVisualStyleBackColor = true;
            // 
            // removerBtn
            // 
            this.removerBtn.Location = new System.Drawing.Point(81, 54);
            this.removerBtn.Name = "removerBtn";
            this.removerBtn.Size = new System.Drawing.Size(75, 64);
            this.removerBtn.TabIndex = 3;
            this.removerBtn.Text = "Remover";
            this.removerBtn.UseVisualStyleBackColor = true;
            // 
            // atualizarBtn
            // 
            this.atualizarBtn.Location = new System.Drawing.Point(162, 54);
            this.atualizarBtn.Name = "atualizarBtn";
            this.atualizarBtn.Size = new System.Drawing.Size(75, 64);
            this.atualizarBtn.TabIndex = 4;
            this.atualizarBtn.Text = "Atualizar";
            this.atualizarBtn.UseVisualStyleBackColor = true;
            // 
            // gerenciaSala
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1105, 638);
            this.Controls.Add(this.atualizarBtn);
            this.Controls.Add(this.removerBtn);
            this.Controls.Add(this.adicionarBtn);
            this.Controls.Add(this.buscaExibir);
            this.Controls.Add(this.toolStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "gerenciaSala";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Gerenciador de Salas";
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
        private System.Windows.Forms.Button adicionarBtn;
        private System.Windows.Forms.Button removerBtn;
        private System.Windows.Forms.Button atualizarBtn;
    }
}