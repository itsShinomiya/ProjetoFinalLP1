namespace ProjetoFinalLP1
{
    partial class editFuncionario
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
            this.btnSalvar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.funcionarioTxt = new System.Windows.Forms.Label();
            this.funcionarioFoto = new System.Windows.Forms.PictureBox();
            this.carregaImagem = new System.Windows.Forms.OpenFileDialog();
            this.carregarImagem = new System.Windows.Forms.Button();
            this.removeImagem = new System.Windows.Forms.Button();
            this.nomeValor = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.cpfTxt = new System.Windows.Forms.Label();
            this.maskedTextBox1 = new System.Windows.Forms.MaskedTextBox();
            this.usuarioTxt = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.senhaValor = new System.Windows.Forms.MaskedTextBox();
            this.senhaTxt = new System.Windows.Forms.Label();
            this.tipoValor = new System.Windows.Forms.ComboBox();
            this.nivelTxt = new System.Windows.Forms.Label();
            this.statusTxt = new System.Windows.Forms.Label();
            this.statusValor = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.funcionarioFoto)).BeginInit();
            this.SuspendLayout();
            // 
            // btnSalvar
            // 
            this.btnSalvar.Location = new System.Drawing.Point(13, 210);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(120, 35);
            this.btnSalvar.TabIndex = 6;
            this.btnSalvar.Text = "Salvar";
            this.btnSalvar.UseVisualStyleBackColor = true;
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(164, 210);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(120, 35);
            this.btnCancelar.TabIndex = 7;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // funcionarioTxt
            // 
            this.funcionarioTxt.AutoSize = true;
            this.funcionarioTxt.Location = new System.Drawing.Point(314, 12);
            this.funcionarioTxt.Name = "funcionarioTxt";
            this.funcionarioTxt.Size = new System.Drawing.Size(31, 13);
            this.funcionarioTxt.TabIndex = 14;
            this.funcionarioTxt.Text = "Foto:";
            // 
            // funcionarioFoto
            // 
            this.funcionarioFoto.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.funcionarioFoto.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.funcionarioFoto.Location = new System.Drawing.Point(317, 28);
            this.funcionarioFoto.Name = "funcionarioFoto";
            this.funcionarioFoto.Size = new System.Drawing.Size(165, 165);
            this.funcionarioFoto.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.funcionarioFoto.TabIndex = 15;
            this.funcionarioFoto.TabStop = false;
            // 
            // carregaImagem
            // 
            this.carregaImagem.FileName = "openFileDialog1";
            // 
            // carregarImagem
            // 
            this.carregarImagem.Location = new System.Drawing.Point(317, 199);
            this.carregarImagem.Name = "carregarImagem";
            this.carregarImagem.Size = new System.Drawing.Size(165, 23);
            this.carregarImagem.TabIndex = 16;
            this.carregarImagem.Text = "Carregar Imagem";
            this.carregarImagem.UseVisualStyleBackColor = true;
            this.carregarImagem.Click += new System.EventHandler(this.carregarImagem_Click);
            // 
            // removeImagem
            // 
            this.removeImagem.Location = new System.Drawing.Point(317, 222);
            this.removeImagem.Name = "removeImagem";
            this.removeImagem.Size = new System.Drawing.Size(165, 23);
            this.removeImagem.TabIndex = 17;
            this.removeImagem.Text = "Remover Imagem";
            this.removeImagem.UseVisualStyleBackColor = true;
            this.removeImagem.Click += new System.EventHandler(this.removeImagem_Click);
            // 
            // nomeValor
            // 
            this.nomeValor.AutoSize = true;
            this.nomeValor.Location = new System.Drawing.Point(10, 12);
            this.nomeValor.Name = "nomeValor";
            this.nomeValor.Size = new System.Drawing.Size(82, 13);
            this.nomeValor.TabIndex = 19;
            this.nomeValor.Text = "Nome Completo";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(13, 28);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(271, 20);
            this.textBox1.TabIndex = 20;
            // 
            // cpfTxt
            // 
            this.cpfTxt.AutoSize = true;
            this.cpfTxt.Location = new System.Drawing.Point(10, 51);
            this.cpfTxt.Name = "cpfTxt";
            this.cpfTxt.Size = new System.Drawing.Size(27, 13);
            this.cpfTxt.TabIndex = 21;
            this.cpfTxt.Text = "CPF";
            // 
            // maskedTextBox1
            // 
            this.maskedTextBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.75F);
            this.maskedTextBox1.Location = new System.Drawing.Point(13, 68);
            this.maskedTextBox1.Mask = "000,000,000-99";
            this.maskedTextBox1.Name = "maskedTextBox1";
            this.maskedTextBox1.Size = new System.Drawing.Size(120, 21);
            this.maskedTextBox1.TabIndex = 22;
            // 
            // usuarioTxt
            // 
            this.usuarioTxt.AutoSize = true;
            this.usuarioTxt.Location = new System.Drawing.Point(10, 92);
            this.usuarioTxt.Name = "usuarioTxt";
            this.usuarioTxt.Size = new System.Drawing.Size(43, 13);
            this.usuarioTxt.TabIndex = 23;
            this.usuarioTxt.Text = "Usuário";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(13, 109);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(120, 20);
            this.textBox2.TabIndex = 24;
            // 
            // senhaValor
            // 
            this.senhaValor.Location = new System.Drawing.Point(164, 109);
            this.senhaValor.Name = "senhaValor";
            this.senhaValor.PasswordChar = '*';
            this.senhaValor.Size = new System.Drawing.Size(119, 20);
            this.senhaValor.TabIndex = 25;
            // 
            // senhaTxt
            // 
            this.senhaTxt.AutoSize = true;
            this.senhaTxt.Location = new System.Drawing.Point(161, 93);
            this.senhaTxt.Name = "senhaTxt";
            this.senhaTxt.Size = new System.Drawing.Size(38, 13);
            this.senhaTxt.TabIndex = 26;
            this.senhaTxt.Text = "Senha";
            // 
            // tipoValor
            // 
            this.tipoValor.AutoCompleteCustomSource.AddRange(new string[] {
            "Administrador",
            "Gerente",
            "Usuario"});
            this.tipoValor.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.tipoValor.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.tipoValor.FormattingEnabled = true;
            this.tipoValor.Items.AddRange(new object[] {
            "Administrador",
            "Gerente",
            "Usuario"});
            this.tipoValor.Location = new System.Drawing.Point(164, 68);
            this.tipoValor.Name = "tipoValor";
            this.tipoValor.Size = new System.Drawing.Size(119, 21);
            this.tipoValor.TabIndex = 27;
            // 
            // nivelTxt
            // 
            this.nivelTxt.AutoSize = true;
            this.nivelTxt.Location = new System.Drawing.Point(161, 51);
            this.nivelTxt.Name = "nivelTxt";
            this.nivelTxt.Size = new System.Drawing.Size(33, 13);
            this.nivelTxt.TabIndex = 28;
            this.nivelTxt.Text = "Nível";
            // 
            // statusTxt
            // 
            this.statusTxt.AutoSize = true;
            this.statusTxt.Location = new System.Drawing.Point(10, 132);
            this.statusTxt.Name = "statusTxt";
            this.statusTxt.Size = new System.Drawing.Size(37, 13);
            this.statusTxt.TabIndex = 29;
            this.statusTxt.Text = "Status";
            // 
            // statusValor
            // 
            this.statusValor.DisplayMember = "0";
            this.statusValor.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.statusValor.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.statusValor.FormattingEnabled = true;
            this.statusValor.Items.AddRange(new object[] {
            "Admitido",
            "Demitido"});
            this.statusValor.Location = new System.Drawing.Point(13, 148);
            this.statusValor.Name = "statusValor";
            this.statusValor.Size = new System.Drawing.Size(120, 21);
            this.statusValor.TabIndex = 30;
            // 
            // editFuncionario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(493, 265);
            this.Controls.Add(this.statusValor);
            this.Controls.Add(this.statusTxt);
            this.Controls.Add(this.nivelTxt);
            this.Controls.Add(this.tipoValor);
            this.Controls.Add(this.senhaTxt);
            this.Controls.Add(this.senhaValor);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.usuarioTxt);
            this.Controls.Add(this.maskedTextBox1);
            this.Controls.Add(this.cpfTxt);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.nomeValor);
            this.Controls.Add(this.removeImagem);
            this.Controls.Add(this.carregarImagem);
            this.Controls.Add(this.funcionarioFoto);
            this.Controls.Add(this.funcionarioTxt);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnSalvar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "editFuncionario";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Editor de Funcionário";
            this.Load += new System.EventHandler(this.editSala_Load);
            ((System.ComponentModel.ISupportInitialize)(this.funcionarioFoto)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnSalvar;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Label funcionarioTxt;
        private System.Windows.Forms.PictureBox funcionarioFoto;
        private System.Windows.Forms.OpenFileDialog carregaImagem;
        private System.Windows.Forms.Button carregarImagem;
        private System.Windows.Forms.Button removeImagem;
        private System.Windows.Forms.Label nomeValor;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label cpfTxt;
        private System.Windows.Forms.MaskedTextBox maskedTextBox1;
        private System.Windows.Forms.Label usuarioTxt;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.MaskedTextBox senhaValor;
        private System.Windows.Forms.Label senhaTxt;
        private System.Windows.Forms.ComboBox tipoValor;
        private System.Windows.Forms.Label nivelTxt;
        private System.Windows.Forms.Label statusTxt;
        private System.Windows.Forms.ComboBox statusValor;
    }
}