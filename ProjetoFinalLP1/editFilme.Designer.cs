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
            this.filmeNmr.Location = new System.Drawing.Point(13, 28);
            this.filmeNmr.Name = "filmeNmr";
            this.filmeNmr.Size = new System.Drawing.Size(120, 20);
            this.filmeNmr.TabIndex = 0;
            // 
            // codeFilme
            // 
            this.codeFilme.AutoSize = true;
            this.codeFilme.Location = new System.Drawing.Point(10, 12);
            this.codeFilme.Name = "codeFilme";
            this.codeFilme.Size = new System.Drawing.Size(82, 13);
            this.codeFilme.TabIndex = 1;
            this.codeFilme.Text = "Código do Filme";
            // 
            // btnSalvar
            // 
            this.btnSalvar.Location = new System.Drawing.Point(13, 283);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(120, 35);
            this.btnSalvar.TabIndex = 6;
            this.btnSalvar.Text = "Salvar";
            this.btnSalvar.UseVisualStyleBackColor = true;
            this.btnSalvar.Click += new System.EventHandler(this.btnSalvar_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(164, 283);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(120, 35);
            this.btnCancelar.TabIndex = 7;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // filmeNomeValor
            // 
            this.filmeNomeValor.Location = new System.Drawing.Point(13, 64);
            this.filmeNomeValor.Name = "filmeNomeValor";
            this.filmeNomeValor.Size = new System.Drawing.Size(270, 20);
            this.filmeNomeValor.TabIndex = 8;
            // 
            // filmeNome
            // 
            this.filmeNome.AutoSize = true;
            this.filmeNome.Location = new System.Drawing.Point(10, 51);
            this.filmeNome.Name = "filmeNome";
            this.filmeNome.Size = new System.Drawing.Size(77, 13);
            this.filmeNome.TabIndex = 9;
            this.filmeNome.Text = "Nome do Filme";
            // 
            // descricaoTexto
            // 
            this.descricaoTexto.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.descricaoTexto.Location = new System.Drawing.Point(12, 178);
            this.descricaoTexto.Name = "descricaoTexto";
            this.descricaoTexto.Size = new System.Drawing.Size(271, 87);
            this.descricaoTexto.TabIndex = 11;
            this.descricaoTexto.Text = "";
            // 
            // descricaoTxt
            // 
            this.descricaoTxt.AutoSize = true;
            this.descricaoTxt.Location = new System.Drawing.Point(10, 162);
            this.descricaoTxt.Name = "descricaoTxt";
            this.descricaoTxt.Size = new System.Drawing.Size(55, 13);
            this.descricaoTxt.TabIndex = 13;
            this.descricaoTxt.Text = "Descrição";
            // 
            // bannerTxt
            // 
            this.bannerTxt.AutoSize = true;
            this.bannerTxt.Location = new System.Drawing.Point(314, 12);
            this.bannerTxt.Name = "bannerTxt";
            this.bannerTxt.Size = new System.Drawing.Size(44, 13);
            this.bannerTxt.TabIndex = 14;
            this.bannerTxt.Text = "Banner:";
            // 
            // bannerImagem
            // 
            this.bannerImagem.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.bannerImagem.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.bannerImagem.Location = new System.Drawing.Point(317, 28);
            this.bannerImagem.Name = "bannerImagem";
            this.bannerImagem.Size = new System.Drawing.Size(165, 237);
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
            this.carregarImagem.Location = new System.Drawing.Point(317, 272);
            this.carregarImagem.Name = "carregarImagem";
            this.carregarImagem.Size = new System.Drawing.Size(165, 23);
            this.carregarImagem.TabIndex = 16;
            this.carregarImagem.Text = "Carregar Imagem";
            this.carregarImagem.UseVisualStyleBackColor = true;
            this.carregarImagem.Click += new System.EventHandler(this.carregarImagem_Click);
            // 
            // removeImagem
            // 
            this.removeImagem.Location = new System.Drawing.Point(317, 295);
            this.removeImagem.Name = "removeImagem";
            this.removeImagem.Size = new System.Drawing.Size(165, 23);
            this.removeImagem.TabIndex = 17;
            this.removeImagem.Text = "Remover Imagem";
            this.removeImagem.UseVisualStyleBackColor = true;
            this.removeImagem.Click += new System.EventHandler(this.removeImagem_Click);
            // 
            // editFilme
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(493, 331);
            this.Controls.Add(this.removeImagem);
            this.Controls.Add(this.carregarImagem);
            this.Controls.Add(this.bannerImagem);
            this.Controls.Add(this.bannerTxt);
            this.Controls.Add(this.descricaoTxt);
            this.Controls.Add(this.descricaoTexto);
            this.Controls.Add(this.filmeNome);
            this.Controls.Add(this.filmeNomeValor);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnSalvar);
            this.Controls.Add(this.codeFilme);
            this.Controls.Add(this.filmeNmr);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
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