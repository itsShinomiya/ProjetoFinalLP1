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
            this.gerenciaSalas = new System.Windows.Forms.Button();
            this.gerenciaFuncionario = new System.Windows.Forms.Button();
            this.gerenciaFilme = new System.Windows.Forms.Button();
            this.gerenciaSessão = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.sairToolStrip = new System.Windows.Forms.ToolStripMenuItem();
            this.arquivoStrip = new System.Windows.Forms.ToolStripDropDownButton();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel1.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // gerenciaSalas
            // 
            this.gerenciaSalas.BackColor = System.Drawing.Color.PowderBlue;
            this.gerenciaSalas.Cursor = System.Windows.Forms.Cursors.Hand;
            this.gerenciaSalas.FlatAppearance.BorderSize = 0;
            this.gerenciaSalas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.gerenciaSalas.Font = new System.Drawing.Font("Segoe UI Semibold", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gerenciaSalas.Image = ((System.Drawing.Image)(resources.GetObject("gerenciaSalas.Image")));
            this.gerenciaSalas.Location = new System.Drawing.Point(26, 339);
            this.gerenciaSalas.Name = "gerenciaSalas";
            this.gerenciaSalas.Size = new System.Drawing.Size(180, 104);
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
            this.gerenciaFuncionario.Location = new System.Drawing.Point(247, 339);
            this.gerenciaFuncionario.Name = "gerenciaFuncionario";
            this.gerenciaFuncionario.Size = new System.Drawing.Size(180, 104);
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
            this.gerenciaFilme.Location = new System.Drawing.Point(26, 188);
            this.gerenciaFilme.Name = "gerenciaFilme";
            this.gerenciaFilme.Size = new System.Drawing.Size(180, 104);
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
            this.gerenciaSessão.Location = new System.Drawing.Point(247, 188);
            this.gerenciaSessão.Name = "gerenciaSessão";
            this.gerenciaSessão.Size = new System.Drawing.Size(180, 104);
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
            this.pictureBox1.Location = new System.Drawing.Point(116, -26);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(229, 215);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 7;
            this.pictureBox1.TabStop = false;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Gainsboro;
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Location = new System.Drawing.Point(0, 10);
            this.panel1.Margin = new System.Windows.Forms.Padding(2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(455, 150);
            this.panel1.TabIndex = 8;
            // 
            // toolStrip1
            // 
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.arquivoStrip});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(455, 25);
            this.toolStrip1.TabIndex = 0;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // sairToolStrip
            // 
            this.sairToolStrip.Name = "sairToolStrip";
            this.sairToolStrip.Size = new System.Drawing.Size(180, 22);
            this.sairToolStrip.Text = "&Sair";
            this.sairToolStrip.Click += new System.EventHandler(this.sairToolStripMenuItem_Click);
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
            // Painel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(455, 475);
            this.Controls.Add(this.gerenciaFuncionario);
            this.Controls.Add(this.gerenciaSalas);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.gerenciaSessão);
            this.Controls.Add(this.gerenciaFilme);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Painel";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Administrador";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button gerenciaSalas;
        private System.Windows.Forms.Button gerenciaFuncionario;
        private System.Windows.Forms.Button gerenciaFilme;
        private System.Windows.Forms.Button gerenciaSessão;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripDropDownButton arquivoStrip;
        private System.Windows.Forms.ToolStripMenuItem sairToolStrip;
    }
}