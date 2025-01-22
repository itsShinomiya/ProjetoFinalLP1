namespace ProjetoFinalLP1
{
    partial class editFilme
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(editFilme));
            this.filmeNmr = new System.Windows.Forms.NumericUpDown();
            this.codeFilme = new System.Windows.Forms.Label();
            this.btnSalvar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.filmeNomeValor = new System.Windows.Forms.TextBox();
            this.filmeNome = new System.Windows.Forms.Label();
            this.descricaoTexto = new System.Windows.Forms.RichTextBox();
            this.descricaoTxt = new System.Windows.Forms.Label();
            this.bannerTxt = new System.Windows.Forms.Label();
            this.bannerImagem = new System.Windows.Forms.PictureBox();
            this.carregaImagem = new System.Windows.Forms.OpenFileDialog();
            this.carregarImagem = new System.Windows.Forms.Button();
            this.removeImagem = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.filmeNmr)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bannerImagem)).BeginInit();
            this.SuspendLayout();
            // 
            // filmeNmr
            // 
            this.filmeNmr.Enabled = false;
            this.filmeNmr.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.filmeNmr.Location = new System.Drawing.Point(17, 34);
            this.filmeNmr.Margin = new System.Windows.Forms.Padding(4);
            this.filmeNmr.Name = "filmeNmr";
            this.filmeNmr.Size = new System.Drawing.Size(160, 25);
            this.filmeNmr.TabIndex = 0;
            // 
            // codeFilme
            // 
            this.codeFilme.AutoSize = true;
            this.codeFilme.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.codeFilme.Location = new System.Drawing.Point(13, 13);
            this.codeFilme.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.codeFilme.Name = "codeFilme";
            this.codeFilme.Size = new System.Drawing.Size(109, 19);
            this.codeFilme.TabIndex = 1;
            this.codeFilme.Text = "Código do Filme";
            // 
            // btnSalvar
            // 
            this.btnSalvar.BackColor = System.Drawing.Color.PowderBlue;
            this.btnSalvar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSalvar.FlatAppearance.BorderSize = 0;
            this.btnSalvar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSalvar.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalvar.Location = new System.Drawing.Point(17, 348);
            this.btnSalvar.Margin = new System.Windows.Forms.Padding(4);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(160, 43);
            this.btnSalvar.TabIndex = 6;
            this.btnSalvar.Text = "Salvar";
            this.btnSalvar.UseVisualStyleBackColor = false;
            this.btnSalvar.Click += new System.EventHandler(this.btnSalvar_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.BackColor = System.Drawing.Color.PowderBlue;
            this.btnCancelar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCancelar.FlatAppearance.BorderSize = 0;
            this.btnCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancelar.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelar.Location = new System.Drawing.Point(219, 348);
            this.btnCancelar.Margin = new System.Windows.Forms.Padding(4);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(160, 43);
            this.btnCancelar.TabIndex = 7;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = false;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // filmeNomeValor
            // 
            this.filmeNomeValor.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.filmeNomeValor.Location = new System.Drawing.Point(17, 92);
            this.filmeNomeValor.Margin = new System.Windows.Forms.Padding(4);
            this.filmeNomeValor.Name = "filmeNomeValor";
            this.filmeNomeValor.Size = new System.Drawing.Size(359, 25);
            this.filmeNomeValor.TabIndex = 8;
            // 
            // filmeNome
            // 
            this.filmeNome.AutoSize = true;
            this.filmeNome.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.filmeNome.Location = new System.Drawing.Point(13, 71);
            this.filmeNome.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.filmeNome.Name = "filmeNome";
            this.filmeNome.Size = new System.Drawing.Size(102, 19);
            this.filmeNome.TabIndex = 9;
            this.filmeNome.Text = "Nome do Filme";
            // 
            // descricaoTexto
            // 
            this.descricaoTexto.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.descricaoTexto.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.descricaoTexto.Location = new System.Drawing.Point(17, 151);
            this.descricaoTexto.Margin = new System.Windows.Forms.Padding(4);
            this.descricaoTexto.Name = "descricaoTexto";
            this.descricaoTexto.Size = new System.Drawing.Size(360, 174);
            this.descricaoTexto.TabIndex = 11;
            this.descricaoTexto.Text = "";
            // 
            // descricaoTxt
            // 
            this.descricaoTxt.AutoSize = true;
            this.descricaoTxt.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.descricaoTxt.Location = new System.Drawing.Point(14, 130);
            this.descricaoTxt.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.descricaoTxt.Name = "descricaoTxt";
            this.descricaoTxt.Size = new System.Drawing.Size(67, 19);
            this.descricaoTxt.TabIndex = 13;
            this.descricaoTxt.Text = "Descrição";
            // 
            // bannerTxt
            // 
            this.bannerTxt.AutoSize = true;
            this.bannerTxt.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bannerTxt.Location = new System.Drawing.Point(418, 13);
            this.bannerTxt.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.bannerTxt.Name = "bannerTxt";
            this.bannerTxt.Size = new System.Drawing.Size(55, 19);
            this.bannerTxt.TabIndex = 14;
            this.bannerTxt.Text = "Banner:";
            // 
            // bannerImagem
            // 
            this.bannerImagem.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.bannerImagem.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.bannerImagem.Location = new System.Drawing.Point(423, 34);
            this.bannerImagem.Margin = new System.Windows.Forms.Padding(4);
            this.bannerImagem.Name = "bannerImagem";
            this.bannerImagem.Size = new System.Drawing.Size(219, 291);
            this.bannerImagem.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.bannerImagem.TabIndex = 15;
            this.bannerImagem.TabStop = false;
            // 
            // carregaImagem
            // 
            this.carregaImagem.FileName = "openFileDialog1";
            // 
            // carregarImagem
            // 
            this.carregarImagem.BackColor = System.Drawing.Color.PowderBlue;
            this.carregarImagem.Cursor = System.Windows.Forms.Cursors.Hand;
            this.carregarImagem.FlatAppearance.BorderSize = 0;
            this.carregarImagem.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.carregarImagem.Font = new System.Drawing.Font("Segoe UI Semibold", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.carregarImagem.Location = new System.Drawing.Point(423, 332);
            this.carregarImagem.Margin = new System.Windows.Forms.Padding(4);
            this.carregarImagem.Name = "carregarImagem";
            this.carregarImagem.Size = new System.Drawing.Size(220, 28);
            this.carregarImagem.TabIndex = 16;
            this.carregarImagem.Text = "Carregar Imagem";
            this.carregarImagem.UseVisualStyleBackColor = false;
            this.carregarImagem.Click += new System.EventHandler(this.carregarImagem_Click);
            // 
            // removeImagem
            // 
            this.removeImagem.BackColor = System.Drawing.Color.PowderBlue;
            this.removeImagem.Cursor = System.Windows.Forms.Cursors.Hand;
            this.removeImagem.FlatAppearance.BorderSize = 0;
            this.removeImagem.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.removeImagem.Font = new System.Drawing.Font("Segoe UI Semibold", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.removeImagem.Location = new System.Drawing.Point(423, 366);
            this.removeImagem.Margin = new System.Windows.Forms.Padding(4);
            this.removeImagem.Name = "removeImagem";
            this.removeImagem.Size = new System.Drawing.Size(220, 28);
            this.removeImagem.TabIndex = 17;
            this.removeImagem.Text = "Remover Imagem";
            this.removeImagem.UseVisualStyleBackColor = false;
            this.removeImagem.Click += new System.EventHandler(this.removeImagem_Click);
            // 
            // editFilme
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(657, 407);
            this.Controls.Add(this.removeImagem);
            this.Controls.Add(this.carregarImagem);
            this.Controls.Add(this.bannerImagem);
            this.Controls.Add(this.bannerTxt);
            this.Controls.Add(this.descricaoTexto);
            this.Controls.Add(this.filmeNomeValor);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnSalvar);
            this.Controls.Add(this.filmeNmr);
            this.Controls.Add(this.filmeNome);
            this.Controls.Add(this.codeFilme);
            this.Controls.Add(this.descricaoTxt);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.Name = "editFilme";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Editor de Filme";
            this.Load += new System.EventHandler(this.editSala_Load);
            ((System.ComponentModel.ISupportInitialize)(this.filmeNmr)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bannerImagem)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.NumericUpDown filmeNmr;
        private System.Windows.Forms.Label codeFilme;
        private System.Windows.Forms.Button btnSalvar;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.TextBox filmeNomeValor;
        private System.Windows.Forms.Label filmeNome;
        private System.Windows.Forms.RichTextBox descricaoTexto;
        private System.Windows.Forms.Label descricaoTxt;
        private System.Windows.Forms.Label bannerTxt;
        private System.Windows.Forms.PictureBox bannerImagem;
        private System.Windows.Forms.OpenFileDialog carregaImagem;
        private System.Windows.Forms.Button carregarImagem;
        private System.Windows.Forms.Button removeImagem;
    }
}