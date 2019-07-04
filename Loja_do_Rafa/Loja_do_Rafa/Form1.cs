using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Loja_do_Rafa
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Setores frm = new Setores();
            frm.ShowDialog();
        }

        private void btnClientes_Click(object sender, EventArgs e)
        {
            Cliente frm = new Cliente();
            frm.ShowDialog();
        }

        private void btnFuncionarios_Click(object sender, EventArgs e)
        {
            Funcionario frm = new Funcionario();
            frm.ShowDialog();
        }

        private void btnProdutos_Click(object sender, EventArgs e)
        {
            Produtos frm = new Produtos();
            frm.ShowDialog();
        }

        private void btnCargos_Click(object sender, EventArgs e)
        {
            Cargos frm = new Cargos();
            frm.ShowDialog();
        }

        private void btnAjuda_Click(object sender, EventArgs e)
        {
            Ajuda frm = new Ajuda();
            frm.ShowDialog();
        }
    }
}
