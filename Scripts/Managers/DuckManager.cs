using Godot;
using System;
using Godot.Collections;

[GlobalClass]
public partial class DuckManager : Manager
{
    [Export] private Array<Duck> _availableDucks;

    public Duck GetDucks()
    {
        var randIndex = (int)(GD.Randi() % _availableDucks.Count);
        return _availableDucks[randIndex];
    }


}
