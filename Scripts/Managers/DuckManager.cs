using Godot;
using System;
using Godot.Collections;

[GlobalClass]
public partial class DuckManager : Manager
{
    [Export] private Array<Duck> _availableDucks;
    [Export] private DuckOnGame _duckOnGame; 
        
    [Signal] public delegate void OnDuckLoadedEventHandler(Duck newDuck);

    [Export] private Duck _currentDuck;
    public Duck CurrentDuck => _currentDuck;
    public Duck GetDucks()
    {
        var randIndex = (int)(GD.Randi() % _availableDucks.Count);
        return _availableDucks[randIndex];
    }

    public void GenerateDuck()
    {
        _currentDuck = GetDucks();
        InitializeDuck();
    }
    public void InitializeDuck()
    {
        EmitSignal(SignalName.OnDuckLoaded, _currentDuck);
    }

}
