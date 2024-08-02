using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModuloCinco
{
    internal class Funcionario
    {
        public string Id { get;  set; }
        public string Nome { get; set; }
        public double Salario { get; set; }

        public Funcionario(string i, string n, double s)
        {
            Id = i;
            Nome = n;
            Salario = s;
        }
        public void AumentarSalario(double porcentagem)
        {
            Salario += Salario * porcentagem / 100.0;
        }
    }
}
