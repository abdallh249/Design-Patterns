
using System;
using System.Collections.Generic;

public sealed class PlayerProfile
{
    public string Username { get; set; }
    public string ClassType { get; set; }
    public int Level { get; set; }
    public List<string> Inventory { get; set; }

    public PlayerProfile()
    {
        Username = "";
        ClassType = "";
        Level = 1;
        Inventory = new List<string>();
    }
}

public class PlayerBuilder
{
    private readonly PlayerProfile _player = new PlayerProfile();

    public PlayerBuilder SetUsername(string username)
    {
        _player.Username = username;
        return this;
    }

    public PlayerBuilder SetClassType(string classType)
    {
        _player.ClassType = classType;
        return this;
    }

    public PlayerBuilder SetLevel(int level)
    {
        _player.Level = level;
        return this;
    }

    public PlayerBuilder AddItem(string item)
    {
        _player.Inventory.Add(item);
        return this;
    }

    public PlayerProfile Build()
    {
        return new PlayerProfile
        {
            Username = _player.Username,
            ClassType = _player.ClassType,
            Level = _player.Level,
            Inventory = new List<string>(_player.Inventory)
        };
    }
}
