using System;

namespace UserRegistration
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to User Registration!!!");
            while (true)
            {
                Pattern p = new Pattern();
                Console.WriteLine("Enter your FirstName");
                var check = p.ValidateFirstName(Console.ReadLine());
                Console.WriteLine(check);

            }
        }
    }
}
