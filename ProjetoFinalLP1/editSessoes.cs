using Google.Protobuf.WellKnownTypes;
using MySql.Data.MySqlClient;
using Mysqlx;
using Org.BouncyCastle.Asn1.Pkcs;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjetoFinalLP1
{
    public partial class editSessoes : Form
    {
        int prmClick = 1;
        private MySqlConnection Obj_Conn = new MySqlConnection();
        private MySqlCommand Obj_CmdSQL = new MySqlCommand();
        private MySqlDataReader Dados;

        int controle;
        int codeFilme = 0;
        int codeSala = 0;
        int codigo;

        public editSessoes(int indice, int indiceSessao)
        {
            controle = indice;
            codigo = indiceSessao;
            InitializeComponent();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        void load()
        {
            Obj_CmdSQL.CommandText = "SELECT nome, banner FROM filmes WHERE 1 = 1";
            Dados = Obj_CmdSQL.ExecuteReader();

            if (Dados.HasRows)
            {
                DataTable dt = new DataTable();
                dt.Load(Dados);

                foreach (DataRow row in dt.Rows)
                {
                    nomeFilmeValor.Items.Add(row["nome"]);
                }
            }

            Obj_CmdSQL.Parameters.Clear();
            Obj_CmdSQL.CommandText = "SELECT MAX(numero) FROM sala";
            Dados = Obj_CmdSQL.ExecuteReader();
            try
            {
                Dados.Read();
                numeroSala.Maximum = Convert.ToInt32(Dados[0]);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Não foi possível obter as salas! Verifique a parte de salas! \n Erro:" + ex, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                Dados.Close();
            }
        }
        private void editSala_Load(object sender, EventArgs e)
        {
            try
            {
                Obj_Conn.ConnectionString = "Server=sql10.freesqldatabase.com;Database=sql10753597;User=sql10753597;Pwd=xaCHSSHFwZ;";
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
                Obj_CmdSQL.CommandText = "SELECT MAX(codigo) FROM sessoes";
                Dados = Obj_CmdSQL.ExecuteReader();

                if (Dados.HasRows)
                {
                    try
                    {
                        Dados.Read();
                        sessaoNmr.Value = Convert.ToInt32(Dados[0]) + 1;
                    }
                    catch (Exception ex)
                    {
                        sessaoNmr.Value = 1;
                    }
                    finally
                    {
                        Dados.Close();
                        atualizaTipoIngresso();
                    }
                }

            }

            load();
            Dados.Close();

            if (controle == 1)
            {
                string strSQL = "SELECT codigo, filme, sala, ingressos, dia, horario, preco FROM sessoes WHERE codigo = @codigo";
                Obj_CmdSQL.Parameters.Clear();
                Obj_CmdSQL.CommandText = strSQL;
                Obj_CmdSQL.Parameters.AddWithValue("@codigo", codigo);


                try
                {

                    Dados = Obj_CmdSQL.ExecuteReader();
                    if (Dados.HasRows)
                    {
                        DataTable dt = new DataTable();
                        dt.Load(Dados);

                        foreach (DataRow row in dt.Rows)
                        {
                            sessaoNmr.Value = Convert.ToInt32(row["codigo"]);
                            nomeFilmeValor.SelectedIndex = Convert.ToInt32(row["filme"]) - 1;
                            numeroSala.Value = Convert.ToInt32(row["sala"]);
                            ingressosQtd.Value = Convert.ToInt32(row["ingressos"]);
                            diaFilme.Text = Convert.ToString(row["dia"]);
                            TimeSpan horario = (TimeSpan)row["horario"];
                            horarioValor.SelectedItem = horario.ToString(@"hh\:mm");
                            valorNumero.Value = Convert.ToDecimal(row["preco"]);
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Ocorreu um erro ao obter informações da sessão! Erro: " + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                finally
                {
                    if (Dados != null && !Dados.IsClosed)
                    {
                        Dados.Close();
                    }
                }
            
            } 
        }


        private void salaNmr_ValueChanged(object sender, EventArgs e)
        {
            atualizaTipoIngresso();
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

        private void salaTipo_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        void atualizaTipoIngresso()
        {
            Dados.Close();
            Obj_CmdSQL.Parameters.Clear();
            string strSQL = $"SELECT tipo, assentos FROM sala WHERE numero = {numeroSala.Value}";
            Obj_CmdSQL.CommandText = strSQL;
            try
            {
                Dados = Obj_CmdSQL.ExecuteReader();
                Dados.Read();
                salaTipo.Text = Dados["tipo"].ToString();
                ingressosQtd.Maximum = Convert.ToInt32(Dados["assentos"]);
                ingressosQtd.Value = Convert.ToInt32(Dados["assentos"]);
                ingressosQtd.Enabled = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro:" + ex);
            }
            finally
            {
                Dados.Close();
            }
        }

        private void numeroSala_ValueChanged(object sender, EventArgs e)
        {
            atualizaTipoIngresso();
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            
            
            Obj_CmdSQL.Parameters.Clear();

            try
            {
                getCodeFilme();
                if (controle == 0)
                {
                    Obj_CmdSQL.CommandText = "Insert INTO sessoes(codigo, filme, sala, ingressos, preco, dia, horario) VALUES(@Codigo, @Filme, @Sala, @Ingressos, @Preço, @Dia, @Horario)";
                }
                else if (controle == 1)
                {
                    Obj_CmdSQL.CommandText = $"UPDATE sessoes SET codigo = @Codigo, filme = @Filme, sala = @Sala, ingressos = @Ingressos, preco = @Preço, dia = @Dia, horario = @Horario WHERE codigo = @CodigoAtual";
                    Obj_CmdSQL.Parameters.AddWithValue("@CodigoAtual", sessaoNmr.Value);
                }


                Obj_CmdSQL.Parameters.AddWithValue("@Codigo", Convert.ToInt32(sessaoNmr.Value));
                Obj_CmdSQL.Parameters.AddWithValue("@Filme", Convert.ToInt32(codeFilme));
                Obj_CmdSQL.Parameters.AddWithValue("@Sala", Convert.ToInt32(numeroSala.Value));
                Obj_CmdSQL.Parameters.AddWithValue("@Ingressos", Convert.ToInt32(ingressosQtd.Value));
                Obj_CmdSQL.Parameters.AddWithValue("@Preço", Convert.ToDecimal(valorNumero.Value));
                string Dia = diaFilme.Value.ToString("yyyy-MM-dd");
                Obj_CmdSQL.Parameters.AddWithValue("@Dia", Dia);
                Obj_CmdSQL.Parameters.AddWithValue("@Horario", Convert.ToString(horarioValor.SelectedItem));
                
                Obj_CmdSQL.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro: " + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                Obj_CmdSQL.Parameters.Clear();
            }
            this.Close();
        }

        private void nomeFilmeValor_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (nomeFilmeValor.SelectedIndex == -1)
                return;

            Obj_CmdSQL.Parameters.Clear();
            Obj_CmdSQL.CommandText = "SELECT banner FROM filmes WHERE nome = @Nome";
            Obj_CmdSQL.Parameters.AddWithValue("@Nome", nomeFilmeValor.SelectedItem.ToString());
            Dados = Obj_CmdSQL.ExecuteReader();
            try
            {
                if (Dados.Read())
                {
                    if (!Dados.IsDBNull(Dados.GetOrdinal("banner")))
                    {
                        byte[] rawData = (byte[])Dados["banner"];
                        using (MemoryStream imagemStream = new MemoryStream(rawData))
                        {
                            bannerImagem.Image = Image.FromStream(imagemStream);
                        }
                    }
                    else
                    {
                        bannerImagem.Image = null; 
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro: " + ex.Message, "Erro!",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                Dados.Close();
            }
        }
        
        void getCodeFilme()
        {
            try
            {
                Obj_CmdSQL.CommandText = "SELECT codigo FROM filmes WHERE nome = @Nome";
                Obj_CmdSQL.Parameters.Clear();
                Obj_CmdSQL.Parameters.AddWithValue("@Nome", Convert.ToString(nomeFilmeValor.SelectedItem));

                using (Dados = Obj_CmdSQL.ExecuteReader())
                {
                    if (Dados.Read())
                    {
                        codeFilme = Convert.ToInt32(Dados["codigo"]);
                    }
                    else
                    {
                        MessageBox.Show("Filme não encontrado.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro: " + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
