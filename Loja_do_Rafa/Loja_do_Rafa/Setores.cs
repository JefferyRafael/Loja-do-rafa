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
    public partial class Setores : Form
    {
        public Setores()
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
            StreamWriter setores;
            string caminho = "C:\\sistema1\\SETOR.txt";
            setores = File.AppendText(caminho);
            setores.WriteLine();
            setores.WriteLine("Código: " + codigo);
            setores.WriteLine("Descrição: " + descricao);
            setores.Close();
            MessageBox.Show("Setor salvo com SUCESSO!!");
        }
    }
}
