using Godot;
using System;
using Godot.Collections;

[GlobalClass]
public partial class CardsManager : Manager
{
    [Export]
    private Array<Card> _cards;

    private int _currentGem, _maxGem;
    private ClickManager _clickManagerRef;
    public ClickManager ClickManagerRef => _clickManagerRef;

    
    [Signal]
    public delegate void OnGemChangeEventHandler(int score);
    public override void ManagerInit()
    {
        _clickManagerRef = ManagerManager.GetManager<ClickManager>();
    }

    public void Draw()
    {
        _cards[0].Draw(this);
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
