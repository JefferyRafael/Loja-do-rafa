using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Loja_do_Rafa
{
    public partial class Cargos : Form
    {
        public Cargos()
        {
            InitializeComponent();
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            txtCodigo.Clear();
            txtDescricao.Clear();
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            int codigo;
            string descricao;

            codigo = Convert.ToInt32(txtCodigo.Text);
            descricao = txtDescricao.Text;

            SalvarCargo(codigo, descricao);
        }

        private void SalvarCargo(int codigo, string descricao)
        {
            StreamWriter cargos;
            string caminho = "C:\\sistema1\\CARGOS.txt";

            cargos = File.AppendText(caminho);
            cargos.WriteLine("CÓDIGO: " + codigo);
            cargos.WriteLine("DESCRIÇÃO: " + descricao);
            cargos.Close();
            MessageBox.Show("Cargo salvo com SUCESSO!!");
        }
    }
}
