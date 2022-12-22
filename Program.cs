namespace Project_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello at perfect num app");

            Console.WriteLine("Enter FirstNumber");
            int FirstNumber=int.Parse(Console.ReadLine());

            Console.WriteLine("Enter SecondNumber");
            int SecondNumber=int.Parse(Console.ReadLine());

            for(int i=FirstNumber;i<=SecondNumber ;i++)
            {
                int y = 1;
                int Sum = 0;

                while(y<i)
                {
                    if (i % y == 0)
                     Sum += y;
                    y++;
                }
                if (Sum == i)
                    Console.WriteLine("Perfct numbers are "+i);
           
            }

           
           

        }
    }
}