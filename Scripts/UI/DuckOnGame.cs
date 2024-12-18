using Godot;
using System;

public partial class DuckOnGame : Button
{
    [Export]
    private Duck _currentDuck;

    [Export] private int _currentLove;
    [Export] private Button _buttonRef;
    [Export] private TextureProgressBar _loveBar;

    private ClickManager _clickManager;
    private GoldAndInventoryManager _goldAndInventoryManager;
    private DuckManager _duckManager;
    public override void _Ready()
    {
        base._Ready();
        _clickManager = ManagerManager.GetManager<ClickManager>();
        _duckManager = ManagerManager.GetManager<DuckManager>();
        _goldAndInventoryManager = ManagerManager.GetManager<GoldAndInventoryManager>();
        ButtonDown += RiseLove;
        
        GenerateDuck();
    }

    private void GenerateDuck()
    {
        _currentDuck = _duckManager.GetDucks();
        InitializeDuck();
    }

    private void InitializeDuck()
    {
        UpdateLove(0);
        _buttonRef.SetButtonIcon( _currentDuck.Sprite);

    }
    
    private void RiseLove()
    {
        var tempLove = _currentLove + _clickManager.GetPower();
        UpdateLove(tempLove);
    }
    private void UpdateLove(int newAmount)
    {
        _currentLove = newAmount;
        _loveBar.Value = ((double)_currentLove / (double)_currentDuck.BaseLove) * 100.0;
        if (_currentLove >= _currentDuck.BaseLove)
        {
            OnLoveMaxxed();
        }
    }

    private void OnLoveMaxxed()
    {
        GenerateDuck();
        _goldAndInventoryManager.RiseGold(_currentDuck.GoldAmount);
    }
}
