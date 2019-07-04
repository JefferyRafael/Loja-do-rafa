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
    public partial class Funcionario : Form
    {
        public Funcionario()
        {
            InitializeComponent();
        }

        private void Funcionario_Load(object sender, EventArgs e)
        {

        }

        private void mtxtCelular_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void label17_Click(object sender, EventArgs e)
        {

        }

        private void label16_Click(object sender, EventArgs e)
        {

        }

        private void label15_Click(object sender, EventArgs e)
        {

        }

        private void cbxSetor_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label14_Click(object sender, EventArgs e)
        {

        }

        private void cbxDemissao_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label13_Click(object sender, EventArgs e)
        {

        }

        private void label12_Click(object sender, EventArgs e)
        {

        }

        private void mtxtNascimento_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void label18_Click(object sender, EventArgs e)
        {

        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            txtNome.Clear();
            txtExtra.Clear();
            txtEndereco.Clear();
            txtEmail.Clear();
            txtCPF.Clear();
            txtContato.Clear();
            txtCodigo.Clear();
            txtCidade.Clear();
            txtCEP.Clear();
            txtBairro.Clear();
            txtRegistro.Clear();
            txtRG.Clear();
            txtSalario.Clear();
            txtSite.Clear();
            mtxtCelular.Clear();
            mtxtNascimento.Clear();
            mtxtTelefone.Clear();
            cbAtivo.Checked = false;
            cbxCargo.SelectedIndex = -1;
            cbxEstado.SelectedIndex = -1;
            cbxSetor.SelectedIndex = -1;
            cbxAdmissao.SelectedIndex = -1;
            cbxDemissao.SelectedIndex = -1;
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            string codigo, registro, nome, ativo, nascimento, cpf, rg, salario, admissao, demissao, extra, cargo, setor, endereco, bairro, cidade, estado, cep, telefone, celular, contato, email, site;

            codigo = txtCodigo.Text;
            registro = txtRegistro.Text;
            nome = txtNome.Text;
            nascimento = mtxtNascimento.Text;
            cpf = txtCPF.Text;
            rg = txtRG.Text;
            salario = txtSalario.Text;
            admissao = cbxAdmissao.Text;
            demissao = cbxDemissao.Text;
            extra = txtExtra.Text;
            cargo = cbxCargo.Items[cbxCargo.SelectedIndex].ToString();
            setor = cbxSetor.Items[cbxSetor.SelectedIndex].ToString();
            endereco = txtEndereco.Text;
            bairro = txtBairro.Text;
            cidade = txtCidade.Text;
            estado = cbxEstado.Items[cbxEstado.SelectedIndex].ToString();
            cep = txtCEP.Text;
            telefone = mtxtTelefone.Text;
            celular = mtxtCelular.Text;
            contato = txtContato.Text;
            email = txtEmail.Text;
            site = txtSite.Text;

            if (cbAtivo.Checked == true)
            {
                ativo = "ATIVO";
            }
            else
            {
                ativo = "Não é ATIVO";
            }

            SalvarFuncionario(codigo, registro, nome, nascimento, admissao, demissao, cpf, rg, salario, extra, cargo, setor, endereco, bairro, cidade, email, telefone, celular, contato, ativo, site, estado, cep);

        }

        private void SalvarFuncionario(string codigo, string registro, string nome, string nascimento, string admissao, string demissao, string cpf, string rg, string salario, string extra, string cargo, string setor, string endereco, string bairro, string cidade, string email, string telefone, string celular, string contato, string ativo, string site, string estado, string cep)
        {
            StreamWriter Funcionarios;
            string caminho = "C:\\sistema1\\FUNCIONARIOS.txt";

            Funcionarios = File.AppendText(caminho);
            Funcionarios.WriteLine("Código: " + codigo);
            Funcionarios.WriteLine("Número de registro: " + registro);
            Funcionarios.WriteLine("Nome: " + nome);
            Funcionarios.WriteLine("Nascimento: " + nascimento);
            Funcionarios.WriteLine("CPF: " + cpf);
            Funcionarios.WriteLine("RG: " + rg);
            Funcionarios.WriteLine("Salário: " + salario);
            Funcionarios.WriteLine("Extra: " + extra);
            Funcionarios.WriteLine("Admissão: " + admissao);
            Funcionarios.WriteLine("Demissão: " + demissao);
            Funcionarios.WriteLine("Cargo: " + cargo);
            Funcionarios.WriteLine("Setor: " + setor);
            Funcionarios.WriteLine("Endereço: " + endereco);
            Funcionarios.WriteLine("Bairro: " + bairro);
            Funcionarios.WriteLine("Cidade: " + cidade);
            Funcionarios.WriteLine("Estado: " + estado);
            Funcionarios.WriteLine("CEP: " + cep);
            Funcionarios.WriteLine("Telefone: " + telefone);
            Funcionarios.WriteLine("Celular: " + celular);
            Funcionarios.WriteLine("E-mail: " + email);
            Funcionarios.WriteLine("Site: " + site);
            Funcionarios.WriteLine("Contato: " + contato);
            Funcionarios.WriteLine("Ativo: " + ativo);
            Funcionarios.Close();
            MessageBox.Show("Funcionarios salvo com SUCESSO!!");
        }
    }
}
