using System;

namespace ConsoleApp1
{
    public class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("Welcome to the ATM!");
                int bal = 5000;
                while (true)
                {
                    Console.WriteLine($"Your balance is {bal}");
                    Console.WriteLine("To see your balance again type '1'");
                    Console.WriteLine("To withdraw money type '2'");
                    Console.WriteLine("To add money type '3'");
                    Console.WriteLine("To exit type '4'");

                    string choice = Console.ReadLine().ToString();

                    if (choice == "1")
                    {
                        Console.WriteLine($"Your balance is {bal}");
                    }
                    else if (choice == "2")
                    {
                        Console.WriteLine("How much would you like to withdraw?");
                        int withdraw = Convert.ToInt32(Console.ReadLine());
                        int temp = bal;
                        bal = Withdraw(withdraw, bal);
                        if (bal == temp)
                        {
                            Console.WriteLine("Invalid amount to withdraw");
                        }
                    }
                    else if (choice == "3")
                    {
                        Console.WriteLine("How much would you like to add?");
                        int add = Convert.ToInt32(Console.ReadLine());
                        int temp = bal;
                        bal = AddTo(add, bal);
                        if (bal == temp)
                        {
                            Console.WriteLine("Invalid amount to add");
                        }
                    }
                    else
                    {
                        Console.WriteLine("Goodbye");
                        break;
                    }
                }
            }
            catch (Exception)
            {
                Console.Error.WriteLine("Please enter valid numbers.");
            }
            Console.ReadLine();
        }

        /// <summary>
        /// This function takes in a balance and a amount you want to subtract from it
        /// </summary>
        /// <param name="amount">Amount to subtract</param>
        /// <param name="bal">Total balance</param>
        /// <returns>New balance</returns>
        public static int Withdraw(int amount, int bal)
        {
            if (bal - amount < 0)
            {
                return bal;
            }
            else if (bal - amount > bal)
            {
                return bal;
            }
            else
            {
                return bal - amount;
            }
        }

        /// <summary>
        /// This function takes in a balance and a amount you want to add to it
        /// </summary>
        /// <param name="amount">Amount to add</param>
        /// <param name="bal">Total balance</param>
        /// <returns>New balance</returns>
        public static int AddTo(int amount, int bal)
        {
            if (bal + amount < bal)
            {
                return bal;
            }
            else
            {
                return bal + amount;
            }
        }
    }
}
