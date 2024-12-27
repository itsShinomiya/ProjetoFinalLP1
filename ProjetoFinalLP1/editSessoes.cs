﻿using MySql.Data.MySqlClient;
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
    public partial class editSessoes : Form
    {
        int prmClick = 1;
        private MySqlConnection Obj_Conn = new MySqlConnection();
        private MySqlCommand Obj_CmdSQL = new MySqlCommand();
        private MySqlDataReader Dados;

        int controle = 0;

        public editSessoes(int indice)
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

            Obj_CmdSQL.CommandText = "SELECT MAX(codigo) FROM filmes";
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

        }
    }
}