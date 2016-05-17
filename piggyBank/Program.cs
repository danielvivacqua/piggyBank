using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace piggyBank
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the Piggy Bank Calculator!");
            int[] coins = new int[6];

            Console.WriteLine("Please enter in the number of pennies you have: ");
            coins[0] = int.Parse(Console.ReadLine());
            Console.WriteLine("Please enter in the number of nickels you have: ");
            coins[1] = int.Parse(Console.ReadLine());
            Console.WriteLine("Please enter in the number of dimes you have: ");
            coins[2] = int.Parse(Console.ReadLine());
            Console.WriteLine("Please enter in the number of quarters you have: ");
            coins[3] = int.Parse(Console.ReadLine());
            Console.WriteLine("Please enter in the number of half-dollars you have: ");
            coins[4] = int.Parse(Console.ReadLine());
            Console.WriteLine("Please enter in the number of gold dollars you have: ");
            coins[5] = int.Parse(Console.ReadLine());
            

            decimal totalCents = coins[0] + (coins[1] * 5) + (coins[2] * 10) + (coins[3] * 25) + (coins[4] * 50) + (coins[5] * 100);
            decimal finalAmount = totalCents / 100;
            Console.WriteLine(finalAmount);

            Console.WriteLine(finalAmount % 20);
            decimal twenty = finalAmount - (finalAmount % 20);
            Console.WriteLine("You can get {0} twenty dollar bills.", twenty / 20);
        }
    }
}
