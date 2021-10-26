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
                Console.WriteLine("Enter your LastName");
                var check = p.ValidateLastName(Console.ReadLine());
                Console.WriteLine(check);

            }
        }
    }
}
