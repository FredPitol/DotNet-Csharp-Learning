using System.ComponentModel.DataAnnotations;
using System.Net.Mail;
using System.Runtime.CompilerServices;
using System.Xml;
using System.Globalization;
using ConsoleApp1;

namespace Course;
class Program
{
    static void Main(string[] args) 
    {
        ContaBancaria conta;
        Console.Write("Entre o número da conta: ");
        int numero = int.Parse(Console.ReadLine());
        Console.Write("Entre o titular da conta: ");
        string titular = Console.ReadLine();
        Console.Write("Haverá depósito inicial (s/n)? ");
        char resp = char.Parse(Console.ReadLine());
        if (resp == 's' || resp == 'S')
        {
            Console.Write("Entre o valor de depósito inicial: ");
            double depositoInicial = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            conta = new ContaBancaria(numero, titular, depositoInicial);
        }
        else
        {
            conta = new ContaBancaria(numero, titular);
        }

        Console.WriteLine();
        Console.WriteLine("Dados da conta:");
        Console.WriteLine(conta);

        Console.WriteLine();
        Console.Write("Entre um valor para depósito: ");
        double quantia = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
        conta.Deposito(quantia);
        Console.WriteLine("Dados da conta atualizados:");
        Console.WriteLine(conta);

        Console.WriteLine();
        Console.Write("Entre um valor para saque: ");
        quantia = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
        conta.Saque(quantia);
        Console.WriteLine("Dados da conta atualizados:");
        Console.WriteLine(conta);
    }




    //Exercicio While
    static string PasswordCheck(string a, string validPassword)
    /*
    - Repete a leitura de uma senha até que ela seja válida.
        - Para cada leitura de senha incorreta informada, 
            - Escrever a mensagem "Senha Invalida". 
        - Senha correta (valor = 2002)
            - "Acesso Permitido" e o algoritmo encerrado. 
     */
    {
        Console.WriteLine("Digite sua senha");
        while (a != validPassword)
        {
            a = Console.ReadLine();
            if (a == validPassword)
            {
                Console.WriteLine("Senha correta");
            }
            else
            {
                Console.WriteLine("Senha incorreta, digite novamente");
            }
        }
        return a;
    }
    static double InsereNumeroPositivoMenor(double a, double valorMaximo)
    /*
        Leia um valor inteiro X(1 <= X <= 1000).
        Em seguida mostre os ímpares de 1 até X,
        um valor por linha, inclusive o  X, se for o caso
     */
    {
        while (a >= valorMaximo & a <= 0)
        {
            a = int.Parse(Console.ReadLine());
        }
        return a;
    }
    static void CheckQuadrante()
    /*
     *  Ler as coordenadas (X,Y) de uma quantidade indeterminada de pontos no sistema
     *  cartesiano. Para cada ponto escrever o quadrante a que ele pertence.
     *  O algoritmo será encerrado quando menos uma de duas coordenadas for NULA 
     *     - (nesta situação sem escrever mensagem alguma).
     *  Quad 1 = x e y > 0
     *  Quad 2 = x < 0 e y > 0
     *  Quad 3 = x < 0 y < 0
     *  Quad 4 = x > 0  y < 0
     *  
     */
    {
        Console.WriteLine("Digite dois numeros separados por espaço");
        string[] lista = Console.ReadLine().Split(' ');
        int x = int.Parse(lista[0]);
        int y = int.Parse(lista[1]);
        while (x != 0 && y != 0)
        {
            if (x > 0 && y > 0)
            {
                Console.WriteLine("Primeiro quadrante");
            }
            else if (x < 0 && y > 0)
            {
                Console.WriteLine("Segundo quadrante");
            }
            else if (x < 0 && y < 0)
            {
                Console.WriteLine("Terceiro quadrante");
            }
            else
            {
                Console.WriteLine("Quarto quadrante");
            }
            lista = Console.ReadLine().Split(' ');
            x = int.Parse(lista[0]);
            y = int.Parse(lista[1]);

        }
    }
    static void PostoDeGasolina()
    {
        int alcool = 0;
        int gasolina = 0;
        int diesel = 0;
        int fim = 0;
        int opcao = 0;
        while (fim == 0)
        {
            Console.WriteLine("Digite o tipo de combustivel: 1.Álcool 2.Gasolina 3.Diesel 4.Fim");
            opcao = int.Parse(Console.ReadLine());
            if (opcao == 1)
            {
                ++alcool;
            }
            else if (opcao == 2)
            {
                ++gasolina;
            }
            else if (opcao == 3)
            {
                ++diesel;
            }
            else if (opcao == 4)
            {
                Console.WriteLine($"Muito obrigado\nAlcool: {alcool}\nGasolina: {gasolina}\nDiesel: {diesel} ");
                ++fim;
            }
            else
            {
                Console.WriteLine("Codigo invalido digite novamente");
            }

        }

    }

    // Exercicio For
    static void ValoresDentroDeIntervalo()
    /*
     * Leia um valor inteiro N. Este valor será a quantidade de valores inteiros X que serão 
     * lidos em seguida.
     * Mostre quantos destes valores X estão dentro do intervalo [10,20] 
     * e quantos estão fora do intervalo, mostrando essas informações conforme exemplo 
     * (use a palavra "in" para dentro do intervalo, e "out" para fora do intervalo)
     */
    {
        int n = int.Parse(Console.ReadLine());
        int fora = 0;
        int dentro = 0;
        for (int i = 0; i < n; i++)
        {
            int x = int.Parse(Console.ReadLine());
            if (x >= 10 && x <= 20)
                ++dentro;
            else
                ++fora;
        }
        Console.WriteLine($"{dentro} in\n{fora} out");

    }
    static void mediaPonderada()
    {
        /*
           - [ ] Leia 1 valor inteiro N, que representa o número de casos de teste que vem a seguir. 
           - [ ] Cada caso de teste consiste de 3 valores reais, cada um deles com uma casa decimal. 
           - [ ] Apresente a média ponderada para cada um destes conjuntos de 3 valores, sendo que: 
               - [ ] primeiro valor tem peso 2
               - [ ] segundo valor tem peso 3 
               - [ ] terceiro valor tem peso 5.
         */
        Console.WriteLine("Quantas médias ponderadas serão calculadas?");
        int n = int.Parse(Console.ReadLine());
        for (int i = 0; i < n; i++)
        {
            Console.WriteLine($"Digite um trio de valores valores separados por espaço");
            string[] entrada = Console.ReadLine().Split(" ");
            double valorA = double.Parse(entrada[0], CultureInfo.InvariantCulture);
            double valorB = double.Parse(entrada[1], CultureInfo.InvariantCulture);
            double valorC = double.Parse(entrada[2], CultureInfo.InvariantCulture);

            double media = (valorA * 2.0 + valorB * 3.0 + valorC * 5.0) / 10.0;

            Console.WriteLine(media.ToString("F1", CultureInfo.InvariantCulture));

        }
    }
}
