using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace ConsoleApp1
{

    internal class ContaBancaria
    {

        public int Numero { get; private set; }
        public string Titular { get; set; }
        public double Saldo { get; private set; }

        public ContaBancaria(int numero, string titular)
        {
            Numero = numero;
            Titular = titular;
        }

        public ContaBancaria(int numero, string titular, double quantia) : this(numero, titular)
        {
            Deposito(quantia);
        }

        public void Deposito(double quantia)
        {
            Saldo += quantia;
        }

        public void Saque(double quantia)
        {
            Saldo -= quantia + 5.0;
        }

        public override string ToString()
        {
            return $"Conta: {Numero}\nTitular: {Titular}\nSaldo: {Saldo.ToString("F2", CultureInfo.InvariantCulture)}";
        }
    }
}
