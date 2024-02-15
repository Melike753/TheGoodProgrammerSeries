using System;

namespace ReferenceTypes
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // int,decimal,float,enum,boolean -> değer tipler (value types)

            int sayi1 = 10;
            int sayi2 = 20;

            sayi1 = sayi2;
            sayi2 = 100;
            Console.WriteLine("Sayi1 is " + sayi1);

            // arraylar referans tiplerdir. arrays,classes,interface -> reference types
            // referans tiplerde adres eşitleme yapılır.

            int[] sayilar = new int[] { 1, 2, 3 };
            int[] sayilar2 = new int[] { 10, 20, 30 };

            sayilar = sayilar2;
            sayilar2[0] = 1000;

            Console.WriteLine(sayilar[0]);

            Person person1 = new Person();
            Person person2 = new Person();

            person1.FirstName = "Melike";
            person2 = person1;
            person1.FirstName = "Engin";
            Console.WriteLine(person2.FirstName);

            Customer customer = new Customer();
            customer.FirstName = "İbrahim";
            customer.CreditCardNumber = "123656544885";

            Employee employee = new Employee();

            // Böyle bir atama işlemi gerçekleştirilemez.
            // customer = employee;

            Person person3 = customer;
            customer.FirstName = "Ahmet";
            Console.WriteLine(person3.FirstName);
            Console.WriteLine(((Customer)person3).CreditCardNumber);

            Person person4 = employee;

            PersonManager personManager = new PersonManager();
            personManager.Add(person3);
            // person yerine customer ya da employee gönderebiliyorum.
            personManager.Add(customer);

            Console.ReadLine();
        }
    }

    // Base Class 
    class Person
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
    }

    class Customer : Person
    {
        public string CreditCardNumber { get; set; }
    }

    class Employee : Person
    {
        public int EmployeeNumber { get; set; }
    }

    class PersonManager
    {
        public void Add(Person person)
        {
            Console.WriteLine(person.FirstName);
        }
    }
}