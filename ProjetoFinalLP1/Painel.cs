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
    public partial class Painel : Form
    {
        public Painel()
        {
            InitializeComponent();
        }

        private void sairToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void gerenciaSalas_Click(object sender, EventArgs e)
        {
            gerenciaSala gerenciarSala = new gerenciaSala();
            gerenciarSala.ShowDialog();
        }

        private void gerenciaFuncionario_Click(object sender, EventArgs e)
        {
            gerenciaFuncionario gerenciarFuncionario = new gerenciaFuncionario();
            gerenciarFuncionario.ShowDialog();
        }

        private void gerenciaFilme_Click(object sender, EventArgs e)
        {
            gerenciaFilme gerencialFilme = new gerenciaFilme();
            gerencialFilme.ShowDialog();
        }
    }
}
