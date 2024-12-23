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
        public gerenciaSala()
        {
            InitializeComponent();
        }

        private void adicionaSala_Click(object sender, EventArgs e)
        {
            controle = 0;
            editSala adicionaSala = new editSala(controle);
            adicionaSala.ShowDialog();
        }

        private void alteraSala_Click(object sender, EventArgs e)
        {
            controle = 1;
            editSala alteraSala = new editSala(controle);
            alteraSala.ShowDialog();
        }
    }
}
