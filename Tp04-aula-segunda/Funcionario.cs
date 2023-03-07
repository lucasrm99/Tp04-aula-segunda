using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tp04_aula_segunda;

namespace Tp04_aula_segunda
{
    public class Funcionario
    {
        public string CPF { get; set; } = string.Empty;
        public string Nome { get; set; } = string.Empty;
        public double Valor { get; set; }
        public double Horas { get; set; }
        public double Salario { get; private set; }


        public void CalcularSalario()
        {
            Salario = (Valor * Horas) * 30;
        }
    }

}
