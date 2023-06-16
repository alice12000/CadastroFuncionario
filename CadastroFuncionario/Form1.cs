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
            double salariofim = Convert.ToDouble(salariofim_tx.Text);
            double salario = Convert.ToDouble(salario_txt.Text);
            string funcao = funcao_tx.Text;
            double irpf;
     
            if (funcao == "MEDICO")
            {
                salario = salario * (20 / 100);
            }
            
            else if (funcao == "TI")
            {
                salario = salario + 5.600;
            }

            else if (funcao == "ADM")
            {
                salario = salario * (15 / 100) + 200;

            }

            if (salario > 5000)
            {
                irpf = salariofim * (17 / 100);
                salariofim = salariofim - irpf;
            }

            else
            {
                irpf = 0;
                salariofim = salario;
            }

            salariofim = Convert.ToDouble(salariofim_tx.Text);
            MessageBox.Show(salariofim.ToString());

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
    }
}
