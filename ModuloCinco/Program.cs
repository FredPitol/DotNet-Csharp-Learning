using System.Globalization;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;
using System.Linq.Expressions;
using System.ComponentModel;
using System.Security.AccessControl;
using System.Runtime.CompilerServices;

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
            Console.WriteLine("6 - Params");
            Console.WriteLine("7 - Modificador de parâmetros - Ref e Out");
            Console.WriteLine("8 - foreach");
            Console.WriteLine("9 - Listas");
            Console.WriteLine("10 - Listas - Exercicio de fixacao");
            Console.WriteLine("0 - Sair");
            Console.WriteLine("");
            string choice = Console.ReadLine();
            Console.WriteLine("");

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

                    for (int i = 0; i < numeroDePessoas; i++)
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
                case "6":
                    int n1 = Calculadora.Soma(4, 4, 4);
                    int n2 = Calculadora.Soma(10, 10, 10);
                    int n3 = Calculadora.Soma(1, 1, 10000, 1);

                    Console.WriteLine($"n1: {n1} n2: {n2} n3: {n3}");

                    break;
                case "7":
                    int n = 10;
                    int triplo;
                    Calculadora.MultiplicaComRef(ref n);
                    Calculadora.MultiplicaComOut(n, out triplo);
                    break;
                case "8":
                    string[] vetor = new string[] { "10", "20", "30" };
                    foreach (string elemento in vetor)
                    {
                        Console.WriteLine($"{elemento}");
                    }
                    Console.WriteLine("");
                    break;
                case "9":

                    List<string> lista1 = new List<string>(); // Vazia
                    List<string> lista2 = new List<string> { "Marcos", "Azevedo", "Moura", "Augusto" }; // Estanciando com valor
                    lista2.Add("Carlos");// Adiciona no final

                    foreach (string obj in lista2)
                    {
                        Console.WriteLine($"{obj}");
                    }

                    lista2.Insert(0, "Lucas"); Console.WriteLine($"\n");

                    foreach (string obj in lista2)
                    {
                        Console.WriteLine($"{obj}");
                    }
                    Console.WriteLine($"\nTamanho da lista: {lista2.Count}\n");

                    Console.WriteLine("---------- Find e FindIndex-----------");
                    string primeiroLista = lista2.Find(x => x[0] == 'A');
                    int primeiraPosicao = lista2.FindIndex(x => x[0] == 'A');

                    Console.WriteLine($"Primeiro nome com a letra A no inicio: {primeiroLista} " +
                        $"\nNa posição {primeiraPosicao}\n");

                    Console.WriteLine("---------- FindLast e FindLastIndex-----------");
                    string ultimoLista = lista2.FindLast(x => x[0] == 'A');
                    int ultimaPosicao = lista2.FindLastIndex(x => x[0] == 'A');

                    Console.WriteLine($"Primeiro nome com a letra A no inicio: {ultimoLista} " +
                        $"\nNa posição {ultimaPosicao}\n");

                    Console.WriteLine("---------- FindAll - Encontra todos os nomes que tenham 5 letras -----------");
                    List<string> listaApoio = lista2.FindAll(x => x.Length == 5);  // Uma nova lista recebe os valores
                    foreach (string obj in listaApoio)
                    {
                        Console.WriteLine($"{obj}");
                    }

                    Console.WriteLine("---------- RemoveRange - os dois a partir do terceiro -----------");
                    lista2.RemoveRange(2, 2);
                    foreach (string obj in lista2)
                    {
                        Console.WriteLine($"{obj}");
                    }

                    Console.WriteLine("---------- RemoveAt - Remove na ultima posição -----------");
                    lista2.RemoveAt(lista2.Count - 1); //Uso do count
                    foreach (string obj in lista2)
                    {
                        Console.WriteLine($"{obj}");
                    }


                    Console.WriteLine("---------- RemoveAll - Todos com M -----------");
                    lista2.RemoveAll(x => x[0] == 'M');
                    foreach (string obj in lista2)
                    {
                        Console.WriteLine($"{obj}");
                    }

                    Console.WriteLine("---------- Remove - Lucas -----------");
                    lista2.Remove("Lucas");
                    foreach (string obj in lista2)
                    {
                        Console.WriteLine($"{obj}");
                    }

                    Console.WriteLine($"");
                    break;
                case "10":
                    Console.WriteLine("Digite a quantidade de funcionários a serem cadastrados: ");

                    int qtdFun = int.Parse(Console.ReadLine());
                    List<Funcionario> listaFun = new List<Funcionario>();
                    for (int i = 0; i < qtdFun; i++)
                    {
                        Console.WriteLine($"Funcionário {i + 1}");

                        Console.Write("Digite o id do funcionario: ");
                        string id = Console.ReadLine();

                        Console.Write("Digite o nome do funcionario : ");
                        string nome = Console.ReadLine();

                        Console.Write("Digite o salario do funcionario : ");
                        double sal = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                        listaFun.Add(new Funcionario(id, nome, sal));
                    }

                    foreach (Funcionario obj in listaFun)
                    {
                        Console.WriteLine($"");
                        Console.WriteLine($"Nome:{obj.Nome}");
                        Console.WriteLine($"Id:{obj.Id}");
                        Console.WriteLine($"Salario: {obj.Salario}");
                        Console.WriteLine($"");
                    }

                    Console.WriteLine("Digite o id do funcionário que terá um acréscimo no salário: ");
                    string escolha = Console.ReadLine();
                    Console.WriteLine("");

                    Console.WriteLine("Digite a porcentagem de acréscimo");
                    double pctg = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                    Console.WriteLine("");

                    int funcPosicao = listaFun.FindIndex(x => x.Id == escolha);
                    listaFun[funcPosicao].AumentarSalario(pctg);
                    Console.WriteLine("");

                    Console.WriteLine($"Lista atualizada");
                    foreach (Funcionario obj in listaFun)
                    {
                        Console.WriteLine($"Nome:{obj.Nome} Id:{obj.Id} Salario:{obj.Salario}");
                    }
                    break;
                case "":
                    Console.WriteLine("");
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