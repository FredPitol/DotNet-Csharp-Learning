using System.Diagnostics;
using System.Diagnostics.Tracing;
using System.Drawing;
using System.Globalization;

namespace ModuloCinco;

class Program
{
    static void Main(string[] args)
    {
        bool continuarRodando = true;

        while (continuarRodando)
        {
            Console.WriteLine("Escolha o bloco de código para rodar:");
            Console.WriteLine("1 - Primeira maneira de instanciar Struct");
            Console.WriteLine("2 - Usando new para instanciar Struct");
            Console.WriteLine("3 - Operador de coalescência nula");
            Console.WriteLine("4 - Vetores - Vetor Struct");
            Console.WriteLine("5 - Vetores - Vetor referencia");
            Console.WriteLine("0 - Sair");
            Console.WriteLine("");
            string choice = Console.ReadLine();

            switch (choice)
            {
                case "1":
                    Point p1;
                    p1.X = 10;
                    p1.Y = 50;
                    Console.WriteLine(p1);
                    Console.WriteLine("");
                    break;

                case "2":

                    Point p2 = new Point();
                    Console.WriteLine(p2);
                    Console.WriteLine("");
                    break;

                case "3":
                    Console.WriteLine("");

                    double? x = null;
                    double? y = 10;

                    double a = x ?? 2000;
                    double b = y ?? 2000;
                    Console.WriteLine($"a = {a}, b = {b}");
                    Console.WriteLine("");
                    break;

                case "4":
                    Console.Write("Digite a quantidade de pessoas a serem inseridas altura: ");
                    int numeroDePessoas = int.Parse(Console.ReadLine());
                    double[] pessoas = new double[numeroDePessoas];
                    double soma = 0.0; 

                    for(int i = 0;i < numeroDePessoas; i++ )
                    {
                        Console.Write($"Digite a altura da pessoa numero {i + 1}: ");
                        pessoas[i] = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                        soma += pessoas[i];
                    }

                    Console.WriteLine($"Média de altura: {soma / numeroDePessoas}");
                    Console.WriteLine();


                    break;

                case "5":
                    Estudante[] estudantes = new Estudante[10];
                    Console.WriteLine("Digite a quantidade de quartos a serem cadastrados");
                    int qtd = int.Parse(Console.ReadLine());
                    for (int i = 1; i <= qtd; i++)
                    {
                        Console.WriteLine("Digite o nome");
                        string nome = Console.ReadLine();
                        Console.WriteLine("Digite o email");
                        string email = Console.ReadLine();
                        Console.WriteLine("Digite o numero do quarto");
                        int nQuarto = int.Parse(Console.ReadLine());
                        estudantes[nQuarto] = new Estudante(nome, email);
                    };

                    for (int i = 0; i < 10; i++)
                    {
                        if (estudantes[i] != null)
                        {
                            Console.WriteLine($"Quarto: {i} Ocupante: {estudantes[i]}");
                        }
                    }

                    break;

                case "0":
                    continuarRodando = false;
                    break;

                default:
                    Console.WriteLine("Escolha inválida.");
                 
                    Console.WriteLine("");
                    break;
            }
        }
        Console.WriteLine("Programa encerrado.");
    }
}
