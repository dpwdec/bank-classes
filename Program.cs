using System;
using System.Collections.Generic;

namespace classes
{
    class Program
    {
        static void Main(string[] args)
        {
            var account = new BankAccount("Dec", 100);

            try
            {
                var account2 = new BankAccount("Dan", -55);
            }
            catch (ArgumentOutOfRangeException e)
            {
                Console.WriteLine("Negative Balance 💸");
                Console.WriteLine(e.ToString());
            }

            try
            {
                account.MakeWithdrawal(750, DateTime.Now, "overdraw!");
            }
            catch(InvalidOperationException e)
            {
                Console.WriteLine("Overdraft detected! ❌");
                Console.WriteLine(e.ToString());
            }
        }
    }
}
