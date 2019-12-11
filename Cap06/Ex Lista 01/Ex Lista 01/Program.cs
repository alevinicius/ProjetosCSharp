using System;
using System.Collections.Generic;

namespace Ex_Lista_01 {
    class Program {
        static void Main(string[] args) {

            List<string> list = new List<string>();

            //ADD - Adiciona no final da lista
            list.Add("Maria");
            list.Add("Alex");
            list.Add("Bob");
            list.Add("Anna");
            list.Add("Joaquim");
            list.Add("Pedro");
            list.Add("Paulo");
            list.Add("Alexandre");
            list.Add("Ingryd");
            list.Add("Will");
            list.Add("Brenda");


            //INSERT - Adiciona a lista no index selecionado 
            list.Insert(2, "Marco");

            foreach (string obj in list) {
                Console.WriteLine(obj);
            }

            Console.WriteLine("Contagem dos elementos da lista: " + list.Count);

            //Essas funções "Find" tem como parâmetro instruções Lambda, no caso do exemplo é:
                //Localizar uma string tal que o primeiro elemento dela começe com a letra A

            string s1 = list.Find(x => x[0] == 'A');
            Console.WriteLine("Primeiro nome que começa com A: " + s1);

            string s2 = list.FindLast(x => x[0] == 'A');
            Console.WriteLine("Ultimo nome que começa com A: " + s2);

            int pos1 = list.FindIndex(x => x[0] == 'A');
            Console.WriteLine("Primeiro index cujo nome começa com A: " + pos1);

            int pos2 = list.FindLastIndex(x => x[0] == 'A');
            Console.WriteLine("Ultimo index cujo nome começa com A: " + pos2);

            Console.WriteLine("------------------------------");

                //Cria uma nova lista com todos os itens da lista que possuem uma string de tamanho 5
            List<string> list2 = list.FindAll(x => x.Length == 5);

            foreach (string obj in list2) {
                Console.WriteLine(obj);
            }

            //remove a string Alex da lista (apenas o primeiro encontrado)
            Console.WriteLine("------------------------------");
            list.Remove("Alex");

            foreach (string obj in list) {
                Console.WriteLine(obj);
            }

            //Remove todos da lista cuja string começa com M
            Console.WriteLine("------------------------------");
            list.RemoveAll(x => x[0] == 'M');

            foreach (string obj in list) {
                Console.WriteLine(obj);
            }

            //Remove da lista o objeto correspondente ao index 1
            Console.WriteLine("------------------------------");
            list.RemoveAt(1);

            foreach (string obj in list) {
                Console.WriteLine(obj);
            }

            //Remove da lista os 6 primeiros objetos contados a partir do index 0
            Console.WriteLine("------------------------------");
            list.RemoveRange(0, 6);

            foreach (string obj in list) {
                Console.WriteLine(obj);
            }

        }
    }
}
