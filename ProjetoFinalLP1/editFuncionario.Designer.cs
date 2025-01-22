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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(editFuncionario));
            this.btnSalvar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.funcionarioTxt = new System.Windows.Forms.Label();
            this.funcionarioFoto = new System.Windows.Forms.PictureBox();
            this.carregaImagem = new System.Windows.Forms.OpenFileDialog();
            this.carregarImagem = new System.Windows.Forms.Button();
            this.removeImagem = new System.Windows.Forms.Button();
            this.nomeTxt = new System.Windows.Forms.Label();
            this.nomeValor = new System.Windows.Forms.TextBox();
            this.cpfTxt = new System.Windows.Forms.Label();
            this.cpfValor = new System.Windows.Forms.MaskedTextBox();
            this.usuarioTxt = new System.Windows.Forms.Label();
            this.usuarioValor = new System.Windows.Forms.TextBox();
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
            this.btnSalvar.BackColor = System.Drawing.Color.PowderBlue;
            this.btnSalvar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSalvar.FlatAppearance.BorderSize = 0;
            this.btnSalvar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSalvar.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalvar.Location = new System.Drawing.Point(17, 258);
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
            this.btnCancelar.Location = new System.Drawing.Point(219, 258);
            this.btnCancelar.Margin = new System.Windows.Forms.Padding(4);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(160, 43);
            this.btnCancelar.TabIndex = 7;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = false;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // funcionarioTxt
            // 
            this.funcionarioTxt.AutoSize = true;
            this.funcionarioTxt.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.funcionarioTxt.Location = new System.Drawing.Point(419, 13);
            this.funcionarioTxt.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.funcionarioTxt.Name = "funcionarioTxt";
            this.funcionarioTxt.Size = new System.Drawing.Size(40, 19);
            this.funcionarioTxt.TabIndex = 14;
            this.funcionarioTxt.Text = "Foto:";
            // 
            // funcionarioFoto
            // 
            this.funcionarioFoto.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.funcionarioFoto.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.funcionarioFoto.Location = new System.Drawing.Point(423, 34);
            this.funcionarioFoto.Margin = new System.Windows.Forms.Padding(4);
            this.funcionarioFoto.Name = "funcionarioFoto";
            this.funcionarioFoto.Size = new System.Drawing.Size(219, 203);
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
            this.carregarImagem.BackColor = System.Drawing.Color.PowderBlue;
            this.carregarImagem.Cursor = System.Windows.Forms.Cursors.Hand;
            this.carregarImagem.FlatAppearance.BorderSize = 0;
            this.carregarImagem.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.carregarImagem.Font = new System.Drawing.Font("Segoe UI Semibold", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.carregarImagem.Location = new System.Drawing.Point(423, 245);
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
            this.removeImagem.Location = new System.Drawing.Point(423, 280);
            this.removeImagem.Margin = new System.Windows.Forms.Padding(4);
            this.removeImagem.Name = "removeImagem";
            this.removeImagem.Size = new System.Drawing.Size(220, 28);
            this.removeImagem.TabIndex = 17;
            this.removeImagem.Text = "Remover Imagem";
            this.removeImagem.UseVisualStyleBackColor = false;
            this.removeImagem.Click += new System.EventHandler(this.removeImagem_Click);
            // 
            // nomeTxt
            // 
            this.nomeTxt.AutoSize = true;
            this.nomeTxt.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nomeTxt.Location = new System.Drawing.Point(15, 13);
            this.nomeTxt.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.nomeTxt.Name = "nomeTxt";
            this.nomeTxt.Size = new System.Drawing.Size(110, 19);
            this.nomeTxt.TabIndex = 19;
            this.nomeTxt.Text = "Nome Completo";
            // 
            // nomeValor
            // 
            this.nomeValor.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nomeValor.Location = new System.Drawing.Point(17, 34);
            this.nomeValor.Margin = new System.Windows.Forms.Padding(4);
            this.nomeValor.Name = "nomeValor";
            this.nomeValor.Size = new System.Drawing.Size(360, 25);
            this.nomeValor.TabIndex = 20;
            // 
            // cpfTxt
            // 
            this.cpfTxt.AutoSize = true;
            this.cpfTxt.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cpfTxt.Location = new System.Drawing.Point(15, 64);
            this.cpfTxt.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.cpfTxt.Name = "cpfTxt";
            this.cpfTxt.Size = new System.Drawing.Size(33, 19);
            this.cpfTxt.TabIndex = 21;
            this.cpfTxt.Text = "CPF";
            // 
            // cpfValor
            // 
            this.cpfValor.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cpfValor.Location = new System.Drawing.Point(17, 85);
            this.cpfValor.Margin = new System.Windows.Forms.Padding(4);
            this.cpfValor.Mask = "000,000,000-99";
            this.cpfValor.Name = "cpfValor";
            this.cpfValor.Size = new System.Drawing.Size(159, 27);
            this.cpfValor.TabIndex = 22;
            // 
            // usuarioTxt
            // 
            this.usuarioTxt.AutoSize = true;
            this.usuarioTxt.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.usuarioTxt.Location = new System.Drawing.Point(15, 116);
            this.usuarioTxt.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.usuarioTxt.Name = "usuarioTxt";
            this.usuarioTxt.Size = new System.Drawing.Size(56, 19);
            this.usuarioTxt.TabIndex = 23;
            this.usuarioTxt.Text = "Usuário";
            // 
            // usuarioValor
            // 
            this.usuarioValor.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.usuarioValor.Location = new System.Drawing.Point(17, 137);
            this.usuarioValor.Margin = new System.Windows.Forms.Padding(4);
            this.usuarioValor.Name = "usuarioValor";
            this.usuarioValor.Size = new System.Drawing.Size(159, 25);
            this.usuarioValor.TabIndex = 24;
            // 
            // senhaValor
            // 
            this.senhaValor.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.senhaValor.Location = new System.Drawing.Point(219, 137);
            this.senhaValor.Margin = new System.Windows.Forms.Padding(4);
            this.senhaValor.Name = "senhaValor";
            this.senhaValor.PasswordChar = '*';
            this.senhaValor.Size = new System.Drawing.Size(157, 25);
            this.senhaValor.TabIndex = 25;
            // 
            // senhaTxt
            // 
            this.senhaTxt.AutoSize = true;
            this.senhaTxt.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.senhaTxt.Location = new System.Drawing.Point(216, 116);
            this.senhaTxt.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.senhaTxt.Name = "senhaTxt";
            this.senhaTxt.Size = new System.Drawing.Size(46, 19);
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
            this.tipoValor.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tipoValor.FormattingEnabled = true;
            this.tipoValor.Items.AddRange(new object[] {
            "Administrador",
            "Gerente",
            "Usuário"});
            this.tipoValor.Location = new System.Drawing.Point(219, 87);
            this.tipoValor.Margin = new System.Windows.Forms.Padding(4);
            this.tipoValor.Name = "tipoValor";
            this.tipoValor.Size = new System.Drawing.Size(157, 25);
            this.tipoValor.TabIndex = 27;
            // 
            // nivelTxt
            // 
            this.nivelTxt.AutoSize = true;
            this.nivelTxt.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nivelTxt.Location = new System.Drawing.Point(216, 66);
            this.nivelTxt.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.nivelTxt.Name = "nivelTxt";
            this.nivelTxt.Size = new System.Drawing.Size(39, 19);
            this.nivelTxt.TabIndex = 28;
            this.nivelTxt.Text = "Nível";
            // 
            // statusTxt
            // 
            this.statusTxt.AutoSize = true;
            this.statusTxt.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.statusTxt.Location = new System.Drawing.Point(15, 166);
            this.statusTxt.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.statusTxt.Name = "statusTxt";
            this.statusTxt.Size = new System.Drawing.Size(47, 19);
            this.statusTxt.TabIndex = 29;
            this.statusTxt.Text = "Status";
            // 
            // statusValor
            // 
            this.statusValor.DisplayMember = "0";
            this.statusValor.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.statusValor.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.statusValor.FormattingEnabled = true;
            this.statusValor.Items.AddRange(new object[] {
            "Admitido",
            "Demitido"});
            this.statusValor.Location = new System.Drawing.Point(17, 187);
            this.statusValor.Margin = new System.Windows.Forms.Padding(4);
            this.statusValor.Name = "statusValor";
            this.statusValor.Size = new System.Drawing.Size(159, 25);
            this.statusValor.TabIndex = 30;
            // 
            // editFuncionario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(657, 326);
            this.Controls.Add(this.statusValor);
            this.Controls.Add(this.tipoValor);
            this.Controls.Add(this.senhaValor);
            this.Controls.Add(this.usuarioValor);
            this.Controls.Add(this.cpfValor);
            this.Controls.Add(this.nomeValor);
            this.Controls.Add(this.removeImagem);
            this.Controls.Add(this.carregarImagem);
            this.Controls.Add(this.funcionarioFoto);
            this.Controls.Add(this.funcionarioTxt);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnSalvar);
            this.Controls.Add(this.nomeTxt);
            this.Controls.Add(this.cpfTxt);
            this.Controls.Add(this.usuarioTxt);
            this.Controls.Add(this.statusTxt);
            this.Controls.Add(this.nivelTxt);
            this.Controls.Add(this.senhaTxt);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
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
        private System.Windows.Forms.Label nomeTxt;
        private System.Windows.Forms.TextBox nomeValor;
        private System.Windows.Forms.Label cpfTxt;
        private System.Windows.Forms.MaskedTextBox cpfValor;
        private System.Windows.Forms.Label usuarioTxt;
        private System.Windows.Forms.TextBox usuarioValor;
        private System.Windows.Forms.MaskedTextBox senhaValor;
        private System.Windows.Forms.Label senhaTxt;
        private System.Windows.Forms.ComboBox tipoValor;
        private System.Windows.Forms.Label nivelTxt;
        private System.Windows.Forms.Label statusTxt;
        private System.Windows.Forms.ComboBox statusValor;
    }
}