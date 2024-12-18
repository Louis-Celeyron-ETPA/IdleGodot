using Godot;
using System;

[GlobalClass]
public partial class GoldAndInventoryManager : Manager
{
    [Signal]
    public delegate void OnGoldChangeEventHandler(int score);
	
    private int _gold;
    private ClickManager _clickManager;

    public override void ManagerInit()
    {
        base.ManagerInit();
        _clickManager = ManagerManager.GetManager<ClickManager>();
    }

    public void RiseGold(int amount)
    {
        SetGold(_gold+amount);
    }
    public void SetGold(int newScore)
    {
        _gold = newScore;
        EmitSignal(SignalName.OnGoldChange, _gold);
    }

    public void RiseScoreByPower()
    {
        RiseGold(_clickManager.GetPower());
    }
    public int GetScore()
    {
        return _gold;
    }
}
