using Godot;
using System;

[GlobalClass]
public partial class ClickManager : Manager
{
    private int _power = 1,_tempPower = 0, _tempAutoPower = 0;
    [Export] private Timer _autoTimer;
    
    [Signal]
    public delegate void OnLoveRaisedEventHandler(int amount);
    [Signal]
    public delegate void OnLoveAutoRaisedEventHandler(int amount);
    
    
    public int GetPower()
    {
        return _power + _tempPower;
    }
    public int GetAutoPower()
    {
        return _power + _tempAutoPower;
    }

    public void RisePower()
    {
        _power++;
    }

    public void LaunchAutoClicker()
    {
        _autoTimer.Start();
    }
    public void SetAutoClicker(int autoPower)
    {
        _tempAutoPower += autoPower;
    }
    
    public void RiseTempPower(int amount)
    {
        _tempPower = Mathf.Clamp(_tempPower+ amount,0,int.MaxValue);
    }

    public void GenericAutoLove()
    {
        
        EmitSignal(SignalName.OnLoveAutoRaised, GetPower());
    }
    public void GenericRiseLove()
    {
        EmitSignal(SignalName.OnLoveRaised, GetPower());
    }
}
