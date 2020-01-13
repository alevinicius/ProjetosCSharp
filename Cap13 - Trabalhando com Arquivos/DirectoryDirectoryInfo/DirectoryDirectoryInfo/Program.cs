using System;
using System.IO;
using System.Collections.Generic;

namespace DirectoryDirectoryInfo
{
    class Program
    {
        static void Main(string[] args)
        {
            string path = @"c:\temp\myFolder";

            try
            {
                //Listar diretórios
                IEnumerable<string> folders = Directory.EnumerateDirectories(path, "*.*", SearchOption.AllDirectories);
                Console.WriteLine("FOLDERS:");
                foreach (string s in folders)
                {
                    Console.WriteLine(s);
                }

                //Listar arquivos
                Console.WriteLine();
                IEnumerable<string> files = Directory.EnumerateFiles(path, "*.*", SearchOption.AllDirectories);
                Console.WriteLine("FILES:");
                foreach (string s in files)
                {
                    Console.WriteLine(s);
                }

                //Criar diretório
                Directory.CreateDirectory(path + @"\newFolder");
            }
            catch (IOException e)
            {
                Console.WriteLine("An error ocurred");
                Console.WriteLine(e.Message);                
            }
        }
    }
}
