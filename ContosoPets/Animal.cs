namespace ContosoPets
{
    public struct Animal
    {
        public string Id { get; set; }
        public string Nickname { get; set; }
        public string Species { get; set; }
        public int Age { get; set; }
        public string PhysicalDescription { get; set; }
        public string PersonalityDescription { get; set; }

        public override string ToString() =>
            $"Id #: {Id}\n"
            + $"Nickname: {Nickname}\n"
            + $"Species: {Species}\n"
            + $"Age: {Age}\n"
            + $"Physical Description: {PhysicalDescription}\n"
            + $"Personality: {PersonalityDescription}\n";

        public bool IsAgeAndPhysicalDescriptionSet() =>
            Age != 0 && !string.IsNullOrEmpty(PhysicalDescription);

        public bool IsNicknameAndPersonalityDescriptionSet() =>
            !string.IsNullOrEmpty(Nickname) && !string.IsNullOrEmpty(PersonalityDescription);

        public void SetId()
        {
            var random = new Random();
            Id = $"{Species.Substring(0, 1).ToLower()}{random.Next(1, 100)}";
        }

        public static Animal AddAnimal()
        {
            Animal animal = new();
            animal.SetNickname();
            animal.SetSpecies();
            animal.SetAge();
            animal.SetPhysicalDescription();
            animal.SetPersonalityDescription();
            animal.SetId();

            return animal;
        }

        public void SetNickname()
        {
            Console.WriteLine("Enter the animal's nickname:");
            var nickname = Console.ReadLine();

            if (string.IsNullOrEmpty(nickname))
            {
                Console.WriteLine("Nickname cannot be empty.");
                SetNickname();
            }
            else
            {
                Nickname = nickname;
            }
        }

        public void SetSpecies()
        {
            Console.WriteLine("Enter the animal's species: dog or cat");
            var species = Console.ReadLine();

            if (string.IsNullOrEmpty(species))
            {
                Console.WriteLine("Species cannot be empty.");
                SetSpecies();
            }
            else
            {
                switch (species.ToLower())
                {
                    case "dog":
                    case "cat":
                        Species = species;
                        break;
                    default:
                        Console.WriteLine("Species must be dog or cat.");
                        SetSpecies();
                        break;
                }
            }
        }

        public void SetAge()
        {
            Console.WriteLine("Enter the animal's age:");
            var age = Console.ReadLine();

            if (string.IsNullOrEmpty(age))
            {
                Console.WriteLine("Age cannot be empty.");
                SetAge();
            }
            else
            {
                if (int.TryParse(age, out int ageInt))
                {
                    if (ageInt < 0)
                    {
                        Console.WriteLine("Age must be a positive number.");
                        SetAge();
                    }
                    else
                    {
                        Age = ageInt;
                    }
                }
                else
                {
                    Console.WriteLine("Age must be a number.");
                    SetAge();
                }
            }
        }

        public void SetPhysicalDescription()
        {
            Console.WriteLine("Enter the animal's physical description:");
            var physicalDescription = Console.ReadLine();

            if (string.IsNullOrEmpty(physicalDescription))
            {
                Console.WriteLine("Physical description cannot be empty.");
                SetPhysicalDescription();
            }
            else
            {
                PhysicalDescription = physicalDescription;
            }
        }

        public void SetPersonalityDescription()
        {
            Console.WriteLine("Enter the animal's personality description:");
            var personalityDescription = Console.ReadLine();

            if (string.IsNullOrEmpty(personalityDescription))
            {
                Console.WriteLine("Personality description cannot be empty.");
                SetPersonalityDescription();
            }
            else
            {
                PersonalityDescription = personalityDescription;
            }
        }
    }
}
