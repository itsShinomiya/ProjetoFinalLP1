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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(editSessoes));
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
            this.nomeFilmeValor = new System.Windows.Forms.ComboBox();
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
            this.sessaoNmr.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sessaoNmr.Location = new System.Drawing.Point(17, 34);
            this.sessaoNmr.Margin = new System.Windows.Forms.Padding(4);
            this.sessaoNmr.Name = "sessaoNmr";
            this.sessaoNmr.Size = new System.Drawing.Size(160, 25);
            this.sessaoNmr.TabIndex = 0;
            this.sessaoNmr.ValueChanged += new System.EventHandler(this.salaNmr_ValueChanged);
            // 
            // sessaoTxt
            // 
            this.sessaoTxt.AutoSize = true;
            this.sessaoTxt.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sessaoTxt.Location = new System.Drawing.Point(13, 15);
            this.sessaoTxt.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.sessaoTxt.Name = "sessaoTxt";
            this.sessaoTxt.Size = new System.Drawing.Size(115, 17);
            this.sessaoTxt.TabIndex = 1;
            this.sessaoTxt.Text = "Código da Sessão";
            // 
            // numeroSala
            // 
            this.numeroSala.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numeroSala.Location = new System.Drawing.Point(17, 128);
            this.numeroSala.Margin = new System.Windows.Forms.Padding(4);
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
            this.numeroSala.Size = new System.Drawing.Size(160, 25);
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
            this.btnSalvar.BackColor = System.Drawing.Color.PowderBlue;
            this.btnSalvar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSalvar.FlatAppearance.BorderSize = 0;
            this.btnSalvar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSalvar.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalvar.Location = new System.Drawing.Point(16, 276);
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
            this.btnCancelar.Location = new System.Drawing.Point(217, 276);
            this.btnCancelar.Margin = new System.Windows.Forms.Padding(4);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(160, 43);
            this.btnCancelar.TabIndex = 7;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = false;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(215, 109);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(81, 17);
            this.label2.TabIndex = 2;
            this.label2.Text = "Tipo da Sala";
            // 
            // salaTipo
            // 
            this.salaTipo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.salaTipo.Enabled = false;
            this.salaTipo.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.salaTipo.FormattingEnabled = true;
            this.salaTipo.Items.AddRange(new object[] {
            "Normal",
            "3D",
            "VIP"});
            this.salaTipo.Location = new System.Drawing.Point(219, 128);
            this.salaTipo.Margin = new System.Windows.Forms.Padding(4);
            this.salaTipo.Name = "salaTipo";
            this.salaTipo.Size = new System.Drawing.Size(159, 25);
            this.salaTipo.TabIndex = 3;
            this.salaTipo.SelectedIndexChanged += new System.EventHandler(this.salaTipo_SelectedIndexChanged);
            // 
            // assentosTxt
            // 
            this.assentosTxt.AutoSize = true;
            this.assentosTxt.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.assentosTxt.Location = new System.Drawing.Point(13, 109);
            this.assentosTxt.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.assentosTxt.Name = "assentosTxt";
            this.assentosTxt.Size = new System.Drawing.Size(103, 17);
            this.assentosTxt.TabIndex = 5;
            this.assentosTxt.Text = "Número da Sala";
            // 
            // filmeNome
            // 
            this.filmeNome.AutoSize = true;
            this.filmeNome.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.filmeNome.Location = new System.Drawing.Point(13, 60);
            this.filmeNome.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.filmeNome.Name = "filmeNome";
            this.filmeNome.Size = new System.Drawing.Size(98, 17);
            this.filmeNome.TabIndex = 9;
            this.filmeNome.Text = "Nome do Filme";
            // 
            // valorNumero
            // 
            this.valorNumero.DecimalPlaces = 2;
            this.valorNumero.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.valorNumero.Increment = new decimal(new int[] {
            5,
            0,
            0,
            65536});
            this.valorNumero.Location = new System.Drawing.Point(219, 177);
            this.valorNumero.Margin = new System.Windows.Forms.Padding(4);
            this.valorNumero.Name = "valorNumero";
            this.valorNumero.Size = new System.Drawing.Size(160, 25);
            this.valorNumero.TabIndex = 10;
            this.valorNumero.Value = new decimal(new int[] {
            15,
            0,
            0,
            0});
            // 
            // valorTxt
            // 
            this.valorTxt.AutoSize = true;
            this.valorTxt.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.valorTxt.Location = new System.Drawing.Point(215, 158);
            this.valorTxt.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.valorTxt.Name = "valorTxt";
            this.valorTxt.Size = new System.Drawing.Size(41, 17);
            this.valorTxt.TabIndex = 12;
            this.valorTxt.Text = "Preço";
            // 
            // bannerTxt
            // 
            this.bannerTxt.AutoSize = true;
            this.bannerTxt.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bannerTxt.Location = new System.Drawing.Point(419, 14);
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
            this.bannerImagem.Size = new System.Drawing.Size(218, 284);
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
            this.ingressosQtd.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ingressosQtd.Location = new System.Drawing.Point(17, 177);
            this.ingressosQtd.Margin = new System.Windows.Forms.Padding(4);
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
            this.ingressosQtd.Size = new System.Drawing.Size(160, 25);
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
            this.ingressosTxt.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ingressosTxt.Location = new System.Drawing.Point(13, 158);
            this.ingressosTxt.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.ingressosTxt.Name = "ingressosTxt";
            this.ingressosTxt.Size = new System.Drawing.Size(135, 17);
            this.ingressosTxt.TabIndex = 19;
            this.ingressosTxt.Text = "Número de Ingressos";
            // 
            // horarioTxt
            // 
            this.horarioTxt.AutoSize = true;
            this.horarioTxt.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.horarioTxt.Location = new System.Drawing.Point(215, 207);
            this.horarioTxt.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.horarioTxt.Name = "horarioTxt";
            this.horarioTxt.Size = new System.Drawing.Size(53, 17);
            this.horarioTxt.TabIndex = 20;
            this.horarioTxt.Text = "Horário";
            // 
            // horarioValor
            // 
            this.horarioValor.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.horarioValor.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
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
            this.horarioValor.Location = new System.Drawing.Point(219, 226);
            this.horarioValor.Margin = new System.Windows.Forms.Padding(4);
            this.horarioValor.Name = "horarioValor";
            this.horarioValor.Size = new System.Drawing.Size(159, 25);
            this.horarioValor.TabIndex = 21;
            // 
            // diaFilme
            // 
            this.diaFilme.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.diaFilme.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.diaFilme.Location = new System.Drawing.Point(17, 226);
            this.diaFilme.Margin = new System.Windows.Forms.Padding(4);
            this.diaFilme.Name = "diaFilme";
            this.diaFilme.ShowUpDown = true;
            this.diaFilme.Size = new System.Drawing.Size(159, 27);
            this.diaFilme.TabIndex = 22;
            this.diaFilme.Value = new System.DateTime(2024, 12, 25, 0, 0, 0, 0);
            // 
            // diaTxt
            // 
            this.diaTxt.AutoSize = true;
            this.diaTxt.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.diaTxt.Location = new System.Drawing.Point(13, 207);
            this.diaTxt.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.diaTxt.Name = "diaTxt";
            this.diaTxt.Size = new System.Drawing.Size(98, 17);
            this.diaTxt.TabIndex = 23;
            this.diaTxt.Text = "Dia de Exibição";
            // 
            // nomeFilmeValor
            // 
            this.nomeFilmeValor.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.nomeFilmeValor.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nomeFilmeValor.FormattingEnabled = true;
            this.nomeFilmeValor.Location = new System.Drawing.Point(17, 79);
            this.nomeFilmeValor.Margin = new System.Windows.Forms.Padding(4);
            this.nomeFilmeValor.Name = "nomeFilmeValor";
            this.nomeFilmeValor.Size = new System.Drawing.Size(359, 25);
            this.nomeFilmeValor.TabIndex = 24;
            this.nomeFilmeValor.SelectedIndexChanged += new System.EventHandler(this.nomeFilmeValor_SelectedIndexChanged);
            // 
            // editSessoes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(657, 331);
            this.Controls.Add(this.nomeFilmeValor);
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
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
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
        private System.Windows.Forms.ComboBox nomeFilmeValor;
    }
}