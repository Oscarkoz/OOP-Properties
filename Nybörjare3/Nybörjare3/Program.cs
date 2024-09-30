namespace Nybörjare3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // 3. Write and call a method that returns the area of a circle (2 decimals).
            float radius = 4.2f;
            float result = AreaofCircle(radius);
            Console.WriteLine($"The area of the circle is: {result:F2} ");
        }
        public static float AreaofCircle(float radius)
        {
            float area = (float)(Math.PI * radius * radius);
            return area;
        }
    }
}
