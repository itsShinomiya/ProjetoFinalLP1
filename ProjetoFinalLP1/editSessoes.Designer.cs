namespace ProjetoFinalLP1
{
    partial class editSessoes
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
            this.sessaoNmr = new System.Windows.Forms.NumericUpDown();
            this.sessaoTxt = new System.Windows.Forms.Label();
            this.numeroSala = new System.Windows.Forms.NumericUpDown();
            this.btnSalvar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.salaTipo = new System.Windows.Forms.ComboBox();
            this.assentosTxt = new System.Windows.Forms.Label();
            this.filmeNome = new System.Windows.Forms.Label();
            this.valorNumero = new System.Windows.Forms.NumericUpDown();
            this.valorTxt = new System.Windows.Forms.Label();
            this.bannerTxt = new System.Windows.Forms.Label();
            this.bannerImagem = new System.Windows.Forms.PictureBox();
            this.carregaImagem = new System.Windows.Forms.OpenFileDialog();
            this.ingressosQtd = new System.Windows.Forms.NumericUpDown();
            this.ingressosTxt = new System.Windows.Forms.Label();
            this.horarioTxt = new System.Windows.Forms.Label();
            this.horarioValor = new System.Windows.Forms.ComboBox();
            this.diaFilme = new System.Windows.Forms.DateTimePicker();
            this.diaTxt = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.sessaoNmr)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numeroSala)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.valorNumero)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bannerImagem)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ingressosQtd)).BeginInit();
            this.SuspendLayout();
            // 
            // sessaoNmr
            // 
            this.sessaoNmr.Enabled = false;
            this.sessaoNmr.Location = new System.Drawing.Point(13, 28);
            this.sessaoNmr.Name = "sessaoNmr";
            this.sessaoNmr.Size = new System.Drawing.Size(120, 20);
            this.sessaoNmr.TabIndex = 0;
            this.sessaoNmr.ValueChanged += new System.EventHandler(this.salaNmr_ValueChanged);
            // 
            // sessaoTxt
            // 
            this.sessaoTxt.AutoSize = true;
            this.sessaoTxt.Location = new System.Drawing.Point(10, 12);
            this.sessaoTxt.Name = "sessaoTxt";
            this.sessaoTxt.Size = new System.Drawing.Size(93, 13);
            this.sessaoTxt.TabIndex = 1;
            this.sessaoTxt.Text = "Código da Sessão";
            // 
            // numeroSala
            // 
            this.numeroSala.Location = new System.Drawing.Point(13, 104);
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
            this.numeroSala.ValueChanged += new System.EventHandler(this.numeroSala_ValueChanged);
            // 
            // btnSalvar
            // 
            this.btnSalvar.Location = new System.Drawing.Point(12, 224);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(120, 35);
            this.btnSalvar.TabIndex = 6;
            this.btnSalvar.Text = "Salvar";
            this.btnSalvar.UseVisualStyleBackColor = true;
            this.btnSalvar.Click += new System.EventHandler(this.btnSalvar_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(163, 224);
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
            this.label2.Location = new System.Drawing.Point(161, 88);
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
            this.salaTipo.Location = new System.Drawing.Point(164, 104);
            this.salaTipo.Name = "salaTipo";
            this.salaTipo.Size = new System.Drawing.Size(120, 21);
            this.salaTipo.TabIndex = 3;
            this.salaTipo.SelectedIndexChanged += new System.EventHandler(this.salaTipo_SelectedIndexChanged);
            // 
            // assentosTxt
            // 
            this.assentosTxt.AutoSize = true;
            this.assentosTxt.Location = new System.Drawing.Point(10, 88);
            this.assentosTxt.Name = "assentosTxt";
            this.assentosTxt.Size = new System.Drawing.Size(83, 13);
            this.assentosTxt.TabIndex = 5;
            this.assentosTxt.Text = "Número da Sala";
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
            // valorNumero
            // 
            this.valorNumero.DecimalPlaces = 2;
            this.valorNumero.Increment = new decimal(new int[] {
            5,
            0,
            0,
            65536});
            this.valorNumero.Location = new System.Drawing.Point(164, 144);
            this.valorNumero.Name = "valorNumero";
            this.valorNumero.Size = new System.Drawing.Size(120, 20);
            this.valorNumero.TabIndex = 10;
            // 
            // valorTxt
            // 
            this.valorTxt.AutoSize = true;
            this.valorTxt.Location = new System.Drawing.Point(161, 128);
            this.valorTxt.Name = "valorTxt";
            this.valorTxt.Size = new System.Drawing.Size(35, 13);
            this.valorTxt.TabIndex = 12;
            this.valorTxt.Text = "Preço";
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
            this.bannerImagem.Size = new System.Drawing.Size(164, 231);
            this.bannerImagem.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.bannerImagem.TabIndex = 15;
            this.bannerImagem.TabStop = false;
            // 
            // carregaImagem
            // 
            this.carregaImagem.FileName = "openFileDialog1";
            // 
            // ingressosQtd
            // 
            this.ingressosQtd.Enabled = false;
            this.ingressosQtd.Location = new System.Drawing.Point(13, 144);
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
            this.ingressosTxt.Location = new System.Drawing.Point(10, 127);
            this.ingressosTxt.Name = "ingressosTxt";
            this.ingressosTxt.Size = new System.Drawing.Size(107, 13);
            this.ingressosTxt.TabIndex = 19;
            this.ingressosTxt.Text = "Número de Ingressos";
            // 
            // horarioTxt
            // 
            this.horarioTxt.AutoSize = true;
            this.horarioTxt.Location = new System.Drawing.Point(161, 167);
            this.horarioTxt.Name = "horarioTxt";
            this.horarioTxt.Size = new System.Drawing.Size(41, 13);
            this.horarioTxt.TabIndex = 20;
            this.horarioTxt.Text = "Horário";
            // 
            // horarioValor
            // 
            this.horarioValor.FormattingEnabled = true;
            this.horarioValor.Items.AddRange(new object[] {
            "13:00",
            "13:30",
            "14:00",
            "14:30",
            "15:00",
            "15:30",
            "16:00",
            "16:30",
            "17:00",
            "17:30",
            "18:00",
            "18:30",
            "19:00",
            "19:30",
            "20:00",
            "20:30",
            "21:00",
            "21:30"});
            this.horarioValor.Location = new System.Drawing.Point(164, 184);
            this.horarioValor.Name = "horarioValor";
            this.horarioValor.Size = new System.Drawing.Size(120, 21);
            this.horarioValor.TabIndex = 21;
            // 
            // diaFilme
            // 
            this.diaFilme.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.diaFilme.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.diaFilme.Location = new System.Drawing.Point(13, 184);
            this.diaFilme.Name = "diaFilme";
            this.diaFilme.ShowUpDown = true;
            this.diaFilme.Size = new System.Drawing.Size(120, 21);
            this.diaFilme.TabIndex = 22;
            this.diaFilme.Value = new System.DateTime(2024, 12, 25, 0, 0, 0, 0);
            // 
            // diaTxt
            // 
            this.diaTxt.AutoSize = true;
            this.diaTxt.Location = new System.Drawing.Point(9, 167);
            this.diaTxt.Name = "diaTxt";
            this.diaTxt.Size = new System.Drawing.Size(81, 13);
            this.diaTxt.TabIndex = 23;
            this.diaTxt.Text = "Dia de Exibição";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(13, 64);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(270, 21);
            this.comboBox1.TabIndex = 24;
            // 
            // editSessoes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(493, 269);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.diaTxt);
            this.Controls.Add(this.diaFilme);
            this.Controls.Add(this.horarioValor);
            this.Controls.Add(this.horarioTxt);
            this.Controls.Add(this.ingressosTxt);
            this.Controls.Add(this.ingressosQtd);
            this.Controls.Add(this.bannerImagem);
            this.Controls.Add(this.bannerTxt);
            this.Controls.Add(this.valorTxt);
            this.Controls.Add(this.valorNumero);
            this.Controls.Add(this.filmeNome);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnSalvar);
            this.Controls.Add(this.assentosTxt);
            this.Controls.Add(this.numeroSala);
            this.Controls.Add(this.salaTipo);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.sessaoTxt);
            this.Controls.Add(this.sessaoNmr);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "editSessoes";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Editor de Sessão";
            this.Load += new System.EventHandler(this.editSala_Load);
            ((System.ComponentModel.ISupportInitialize)(this.sessaoNmr)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numeroSala)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.valorNumero)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bannerImagem)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ingressosQtd)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.NumericUpDown sessaoNmr;
        private System.Windows.Forms.Label sessaoTxt;
        private System.Windows.Forms.NumericUpDown numeroSala;
        private System.Windows.Forms.Button btnSalvar;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox salaTipo;
        private System.Windows.Forms.Label assentosTxt;
        private System.Windows.Forms.Label filmeNome;
        private System.Windows.Forms.NumericUpDown valorNumero;
        private System.Windows.Forms.Label valorTxt;
        private System.Windows.Forms.Label bannerTxt;
        private System.Windows.Forms.PictureBox bannerImagem;
        private System.Windows.Forms.OpenFileDialog carregaImagem;
        private System.Windows.Forms.NumericUpDown ingressosQtd;
        private System.Windows.Forms.Label ingressosTxt;
        private System.Windows.Forms.Label horarioTxt;
        private System.Windows.Forms.ComboBox horarioValor;
        private System.Windows.Forms.DateTimePicker diaFilme;
        private System.Windows.Forms.Label diaTxt;
        private System.Windows.Forms.ComboBox comboBox1;
    }
}