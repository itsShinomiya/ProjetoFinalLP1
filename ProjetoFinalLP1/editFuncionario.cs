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
        string value = "";

        public editFuncionario(int indice, string valor)
        {
            value = valor;
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

            if (controle == 1)
            {
                Obj_CmdSQL.CommandText = $"SELECT nome, cpf, nivel, status, usuario, senha FROM usuarios WHERE cpf = {value}";
                cpfValor.TextMaskFormat = MaskFormat.ExcludePromptAndLiterals;
                Dados = Obj_CmdSQL.ExecuteReader();

                if (Dados.HasRows)
                {
                    try
                    {
                        Dados.Read();
                        nomeValor.Text = Convert.ToString(Dados[0]);
                        cpfValor.Text = Convert.ToString(Dados[1]);
                        tipoValor.Text = Convert.ToString(Dados[2]);
                        statusValor.Text = Convert.ToString(Dados[3]);
                        usuarioValor.Text = Convert.ToString(Dados[4]);
                        senhaValor.Text = Convert.ToString(Dados[5]);
                        cpfValor.ReadOnly = true;
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
            if (string.IsNullOrWhiteSpace(nomeValor.Text))
            {
                MessageBox.Show("O campo 'Nome' é obrigatório!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            cpfValor.TextMaskFormat = MaskFormat.ExcludePromptAndLiterals;

            if (string.IsNullOrWhiteSpace(cpfValor.Text))
            {
                MessageBox.Show("O campo 'CPF' é obrigatório!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                cpfValor.TextMaskFormat = MaskFormat.IncludePromptAndLiterals; // Restaura a máscara
                return;
            }
            if (Cls_Validacoes.ValidaCPF(cpfValor.Text) == false)
            {
                MessageBox.Show("CPF inválido", "Inválido", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (string.IsNullOrWhiteSpace(tipoValor.Text))
            {
                MessageBox.Show("O campo 'Nível' é obrigatório!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (string.IsNullOrWhiteSpace(usuarioValor.Text))
            {
                MessageBox.Show("O campo 'Usuário' é obrigatório!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (string.IsNullOrWhiteSpace(senhaValor.Text))
            {
                MessageBox.Show("O campo 'Senha' é obrigatório!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (string.IsNullOrWhiteSpace(statusValor.Text))
            {
                MessageBox.Show("O campo 'Status' é obrigatório!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            

            string strSQL;
            MemoryStream streamFoto = new MemoryStream();
            byte[] rawData;

            if (controle == 0)
            {
                strSQL = "INSERT INTO usuarios(senha, usuario, nivel, nome, cpf, foto, status) VALUES(@Senha, @Usuario, @Nivel, @Nome, @Cpf, @Foto, @Status)";
                Obj_CmdSQL.Parameters.Clear();
            }
            else
            {
                strSQL = $"UPDATE usuarios SET senha = @Senha, usuario = @Usuario, nivel = @Nivel, nome = @Nome, cpf = @Cpf, foto = @Foto, status = @Status WHERE cpf = {cpfValor.Text}";
                Obj_CmdSQL.Parameters.Clear();
            }


            try
                {
                    if (funcionarioFoto.Image != null)
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
                    cpfValor.TextMaskFormat = MaskFormat.ExcludePromptAndLiterals;
                    Obj_CmdSQL.Parameters.AddWithValue("@Cpf", cpfValor.Text);
                    cpfValor.TextMaskFormat = MaskFormat.IncludePromptAndLiterals;
                    Obj_CmdSQL.Parameters.AddWithValue("@Foto", rawData);
                    Obj_CmdSQL.Parameters.AddWithValue("@Status", statusValor.Text);

                    Obj_CmdSQL.ExecuteNonQuery();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Erro: " + ex.Message, "Erro na inclusão de valores!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                finally
                {
                    Obj_CmdSQL.Parameters.Clear();
                }
                this.Close();
        }
    }
}
