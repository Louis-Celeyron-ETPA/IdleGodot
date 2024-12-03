using Godot;
using System;

[GlobalClass]
public partial class ScoreManager : Manager
{
    [Signal]
    public delegate void OnScoreChangeEventHandler(int score);
	
    private int _score;
    private ClickManager _clickManager;

    public override void ManagerInit()
    {
        base.ManagerInit();
        _clickManager = ManagerManager.GetManager<ClickManager>();
    }

    public void RiseScore(int amount)
    {
        SetScore(_score+amount);
    }
    public void SetScore(int newScore)
    {
        _score = newScore;
        EmitSignal(SignalName.OnScoreChange, _score);
    }

    public void RiseScoreByPower()
    {
        RiseScore(_clickManager.GetPower());
    }
    public int GetScore()
    {
        return _score;
    }
}
