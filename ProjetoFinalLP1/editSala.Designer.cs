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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(editSala));
            this.salaNmr = new System.Windows.Forms.NumericUpDown();
            this.nmrSalaTxt = new System.Windows.Forms.Label();
            this.tipoSalaTxt = new System.Windows.Forms.Label();
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
            this.salaNmr.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.salaNmr.Location = new System.Drawing.Point(52, 40);
            this.salaNmr.Margin = new System.Windows.Forms.Padding(4);
            this.salaNmr.Name = "salaNmr";
            this.salaNmr.Size = new System.Drawing.Size(160, 25);
            this.salaNmr.TabIndex = 0;
            this.salaNmr.ValueChanged += new System.EventHandler(this.salaNmr_ValueChanged);
            // 
            // nmrSalaTxt
            // 
            this.nmrSalaTxt.AutoSize = true;
            this.nmrSalaTxt.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nmrSalaTxt.Location = new System.Drawing.Point(50, 20);
            this.nmrSalaTxt.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.nmrSalaTxt.Name = "nmrSalaTxt";
            this.nmrSalaTxt.Size = new System.Drawing.Size(106, 19);
            this.nmrSalaTxt.TabIndex = 1;
            this.nmrSalaTxt.Text = "Número da Sala";
            this.nmrSalaTxt.Click += new System.EventHandler(this.nmrSalaTxt_Click);
            // 
            // tipoSalaTxt
            // 
            this.tipoSalaTxt.AutoSize = true;
            this.tipoSalaTxt.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tipoSalaTxt.Location = new System.Drawing.Point(50, 66);
            this.tipoSalaTxt.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.tipoSalaTxt.Name = "tipoSalaTxt";
            this.tipoSalaTxt.Size = new System.Drawing.Size(35, 19);
            this.tipoSalaTxt.TabIndex = 2;
            this.tipoSalaTxt.Text = "Tipo";
            // 
            // salaTipo
            // 
            this.salaTipo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.salaTipo.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.salaTipo.FormattingEnabled = true;
            this.salaTipo.Items.AddRange(new object[] {
            "Normal",
            "3D",
            "VIP"});
            this.salaTipo.Location = new System.Drawing.Point(52, 85);
            this.salaTipo.Margin = new System.Windows.Forms.Padding(4);
            this.salaTipo.Name = "salaTipo";
            this.salaTipo.Size = new System.Drawing.Size(160, 25);
            this.salaTipo.TabIndex = 3;
            // 
            // numeroAssentos
            // 
            this.numeroAssentos.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numeroAssentos.Location = new System.Drawing.Point(52, 133);
            this.numeroAssentos.Margin = new System.Windows.Forms.Padding(4);
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
            this.numeroAssentos.Size = new System.Drawing.Size(160, 25);
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
            this.assentosTxt.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.assentosTxt.Location = new System.Drawing.Point(50, 113);
            this.assentosTxt.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.assentosTxt.Name = "assentosTxt";
            this.assentosTxt.Size = new System.Drawing.Size(137, 19);
            this.assentosTxt.TabIndex = 5;
            this.assentosTxt.Text = "Número de Assentos";
            // 
            // btnSalvar
            // 
            this.btnSalvar.BackColor = System.Drawing.Color.PowderBlue;
            this.btnSalvar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSalvar.FlatAppearance.BorderSize = 0;
            this.btnSalvar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSalvar.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalvar.Location = new System.Drawing.Point(52, 165);
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
            this.btnCancelar.Location = new System.Drawing.Point(52, 218);
            this.btnCancelar.Margin = new System.Windows.Forms.Padding(4);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(160, 43);
            this.btnCancelar.TabIndex = 7;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = false;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // editSala
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(274, 276);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnSalvar);
            this.Controls.Add(this.numeroAssentos);
            this.Controls.Add(this.salaTipo);
            this.Controls.Add(this.salaNmr);
            this.Controls.Add(this.nmrSalaTxt);
            this.Controls.Add(this.tipoSalaTxt);
            this.Controls.Add(this.assentosTxt);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
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
        private System.Windows.Forms.Label nmrSalaTxt;
        private System.Windows.Forms.Label tipoSalaTxt;
        private System.Windows.Forms.ComboBox salaTipo;
        private System.Windows.Forms.NumericUpDown numeroAssentos;
        private System.Windows.Forms.Label assentosTxt;
        private System.Windows.Forms.Button btnSalvar;
        private System.Windows.Forms.Button btnCancelar;
    }
}