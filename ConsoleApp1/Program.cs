using System;

namespace ConsoleApp1
{
    class Program
    {
        int calculator(string ch, int x, int y)
        {
            int ans = 0;

            switch (ch)
            {

                case "1":
                    ans = x + y;
                    break;
                case "2":
                    ans = x - y;
                    break;
                case "3":
                    ans = x * y;
                    break;
                case "4":
                    ans = x / y;
                    break;
                case "5":
                    Environment.Exit(0);
                    break;
                default:
                    break;
            }

            return ans;
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Enter First Number:- ");
            int x = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter Second Number:- ");
            int y = Convert.ToInt32(Console.ReadLine());

            Program p = new Program();

            Console.WriteLine("Enter Opration");
            Console.WriteLine("For Addition:Press  1  ");
            Console.WriteLine("For Substraction:Press  2");
            Console.WriteLine("For Multiplication:Press  3");
            Console.WriteLine("For Division:Press  4");
            Console.WriteLine("For Exit:Press  5");

            Console.WriteLine("Write Your choice:- ");
            string choice = Console.ReadLine().ToString();

            Console.WriteLine("Answer Is:-  " + p.calculator(choice, x, y));
        }
    }
}
