using System;
using System.Windows.Forms;

public class Funcionario
{
    public double salario;
    public double irpf;
    public string funcao;

    public Funcionario(double salario, string funcao)
    {
        this.salario = salario;
        this.funcao = funcao;
    }

    public double CalcularSalario(double salario, string funcao)
    {
        if (funcao == "MEDICO")
        {
            salario = (salario * 20) / 100 + salario;
        }

        else if (funcao == "TI")
        {
            salario = salario + 5600;
        }

        else if (funcao == "ADM")
        {
            salario = ((salario * 15) / 100) + 200 + salario;
        }


        if (salario > 5000)
        {
            irpf = salario * (17 /100);
            salario = salario - irpf;
        }

        else
        {

        }

        return salario;
    }
}
