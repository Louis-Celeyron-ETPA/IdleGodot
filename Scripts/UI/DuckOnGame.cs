using Godot;
using System;

public partial class DuckOnGame : Button
{
    [Export]
    private Duck _currentDuck;

    [Export] private int _currentLove;
    [Export] private TextureProgressBar _loveBar;

    private ClickManager _clickManager;
    public override void _Ready()
    {
        base._Ready();
        _clickManager = ManagerManager.GetManager<ClickManager>();
        ButtonDown += RiseLove;
    }

    private void RiseLove()
    {
        var tempLove = _currentLove + _clickManager.GetPower();
        UpdateLove(tempLove);
    }
    private void UpdateLove(int newAmount)
    {
        _currentLove = newAmount;
        _loveBar.Value = ((double)_currentLove / (double)_currentDuck.BaseHp) * 100.0;
        
    }
}
