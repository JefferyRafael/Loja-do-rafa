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
    public partial class Produtos : Form
    {
        public Produtos()
        {
            InitializeComponent();
        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void Produtos_Load(object sender, EventArgs e)
        {

        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            txtCodigo.Clear();
            txtNome.Clear();
            txtLucro.Clear();
            txtPrecoVenda.Clear();
            txtPrecoCusto.Clear();
            txtCodigoBarras.Clear();
            cbxCategoria.SelectedIndex = -1;
            cbxMarca.SelectedIndex = -1;
            cbxUnidadeMedida.SelectedIndex = -1;
            cbxOrigem.SelectedIndex = -1;
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            string nome, codigo, barras, custo, venda, lucroporcent, unidamedida, origem, marca, categoria;

            nome = txtNome.Text;
            codigo = txtCodigo.Text;
            barras = txtCodigoBarras.Text;
            custo = txtPrecoCusto.Text;
            venda = txtPrecoVenda.Text;
            lucroporcent = txtLucro.Text;
            unidamedida = cbxUnidadeMedida.Items[cbxUnidadeMedida.SelectedIndex].ToString();
            origem = cbxOrigem.Items[cbxOrigem.SelectedIndex].ToString();
            marca = cbxMarca.Items[cbxMarca.SelectedIndex].ToString();
            categoria = cbxCategoria.Items[cbxCategoria.SelectedIndex].ToString();

            SalvarProdutos(codigo, nome, barras, custo, venda, lucroporcent, unidamedida, origem, marca, categoria);
        }

        private void SalvarProdutos(string codigo, string nome, string barras, string custo, string venda, string lucroporcent, string unidamedida, string origem, string marca, string categoria)
        {
            StreamWriter produtos;
            string caminho = "C:\\sistema1\\PRODUTOS.txt";

            produtos = File.AppendText(caminho);
            produtos.WriteLine("Código: " + codigo);
            produtos.WriteLine("Nome: " + nome);
            produtos.WriteLine("Código de barras: " + barras);
            produtos.WriteLine("Preço de custo: " + custo);
            produtos.WriteLine("Preço de venda: " + venda);
            produtos.WriteLine("Lucro%: " + lucroporcent);
            produtos.WriteLine("Unidade de Medida: " + unidamedida);
            produtos.WriteLine("Origem do Produto: " + origem);
            produtos.WriteLine("Marca: " + marca);
            produtos.WriteLine("Categoria: " + categoria);
            produtos.Close();
            MessageBox.Show("Produto salvo com SUCESSO!!");
        }
    }
}
