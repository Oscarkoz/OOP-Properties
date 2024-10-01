namespace ColorBallsProperties
{
    public class Colour
    {
        public string Name { get; set; }

        private int _red;
        public int Red
        {
            get { return _red; }
            set
            {
                if (value >= 0 && value <= 255)
                    _red = value;
                else
                    throw new ArgumentOutOfRangeException("Value must be between 0 and 255");
            }
        }

        private int _green;
        public int Green
        {
            get { return _green; }
            set
            {
                if (value >= 0 && value <= 255)
                    _green = value;
                else
                    throw new ArgumentOutOfRangeException("Value must be between 0 and 255");
            }
        }

        private int _blue;
        public int Blue
        {
            get { return _blue; }
            set
            {
                if (value >= 0 && value <= 255)
                    _blue = value;
                else
                    throw new ArgumentOutOfRangeException("Value must be between 0 and 255");
            }
        }

        // Metod för att returnera färgen som en RGB-sträng
        public string GetRgb()
        {
            return $"RGB({Red}, {Green}, {Blue})";
        }
    }
}
