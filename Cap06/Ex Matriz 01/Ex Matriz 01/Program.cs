using System;

namespace Ex_Matriz_01 {
    class Program {
        static void Main(string[] args) {
            double[,] mat = new double[2, 3];
            Console.WriteLine(mat.Length); //quantidade de espaços paraelementos na matriz
            Console.WriteLine(mat.Rank);  // quantidade de espaços do eixo X
            Console.WriteLine(mat.GetLength(0)); //quantidade de elementos do eixo X
            Console.WriteLine(mat.GetLength(1)); //quantidade de elementos do eixo Y
        }
    }
}
