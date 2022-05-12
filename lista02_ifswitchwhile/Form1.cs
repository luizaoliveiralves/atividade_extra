using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lista02_ifswitchwhile
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btn_senha_Click(object sender, EventArgs e)
        {
            string senha;
            senha = txt_senha.Text;

            if ( senha == "1234")
            {
                MessageBox.Show ("Acesso Permitido");
            }
            else
            {
                MessageBox.Show("Acesso Negado");
            }

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void btn_calcular_Click(object sender, EventArgs e)
        {
            string nome;

            int quantidade;
            //duvida no float
            float valorI, valorF, total;
            

            nome = (txt_nome.Text);

            quantidade = int.Parse(txt_quantidade.Text);

            valorI = float.Parse(txt_valor.Text);

            valorF = quantidade * valorI;


            if (quantidade <= 5)

            {
                //duvida aqui
                total = valorF - (valorF * 2 / 100);

                MessageBox.Show("O seu desconto é de 2%, você tera que pagar: R$" + total);

            }

            else if (quantidade >= 6 && quantidade <= 10)

            {

                total = valorF - (valorF * 3 / 100);

                MessageBox.Show("O seu desconto é de 3%, você tera que pagar: R$" + total);

            }

            else if (quantidade > 10)

            {

                total = valorF - (valorF * 5 / 100);

                MessageBox.Show("O seu desconto é de 5%, você tera que pagar: R$" + total);

            }
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void btn_movimentar_Click(object sender, EventArgs e)
        {
            int conta;

            string nome, metodo;

            float saldo;


            nome = (txt_nome1.Text);

            conta = int.Parse(txt_conta.Text);

            metodo = (txt_metodo.Text);

            saldo = float.Parse(txt_saldo.Text);


            if (metodo == "deposito")

            {


                MessageBox.Show("O seguinte valor foi creditado a sua conta: R$" + saldo);

            }

            else if (metodo == "sacar")

            {

                MessageBox.Show("O seguinte valor foi debitado na sua conta: R$" + saldo);

            }
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            int resultado = 0, aprovacao = 0, valortotal = int.Parse(txt_valor.Text), salario = int.Parse(txt_salario.Text), parcelas = int.Parse(txt_parcelas.Text);

            resultado = valortotal / parcelas;

            aprovacao = salario / resultado;

            

            if (aprovacao <= 0.30)
            {

                MessageBox.Show("aprovado");

            }

            else

            {

                MessageBox.Show("reprovado");

            }


        }

        private void textBox2_TextChanged_1(object sender, EventArgs e)
        {

        }
    }
}
