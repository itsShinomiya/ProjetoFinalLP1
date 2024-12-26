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
    public partial class editFilme : Form
    {
        int prmClick = 1;
        private MySqlConnection Obj_Conn = new MySqlConnection();
        private MySqlCommand Obj_CmdSQL = new MySqlCommand();
        private MySqlDataReader Dados;

        int controle = 0;
        int value = 0;

        public editFilme(int indice, int valor)
        {
            controle = indice;
            value = valor;
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

            if (controle == 0 || controle == 2) 
            {
                Obj_CmdSQL.CommandText = "SELECT MAX(codigo) FROM filmes";
            }
            else
            {
                Obj_CmdSQL.CommandText = $"SELECT codigo, nome, descricao, banner FROM filmes WHERE @Codigo = codigo";
                Obj_CmdSQL.Parameters.AddWithValue("@Codigo", Convert.ToInt32(value));
            }
            Dados = Obj_CmdSQL.ExecuteReader();

            if (Dados.HasRows)
            {
                if (controle == 0)
                {
                    try
                    {
                        Dados.Read();
                        filmeNmr.Value = Convert.ToInt32(Dados[0]) + 1;
                    }
                    catch (Exception ex)
                    {
                        filmeNmr.Value = 1;
                    }
                    finally
                    {
                        Dados.Close();
                    }
                }
                if (controle == 1)
                {
                    byte[] rawData;
                    try
                    {
                        Dados.Read();
                        filmeNmr.Value = Convert.ToDecimal(Dados[0]);
                        filmeNomeValor.Text = Convert.ToString(Dados[1]);
                        descricaoTexto.Text = Convert.ToString(Dados[2]);
                        if (!Dados.IsDBNull(Dados.GetOrdinal("banner")))
                        {
                            rawData = (byte[])Dados["banner"];
                            MemoryStream Imagem = new MemoryStream(rawData);
                            bannerImagem.Image = Image.FromStream(Imagem);
                        }
                        else
                        {
                            bannerImagem.Image = null;
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Ocorreu um erro:" + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    finally
                    {
                        Dados.Close();
                    }
                }
                if (controle == 2)
                {                 
                    try
                    {
                        Dados.Read();
                        filmeNmr.Maximum = Convert.ToInt32(Dados[0]);
                        filmeNmr.Enabled = true;
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Ocorreu um erro:" + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    finally
                    {
                        Dados.Close();
                    }
                }
            }   
        }

        private void descricaoTexto_Click(object sender, EventArgs e)
        {
            if (prmClick == 1)
            {
                descricaoTexto.Text = "";
            }
            prmClick = 0;
        }

        private void carregarImagem_Click(object sender, EventArgs e)
        {
            if (carregaImagem.ShowDialog() == DialogResult.OK) 
            {
                bannerImagem.Load(carregaImagem.FileName);
            }
        }

        private void removeImagem_Click(object sender, EventArgs e)
        {
            bannerImagem.Image = null;
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            string strSQL;
            if (controle == 0)
            {
                strSQL = "INSERT INTO filmes(codigo, nome, descricao, banner)  VALUES(@Codigo, @Nome, @Descricao, @Banner)";
            }
            else
            {
                strSQL = "UPDATE filmes SET codigo = @Codigo, descricao = @Descricao, banner = @Banner WHERE codigo = @Codigo";
            }
            MemoryStream streamBanner = new MemoryStream();
            byte[] rawData;

            Obj_CmdSQL.Parameters.Clear();

            try
            {
                if (bannerImagem.Image != null)
                {
                    bannerImagem.Image.Save(streamBanner, bannerImagem.Image.RawFormat);
                    rawData = streamBanner.ToArray();
                }
                else
                {
                    rawData = null;
                }

                Obj_CmdSQL.CommandText = strSQL;

                Obj_CmdSQL.Parameters.AddWithValue("@Codigo", Convert.ToInt32(filmeNmr.Value));
                Obj_CmdSQL.Parameters.AddWithValue("@Nome", Convert.ToString(filmeNomeValor.Text));
                Obj_CmdSQL.Parameters.AddWithValue("@Descricao", Convert.ToString(descricaoTexto.Text));
                Obj_CmdSQL.Parameters.AddWithValue("@Banner", rawData);

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
}
