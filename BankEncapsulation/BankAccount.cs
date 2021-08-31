using System;
namespace BankEncapsulation
{
    public class BankAccount
    {
        private double balance = 0;
        private string pinNumber = "1234";
        private bool lockedAccount = false;
       
        public bool CheckPin(string userInput)
        {
            return (userInput == pinNumber);
        }

        public bool LogIntoAccount()
        {
            if (!lockedAccount)
            {
                int i = 0;
                bool loggedIn = false;
                while (i < 4)
                {
                    Console.WriteLine("Please enter your pin to login to your account.");
                    string userInput = Console.ReadLine();
                    if (CheckPin(userInput))
                    {
                        loggedIn = true;
                        i = 4;

                    }
                    else if (i < 3)
                    {
                        i++;
                    }
                    if (i < 3)
                    {
                        Console.WriteLine("That was the incorrect pin number.\nPlease try again.");
                    }
                    if (i == 3)
                    {
                        Console.WriteLine("You have failed too many attempts.\n Your account has been locked");
                        lockedAccount = true;
                        i++;
                    }
                }
                return loggedIn;
            }
            else
            {
                Console.WriteLine("Your account has had too many failed login attempts and has been locked.\n Please try again tomorrow.");
                return false;
            }
        }

        public void Deposit(double amountToDeposit)
        {
            
            balance += amountToDeposit;
        }

        public double GetBalance()
        {
            return balance;
        }
    }
}
