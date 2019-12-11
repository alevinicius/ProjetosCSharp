using System;

namespace Ex_Foreach {
    class Program {
        static void Main(string[] args) {
            string[] nomes = new string[] { "Maria", "Alex", "Bob" };

            foreach (string nome in nomes) {
                Console.WriteLine(nome);
            }
        }
    }
}
