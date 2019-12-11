using System;

namespace Tipo_Duracao {
    class Program {
        static void Main(string[] args) {

            
            TimeSpan t1 = new TimeSpan();
            TimeSpan t2 = new TimeSpan(900000000); //quantidade de ticks por  parametro
            TimeSpan t3 = new TimeSpan(2, 11, 21); //hora, min, seg
            TimeSpan t4 = new TimeSpan(1, 2, 11, 21); //dia, hora, min, seg
            TimeSpan t5 = new TimeSpan(1, 2, 11, 21, 321); //dia, hora, min, seg, milisegundos

            Console.WriteLine(t1);
            Console.WriteLine(t2);
            Console.WriteLine(t3);
            Console.WriteLine(t4);
            Console.WriteLine(t5);

            Console.WriteLine(); Console.WriteLine(); Console.WriteLine();

            t1 = TimeSpan.FromDays(1.5); //Método From, passando o timespan de 1 DIA e meio, retornando 1 DIA 12h
            t2 = TimeSpan.FromHours(1.5); //Método From, passando o timespan de 1 HORA e meio, retornando 1 HORA 30 MINUTOS
            t3 = TimeSpan.FromMinutes(1.5);  //Método From, passando o timespan de 1 MINUTO e meio, retornando 1 MINUTO 30 SEGUNDOS
            t4 = TimeSpan.FromSeconds(1.5);  //Método From, passando o timespan de 1 SEGUNDO e meio, retornando 1 SEGUNDO 500 MILESEGUNDOS
            t5 = TimeSpan.FromMilliseconds(1.5);  //Mesma lógica, só que com milesegundos, passando 1 MILESEGUND e meio 

            TimeSpan t6 = TimeSpan.FromTicks(900000000L); //A partir dos ticks

            Console.WriteLine(t1);
            Console.WriteLine(t2);
            Console.WriteLine(t3);
            Console.WriteLine(t4);
            Console.WriteLine(t5);
            Console.WriteLine(t6);

        }
    }
}
