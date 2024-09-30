namespace Methodstest123
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var name = "Oscar";
            var age = 24;
            var hours = 10;

            var salary = SalaryCalculator(name, age, hours);
            Console.WriteLine($"Den korrekta lönen är {salary} kr");

            double SalaryCalculator(string name, double age, double hours)
            {
                double salaryPerHour = 0;

                if (age < 25)
                    salaryPerHour = 150;
                else if (age >= 25 && age <= 50)
                    salaryPerHour = 180;
                else
                    salaryPerHour = 170;

                if (name == "Oscar")
                    salaryPerHour = salaryPerHour * 2.4;

                return salaryPerHour * hours;
            }
        }
    }
}
