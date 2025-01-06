using Godot;
using System;

[GlobalClass]
public partial class CE_AutoClick : CardEvent
{
    public override void OnSubscribe(TeamManager teamManager)
    {
        teamManager.ClickManagerRef.LaunchAutoClicker();
    }

    public override string GetDescription()
    {
        return "Enable Auto Pet if disable";
    }
}
