using System;

namespace Interfaces
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // interface new'lenemez.
            IPersonManager customerManager = new CustomerManager();
            customerManager.Add();

            IPersonManager employeeManager = new EmployeeManager();
            employeeManager.Add();

            ProjectManager projectManager = new ProjectManager();
            projectManager.Add(customerManager);
            projectManager.Add(new EmployeeManager());

            projectManager.Add(new InternManager());

            Console.ReadLine();
        }
    }

    class PersonManager
    {
        // Tamamlanmış Operasyon : Implemented Operation
        public void Add()
        {
            Console.WriteLine("Eklendi!");
        }
    }

    interface IPersonManager
    {
        // Unimplemented Operation
        // Default olarak publictir. Interface üyeleri dışarıdan erişilebilir olmalıdır.
        void Add();
        void Update();
    }

    // inherits -> class
    // implements -> interface
    class CustomerManager : IPersonManager
    {
        public void Add()
        {
            // Müşteri ekleme kodları
            Console.WriteLine("Müşteri Eklendi!");
        }
        public void Update()
        {
            Console.WriteLine("Müşteri Güncellendi!");
        }
    }
    class EmployeeManager : IPersonManager
    {
        public void Add()
        {
            // Personel ekleme kodları
            Console.WriteLine("Personel Eklendi!");
        }
        public void Update()
        {
            Console.WriteLine("Personel Güncellendi!");
        }
    }

    // Yeni özellik eklediğinde mevcut kodlara dokunmamalısın.
    class InternManager : IPersonManager
    {
        public void Add()
        {
            // Stajyer ekleme kodları
            Console.WriteLine("Stajyer Eklendi!");
        }
        public void Update()
        {
            Console.WriteLine("Stajyer Güncellendi!");
        }
    }

    // Merkezi yönetime ihtiyaç var.
    class ProjectManager
    {
        public void Add(IPersonManager personManager)
        {
            personManager.Add();
        }
    }
}