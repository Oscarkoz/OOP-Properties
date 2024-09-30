using System.IO;

namespace SeedProducts
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Nu kallar vi på metoden som seeda några produkter
            WriteDefaultProducts();
        }

        static void WriteDefaultProducts()
        {
            string filePath = Path.Combine("..", "..", "..", "MyProducts.txt");

            // Denna if sats är viktig!!!
            if (File.Exists(filePath)) return;

            string text = "11 Jordgubbar 39,90 Styckpris\n" +
                          "22 Nutella 19,90 Styckpris\n" +
                          "33 Citron 4,90 Styckpris\n" +
                          "44 Bananer 9,90 Kilopris\n" +
                          "55 Grädde 15,90 Styckpris\n" +
                          "66 Choklad 9,90 Styckpris\n" +
                          "77 Apelsiner 29,90 Kilopris\n";
            File.WriteAllText(filePath, text);
        }
    }
}
