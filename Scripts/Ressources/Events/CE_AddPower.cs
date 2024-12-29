using Godot;
using System;

[GlobalClass]
public partial class CE_AddPower : CardEvent
{
    [Export]
    private int _amount;
    public override void OnSubscribe(TeamManager teamManager)
    {
        teamManager.ClickManagerRef.RiseTempPower(_amount);
    }

    public override void OnUnsubscribe(TeamManager teamManager)
    {
        teamManager.ClickManagerRef.RiseTempPower(-_amount);
    }

    public override string GetDescription()
    {
        return $"+ {_amount} pet power";
    }
}
