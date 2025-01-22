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
    public partial class gerenciaSessao : Form
    {
        int controle = 0;

        private MySqlConnection Obj_Conn = new MySqlConnection();
        private MySqlCommand Obj_CmdSQL = new MySqlCommand();
        private MySqlDataReader Dados;

        int lvl;
        public gerenciaSessao(int nivel)
        {
            lvl = nivel;
            InitializeComponent();
        }

        private void refresh()
        {
            try
            {
                string comando = "SELECT codigo, filme, sala, ingressos, dia, horario, preco FROM sessoes WHERE 1=1";

                Obj_CmdSQL.Parameters.Clear();
                Obj_CmdSQL.CommandText = comando;
                Dados = Obj_CmdSQL.ExecuteReader();

                if (Dados.HasRows)
                {
                    DataTable dt = new DataTable();
                    dt.Load(Dados);


                    buscaExibir.Rows.Clear();
                    foreach (DataRow row in dt.Rows)
                    {

                        string precoFormatado = Convert.ToDecimal(row["preco"]).ToString("C2", new System.Globalization.CultureInfo("pt-BR"));
                        string nomeFilme = getNomeFilme(Convert.ToInt32(row["filme"]));
                        string diaFormatado = ((DateTime)row["dia"]).ToString("dd/MM/yyyy");
                        string tipoSala = getTipoSala(Convert.ToInt32(row["sala"]));
                        if (string.IsNullOrEmpty(nomeFilme))
                        {
                            nomeFilme = "Desconhecido";
                        }
                        buscaExibir.Rows.Add(
                            row["codigo"],
                            nomeFilme,
                            row["sala"],
                            tipoSala,
                            diaFormatado,
                            row["horario"],
                            row["ingressos"],
                            precoFormatado
                        );
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro: " + ex.Message, "Erro de Conexão", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                Dados.Close();
            }
        }

        private void adicionaSala_Click(object sender, EventArgs e)
        {
            controle = 0;
            editSessoes adicionaSessao = new editSessoes(0, -1);
            adicionaSessao.ShowDialog();
            refresh();
        }

        private void alteraSala_Click(object sender, EventArgs e)
        {
            controle = 1;
            DataGridViewRow selectedRow = buscaExibir.SelectedRows[0];
            int selectedIndex = buscaExibir.SelectedRows[0].Index;
            editSessoes adicionaSessao = new editSessoes(1, Convert.ToInt32(selectedRow.Cells["codigo"].Value));
            adicionaSessao.ShowDialog();
            refresh();
        }

        private void gerenciaSala_Load(object sender, EventArgs e)
        {
            try
            {
                Obj_Conn.ConnectionString = "Server=sql10.freesqldatabase.com;Database=sql10753597;User=sql10753597;Pwd=xaCHSSHFwZ";
                Obj_Conn.Open();
                Obj_CmdSQL.Connection = Obj_Conn;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro: " + ex.Message, "Erro de Conexão", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            if(lvl == 2)
            {
                alteraSala.Enabled = false;
                removeSala.Enabled = false;
            }
            else if(lvl == 1)
            {
                removeSala.Enabled = false;
            }

            refresh();
        }

        private void atualizaBtn_Click(object sender, EventArgs e)
        {
            refresh();
        }

        private void removeSala_Click(object sender, EventArgs e)
        {
            DataGridViewRow selectedRow = buscaExibir.SelectedRows[0];
            string valor = Convert.ToString(selectedRow.Cells["codigo"].Value);
            DialogResult exc = MessageBox.Show("Deseja realmente excluir essa sessão?", "Excluir?", MessageBoxButtons.YesNo);
            if (exc == DialogResult.Yes)
            {
                try
                {
                    Obj_CmdSQL.CommandText = "DELETE FROM sessoes WHERE codigo = " + valor;
                    int deletar = Obj_CmdSQL.ExecuteNonQuery();
                    refresh();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Houve um erro a deletar a sessão!", "Erro", MessageBoxButtons.OK);
                }
            }
            else if (exc == DialogResult.No)
            {

            }
        }

        private void sairToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void adicionarStrip_Click(object sender, EventArgs e)
        {
            adicionaSala.PerformClick();
        }

        private string getNomeFilme(int codigo) 
        {
            string nome = string.Empty;
            try
            {
                Obj_CmdSQL.CommandText = "SELECT nome FROM filmes WHERE codigo = @CodigoAtual";
                Obj_CmdSQL.Parameters.Clear();
                Obj_CmdSQL.Parameters.AddWithValue("@CodigoAtual", Convert.ToString(codigo));

                using (Dados = Obj_CmdSQL.ExecuteReader())
                {
                    if (Dados.Read())
                    {
                        nome = Convert.ToString(Dados["Nome"]);
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
                this.Close();
            }
            return nome;
        }

        private string getTipoSala(int codigo) 
        {
            string tipo = string.Empty;
            try
            {
                Obj_CmdSQL.CommandText = "SELECT tipo FROM sala WHERE numero = @CodigoAtual";
                Obj_CmdSQL.Parameters.Clear();
                Obj_CmdSQL.Parameters.AddWithValue("@CodigoAtual", Convert.ToString(codigo));

                using (Dados = Obj_CmdSQL.ExecuteReader())
                {
                    if (Dados.Read())
                    {
                        tipo = Convert.ToString(Dados["Tipo"]);
                    }
                    else
                    {
                        MessageBox.Show("Sala não encontrada.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro: " + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.Close();
            }
            return tipo;
        }

        private void buscaExibir_SelectionChanged(object sender, EventArgs e)
        {
            if (buscaExibir.SelectedRows.Count > 0)
            {
                DataGridViewRow selectedRow = buscaExibir.SelectedRows[0];

                codeValor.Text = selectedRow.Cells["codigo"].Value.ToString();
                nomeValor.Text = selectedRow.Cells["filme"].Value.ToString();
                salaValor.Text = selectedRow.Cells["sala"].Value.ToString();
                ingressosValor.Text = selectedRow.Cells["ingressos"].Value.ToString();
                diaValor.Text = selectedRow.Cells["dia"].Value.ToString();
                horarioValor.Text = selectedRow.Cells["horario"].Value.ToString();
                valorValor.Text = selectedRow.Cells["preço"].Value.ToString();
                tipoValor.Text = selectedRow.Cells["tipoSala"].Value.ToString();

                string comando = "SELECT banner FROM filmes WHERE nome = @Nome";
                Obj_CmdSQL.Parameters.Clear();
                Obj_CmdSQL.CommandText = comando;
                Obj_CmdSQL.Parameters.AddWithValue("@Nome", nomeValor.Text);
                try
                {
                    Dados = Obj_CmdSQL.ExecuteReader();
                    Dados.Read();
                    byte[] rawData;
                    if (!DBNull.Value.Equals(Dados[0]))
                    {
                        rawData = (byte[])Dados[0];
                        MemoryStream Imagem = new MemoryStream(rawData);
                        banner.Image = Image.FromStream(Imagem);
                    }
                    else
                    {
                        banner.Image = null;
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Erro: " + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                finally
                {
                    Dados.Close();
                }
            }
        }

        private void nomeTxt_Click(object sender, EventArgs e)
        {

        }
    }
}
