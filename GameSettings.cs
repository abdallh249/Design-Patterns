
using System;

namespace SingletonExampl;

public sealed class GameSettings
{
    private static readonly GameSettings _instance = new();

    public string Difficulty { get; set; } = "Hard";

    public int SoundVolume { get; set; } = 50;

    private GameSettings()
    {
    }

    public static GameSettings Instance => _instance;

    public void ShowSoundVolume()
    {
        Console.WriteLine($"SoundVolume: {SoundVolume}");
    }

    public void ShowDifficulty()
    {
        Console.WriteLine($"Difficulty: {Difficulty}");
    }
}
