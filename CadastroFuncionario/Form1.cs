using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlTypes;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CadastroFuncionario
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            string salariofim = salariofim_tx.Text;
            salariofim = "";
            string irpf = irpf_txt.Text;
            irpf = "";
           
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void cadastrar_tx_Click(object sender, EventArgs e)
        {
            
            //botão cadastrar
            int matricula = Convert.ToInt32(matricula_tx.Text);
            string nome = matricula_tx.Text;
            string cpf = cpf_txt.Text;
            double salario = Convert.ToDouble(salario1_tx.Text);
            string funcao = funcao_tx.Text;

            Funcionario f = new Funcionario(salario, funcao);
            MessageBox.Show(f.CalcularSalario(salario, funcao).ToString());


        }

        private void cancelar_tx_Click(object sender, EventArgs e)
        { 

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void salario_txt_TextChanged(object sender, EventArgs e)
        {

        }

        private void funcao_tx_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
