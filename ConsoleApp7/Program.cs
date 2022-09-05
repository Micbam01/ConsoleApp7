using System;

namespace ConsoleApp4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double Total = 0, interestRate, years, annualCompound, Amount;
            Console.WriteLine("Enter the Initial Amount:");
            Amount = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Enter the Rate of Interest:");
            interestRate = Convert.ToDouble(Console.ReadLine()) / 100;
            years = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Number of Times the Interest will be Compounded:");
            annualCompound = Convert.ToDouble(Console.ReadLine());
            for (int i = 0; i < years; i++)
            {
                Total = Amount * Math.Pow((1 + interestRate / annualCompound)(annualCompound * Total)); ;
                Console.WriteLine("Your Total for Year{0}" + "is {1:F0} .\n", Total, i);

            }


            Console.ReadLine();



        }
    }
}
