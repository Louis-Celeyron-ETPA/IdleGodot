using Godot;
using System;

public partial class DuckOnGame : StaticBody2D
{
    
    [Export] private int _currentLove;
    [Export] private TextureProgressBar _loveBar;
    [Export] private Sprite2D _sprite;

    private ClickManager _clickManager;
    private GoldAndInventoryManager _goldAndInventoryManager;
    private DuckManager _duckManager;

    public Duck CurrentDuck => _duckManager.CurrentDuck;
    public override void _Ready()
    {
        base._Ready();
        _clickManager = ManagerManager.GetManager<ClickManager>();
        _duckManager = ManagerManager.GetManager<DuckManager>();
        _goldAndInventoryManager = ManagerManager.GetManager<GoldAndInventoryManager>();
        
        _duckManager.OnDuckLoaded += InitializeDuck;
        _duckManager.GenerateDuck();
    }

    private void OnInputEvent(Node viewport, InputEvent @event, long shapeidx)
    {
        if (@event is InputEventMouse inputEventMouse)
        {
            if (inputEventMouse.ButtonMask == MouseButtonMask.Left)
            {
                RiseLove();
            }
        }

        if (@event is InputEventScreenTouch)
        {
            RiseLove();
        }
    }

    private void InitializeDuck(Duck newDuck)
    {
        UpdateLove(0);
        _sprite.Texture = newDuck.Sprite;
    }
    
    private void RiseLove()
    {
        var tempLove = _currentLove + _clickManager.GetPower();
        UpdateLove(tempLove);
    }
    private void UpdateLove(int newAmount)
    {
        _currentLove = newAmount;
        _loveBar.Value = ((double)_currentLove / (double)CurrentDuck.BaseLove) * 100.0;
        if (_currentLove >= CurrentDuck.BaseLove)
        {
            OnLoveMaxxed();
        }
    }

    private void OnLoveMaxxed()
    {
        _goldAndInventoryManager.RiseGold(CurrentDuck.GoldAmount);
        _duckManager.GenerateDuck();
    }
}
