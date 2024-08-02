using System;

namespace Course
{
    class Program
    {
        static void Main(string[] args)
        {
            // Determina tamanho array e armazena em vetor
            Console.WriteLine("Digite o as dimensões do array: linhas,  colunas");
            string[] line = Console.ReadLine().Split(' ');
            int lineQtd = int.Parse(line[0]);
            int columnQtd = int.Parse(line[1]);

            //Estancia array com tamanho inseridos
            int[,] mat = new int[lineQtd, columnQtd];

            // Percorre linhas
            for (int i = 0; i < lineQtd; i++)
            {
                // Adiciona valores da linha para cada coluna de uma vez
                Console.WriteLine($"Insert the values for the line {i}");
                string[] values = Console.ReadLine().Split(' ');

                // Usa quantidade de colunas inseridas como argumento
                for (int j = 0; j < columnQtd; j++)
                {
                    mat[i, j] = int.Parse(values[j]);
                }
            }

            // Insere valor a ser buscado no array
            int x = int.Parse(Console.ReadLine());

            // Percorre linhas
            for (int i = 0; i < lineQtd; i++)
            {
                 
                // Percorre colunas
                for (int j = 0; j < columnQtd; j++)
                {
                    // Encontra valor passado
                    if (mat[i, j] == x)
                    {   
                        // Retorna posição
                        Console.WriteLine("Position " + i + "," + j + ":");
                        
                        
                        //Printa valor a esquerda
                        if (j > 0)
                        {
                            Console.WriteLine("Left: " + mat[i, j - 1]);
                        }
                        // Printa valor a direita
                        if (i > 0)
                        {
                            Console.WriteLine("Up: " + mat[i - 1, j]);
                        }
                        // Printa Valor a esquerda
                        if (j < columnQtd - 1)
                        {
                            Console.WriteLine("Right: " + mat[i, j + 1]);
                        }
                        // Printa valor a baixo
                        if (i < lineQtd - 1)
                        {
                            Console.WriteLine("Down: " + mat[i + 1, j]);
                        }
                    }
                }
            }
        }
    }
}