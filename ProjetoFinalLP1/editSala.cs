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
    public partial class editSala : Form
    {
        private MySqlConnection Obj_Conn = new MySqlConnection();
        private MySqlCommand Obj_CmdSQL = new MySqlCommand();
        private MySqlDataReader Dados;

        int controle;
        public editSala(int controleF1)
        {
            controle = controleF1;
            InitializeComponent();
            
            if (controle == 1)
            {

            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            string tipo = salaTipo.Text.Trim();

            if (tipo != "") {
                if (controle == 0)
                {
                    string strSql;
                    strSql = "INSERT INTO sala(numero, tipo, assentos) " +
                        "VALUES(@Numero, @Tipo, @Assentos)";

                    Obj_CmdSQL.Parameters.Clear();

                    try
                    {
                        Obj_CmdSQL.CommandText = strSql;

                        Obj_CmdSQL.Parameters.AddWithValue("@Numero", Convert.ToInt32(salaNmr.Text));
                        Obj_CmdSQL.Parameters.AddWithValue("@Tipo", tipo);
                        Obj_CmdSQL.Parameters.AddWithValue("@Assentos", Convert.ToInt32(numeroAssentos.Value));

                        Obj_CmdSQL.ExecuteNonQuery();
                    }
                    catch (Exception erro) 
                    {
                        MessageBox.Show("Erro: " + erro.Message, "Erro na inclusão de valores!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                    finally 
                    {
                        Obj_CmdSQL.Parameters.Clear();
                    }

                    this.Close();
                }
            }
            else
            {
                MessageBox.Show("Preencha o tipo!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
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
        }
    }
}
