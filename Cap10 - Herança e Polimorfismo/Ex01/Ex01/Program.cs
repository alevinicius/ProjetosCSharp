using System;
using Ex01.Entities;

namespace Ex01
{
    class Program
    {
        static void Main(string[] args)
        {
            Account acc = new Account(1001, "Alex", 0.0);
            BusinessAccount bacc = new BusinessAccount(1002, "Maria", 0.0, 500.0);

        //UPCASTING
                //(Atribuir à Superclasse uma Subclasse)
                //Objeto da Superclasse Account apontando para objetos das Subclasses BusinessAccount e SavingsAccount
                
            Account acc1 = bacc; //bacc é um objeto BusinessAccount
            Account acc2 = new BusinessAccount(1003, "Bob", 0.0, 200.0);
            Account acc3 = new SavingsAccount(1004, "Anna", 0.0, 0.01);

        //DOWNCASTING
                //Atribui à Subclasse uma SuperClasse
                //Objetos da Subclasses BusinessAccount e SavingsAccount apontando para objetos da SuperClasse Account
            BusinessAccount acc4 = (BusinessAccount)acc2; //acc2 é um objeto Account

            //Verifica se acc3 é um BusinessAccount, mas não é então não vai rodar essa parte
            if (acc3 is BusinessAccount)
            {
                //BusinessAccount acc5 = (BusinessAccount)acc3;
                BusinessAccount acc5 = acc3 as BusinessAccount; //"as" é uma forma alternativa de fazer o Casting
                acc5.Loan(200.00);
                Console.WriteLine("Loan!");
            }
            //Verifica se acc3 é um SavingsAccount, como é ele vai entrar no IF
            if (acc3 is SavingsAccount)
            {
                //SavingsAccount acc5 = (SavingsAccount)acc3;
                SavingsAccount acc5 = acc3 as SavingsAccount;
                acc5.UpdateBalance();
                Console.WriteLine("Update!");
            }

            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();

            Account ac1 = new Account(1001, "Alex", 500.0);
            Account ac2 = new SavingsAccount(1002, "Anna", 500, 0.01);

            ac1.Withdraw(10);
            ac2.Withdraw(10);

            Console.WriteLine(ac1.Balance);
            Console.WriteLine(ac2.Balance);
        }
    }
}
