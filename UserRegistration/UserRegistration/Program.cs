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
                Console.WriteLine("Enter your Password");
                var check = p.ValidatePassword(Console.ReadLine());
                Console.WriteLine(check);

            }
        }
    }
}
