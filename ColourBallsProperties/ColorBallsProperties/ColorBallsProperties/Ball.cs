using System.Drawing;

namespace ColorBallsProperties
{
    public class Ball
    {
        // Auto-Implemented Property
        public int Size { get; set; }

        // Vanlig property med privat instansvariabel (backing field)
        private Colour _colour;
        public Colour Colour
        {
            get { return _colour; }
            set { _colour = value; }
        }

        // Privat instansvariabel för TimesThrown
        private int _timesThrown;

        // Property för TimesThrown med endast get; set privat
        public int TimesThrown
        {
            get { return _timesThrown; }
            private set { _timesThrown = value; }
        }

        // Metod för att kasta bollen och uppdatera TimesThrown
        public void Throw()
        {
            if (Size > 0)
            {
                TimesThrown++;
                Console.WriteLine($"Ball has been thrown {TimesThrown} times.");
            }
            else
            {
                Console.WriteLine("The ball is broken and can't be thrown.");
            }
        }

        // Metod för att förstöra bollen (gör Size till 0)
        public void Pop()
        {
            Size = 0;
            Console.WriteLine("The ball has been popped!");
        }
    }
}
