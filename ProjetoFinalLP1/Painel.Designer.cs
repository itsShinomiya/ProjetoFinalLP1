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
            this.gerenciaFilme = new System.Windows.Forms.Button();
            this.gerenciaSessão = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.arquivoStrip,
            this.ferramentasStrip});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(607, 31);
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
            this.arquivoStrip.Size = new System.Drawing.Size(75, 28);
            this.arquivoStrip.Text = "&Arquivo";
            // 
            // sairToolStrip
            // 
            this.sairToolStrip.Name = "sairToolStrip";
            this.sairToolStrip.Size = new System.Drawing.Size(117, 26);
            this.sairToolStrip.Text = "&Sair";
            this.sairToolStrip.Click += new System.EventHandler(this.sairToolStripMenuItem_Click);
            // 
            // ferramentasStrip
            // 
            this.ferramentasStrip.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.ferramentasStrip.Image = ((System.Drawing.Image)(resources.GetObject("ferramentasStrip.Image")));
            this.ferramentasStrip.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.ferramentasStrip.Name = "ferramentasStrip";
            this.ferramentasStrip.Size = new System.Drawing.Size(104, 24);
            this.ferramentasStrip.Text = "&Ferramentas";
            // 
            // gerenciaSalas
            // 
            this.gerenciaSalas.BackColor = System.Drawing.Color.PowderBlue;
            this.gerenciaSalas.Cursor = System.Windows.Forms.Cursors.Hand;
            this.gerenciaSalas.FlatAppearance.BorderSize = 0;
            this.gerenciaSalas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.gerenciaSalas.Font = new System.Drawing.Font("Segoe UI Semibold", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gerenciaSalas.Image = ((System.Drawing.Image)(resources.GetObject("gerenciaSalas.Image")));
            this.gerenciaSalas.Location = new System.Drawing.Point(34, 417);
            this.gerenciaSalas.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.gerenciaSalas.Name = "gerenciaSalas";
            this.gerenciaSalas.Size = new System.Drawing.Size(240, 128);
            this.gerenciaSalas.TabIndex = 1;
            this.gerenciaSalas.Text = "Gerenciar Salas";
            this.gerenciaSalas.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.gerenciaSalas.UseVisualStyleBackColor = false;
            this.gerenciaSalas.Click += new System.EventHandler(this.gerenciaSalas_Click);
            // 
            // gerenciaFuncionario
            // 
            this.gerenciaFuncionario.BackColor = System.Drawing.Color.PowderBlue;
            this.gerenciaFuncionario.Cursor = System.Windows.Forms.Cursors.Hand;
            this.gerenciaFuncionario.FlatAppearance.BorderSize = 0;
            this.gerenciaFuncionario.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.gerenciaFuncionario.Font = new System.Drawing.Font("Segoe UI Semibold", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gerenciaFuncionario.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.gerenciaFuncionario.Image = ((System.Drawing.Image)(resources.GetObject("gerenciaFuncionario.Image")));
            this.gerenciaFuncionario.Location = new System.Drawing.Point(329, 417);
            this.gerenciaFuncionario.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.gerenciaFuncionario.Name = "gerenciaFuncionario";
            this.gerenciaFuncionario.Size = new System.Drawing.Size(240, 128);
            this.gerenciaFuncionario.TabIndex = 2;
            this.gerenciaFuncionario.Text = "Gerenciar   Funcionários";
            this.gerenciaFuncionario.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.gerenciaFuncionario.UseVisualStyleBackColor = false;
            this.gerenciaFuncionario.Click += new System.EventHandler(this.gerenciaFuncionario_Click);
            // 
            // gerenciaFilme
            // 
            this.gerenciaFilme.BackColor = System.Drawing.Color.PowderBlue;
            this.gerenciaFilme.Cursor = System.Windows.Forms.Cursors.Hand;
            this.gerenciaFilme.FlatAppearance.BorderSize = 0;
            this.gerenciaFilme.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.gerenciaFilme.Font = new System.Drawing.Font("Segoe UI Semibold", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gerenciaFilme.Image = ((System.Drawing.Image)(resources.GetObject("gerenciaFilme.Image")));
            this.gerenciaFilme.Location = new System.Drawing.Point(34, 232);
            this.gerenciaFilme.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.gerenciaFilme.Name = "gerenciaFilme";
            this.gerenciaFilme.Size = new System.Drawing.Size(240, 128);
            this.gerenciaFilme.TabIndex = 5;
            this.gerenciaFilme.Text = "Gerenciar Filmes";
            this.gerenciaFilme.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.gerenciaFilme.UseVisualStyleBackColor = false;
            this.gerenciaFilme.Click += new System.EventHandler(this.gerenciaFilme_Click);
            // 
            // gerenciaSessão
            // 
            this.gerenciaSessão.BackColor = System.Drawing.Color.PowderBlue;
            this.gerenciaSessão.Cursor = System.Windows.Forms.Cursors.Hand;
            this.gerenciaSessão.FlatAppearance.BorderSize = 0;
            this.gerenciaSessão.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.gerenciaSessão.Font = new System.Drawing.Font("Segoe UI Semibold", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gerenciaSessão.Image = ((System.Drawing.Image)(resources.GetObject("gerenciaSessão.Image")));
            this.gerenciaSessão.Location = new System.Drawing.Point(329, 232);
            this.gerenciaSessão.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.gerenciaSessão.Name = "gerenciaSessão";
            this.gerenciaSessão.Size = new System.Drawing.Size(240, 128);
            this.gerenciaSessão.TabIndex = 6;
            this.gerenciaSessão.Text = "Gerenciar Sessões";
            this.gerenciaSessão.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.gerenciaSessão.UseVisualStyleBackColor = false;
            this.gerenciaSessão.Click += new System.EventHandler(this.gerenciaSessão_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(140, -55);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(331, 289);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 7;
            this.pictureBox1.TabStop = false;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Gainsboro;
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Location = new System.Drawing.Point(0, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(607, 184);
            this.panel1.TabIndex = 8;
            // 
            // Painel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(607, 585);
            this.Controls.Add(this.gerenciaFuncionario);
            this.Controls.Add(this.gerenciaSalas);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.gerenciaSessão);
            this.Controls.Add(this.gerenciaFilme);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.MaximizeBox = false;
            this.Name = "Painel";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Administrador";
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripDropDownButton arquivoStrip;
        private System.Windows.Forms.ToolStripMenuItem sairToolStrip;
        private System.Windows.Forms.Button gerenciaSalas;
        private System.Windows.Forms.Button gerenciaFuncionario;
        private System.Windows.Forms.Button gerenciaFilme;
        private System.Windows.Forms.Button gerenciaSessão;
        private System.Windows.Forms.ToolStripDropDownButton ferramentasStrip;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel1;
    }
}