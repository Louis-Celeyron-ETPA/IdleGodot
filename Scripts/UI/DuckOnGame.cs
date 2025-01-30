using Godot;
using System;
using Godot.Collections;

public partial class DuckOnGame : StaticBody2D
{
    
    [Export] private int _currentLove,_currentRun;
    [Export] private TextureProgressBar _loveBar, _runBar;
    [Export] private Sprite2D _sprite;
    [Export] private Timer _runTimer;
    [Export] private Array<AnimLauncher> _animLaunchers;

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

        _clickManager.OnLoveRaised += RiseLove;
        _clickManager.OnLoveAutoRaised += RiseLove;
        
        _duckManager.OnDuckLoaded += InitializeDuck;
    }

    private void OnInputEvent(Node viewport, InputEvent @event, long shapeidx)
    {
        if (@event is InputEventMouse inputEventMouse)
        {
            if (inputEventMouse.ButtonMask == MouseButtonMask.Left)
            {
                _clickManager.GenericRiseLove();
            }
        }

        if (@event is InputEventScreenTouch)
        {
            _clickManager.GenericRiseLove();
        }
    }

    private void InitializeDuck(Duck newDuck)
    {
        UpdateLove(0);
        UpdateRun(0);
        _runTimer.WaitTime = newDuck.RunRate;
        _sprite.Texture = newDuck.Sprite;
    }

    private void RiseLove(int amount)
    {
        _animLaunchers.PickRandom().PlayAnimation();
        UpdateLove(_currentLove+amount);
    }
    private void UpdateLove(int newAmount)
    {
        _currentLove = newAmount;
        _loveBar.Value = ((double)_currentLove / (double)CurrentDuck.BaseLove) * 100.0;
        
        if (_currentLove >= CurrentDuck.BaseLove)
        {
            OnLoveMaxed();
        }
    }
    private void RiseRun()
    {
        UpdateRun(_currentLove+1);
    }
    public void UpdateRun(int amount)
    {
        _currentRun = amount;
        _runBar.Value =  ((double)_currentRun / (double)CurrentDuck.BaseRun) * 100.0;

        if (_currentRun >= CurrentDuck.BaseRun)
        {
            OnRunMaxed();            
        }
    }
    private void OnLoveMaxed()
    {
        _goldAndInventoryManager.RiseGold(CurrentDuck.GoldAmount);
        _duckManager.GenerateDuck();
    }

    private void OnRunMaxed()
    {
        //Add flee fx
        _duckManager.GenerateDuck();
    }
}
