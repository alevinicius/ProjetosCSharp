using System;
using System.IO;

namespace BlocoUsing
{
    class Program
    {
        static void Main(string[] args)
        {
            string path = @"c:\temp\file1.txt";

            //O bloco Using dispensa a necessidade de tryFinally para destruir os objetos

            try
            {
                using (FileStream fs = new FileStream(path, FileMode.Open))
                {
                    using (StreamReader sr = new StreamReader(fs))
                    {
                        while (!sr.EndOfStream)
                        {
                            string line = sr.ReadLine();
                            Console.WriteLine(line);
                        }
                    }
                }
            }
            catch (IOException e)
            {
                Console.WriteLine("An error ocurred");
                Console.WriteLine(e.Message);
            }

        }
    }
}
