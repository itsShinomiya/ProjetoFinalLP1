using System;
using MySql.Data.MySqlClient;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjetoFinalLP1
{
    public partial class Login : Form
    {
        private MySqlConnection Obj_Conn = new MySqlConnection();
        private MySqlCommand Obj_CmdSQL = new MySqlCommand();
        private MySqlDataReader Dados;
        public Login()
        {
            InitializeComponent();
        }

        private void btnEntrar_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(userTxt.Text) || string.IsNullOrWhiteSpace(passTxt.Text))
                {
                    MessageBox.Show("Por favor, preencha usuário e senha.", "Campos obrigatórios", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                string comando = "SELECT senha, usuario, nivel FROM usuarios WHERE usuario = @user AND senha = @pass";

                Obj_CmdSQL.Parameters.Clear();
                Obj_CmdSQL.Parameters.AddWithValue("@user", userTxt.Text);
                Obj_CmdSQL.Parameters.AddWithValue("@pass", passTxt.Text);
                Obj_CmdSQL.CommandText = comando;

                using (var Dados = Obj_CmdSQL.ExecuteReader())
                {
                    if (Dados.HasRows)
                    {
                        Dados.Read();
                        string nivel = Dados["nivel"].ToString();

                        switch (nivel)
                        {
                            case "usuario":
                                MessageBox.Show("Bem-vindo, usuário!", "Login realizado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                break;

                            case "vendedor":
                                MessageBox.Show("Bem-vindo, vendedor!", "Login realizado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                break;

                            case "administrador":
                                MessageBox.Show("Bem-vindo, administrador!", "Login realizado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                break;

                            default:
                                MessageBox.Show("Nível de acesso inválido!", "Erro de login", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                break;
                        }
                    }
                    else
                    {
                        MessageBox.Show("Usuário ou senha incorretos.", "Erro de login", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erro: {ex.Message}", "Erro ao carregar dados", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private void Login_Load(object sender, EventArgs e)
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
