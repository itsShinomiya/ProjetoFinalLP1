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
            this.funcionarioNmr = new System.Windows.Forms.NumericUpDown();
            this.codeFuncionario = new System.Windows.Forms.Label();
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
            ((System.ComponentModel.ISupportInitialize)(this.funcionarioNmr)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.funcionarioFoto)).BeginInit();
            this.SuspendLayout();
            // 
            // funcionarioNmr
            // 
            this.funcionarioNmr.Enabled = false;
            this.funcionarioNmr.Location = new System.Drawing.Point(13, 28);
            this.funcionarioNmr.Name = "funcionarioNmr";
            this.funcionarioNmr.Size = new System.Drawing.Size(120, 20);
            this.funcionarioNmr.TabIndex = 0;
            this.funcionarioNmr.ValueChanged += new System.EventHandler(this.salaNmr_ValueChanged);
            // 
            // codeFuncionario
            // 
            this.codeFuncionario.AutoSize = true;
            this.codeFuncionario.Location = new System.Drawing.Point(10, 12);
            this.codeFuncionario.Name = "codeFuncionario";
            this.codeFuncionario.Size = new System.Drawing.Size(113, 13);
            this.codeFuncionario.TabIndex = 1;
            this.codeFuncionario.Text = "Código do Funcionário";
            // 
            // btnSalvar
            // 
            this.btnSalvar.Location = new System.Drawing.Point(13, 283);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(120, 35);
            this.btnSalvar.TabIndex = 6;
            this.btnSalvar.Text = "Salvar";
            this.btnSalvar.UseVisualStyleBackColor = true;
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
            // nomeValor
            // 
            this.nomeValor.AutoSize = true;
            this.nomeValor.Location = new System.Drawing.Point(10, 51);
            this.nomeValor.Name = "nomeValor";
            this.nomeValor.Size = new System.Drawing.Size(82, 13);
            this.nomeValor.TabIndex = 19;
            this.nomeValor.Text = "Nome Completo";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(13, 67);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(271, 20);
            this.textBox1.TabIndex = 20;
            // 
            // cpfTxt
            // 
            this.cpfTxt.AutoSize = true;
            this.cpfTxt.Location = new System.Drawing.Point(10, 90);
            this.cpfTxt.Name = "cpfTxt";
            this.cpfTxt.Size = new System.Drawing.Size(27, 13);
            this.cpfTxt.TabIndex = 21;
            this.cpfTxt.Text = "CPF";
            // 
            // maskedTextBox1
            // 
            this.maskedTextBox1.Location = new System.Drawing.Point(13, 107);
            this.maskedTextBox1.Mask = "___.___.___.-99";
            this.maskedTextBox1.Name = "maskedTextBox1";
            this.maskedTextBox1.Size = new System.Drawing.Size(120, 20);
            this.maskedTextBox1.TabIndex = 22;
            // 
            // editFuncionario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(493, 331);
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
            this.Controls.Add(this.codeFuncionario);
            this.Controls.Add(this.funcionarioNmr);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "editFuncionario";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Editor de Funcionário";
            this.Load += new System.EventHandler(this.editSala_Load);
            ((System.ComponentModel.ISupportInitialize)(this.funcionarioNmr)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.funcionarioFoto)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.NumericUpDown funcionarioNmr;
        private System.Windows.Forms.Label codeFuncionario;
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
    }
}