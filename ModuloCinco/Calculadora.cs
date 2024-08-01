using System.Globalization;
using System.Runtime;

namespace ModuloCinco{
    class Calculadora
    {
        public static int Soma(params int[] numeros)
        {
            int soma = 0;
            for (int i = 0; i < numeros.Length; i++ )
            {
                soma += numeros[i];
            }
            return soma;
        }
        public static void MultiplicaComRef(ref int x)
        {
            int b = x;
            x *= 3;
            Console.WriteLine($"{b} X 3 = {x}"); 
        }
        public static void MultiplicaComOut(int origem, out int resultado)
        {
            resultado = origem * 3;
            Console.WriteLine($"{origem} X 3 = {resultado}");
        }
    }
}