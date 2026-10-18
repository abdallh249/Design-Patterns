
using System;

namespace SingletonExampl;

public static class Program
{
    public static void Main(string[] args)
    {
        

        Console.WriteLine("=== Builder Pattern ===");

        PlayerProfile player = new PlayerBuilder()
            .SetUsername("abdullah")
            .SetClassType("Warrior")
            .SetLevel(10)
            .AddItem("Sword")
            .AddItem("Shield")
            .AddItem("Potion")
            .Build();

        Console.WriteLine($"Username: {player.Username}");
        Console.WriteLine($"ClassType: {player.ClassType}");
        Console.WriteLine($"Level: {player.Level}");

        Console.WriteLine("Inventory:");

        foreach (string item in player.Inventory)
        {
            Console.WriteLine($"- {item}");
        }

        

        Console.WriteLine("\n=== Singleton Pattern ===");

        GameSettings settings1 = GameSettings.Instance;

        settings1.Difficulty = "Hard";
        settings1.SoundVolume = 80;

        settings1.ShowDifficulty();
        settings1.ShowSoundVolume();

        GameSettings settings2 = GameSettings.Instance;

        settings2.SoundVolume = 30;

        Console.WriteLine("\nAfter changing settings2:");

        settings1.ShowSoundVolume();

        Console.WriteLine(
            $"Same Instance: {ReferenceEquals(settings1, settings2)}"
        );
    }
}
