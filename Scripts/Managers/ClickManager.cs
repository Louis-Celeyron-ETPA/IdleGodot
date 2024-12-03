using Godot;
using System;

[GlobalClass]
public partial class ClickManager : Manager
{
    private int _power = 1;
    private int _tempPower = 0;
    
    public int GetPower()
    {
        return _power + _tempPower;
    }

    public void RisePower()
    {
        _power++;
    }

    public void RiseTempPower(int amount)
    {
        _tempPower = Mathf.Clamp(_tempPower+ amount,0,int.MaxValue);
    }
}
