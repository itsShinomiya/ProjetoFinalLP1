using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjetoFinalLP1
{
    public partial class gerenciaFuncionario : Form
    {
        int controle = 0;

        private MySqlConnection Obj_Conn = new MySqlConnection();
        private MySqlCommand Obj_CmdSQL = new MySqlCommand();
        private MySqlDataReader Dados;
        public gerenciaFuncionario()
        {
            InitializeComponent();
        }

        private void refresh()
        {
            try
            {
                string comando = "SELECT nome, cpf, nivel, status FROM usuarios WHERE 1=1";

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
                        buscaExibir.Rows.Add(
                            row["nome"],
                            row["cpf"],
                            row["nivel"],
                            row["status"]
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
            editFuncionario adicionaFuncionario = new editFuncionario(0, "");
            adicionaFuncionario.ShowDialog();
            refresh();
        }

        private void alteraSala_Click(object sender, EventArgs e)
        {
            controle = 1;

            DataGridViewRow selectedRow = buscaExibir.SelectedRows[0];
            string valor = Convert.ToString(selectedRow.Cells["cpf"].Value);
            editFuncionario editaFuncionario = new editFuncionario(controle, valor);
            editaFuncionario.ShowDialog();
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
            string valor = Convert.ToString(selectedRow.Cells["cpf"].Value);
            DialogResult exc = MessageBox.Show("Deseja realmente deletar esse funcionário?", "Excluir?", MessageBoxButtons.YesNo);
            if (exc == DialogResult.Yes)
            {
                try
                {
                    Obj_CmdSQL.CommandText = "DELETE FROM usuarios WHERE cpf = " + valor.ToString();
                    int deletar = Obj_CmdSQL.ExecuteNonQuery();
                    refresh();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Houve um erro ao deletar o funcionário!", "Erro", MessageBoxButtons.OK);
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
            adicionaFuncionario.PerformClick();
        }

        private void buscaExibir_SelectionChanged(object sender, EventArgs e)
        {
            if (buscaExibir.SelectedRows.Count > 0 && buscaExibir.RowCount > 0)
            {
                try
                {
                    string comando = "SELECT nome, cpf, nivel, status, foto FROM usuarios WHERE 1=1";

                    Obj_CmdSQL.Parameters.Clear();
                    Obj_CmdSQL.CommandText = comando;
                    Dados = Obj_CmdSQL.ExecuteReader();
                    byte[] rawData;

                    DataTable dt = new DataTable();
                    dt.Load(Dados);


                    DataGridViewRow selectedRow = buscaExibir.SelectedRows[0];
                    int selectedIndex = buscaExibir.SelectedRows[0].Index;
                    nomeValor.Text = Convert.ToString(selectedRow.Cells["nome"].Value);
                    cpfValor.Text = Convert.ToString(selectedRow.Cells["cpf"].Value);
                    nivelValor.Text = Convert.ToString(selectedRow.Cells["nivel"].Value);
                    statusValor.Text = Convert.ToString(selectedRow.Cells["status"].Value);

                    DataRow selectedDataRow = dt.Rows[selectedIndex];

                    if (!DBNull.Value.Equals(selectedDataRow["foto"]))
                    {
                        rawData = (byte[])selectedDataRow["foto"];
                        MemoryStream Imagem = new MemoryStream(rawData);
                        foto.Image = Image.FromStream(Imagem);
                    }
                    else
                    {
                        foto.Image = null;
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
        }
    }
}
