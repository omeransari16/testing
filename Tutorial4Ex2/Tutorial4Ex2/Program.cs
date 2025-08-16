using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tutorial4Ex2
{
    class Customer
    {
        // Properties of the Customer class
        public int Id { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }

        public int Age { get; set; }

        // Constructor to initialize the properties
        public Customer(int id, string name, string email, int age)
        {
            Id = id;
            Name = name;
            Email = email;
            Age = age;
        }
    }

    class Program
    {
        static void Main()
        {
            // Create 3 Customer objects with different values
            Customer Cust1 = new Customer(1, "John Doe", "john.doe@example.com", 19);
            Customer Cust2 = new Customer(2, "Jane Smith", "jane.smith@example.com", 9);
            Customer Cust3 = new Customer(3, "Alex Kim", "alex.kim@example.com", 15);

            // Only display customers younger than 10
            if (Cust1.Age < 10) Print(Cust1);
            if (Cust2.Age < 10) Print(Cust2);
            if (Cust3.Age < 10) Print(Cust3);
        }

        static void Print(Customer c)
        {
            Console.WriteLine("ID: " + c.Id);
            Console.WriteLine("Name: " + c.Name);
            Console.WriteLine("Email: " + c.Email);
            Console.WriteLine("Age: " + c.Age);
            Console.WriteLine();
        }
    }

}
    
