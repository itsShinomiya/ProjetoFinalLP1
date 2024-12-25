using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjetoFinalLP1
{
    public partial class editFuncionario : Form
    {
        int prmClick = 1;
        private MySqlConnection Obj_Conn = new MySqlConnection();
        private MySqlCommand Obj_CmdSQL = new MySqlCommand();
        private MySqlDataReader Dados;

        int controle = 0;

        public editFuncionario(int indice)
        {
            controle = indice;
            InitializeComponent();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void editSala_Load(object sender, EventArgs e)
        {
            try
            {
                Obj_Conn.ConnectionString = "Server=sql10.freesqldatabase.com;Database=sql10753597;User=sql10753597;Pwd=xaCHSSHFwZ";
                Obj_Conn.Open();
                Obj_CmdSQL.Connection = Obj_Conn;
            }
            catch (Exception Erro)
            {
                MessageBox.Show("Erro: " + Erro.Message, "Erro de Conexão",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            Obj_CmdSQL.CommandText = "SELECT MAX(codigo) FROM funcionarios";
            Dados = Obj_CmdSQL.ExecuteReader();

            if (Dados.HasRows)
            {
                try
                {
                    Dados.Read();
                    funcionarioNmr.Value = Convert.ToInt32(Dados[0]) + 1;
                }
                catch (Exception ex)
                {
                    funcionarioNmr.Value = 1;
                }
                finally
                {
                    Dados.Close();
                }
            }
        }

        private void salaNmr_ValueChanged(object sender, EventArgs e)
        {
        }

        private void carregarImagem_Click(object sender, EventArgs e)
        {
            if (carregaImagem.ShowDialog() == DialogResult.OK) 
            {
                funcionarioFoto.Load(carregaImagem.FileName);
            }
        }

        private void removeImagem_Click(object sender, EventArgs e)
        {
            funcionarioFoto.Image = null;
        }
    }
}
