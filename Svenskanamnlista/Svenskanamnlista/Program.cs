namespace Svenskanamnlista
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<string> SvenskaNamn = new List<string>
            {
                "Oscar", "Johan", "Erik", "Calle", "Joanna", "Edmund", "Fredrik", "Molly", "Anna"
            };

            string dagensDatum = DateTime.Now.ToString("yyyy-MM-dd");

            string filnamn = $"Swedish Names-{dagensDatum}.txt";
            using (StreamWriter writer = new StreamWriter(filnamn))
            {
                foreach (var namn in SvenskaNamn)
                {
                    Console.WriteLine(namn);
                }
            }

            using (StreamReader reader = new StreamReader(filnamn))
            {
                string line;
                while ((line = reader.ReadLine()) != null)
                {
                    Console.WriteLine(line);
                }
            }
        }
    }
}
