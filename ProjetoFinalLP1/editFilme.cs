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
    public partial class editFilme : Form
    {
        private MySqlConnection Obj_Conn = new MySqlConnection();
        private MySqlCommand Obj_CmdSQL = new MySqlCommand();
        private MySqlDataReader Dados;

        int controle;
        int valor;
        public editFilme(int controleF1, int indice)
        {
            controle = controleF1;
            valor = indice;
            InitializeComponent();
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

                if (controle == 1)
                {
                    string strSQL;
                    strSQL = $"UPDATE sala SET numero = @Numero, tipo = @Tipo, assentos = @Assentos WHERE numero = {salaNmr.Value}";

                    Obj_CmdSQL.Parameters.Clear();

                    try
                    {
                        Obj_CmdSQL.CommandText = strSQL;

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
                if (controle == 2)
                {
                    string strSQL;
                    strSQL = $"UPDATE sala SET numero = @Numero, tipo = @Tipo, assentos = @Assentos WHERE numero = {salaNmr.Value}";

                    Obj_CmdSQL.Parameters.Clear();

                    try
                    {
                        Obj_CmdSQL.CommandText = strSQL;

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


            if (controle == 0)
            {
                Obj_CmdSQL.CommandText = "SELECT MAX(numero) FROM sala";
                Dados = Obj_CmdSQL.ExecuteReader();

                if (Dados.HasRows)
                {
                    try
                    {
                        Dados.Read();
                        salaNmr.Value = Convert.ToDecimal(Dados[0]) + 1;
                    }
                    catch (Exception ex)
                    {
                        salaNmr.Value = 1;
                    }
                    finally
                    {
                        Dados.Close();
                    }
                }
            }

            if(controle == 1)
            {
                Obj_CmdSQL.CommandText = $"SELECT {valor}, tipo, assentos FROM sala WHERE {valor} = numero";
                Obj_CmdSQL.Parameters.Clear();
                Dados = Obj_CmdSQL.ExecuteReader();

                if (Dados.HasRows)
                {
                    try
                    {
                        Dados.Read();
                        salaNmr.Value = Convert.ToDecimal(Dados[0]);
                        salaTipo.SelectedItem = Convert.ToString(Dados[1]);
                        numeroAssentos.Value = Convert.ToInt32(Dados[2]);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Ocorreu um erro ao obter informações da sala!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    finally
                    {
                        Dados.Close();
                    }
                }
            }

            if (controle == 2)
            {
                salaNmr.Enabled = true;
                numeroAssentos.Enabled = false;
                salaTipo.Enabled = false;
            }
        }

        private void salaNmr_ValueChanged(object sender, EventArgs e)
        {
            if (controle == 2)
            {
                salaTipo.SelectedIndex = -1;
                numeroAssentos.Value = 1;
                salaTipo.Enabled = true;
                numeroAssentos.Enabled = true;

                Obj_CmdSQL.CommandText = $"SELECT {salaNmr.Value}, tipo, assentos FROM sala WHERE {salaNmr.Value} = numero";
                Obj_CmdSQL.Parameters.Clear();
                Dados = Obj_CmdSQL.ExecuteReader();

                if (Dados.HasRows)
                {
                    try
                    {
                        Dados.Read();
                        salaNmr.Value = Convert.ToDecimal(Dados[0]);
                        salaTipo.SelectedItem = Convert.ToString(Dados[1]);
                        numeroAssentos.Value = Convert.ToInt32(Dados[2]);
                        Dados.Close();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Ocorreu um erro ao obter informações da sala!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    finally
                    {
                        Dados.Close();
                    }
                }
                else
                {
                    salaTipo.Enabled = false;
                    numeroAssentos.Enabled = false;
                }
               
                Dados.Close();
            }
        }
    }
}
