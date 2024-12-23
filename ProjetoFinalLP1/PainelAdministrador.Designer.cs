namespace ProjetoFinalLP1
{
    partial class PainelAdministrador
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PainelAdministrador));
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripDropDownButton1 = new System.Windows.Forms.ToolStripDropDownButton();
            this.sairToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripLabel2 = new System.Windows.Forms.ToolStripLabel();
            this.gerenciaSalas = new System.Windows.Forms.Button();
            this.gerenciaFuncionario = new System.Windows.Forms.Button();
            this.gerenciaVenda = new System.Windows.Forms.Button();
            this.gerenciaCliente = new System.Windows.Forms.Button();
            this.gerenciaFilme = new System.Windows.Forms.Button();
            this.obterAjuda = new System.Windows.Forms.Button();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripDropDownButton1,
            this.toolStripLabel2});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(800, 25);
            this.toolStrip1.TabIndex = 0;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // toolStripDropDownButton1
            // 
            this.toolStripDropDownButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripDropDownButton1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.sairToolStripMenuItem});
            this.toolStripDropDownButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripDropDownButton1.Image")));
            this.toolStripDropDownButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripDropDownButton1.Name = "toolStripDropDownButton1";
            this.toolStripDropDownButton1.Size = new System.Drawing.Size(62, 22);
            this.toolStripDropDownButton1.Text = "&Arquivo";
            // 
            // sairToolStripMenuItem
            // 
            this.sairToolStripMenuItem.Name = "sairToolStripMenuItem";
            this.sairToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.sairToolStripMenuItem.Text = "&Sair";
            this.sairToolStripMenuItem.Click += new System.EventHandler(this.sairToolStripMenuItem_Click);
            // 
            // toolStripLabel2
            // 
            this.toolStripLabel2.Name = "toolStripLabel2";
            this.toolStripLabel2.Size = new System.Drawing.Size(72, 22);
            this.toolStripLabel2.Text = "&Ferramentas";
            // 
            // gerenciaSalas
            // 
            this.gerenciaSalas.Location = new System.Drawing.Point(28, 168);
            this.gerenciaSalas.Name = "gerenciaSalas";
            this.gerenciaSalas.Size = new System.Drawing.Size(127, 118);
            this.gerenciaSalas.TabIndex = 1;
            this.gerenciaSalas.Text = "Gerenciar Salas";
            this.gerenciaSalas.UseVisualStyleBackColor = true;
            this.gerenciaSalas.Click += new System.EventHandler(this.gerenciaSalas_Click);
            // 
            // gerenciaFuncionario
            // 
            this.gerenciaFuncionario.Location = new System.Drawing.Point(172, 168);
            this.gerenciaFuncionario.Name = "gerenciaFuncionario";
            this.gerenciaFuncionario.Size = new System.Drawing.Size(127, 118);
            this.gerenciaFuncionario.TabIndex = 2;
            this.gerenciaFuncionario.Text = "Gerenciar Funcionários";
            this.gerenciaFuncionario.UseVisualStyleBackColor = true;
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
            // gerenciaCliente
            // 
            this.gerenciaCliente.Location = new System.Drawing.Point(314, 168);
            this.gerenciaCliente.Name = "gerenciaCliente";
            this.gerenciaCliente.Size = new System.Drawing.Size(127, 118);
            this.gerenciaCliente.TabIndex = 4;
            this.gerenciaCliente.Text = "Gerenciar Clientes";
            this.gerenciaCliente.UseVisualStyleBackColor = true;
            // 
            // gerenciaFilme
            // 
            this.gerenciaFilme.Location = new System.Drawing.Point(172, 310);
            this.gerenciaFilme.Name = "gerenciaFilme";
            this.gerenciaFilme.Size = new System.Drawing.Size(127, 118);
            this.gerenciaFilme.TabIndex = 5;
            this.gerenciaFilme.Text = "Gerenciar Filmes";
            this.gerenciaFilme.UseVisualStyleBackColor = true;
            // 
            // obterAjuda
            // 
            this.obterAjuda.Location = new System.Drawing.Point(314, 310);
            this.obterAjuda.Name = "obterAjuda";
            this.obterAjuda.Size = new System.Drawing.Size(127, 118);
            this.obterAjuda.TabIndex = 6;
            this.obterAjuda.Text = "Ajuda";
            this.obterAjuda.UseVisualStyleBackColor = true;
            // 
            // PainelAdministrador
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.obterAjuda);
            this.Controls.Add(this.gerenciaFilme);
            this.Controls.Add(this.gerenciaCliente);
            this.Controls.Add(this.gerenciaVenda);
            this.Controls.Add(this.gerenciaFuncionario);
            this.Controls.Add(this.gerenciaSalas);
            this.Controls.Add(this.toolStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "PainelAdministrador";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Administrador";
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripLabel toolStripLabel2;
        private System.Windows.Forms.ToolStripDropDownButton toolStripDropDownButton1;
        private System.Windows.Forms.ToolStripMenuItem sairToolStripMenuItem;
        private System.Windows.Forms.Button gerenciaSalas;
        private System.Windows.Forms.Button gerenciaFuncionario;
        private System.Windows.Forms.Button gerenciaVenda;
        private System.Windows.Forms.Button gerenciaCliente;
        private System.Windows.Forms.Button gerenciaFilme;
        private System.Windows.Forms.Button obterAjuda;
    }
}