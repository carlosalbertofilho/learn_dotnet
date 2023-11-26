using System;

namespace TestProject
{
    class MyString
    {
        public static void MyGuids()
        {
            var id = Guid.NewGuid();
            Console.WriteLine(id);
        }

        public static void MyInterpolation()
        {
            var name = "Carlos";
            var lastName = "Filho";
            var age = 34;
            var height = 1.85;

            Console.WriteLine($"Id: {Guid.NewGuid()}");
            Console.WriteLine($"Nome: {name} {lastName}, Idade: {age}, Altura: {height}");
        }
    }
}