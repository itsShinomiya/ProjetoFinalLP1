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
            this.numeroSala = new System.Windows.Forms.NumericUpDown();
            this.btnSalvar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.salaTipo = new System.Windows.Forms.ComboBox();
            this.assentosTxt = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.filmeNome = new System.Windows.Forms.Label();
            this.valorNumero = new System.Windows.Forms.NumericUpDown();
            this.descricaoTexto = new System.Windows.Forms.RichTextBox();
            this.valorTxt = new System.Windows.Forms.Label();
            this.descricaoTxt = new System.Windows.Forms.Label();
            this.bannerTxt = new System.Windows.Forms.Label();
            this.bannerImagem = new System.Windows.Forms.PictureBox();
            this.carregaImagem = new System.Windows.Forms.OpenFileDialog();
            this.carregarImagem = new System.Windows.Forms.Button();
            this.removeImagem = new System.Windows.Forms.Button();
            this.ingressosQtd = new System.Windows.Forms.NumericUpDown();
            this.ingressosTxt = new System.Windows.Forms.Label();
            this.horarioTxt = new System.Windows.Forms.Label();
            this.horarioValor = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.filmeNmr)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numeroSala)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.valorNumero)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bannerImagem)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ingressosQtd)).BeginInit();
            this.SuspendLayout();
            // 
            // filmeNmr
            // 
            this.filmeNmr.Enabled = false;
            this.filmeNmr.Location = new System.Drawing.Point(13, 28);
            this.filmeNmr.Name = "filmeNmr";
            this.filmeNmr.Size = new System.Drawing.Size(120, 20);
            this.filmeNmr.TabIndex = 0;
            this.filmeNmr.ValueChanged += new System.EventHandler(this.salaNmr_ValueChanged);
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
            // numeroSala
            // 
            this.numeroSala.Location = new System.Drawing.Point(13, 67);
            this.numeroSala.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.numeroSala.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numeroSala.Name = "numeroSala";
            this.numeroSala.Size = new System.Drawing.Size(120, 20);
            this.numeroSala.TabIndex = 4;
            this.numeroSala.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
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
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(161, 51);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Tipo da Sala";
            // 
            // salaTipo
            // 
            this.salaTipo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.salaTipo.Enabled = false;
            this.salaTipo.FormattingEnabled = true;
            this.salaTipo.Items.AddRange(new object[] {
            "Normal",
            "3D",
            "VIP"});
            this.salaTipo.Location = new System.Drawing.Point(164, 67);
            this.salaTipo.Name = "salaTipo";
            this.salaTipo.Size = new System.Drawing.Size(120, 21);
            this.salaTipo.TabIndex = 3;
            // 
            // assentosTxt
            // 
            this.assentosTxt.AutoSize = true;
            this.assentosTxt.Location = new System.Drawing.Point(10, 51);
            this.assentosTxt.Name = "assentosTxt";
            this.assentosTxt.Size = new System.Drawing.Size(83, 13);
            this.assentosTxt.TabIndex = 5;
            this.assentosTxt.Text = "Número da Sala";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(164, 28);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(120, 20);
            this.textBox1.TabIndex = 8;
            // 
            // filmeNome
            // 
            this.filmeNome.AutoSize = true;
            this.filmeNome.Location = new System.Drawing.Point(161, 15);
            this.filmeNome.Name = "filmeNome";
            this.filmeNome.Size = new System.Drawing.Size(77, 13);
            this.filmeNome.TabIndex = 9;
            this.filmeNome.Text = "Nome do Filme";
            // 
            // valorNumero
            // 
            this.valorNumero.DecimalPlaces = 2;
            this.valorNumero.Increment = new decimal(new int[] {
            5,
            0,
            0,
            65536});
            this.valorNumero.Location = new System.Drawing.Point(164, 107);
            this.valorNumero.Name = "valorNumero";
            this.valorNumero.Size = new System.Drawing.Size(120, 20);
            this.valorNumero.TabIndex = 10;
            // 
            // descricaoTexto
            // 
            this.descricaoTexto.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.descricaoTexto.Location = new System.Drawing.Point(13, 187);
            this.descricaoTexto.Name = "descricaoTexto";
            this.descricaoTexto.Size = new System.Drawing.Size(271, 87);
            this.descricaoTexto.TabIndex = 11;
            this.descricaoTexto.Text = "Insira a Descrição";
            this.descricaoTexto.Click += new System.EventHandler(this.descricaoTexto_Click);
            // 
            // valorTxt
            // 
            this.valorTxt.AutoSize = true;
            this.valorTxt.Location = new System.Drawing.Point(161, 91);
            this.valorTxt.Name = "valorTxt";
            this.valorTxt.Size = new System.Drawing.Size(35, 13);
            this.valorTxt.TabIndex = 12;
            this.valorTxt.Text = "Preço";
            // 
            // descricaoTxt
            // 
            this.descricaoTxt.AutoSize = true;
            this.descricaoTxt.Location = new System.Drawing.Point(10, 171);
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
            // ingressosQtd
            // 
            this.ingressosQtd.Enabled = false;
            this.ingressosQtd.Location = new System.Drawing.Point(13, 107);
            this.ingressosQtd.Maximum = new decimal(new int[] {
            50,
            0,
            0,
            0});
            this.ingressosQtd.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.ingressosQtd.Name = "ingressosQtd";
            this.ingressosQtd.Size = new System.Drawing.Size(120, 20);
            this.ingressosQtd.TabIndex = 18;
            this.ingressosQtd.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // ingressosTxt
            // 
            this.ingressosTxt.AutoSize = true;
            this.ingressosTxt.Location = new System.Drawing.Point(10, 90);
            this.ingressosTxt.Name = "ingressosTxt";
            this.ingressosTxt.Size = new System.Drawing.Size(107, 13);
            this.ingressosTxt.TabIndex = 19;
            this.ingressosTxt.Text = "Número de Ingressos";
            // 
            // horarioTxt
            // 
            this.horarioTxt.AutoSize = true;
            this.horarioTxt.Location = new System.Drawing.Point(10, 130);
            this.horarioTxt.Name = "horarioTxt";
            this.horarioTxt.Size = new System.Drawing.Size(41, 13);
            this.horarioTxt.TabIndex = 20;
            this.horarioTxt.Text = "Horário";
            // 
            // horarioValor
            // 
            this.horarioValor.FormattingEnabled = true;
            this.horarioValor.Location = new System.Drawing.Point(13, 147);
            this.horarioValor.Name = "horarioValor";
            this.horarioValor.Size = new System.Drawing.Size(120, 21);
            this.horarioValor.TabIndex = 21;
            // 
            // editFilme
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(493, 331);
            this.Controls.Add(this.horarioValor);
            this.Controls.Add(this.horarioTxt);
            this.Controls.Add(this.ingressosTxt);
            this.Controls.Add(this.ingressosQtd);
            this.Controls.Add(this.removeImagem);
            this.Controls.Add(this.carregarImagem);
            this.Controls.Add(this.bannerImagem);
            this.Controls.Add(this.bannerTxt);
            this.Controls.Add(this.descricaoTxt);
            this.Controls.Add(this.valorTxt);
            this.Controls.Add(this.descricaoTexto);
            this.Controls.Add(this.valorNumero);
            this.Controls.Add(this.filmeNome);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnSalvar);
            this.Controls.Add(this.assentosTxt);
            this.Controls.Add(this.numeroSala);
            this.Controls.Add(this.salaTipo);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.codeFilme);
            this.Controls.Add(this.filmeNmr);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "editFilme";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Editor de Filme";
            this.Load += new System.EventHandler(this.editSala_Load);
            ((System.ComponentModel.ISupportInitialize)(this.filmeNmr)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numeroSala)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.valorNumero)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bannerImagem)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ingressosQtd)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.NumericUpDown filmeNmr;
        private System.Windows.Forms.Label codeFilme;
        private System.Windows.Forms.NumericUpDown numeroSala;
        private System.Windows.Forms.Button btnSalvar;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox salaTipo;
        private System.Windows.Forms.Label assentosTxt;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label filmeNome;
        private System.Windows.Forms.NumericUpDown valorNumero;
        private System.Windows.Forms.RichTextBox descricaoTexto;
        private System.Windows.Forms.Label valorTxt;
        private System.Windows.Forms.Label descricaoTxt;
        private System.Windows.Forms.Label bannerTxt;
        private System.Windows.Forms.PictureBox bannerImagem;
        private System.Windows.Forms.OpenFileDialog carregaImagem;
        private System.Windows.Forms.Button carregarImagem;
        private System.Windows.Forms.Button removeImagem;
        private System.Windows.Forms.NumericUpDown ingressosQtd;
        private System.Windows.Forms.Label ingressosTxt;
        private System.Windows.Forms.Label horarioTxt;
        private System.Windows.Forms.ComboBox horarioValor;
    }
}