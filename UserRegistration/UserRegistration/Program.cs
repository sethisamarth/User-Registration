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
                Console.WriteLine("Enter your Mobile Number");
                var check = p.ValidateMobileNumber(Console.ReadLine());
                Console.WriteLine(check);

            }
        }
    }
}
