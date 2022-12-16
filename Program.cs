using System.Data;

namespace project_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello at Prime application");

            Console.WriteLine("please enter the 1st Number");
            int FirstNumber=int.Parse(Console.ReadLine());

            Console.WriteLine("please enter 2nd Number");
            int SecondNumber=int.Parse(Console.ReadLine());

            int i;

            for (i =FirstNumber; i<=SecondNumber; i++)
            {
                if(i==2)
                {
                    Console.WriteLine(i+"is prime");
                }
                else if(i==3)
                {
                    Console.WriteLine(i+"is prime");
                }
                else if(i==5)
                {
                    Console.WriteLine(i + "is prime");
                }
            }
            for (i = FirstNumber; i <= SecondNumber; i++)
            {
                if (i == 1)
                {
                    continue;
                }

                else if (i % 2 == 0)
                {
                    continue;
                }
                else if (i % 3 == 0)
                {
                    continue;
                }
                else if (i % 5 == 0)
                {
                    continue;
                }
                Console.WriteLine(i + "is prime");
            }
















        }
    }
}