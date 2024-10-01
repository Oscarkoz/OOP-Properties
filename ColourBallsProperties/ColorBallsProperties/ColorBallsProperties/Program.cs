using System;

namespace ColorBallsProperties
{
    class Program
    {
        static void Main(string[] args)
        {
            // Skapa ett Colour-objekt
            Colour ballColour = new Colour { Name = "Red", Red = 255, Green = 0, Blue = 0 };

            // Skapa ett Ball-objekt
            Ball ball = new Ball { Size = 5, Colour = ballColour };

            // Kasta bollen några gånger
            ball.Throw();
            ball.Throw();

            // Poppa bollen
            ball.Pop();

            // Försök kasta den igen
            ball.Throw();

            // Visa bollen färg och RGB-värden
            Console.WriteLine($"Ball's colour: {ball.Colour.Name}, RGB: {ball.Colour.GetRgb()}");
        }
    }
}
