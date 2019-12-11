using System;

namespace FuncoesStrings {
    class Program {        
        static void Main(string[] args) {
            string original = "abcde FHGIJ ABC abc DEFG    ";

            string s1 = original.ToUpper(); //Retorna todas em maiúsculas
            string s2 = original.ToLower(); //Retorna todas em minúsculas
            string s3 = original.Trim();    //Retorna sem espaços em branco no início e no final
            int n1 = original.IndexOf("bc"); //Retorna o índice do PRIMEIRO valor encontrado que corresponde ao parâmetro (bc)
            int n2 = original.LastIndexOf("bc"); //Retorna o índice do ÚLTIMO valor encontrado que corresponde ao parâmetro (bc)
            string s4 = original.Substring(3); //Retorna um pedaço da string a partir de um certo ponto (3)
            string s5 = original.Substring(3, 5); //Retorna um pedaço da string a partir de um certo (3) ponto até uma quantia de caracteres especificada (5)
            string s6 = original.Replace('a', 'x'); //Substitui parte da string (a por x nesse caso)

            bool b1 = String.IsNullOrEmpty(original); // retorna se original é nulo ou vazio (booleano)
            bool b2 = String.IsNullOrWhiteSpace(original); // retorna se original é nulo ou espaço em branco (booleano)

            Console.WriteLine("Original:                    |" + original + "|");
            Console.WriteLine("ToUpper:                     |" + s1 + "|");
            Console.WriteLine("ToLower:                     |" + s2 + "|");
            Console.WriteLine("Trim:                        |" + s3 + "|");
            Console.WriteLine("IndexOf('bc'):               |" + n1 + "|");
            Console.WriteLine("LastIndexOf('bc'):           |" + n2 + "|");
            Console.WriteLine("Substring(3):                |" + s4 + "|");
            Console.WriteLine("Substring(3, 5):             |" + s5 + "|");
            Console.WriteLine("Replace('a', 'x'):           |" + s6 + "|");
            Console.WriteLine("IsNullOrEmpty(original):     |" + b1 + "|");
            Console.WriteLine("IsNullOrWhiteSpace(original):|" + b2 + "|");


            Console.WriteLine();
        }
    }
}
