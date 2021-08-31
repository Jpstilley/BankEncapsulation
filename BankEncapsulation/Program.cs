using System;

namespace BankEncapsulation
{
    class Program
    {
        static void Main(string[] args)
        {
            BankAccount myAccount = new BankAccount();
            string userInput = "";
            Console.WriteLine("Welcome to YourAccount Banking");

            if (myAccount.LogIntoAccount())
            {
                Console.WriteLine("\nYou have successfully logged into your account.\n");
                do
                {
                    Console.WriteLine("What would you like to do?");
                    Console.WriteLine("1. View Balance\n2. Make a deposit\n3. Exit");
                    userInput = Console.ReadLine();
                    if (userInput == "1")
                    {
                        Console.WriteLine($"\nYour current balance is ${myAccount.GetBalance()}.\n");
                    }
                    else if (userInput == "2")
                    {
                        Console.WriteLine("How much would you like to deposit?");
                        myAccount.Deposit(Convert.ToDouble(Console.ReadLine()));
                    }
                } while (userInput != "3");
            }
        }
    }
}
