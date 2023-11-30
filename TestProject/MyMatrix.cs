using System;

namespace TestProject
{
    class MyMatrix()
    {
        public static void Run()
        {
            string[] fraudulentOrderIDs = { "B123", "C234", "A345", "C15", "B177", "G3003", "C235", "B179" };


            Console.Clear();
            Console.WriteLine("\n\n----------------------------------------\n");

            foreach( var orderId in fraudulentOrderIDs)
            {
                 if (orderId.StartsWith("B"))
                 {
                     Console.WriteLine($"Fraudulent order ID: {orderId}");
                 }
            }

             Console.WriteLine("\n\n----------------------------------------\n");
            
        }
    }
}