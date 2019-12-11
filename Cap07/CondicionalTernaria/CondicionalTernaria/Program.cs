using System;

namespace CondicionalTernaria {
    class Program {
        static void Main(string[] args) {
            double preco = double.Parse(Console.ReadLine());

            //é como se fosse um if, se preco menor do que 20, desconto recebe preco * 0.1, senão o desconto recebe preco * 0.05
            double desconto = (preco < 20) ? preco * 0.1 : preco * 0.05;

            Console.WriteLine(desconto);

        }
    }
}
