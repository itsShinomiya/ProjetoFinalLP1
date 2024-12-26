using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
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

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            string strSQL;
            MemoryStream streamFoto = new MemoryStream();
            byte[] rawData;

            if (controle == 0)
            {
                strSQL = "INSERT INTO usuarios(senha, usuario, nivel, nome, cpf, foto, status) VALUES(@Senha, @Usuario, @Nivel, @Nome, @Cpf, @Foto, @Status)";
                Obj_CmdSQL.Parameters.Clear();



                try
                {
                    if (funcionarioFoto != null)
                    {
                        funcionarioFoto.Image.Save(streamFoto, funcionarioFoto.Image.RawFormat);
                        rawData = streamFoto.ToArray();
                    }
                    else 
                    {
                        rawData = null; 
                    }

                    Obj_CmdSQL.CommandText = strSQL;


                    Obj_CmdSQL.Parameters.AddWithValue("@Senha", senhaValor.Text);
                    Obj_CmdSQL.Parameters.AddWithValue("@Usuario", usuarioValor.Text);
                    Obj_CmdSQL.Parameters.AddWithValue("@Nivel", tipoValor.Text);
                    Obj_CmdSQL.Parameters.AddWithValue("@Nome", nomeValor.Text);
                    Obj_CmdSQL.Parameters.AddWithValue("@Cpf", cpfValor.Text);
                    Obj_CmdSQL.Parameters.AddWithValue("@Foto", rawData);
                    Obj_CmdSQL.Parameters.AddWithValue("@Status", statusValor.Text);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Erro: " + ex.Message, "Erro na inclusão de valores!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                finally
                {
                    Dados.Close();
                }
                this.Close();
            }
        }
    }
}
