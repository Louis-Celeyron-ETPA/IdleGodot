using Godot;
using Godot.Collections;
using System;

public partial class TimeManager : Manager
{
	private Array<Timer> _timers;
	
	public void CreateTimer(Action<TeamManager> callback, int seconds, string name = "Timer")
	{
		var tempTimer = new Timer();
		tempTimer.Name = name;
		tempTimer.WaitTime = seconds;
	}
}
