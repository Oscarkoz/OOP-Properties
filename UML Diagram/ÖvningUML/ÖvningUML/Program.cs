using System;

namespace PersonAddressExample
{
    // 1. Object class with Id and Name properties
    public class CustomObject
    {
        public int Id { get; set; }
        public string Name { get; set; }
    }

    // 2. Person class inheriting from Object
    public class Person : CustomObject
    {
        // 3. Additional properties
        public string Phone { get; set; }
        public string EmailAddress { get; set; }

        // 4. Methods
        public void SetName(string name)
        {
            Name = name;
        }

        public string GetName()
        {
            return Name;
        }

        public int GetId()
        {
            return Id;
        }

        // 8. Dependency on Address
        public Address PersonAddress { get; set; }
    }

    // 5. Address class
    public class Address
    {
        // 6. Properties
        public string Street { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public string PostalCode { get; set; }
        public string Country { get; set; }

        // 7. Methods
        public bool ValidatePostalCode()
        {
            // Simple validation for example: length should be 5 for US ZIP codes
            return PostalCode.Length == 5 && int.TryParse(PostalCode, out _);
        }

        public string GetAddress()
        {
            return $"{Street}, {City}, {State}, {PostalCode}, {Country}";
        }
    }

    // Program class to demonstrate functionality
    class Program
    {
        static void Main(string[] args)
        {
            // Create a new person
            Person person = new Person
            {
                Id = 1,
                Phone = "0709683944",
                EmailAddress = "oscarturell@gmail.com",
                PersonAddress = new Address
                {
                    Street = "Torgny Segerstedts allé 97",
                    City = "Uppsala", // An example city; you can change this as needed
                    State = "Uppsala County", // An example state; you can change this as needed
                    PostalCode = "752 37", // An example postal code; please replace it with the actual one
                    Country = "Sweden"
                }
            };

            person.SetName("Oscar Turell");

            // Output person information
            Console.WriteLine($"ID: {person.GetId()}");
            Console.WriteLine($"Name: {person.GetName()}");
            Console.WriteLine($"Phone: {person.Phone}");
            Console.WriteLine($"Email: {person.EmailAddress}");
            Console.WriteLine($"Address: {person.PersonAddress.GetAddress()}");
            Console.WriteLine($"Is Postal Code Valid: {person.PersonAddress.ValidatePostalCode()}");
        }
    }
}
