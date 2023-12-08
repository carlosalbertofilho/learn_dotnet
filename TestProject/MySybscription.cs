using System;

namespace TestProject
{
    class MySybscription
    {
        public static void Run()
        {
            Random random = new Random();

            var daysUntilExpiration = random.Next(12);
            Console.Clear();
            Console.WriteLine($"Days until expiration: {daysUntilExpiration}");

            if (daysUntilExpiration <= 10)
            {
                Console.WriteLine("Your subscription will expire soon. Renew now!");
            }
            else if (daysUntilExpiration <= 5 )
            {
                Console.WriteLine($"Your subscription expires in {daysUntilExpiration} days.");
                Console.WriteLine("Renew now and save 10%!");
            }
            else if (daysUntilExpiration == 1)
            {
                Console.WriteLine("Your subscription expires within a day!");
                Console.WriteLine("Renew now and save 20%!");
            }
            else
            {
                Console.WriteLine("Your subscription has expired.");
            }
        }
    }
}