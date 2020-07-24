using System;
using System.Collections.Generic;

namespace classes
{
    class Program
    {
        static void Main(string[] args)
        {
            var account = new BankAccount("Dec", 100);

            // try
            // {
            //     var account2 = new BankAccount("Dan", -55);
            // }
            // catch (ArgumentOutOfRangeException e)
            // {
            //     Console.WriteLine("Negative Balance");
            //     Console.WriteLine(e.ToString());
            // }

            try
            {
                account.MakeWithdrawal(750, DateTime.Now, "overdraw!");
            }
            catch(InvalidOperationException e)
            {
                Console.WriteLine("Overdraft detected! ❌");
                Console.WriteLine(e.ToString());
            }
            // Console.WriteLine($"Balance: {account.Balance}\nName: {account.Owner}\nIdent: {account.Number}\nAge:{account.Age}");
            // var account2 = new BankAccount("Marcus", 200);
            // Console.WriteLine($"Balance: {account2.Balance}\nName: {account2.Owner}\nIdent: {account2.Number}");
            // var names = new List<string> { "<name>", "Ana", "Felipe" };

            // Func<int, int> add = x => x + 1;
            // Func<int, int> dub = x => x * 2;

            // var g = 2;
            // Console.WriteLine(dub(add(g)));
            // Console.WriteLine(g);
        }
    }
}
