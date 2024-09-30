public class Program
{
    static void Main(string[] args)
    {
        CountToTen();
    }

    static void CountToTen()
    {
        for (int index = 1; index <= 10; index++)
            Console.Write($"{index}, ");
    }
}