using System;

using tabuleiro;


namespace meu_xadrez
{
    class Tela
    {
        public static void imprimirTabuleiro(Tabuleiro tab)
        {
            for (int i = 0; i < tab.Linhas; i++)
            {
                for (int j = 0; j < tab.Colunas; j++)
                {
                    if (tab.Peca(new Posicao(i,j)) == null)
                    {
                        Console.Write("- ");
                    }
                    else
                    {
                        Console.Write(tab.Peca(new Posicao(i, j)) + " ");
                    }
                    
                }
                Console.WriteLine();
            }
        }
    }
}
