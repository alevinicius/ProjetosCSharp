using System;

namespace ModifParams {
    class Calculadora {
        public static int Soma(params int[] numeros) {
            int soma = 0;
            for (int i = 0; i < numeros.Length; i++) {
                soma += numeros[i];
            }
            return soma;
        }
        //Função com modificador REF, muda o parâmetro "numero" que faz referência à "soma"
        public static void Triplo(ref int numero) {
            numero = numero * 3;
        }

        //Função com o modificador OUT, que muda o parâmetro "resultado" que referencia "int dobro"
        public static void Dobro(int numero, out int resultado) {
            resultado = numero * 2;
        }
    }

    class Program {
        static void Main(string[] args) {
            int soma = Calculadora.Soma(4, 5, 6);
            Console.WriteLine(soma);

            Calculadora.Triplo(ref soma);
            Console.WriteLine(soma);
            
            Calculadora.Dobro(soma, out int dobro);
            Console.WriteLine(dobro);

        }
    }
}
