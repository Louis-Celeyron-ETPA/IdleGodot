using Godot;
using System;
using Godot.Collections;

[GlobalClass]
public partial class TeamManager : Manager
{
    [Export]
    private Array<Duck> _team;

    private int _currentGem, _maxGem;
    private ClickManager _clickManagerRef;
    public ClickManager ClickManagerRef => _clickManagerRef;

    
    [Signal]
    public delegate void OnGemChangeEventHandler(int score);

    [Signal]
    public delegate void OnTeamUpdatedEventHandler(Array<Duck> team);
    public override void ManagerInit()
    {
        _clickManagerRef = ManagerManager.GetManager<ClickManager>();
        StartOfBattle();
    }
    
    public void AddActionToTeamUpdate(OnTeamUpdatedEventHandler @event)
    {
        OnTeamUpdated += @event;
        UpdateTeam();
    }

    public void UpdateTeam()
    {
        EmitSignal(SignalName.OnTeamUpdated, _team);
    }

    public void StartOfBattle()
    {
        if (_team.Count > 0)
        {
            foreach (var teammate in _team)
            {
                teammate.RunEventOnStart(this);
            }
        }
    }

    public void ChangeGem(int newAmount)
    {
        _currentGem = Mathf.Clamp(newAmount, 0, 100);
        EmitSignal(SignalName.OnGemChange, _currentGem);
    }

    public void AddGem(int amount)
    {
        ChangeGem(_currentGem+amount);
    }
}
