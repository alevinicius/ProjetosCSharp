using System;
using System.Collections.Generic;

namespace Ex_Conjunto_02 {
    class Program {       
        static void Main(string[] args) {                                    
            int n = 0; //Quantidade de alunos por curso
            HashSet<int> cursoA = new HashSet<int>();
            HashSet<int> cursoB = new HashSet<int>();
            HashSet<int> cursoC = new HashSet<int>();

            Console.Write("Quantos alunos possui o Curso A? ");
            n = int.Parse(Console.ReadLine());            
            for (int i = 1; i <= n; i++) {
                Console.Write("Código do {0}º aluno: ", i);
                cursoA.Add(int.Parse(Console.ReadLine()));
            }
            Console.WriteLine();
            
            Console.Write("Quantos alunos possui o Curso B? ");
            n = int.Parse(Console.ReadLine());            
            for (int i = 1; i <= n; i++) {
                Console.Write("Código do {0}º aluno: ", i);
                cursoB.Add(int.Parse(Console.ReadLine()));
            }
            Console.WriteLine();

            Console.Write("Quantos alunos possui o Curso C? ");
            n = int.Parse(Console.ReadLine());            
            for (int i = 1; i <= n; i++) {
                Console.Write("Código do {0}º aluno: ", i);
                cursoC.Add(int.Parse(Console.ReadLine()));
            }
            Console.WriteLine();

            HashSet<int> alunos = new HashSet<int>();
            alunos.UnionWith(cursoA);
            alunos.UnionWith(cursoB);
            alunos.UnionWith(cursoC);

            Console.WriteLine("O total de alunos do professor Fulano é " + alunos.Count);
        }
    }
}
