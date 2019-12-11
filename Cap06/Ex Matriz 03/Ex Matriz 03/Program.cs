using System;

namespace Ex_Matriz_03 {
    class Program {
        static void Main(string[] args) {
            Console.Write("Informe respectivamente o número de linhas e de colunas de uma matriz: ");
            string[] mn = Console.ReadLine().Split(' ');
            int m = int.Parse(mn[0]);
            int n = int.Parse(mn[1]);

            int[,] mat = new int[m, n];

            for (int i = 0; i < m; i++) {
                Console.Write("Informe os valores da linha {0} do vetor: ", i);
                string[] valLinha = Console.ReadLine().Split(' ');

                for (int j = 0; j < n; j++) {
                    mat[i, j] = int.Parse(valLinha[j]);
                }
            }

            Console.WriteLine();
            Console.Write("Informe um número que deseja pesquisar na matriz: ");
            int x = int.Parse(Console.ReadLine());

            for (int i = 0; i < m; i++) {
                for (int j = 0; j < n; j++) {
                    if (mat[i, j] == x) {
                        Console.WriteLine($"Posição: {i},{j}");

                        if (i > 0) {
                            Console.WriteLine("Acima: " + mat[i - 1, j].ToString());
                        }

                        if (i < m-1) {
                            Console.WriteLine("Abaixo: " + mat[i + 1, j].ToString());
                        }

                        if (j > 0) {
                            Console.WriteLine("Esquerda: " + mat[i, j - 1].ToString());
                        }

                        if (j < n-1) {
                            Console.WriteLine("Direita: " + mat[i, j + 1].ToString());
                        }

                        Console.WriteLine();
                    }
                }
            }
        }
    }
}
