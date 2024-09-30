using System;

namespace Enumerations
{
    public enum MonthsofYear
    {
        January = 1,
        February = 2,
        March = 3,
        April = 4,
        May = 5,
        June = 6,
        July = 7,
        August = 8,
        September = 9,
        October = 10,
        November = 11,
        December = 12
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            int input;
            while (true)
            {
                Console.WriteLine("Välj ett nummer mellan 1 - 12 ");
                input = int.Parse(Console.ReadLine());

                if (Enum.IsDefined(typeof(MonthsofYear), input))
                {

                    MonthsofYear today = (MonthsofYear)input;
                    Console.WriteLine($"Nummer {input} är {today} månad");
                    break;
                }
                else
                {
                    Console.WriteLine($"Vänligen välj ett giltigt nummer");
                }
            }
        }
    }
}

