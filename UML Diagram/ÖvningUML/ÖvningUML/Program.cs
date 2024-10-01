using System;

namespace PersonAddressExample
{

    public class CustomObject
    {
        public int Id { get; set; }
        public string Name { get; set; }
    }


    public class Person : CustomObject
    {

        public string Phone { get; set; }
        public string EmailAddress { get; set; }


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


        public Address PersonAddress { get; set; }
    }


    public class Address
    {

        public string Street { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public string PostalCode { get; set; }
        public string Country { get; set; }

 
        public bool ValidatePostalCode()
        {
 
            return PostalCode.Length == 5 && int.TryParse(PostalCode, out _);
        }

        public string GetAddress()
        {
            return $"{Street}, {City}, {State}, {PostalCode}, {Country}";
        }
    }


    class Program
    {
        static void Main(string[] args)
        {

            Person person = new Person
            {
                Id = 1,
                Phone = "0709683944", // Mitt namn
                EmailAddress = "oscarturell@gmail.com", // min mail
                PersonAddress = new Address // min address
                {
                    Street = "Torgny Segerstedts allé 97", // Address
                    City = "Uppsala", // Stad
                    State = "Uppsala County", // Ort
                    PostalCode = "752 57", // Mitt postnr
                    Country = "Sweden"
                }
            };

            person.SetName("Oscar Turell");


            Console.WriteLine($"ID: {person.GetId()}");
            Console.WriteLine($"Name: {person.GetName()}");
            Console.WriteLine($"Phone: {person.Phone}");
            Console.WriteLine($"Email: {person.EmailAddress}");
            Console.WriteLine($"Address: {person.PersonAddress.GetAddress()}");
            Console.WriteLine($"Is Postal Code Valid: {person.PersonAddress.ValidatePostalCode()}");
        }
    }
}
