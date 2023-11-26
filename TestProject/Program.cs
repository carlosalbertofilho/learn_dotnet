using System;

Random dice = new Random();
int roll1 = dice.Next();
int roll2 = dice.Next(1, 7);
int roll3 = dice.Next(50, 202);

Console.WriteLine($"First Dice roll: {roll1}");
Console.WriteLine($"Second Dice roll: {roll2}");
Console.WriteLine($"Third Dice roll: {roll3}");

Console.WriteLine("------------------");
int firstValue = 500;
int secondValue = 600;
int largerValue = Math.Max(firstValue, secondValue);

Console.WriteLine(largerValue);