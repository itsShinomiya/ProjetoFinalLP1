namespace ProjetoFinalLP1
{
    partial class editSala
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
            this.salaNmr = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.salaTipo = new System.Windows.Forms.ComboBox();
            this.numeroAssentos = new System.Windows.Forms.NumericUpDown();
            this.assentosTxt = new System.Windows.Forms.Label();
            this.btnSalvar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.salaNmr)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numeroAssentos)).BeginInit();
            this.SuspendLayout();
            // 
            // salaNmr
            // 
            this.salaNmr.Enabled = false;
            this.salaNmr.Location = new System.Drawing.Point(12, 29);
            this.salaNmr.Name = "salaNmr";
            this.salaNmr.Size = new System.Drawing.Size(120, 20);
            this.salaNmr.TabIndex = 0;
            this.salaNmr.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(83, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Número da Sala";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 52);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(28, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Tipo";
            // 
            // salaTipo
            // 
            this.salaTipo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.salaTipo.FormattingEnabled = true;
            this.salaTipo.Items.AddRange(new object[] {
            "Normal",
            "3D",
            "VIP"});
            this.salaTipo.Location = new System.Drawing.Point(12, 68);
            this.salaTipo.Name = "salaTipo";
            this.salaTipo.Size = new System.Drawing.Size(120, 21);
            this.salaTipo.TabIndex = 3;
            // 
            // numeroAssentos
            // 
            this.numeroAssentos.Location = new System.Drawing.Point(12, 108);
            this.numeroAssentos.Maximum = new decimal(new int[] {
            50,
            0,
            0,
            0});
            this.numeroAssentos.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numeroAssentos.Name = "numeroAssentos";
            this.numeroAssentos.Size = new System.Drawing.Size(120, 20);
            this.numeroAssentos.TabIndex = 4;
            this.numeroAssentos.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // assentosTxt
            // 
            this.assentosTxt.AutoSize = true;
            this.assentosTxt.Location = new System.Drawing.Point(9, 92);
            this.assentosTxt.Name = "assentosTxt";
            this.assentosTxt.Size = new System.Drawing.Size(105, 13);
            this.assentosTxt.TabIndex = 5;
            this.assentosTxt.Text = "Número de Assentos";
            // 
            // btnSalvar
            // 
            this.btnSalvar.Location = new System.Drawing.Point(12, 134);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(120, 35);
            this.btnSalvar.TabIndex = 6;
            this.btnSalvar.Text = "Salvar";
            this.btnSalvar.UseVisualStyleBackColor = true;
            this.btnSalvar.Click += new System.EventHandler(this.btnSalvar_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(12, 177);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(120, 35);
            this.btnCancelar.TabIndex = 7;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // editSala
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(150, 224);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnSalvar);
            this.Controls.Add(this.assentosTxt);
            this.Controls.Add(this.numeroAssentos);
            this.Controls.Add(this.salaTipo);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.salaNmr);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "editSala";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Editor de Sala";
            this.Load += new System.EventHandler(this.editSala_Load);
            ((System.ComponentModel.ISupportInitialize)(this.salaNmr)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numeroAssentos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.NumericUpDown salaNmr;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox salaTipo;
        private System.Windows.Forms.NumericUpDown numeroAssentos;
        private System.Windows.Forms.Label assentosTxt;
        private System.Windows.Forms.Button btnSalvar;
        private System.Windows.Forms.Button btnCancelar;
    }
}