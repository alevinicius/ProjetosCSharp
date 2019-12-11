using System;
using System.Collections.Generic;

namespace Ex_Conjunto_01 {
    class Program {
        static void ImprimirConjuntos(HashSet<int> a, HashSet<int> b) {
            Console.WriteLine("Conjunto A: ");
            foreach (int x in a) {
                Console.WriteLine(x);
            }

            Console.WriteLine();
            Console.WriteLine("Conjunto B: ");
            foreach (int x in b) {
                Console.WriteLine(x);
            }
        }


        static void PreencherConjuntos(HashSet<int> a, HashSet<int> b) {
            a.Remove(3);
            a.Remove(4);
            a.Remove(5);
            a.Remove(6);
            a.Remove(7);
            a.Remove(8);
            a.Remove(9);

            b.Remove(3);
            b.Remove(4);
            b.Remove(5);
            b.Remove(6);
            b.Remove(7);
            b.Remove(8);
            b.Remove(9);

            a.Add(3); a.Add(5); a.Add(8); a.Add(9);
            b.Add(3); b.Add(4); b.Add(5);
        }

        static void Main(string[] args) {

            HashSet<int> a = new HashSet<int>();
            HashSet<int> b = new HashSet<int>();
            PreencherConjuntos(a, b);
            ImprimirConjuntos(a, b);
            Console.WriteLine();

            Console.Write("Digite um valor inteiro: ");
            int n = int.Parse(Console.ReadLine());

            if (a.Contains(n)) {
                a.Remove(n);
                Console.WriteLine(n + " removido do conjunto A");
            } else {
                Console.WriteLine(n + " não está no conjunto A");
            }
            if (b.Contains(n)) {
                b.Remove(n);
                Console.WriteLine(n + " removido do conjunto B");
            } else {
                Console.WriteLine(n + " não está no conjunto B");
            }

            ImprimirConjuntos(a, b);
            Console.WriteLine();
            Console.WriteLine("Conjuntos preenchidos novamente a partir daqui");
            PreencherConjuntos(a, b);
            ImprimirConjuntos(a, b);
            Console.WriteLine();

            Console.WriteLine("a.ExceptWith(b) - Deixa em A somente o que não tem também em B (Diferença)");
            a.ExceptWith(b);
            ImprimirConjuntos(a, b);
            Console.WriteLine();
            Console.WriteLine("Conjuntos preenchidos novamente a partir daqui");
            Console.WriteLine();
            PreencherConjuntos(a, b);
            ImprimirConjuntos(a, b);

            Console.WriteLine("a.UnionWith(b) - Adiciona em A o que tem em B, mas não tinha em A (União)");
            a.UnionWith(b);
            ImprimirConjuntos(a, b);

            Console.WriteLine("Conjuntos preenchidos novamente a partir daqui");
            Console.WriteLine();
            PreencherConjuntos(a, b);
            ImprimirConjuntos(a, b);

            Console.WriteLine("a.IntersectWith(b) - Deixa em A, a intersecção entre A e B");
            a.IntersectWith(b);
            ImprimirConjuntos(a, b);
        }
    }
}
