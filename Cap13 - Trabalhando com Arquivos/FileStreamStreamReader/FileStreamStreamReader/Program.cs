using System;
using System.IO;

namespace FileStreamStreamReader
{
    class Program
    {
        static void Main(string[] args)
        {
            string path = @"C:\temp\File1.txt";
            FileStream fs = null; //se usar File.OpenText é desnecessária essa linha
            StreamReader sr = null;
            try
            {
                fs = new FileStream(path, FileMode.Open);//se usar File.OpenText é desnecessária essa linha
                sr = new StreamReader(fs); //Pode ser substituida por sr = File.OpenText(path);
                while (!sr.EndOfStream)
                {
                    string line = sr.ReadLine();
                    Console.WriteLine(line);
                }
            }
            catch (IOException e)
            {
                Console.WriteLine("An error acurred");
                Console.WriteLine(e.Message);
            }
            finally
            {
                if (sr != null) sr.Close();
                if (fs != null) fs.Close();                
            }
        }
    }
}
