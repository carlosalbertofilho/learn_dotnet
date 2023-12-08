
namespace TestProject
{
    class MyTest
    {
        public static void Run()
        {
            var owners = new string[] { "Alice", "Bob", "Charlie" };
            var pets = new string[] { "Dog", "Cat", "Bird" };

            foreach (var (owner, pet)
                in owners.Zip(pets, (owner, pet) => (owner, pet)).Skip(1))
            {
                Console.WriteLine($"{owner} has a {pet}");
            }
        }
    }
}