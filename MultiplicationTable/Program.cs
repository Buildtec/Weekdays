using System;

namespace MultiplicationTable
{
    internal class Program
    {
        static void Main(string[] args)
        {

            while (true)
            {
                Console.Clear();
                Console.WriteLine(" Please write number(1,2,3 etc) ");
                string str = Console.ReadLine();

                try
                {
                    int n = Convert.ToInt32(str);
                    Console.WriteLine($"\t" + "Your number is" + "\t" + str);

                    for (int i = 1; i < 11; i++)
                    {
                        int m = i * n;
                        Console.WriteLine("{0}*{1}={2}", i, n, m);

                    }
                    Console.WriteLine("\t" + "If you want to continue press button!");
                    Console.ReadLine();

                }
                catch (Exception)
                {
                    Console.WriteLine("Please, enter valid  number ! ");
                    Console.ReadLine();
                }
            }       
        }
    }
}
