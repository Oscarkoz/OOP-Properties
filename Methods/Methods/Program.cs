namespace Methods
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Arrange variables
            var name = "Richard";
            var age = 53;
            var hours = 10;

            // Call Method - Option 1
            var salary = SalaryCalculator(name, age, hours);
            Console.WriteLine($"Den korrekta lönen är: {salary}kr");

            // Call Method - Option 2
            // Console.WriteLine($"Den korrekta lönen är: {SalaryCalculator(name, age, hours)}kr");

            // Define Method
            double SalaryCalculator(string name, int age, int totalHours)
            {
                double salaryPerHour = 0;

                if (age < 30)
                    salaryPerHour = 100;
                else if (age >= 30 && age <= 50)
                    salaryPerHour = 120;
                else
                    salaryPerHour = 130;

                if (name == "Richard")
                    salaryPerHour = salaryPerHour * 1.1;

                return salaryPerHour * totalHours;
            }
        }
    }
}