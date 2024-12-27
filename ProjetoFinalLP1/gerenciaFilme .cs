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
    public partial class gerenciaFilme : Form
    {
        int controle = 0;

        private MySqlConnection Obj_Conn = new MySqlConnection();
        private MySqlCommand Obj_CmdSQL = new MySqlCommand();
        private MySqlDataReader Dados;
        public gerenciaFilme()
        {
            InitializeComponent();
        }

        private void refresh()
        {
            try
            {
                string comando = "SELECT codigo, nome, descricao, banner FROM filmes WHERE 1=1";

                Obj_CmdSQL.Parameters.Clear();
                Obj_CmdSQL.CommandText = comando;
                Dados = Obj_CmdSQL.ExecuteReader();
                byte[] rawData;

                if (Dados.HasRows)
                {
                    DataTable dt = new DataTable();
                    dt.Load(Dados);

                    buscaExibir.Rows.Clear();
                    foreach (DataRow row in dt.Rows)
                    {
                        buscaExibir.Rows.Add(
                            row["codigo"],
                            row["nome"],
                            row["descricao"]
                        );
                    }

                    DataGridViewRow selectedRow = buscaExibir.SelectedRows[0];
                    int selectedIndex = buscaExibir.SelectedRows[0].Index;
                    codeValor.Text = Convert.ToString(selectedRow.Cells["codigo"].Value);
                    nomeValor.Text = Convert.ToString(selectedRow.Cells["nome"].Value);
                    descricaoValor.Text = Convert.ToString(selectedRow.Cells["descricao"].Value);

                    DataRow selectedDataRow = dt.Rows[selectedIndex];

                    if (!DBNull.Value.Equals(selectedDataRow["banner"]))
                    {
                        rawData = (byte[])selectedDataRow["banner"];
                        MemoryStream Imagem = new MemoryStream(rawData);
                        banner.Image = Image.FromStream(Imagem);
                    }
                    else
                    {
                        banner.Image = null;
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
            editFilme adicionaFilme = new editFilme(0, 0);
            adicionaFilme.ShowDialog();
            refresh();
        }

        private void alteraSala_Click(object sender, EventArgs e)
        {
            DataGridViewRow selectedRow = buscaExibir.SelectedRows[0];
            editFilme adicionaFilme = new editFilme(1, Convert.ToInt32(selectedRow.Cells["codigo"].Value));
            adicionaFilme.ShowDialog();
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

            refresh();


        }

        private void atualizaBtn_Click(object sender, EventArgs e)
        {
            refresh();
        }

        private void removeSala_Click(object sender, EventArgs e)
        {
            DataGridViewRow selectedRow = buscaExibir.SelectedRows[0];
            int valor = Convert.ToInt32(selectedRow.Cells["numero"].Value);
            DialogResult exc = MessageBox.Show("Deseja realmente deletar essa sala?", "Excluir?", MessageBoxButtons.YesNo);
            if (exc == DialogResult.Yes)
            {
                try
                {
                    Obj_CmdSQL.CommandText = "DELETE FROM sala WHERE numero = " + valor.ToString();
                    int deletar = Obj_CmdSQL.ExecuteNonQuery();
                    refresh();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Houve um erro a deletar a sala!", "Erro", MessageBoxButtons.OK);
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
        private void alterarStrip_Click(object sender, EventArgs e)
        {
               controle = 2;

               //DataGridViewRow selectedRow = buscaExibir.SelectedRows[0];
               //int valor = Convert.ToInt32(selectedRow.Cells["numero"].Value);

               editFilme adicionaFilme = new editFilme(2, 0);
               adicionaFilme.ShowDialog();
               refresh();          
        }
    }
}
