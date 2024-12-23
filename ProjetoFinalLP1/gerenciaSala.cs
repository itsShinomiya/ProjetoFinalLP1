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
    public partial class gerenciaSala : Form
    {
        int controle = 0;

        private MySqlConnection Obj_Conn = new MySqlConnection();
        private MySqlCommand Obj_CmdSQL = new MySqlCommand();
        private MySqlDataReader Dados;
        public gerenciaSala()
        {
            InitializeComponent();
        }

        private void refresh()
        {
            try
            {
                string comando = "SELECT numero, assentos, tipo FROM sala WHERE 1=1";

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
                            row["numero"],
                            row["tipo"],
                            row["assentos"]
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
            editSala adicionaSala = new editSala(controle, -1);
            adicionaSala.ShowDialog();
            refresh();
        }

        private void alteraSala_Click(object sender, EventArgs e)
        {
            controle = 1;

            DataGridViewRow selectedRow = buscaExibir.SelectedRows[0];
            int valor = Convert.ToInt32(selectedRow.Cells["numero"].Value);

            editSala alteraSala = new editSala(controle, valor);
            alteraSala.ShowDialog();
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
    }
}
