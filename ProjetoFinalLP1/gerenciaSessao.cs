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
    public partial class gerenciaSessao : Form
    {
        int controle = 0;

        private MySqlConnection Obj_Conn = new MySqlConnection();
        private MySqlCommand Obj_CmdSQL = new MySqlCommand();
        private MySqlDataReader Dados;
        public gerenciaSessao()
        {
            InitializeComponent();
        }

        private void refresh()
        {
            try
            {
                string comando = "SELECT codigo, filme, sala, ingressos, preco, dia, horario FROM sessoes WHERE 1=1";

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
                            row["codigo"],
                            row["filme"],
                            row["sala"],
                            row["dia"],
                            row["horario"],
                            row["ingressos"],
                            row["preco"]
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
            DialogResult exc = MessageBox.Show("Deseja realmente excluir essa sessão?", "Excluir?", MessageBoxButtons.YesNo);
            if (exc == DialogResult.Yes)
            {
                try
                {
                    Obj_CmdSQL.CommandText = "DELETE FROM usuarios WHERE cpf = " + valor;
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

            editSessoes adicionaSessao = new editSessoes(2, -1);
            adicionaSessao.ShowDialog();
            refresh();
        }
    }
}
