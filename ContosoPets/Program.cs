using System.ComponentModel;
using ContosoPets;

Animal[] ourAnimal =
{
    new()
    {
        Id = "d1",
        Nickname = "lola",
        Species = "dog",
        Age = 2,
        PhysicalDescription =
            "medium sized cream colored female golden retriever weighing about 65 pounds. housebroken.",
        PersonalityDescription =
            "loves to have her belly rubbed and likes to chase her tail. gives lots of kisses."
    },
    new()
    {
        Id = "d2",
        Nickname = "loki",
        Species = "dog",
        Age = 9,
        PhysicalDescription =
            "large reddish-brown male golden retriever weighing about 85 pounds. housebroken.",
        PersonalityDescription =
            "loves to have his ears rubbed when he greets you at the door, or at any time! loves to lean-in and give doggy hugs."
    },
    new()
    {
        Id = "c3",
        Nickname = "Puss",
        Species = "cat",
        Age = 1,
        PhysicalDescription = "small white female weighing about 8 pounds. litter box trained.",
        PersonalityDescription = "friendly"
    },
    new()
    {
        Id = "c4",
        Nickname = "lola",
        Species = "cat"
    }
};

ClientMessages.Run(ourAnimal);
