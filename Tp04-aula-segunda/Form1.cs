using System;
using Tp04_aula_segunda;
namespace Calculo_Pagamento

{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {

            Funcionario calculo = new Funcionario();

            calculo.CPF = txtCpf.Text;
            calculo.Nome = txtNome.Text;
            calculo.Valor = Convert.ToDouble(txtValor.Text);
            calculo.Horas = Convert.ToDouble(txtHoras.Text);

            calculo.CalcularSalario();

            txtSalario.Text = calculo.Salario.ToString("F2");
        }
    }
}