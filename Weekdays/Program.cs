using System;

namespace Weekdays
{
    internal class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.Clear();
                int DayNumber;

                try
                {
                    Console.WriteLine("Please, enter the number (from 1 to 7)");
                    DayNumber = int.Parse(Console.ReadLine());

                }
                catch (Exception)
                {
                    Console.WriteLine("Please, choose the correct form! Press 'Enter' and try again.");
                    Console.ReadLine();
                    continue;
                }

                switch (DayNumber)

                {
                    case 1:
                        Console.WriteLine("Monday"); // can write diferent form "1 - Monday" etc
                        break;

                    case 2:
                        Console.WriteLine("Tuesday");
                        break;

                    case 3:
                        Console.WriteLine("Wednesday");
                        break;

                    case 4:
                        Console.WriteLine("Thursday");
                        break;

                    case 5:
                        Console.WriteLine("Friday");
                        break;

                    case 6:
                        Console.WriteLine("Saturday");
                        break;

                    case 7:
                        Console.WriteLine("Sunday");
                        break;

                    default:
                        Console.WriteLine("Please, write correct form!");
                        break;

                }
                Console.ReadLine();

            }   
        }
    }
}