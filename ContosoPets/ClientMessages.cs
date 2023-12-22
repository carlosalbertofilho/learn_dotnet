namespace ContosoPets
{
    public class ClientMessages
    {
        public static string Menu()
        {
            string? readResult;
            string menuSelection = "";

            Console.Clear();

            Console.WriteLine("Welcome to the Contoso PetFriends app. Your main menu options are:");
            Console.WriteLine(" 1. List all of our current pet information");
            Console.WriteLine(" 2. Add a new animal friend to the ourAnimals array");
            Console.WriteLine(" 3. Ensure animal ages and physical descriptions are complete");
            Console.WriteLine(
                " 4. Ensure animal nicknames and personality descriptions are complete"
            );
            Console.WriteLine(" 5. Edit an animal’s age");
            Console.WriteLine(" 6. Edit an animal’s personality description");
            Console.WriteLine(" 7. Display all cats with a specified characteristic");
            Console.WriteLine(" 8. Display all dogs with a specified characteristic");
            Console.WriteLine();
            Console.WriteLine("Enter your selection number (or type Exit to exit the program)");

            readResult = Console.ReadLine();
            if (readResult != null)
            {
                menuSelection = readResult.ToLower();
            }

            return menuSelection;
        }

        public static void AgeAndPhysicalDescriptionSet(Animal[] ourAnimal)
        {
            foreach (var animal in ourAnimal)
            {
                if (!animal.IsAgeAndPhysicalDescriptionSet())
                {
                    Console.WriteLine(
                        $"Animal {animal.Id} is missing age and/or physical description."
                    );
                    animal.SetAge();
                    animal.SetPhysicalDescription();
                }
            }
        }

        public static void NicknameAndPersonalityDescriptionSet(Animal[] ourAnimal)
        {
            foreach (var animal in ourAnimal)
            {
                if (!animal.IsNicknameAndPersonalityDescriptionSet())
                {
                    Console.WriteLine(
                        $"Animal {animal.Id} is missing nickname and/or personality description."
                    );
                    animal.SetNickname();
                    animal.SetPersonalityDescription();
                }
            }
        }

        public static void EditAge(Animal[] ourAnimal)
        {
            Console.WriteLine("List of animals IDs:");
            foreach (var animal in ourAnimal)
                Console.WriteLine($"ID: {animal.Id} Nickname: {animal.Nickname}");
            Console.WriteLine("Enter the ID of the animal whose age you want to edit:");
            var id = Console.ReadLine();
            var animalToEdit = ourAnimal.FirstOrDefault(a => a.Id == id);
            animalToEdit.SetAge();
        }

        public static void DisplayCatsWithCharacteristic(Animal[] ourAnimal)
        {
            Console.WriteLine("Enter the characteristic you want to search for:");
            var characteristic = Console.ReadLine();
            var catsWithCharacteristic = ourAnimal.Where(
                a => a.Species == "cat" && a.PersonalityDescription.Contains(characteristic)
            );
            foreach (var cat in catsWithCharacteristic)
                Console.WriteLine(cat);
        }

        public static void DisplayDogsWithCharacteristic(Animal[] ourAnimal)
        {
            Console.WriteLine("Enter the characteristic you want to search for:");
            var characteristic = Console.ReadLine();
            var dogsWithCharacteristic = ourAnimal.Where(
                a => a.Species == "dog" && a.PersonalityDescription.Contains(characteristic)
            );
            foreach (var dog in dogsWithCharacteristic)
                Console.WriteLine(dog);
        }

        public static void Run(Animal[] ourAnimal)
        {
            switch (Menu())
            {
                case "1":
                    foreach (var animal in ourAnimal)
                        Console.WriteLine(animal);
                    break;
                case "2":
                    ourAnimal = ourAnimal.Append(Animal.AddAnimal()).ToArray();
                    break;
                case "3":
                    AgeAndPhysicalDescriptionSet(ourAnimal);
                    break;
                case "4":
                    NicknameAndPersonalityDescriptionSet(ourAnimal);
                    break;
                case "5":
                    EditAge(ourAnimal);
                    break;
                case "6":
                    NicknameAndPersonalityDescriptionSet(ourAnimal);
                    break;
                case "7":
                    DisplayCatsWithCharacteristic(ourAnimal);
                    break;
                case "8":
                    DisplayDogsWithCharacteristic(ourAnimal);
                    break;
                default:
                    Console.WriteLine("Invalid selection. Please try again.");
                    break;
            }
        }
    }
}
