﻿public class Player
{
    string id;
    string name;

    public Player(string id, string name)
    {
        this.id = id;
        this.name = name;
    }

    public string Id { get => id; set => id = value; }
    public string Name { get => name; set => name = value; }

    public override string ToString()
    {
        return Id +" : "+ Name;
    }
}