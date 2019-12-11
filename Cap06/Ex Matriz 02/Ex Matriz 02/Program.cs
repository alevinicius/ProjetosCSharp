using System;
using System.Globalization;

namespace Ex_Matriz_02 {
    class Program {
        static void Main(string[] args) {
            Console.Write("Informe o número de elementos por eixo da matriz: ");
            int n = int.Parse(Console.ReadLine());

            double[,] mat = new double[n, n];
            int contNumerosNegativos = 0;
            for (int i = 0; i < n; i++) {
                Console.Write("Informe os valores da {0}ª linha da matriz: ", i);
                string[] vetAux = Console.ReadLine().Split(' ');

                for (int j = 0; j < n; j++) {
                    mat[i, j] = double.Parse(vetAux[j].ToString(), CultureInfo.InvariantCulture);

                    if (mat[i,j] < 0) {
                        contNumerosNegativos++;
                    }
                }
            }

            Console.Write("Os valores da diagonal principal da matriz são respectivamente: ");
            for (int i = 0; i < n; i++) {
                Console.Write(mat[i,i].ToString(), "F2", CultureInfo.InvariantCulture);

                if (i < n - 1) {
                    Console.Write(" | ");
                }                
            }
            Console.WriteLine();
            Console.WriteLine("Foram informados {0} números negativos", contNumerosNegativos);
        }
    }
}
