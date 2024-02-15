using System;

namespace Constructors
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Constructor : Amacı, bir sınıfın ilk oluşma anını kontrol etmektir.
            // Bir classı newlediğimizde çalışan metottur.
            // Yapıcı metot/blok

            Customer customer = new Customer();

            Customer customer1 = new Customer
            {
                Id = 1,
                FirstName = "Melike",
                LastName = "Dönmez",
                City = "Ankara",
            };

            Customer customer2 = new Customer(2, "Derin", "Demiroğ", "İstanbul");
            Console.WriteLine(customer2.FirstName);

            Console.ReadLine();
        }
    }

    class Customer
    {
        // Default constructor : Parametresi olmayan constructor
        public Customer()
        {
            Console.WriteLine("Yapıcı blok çalıştı !");
        }
        public Customer(int id, string firstName, string lastName, string city)
        {
            Id = id;
            FirstName = firstName;
            LastName = lastName;
            City = city;
        }

        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string City { get; set; }
    }
}