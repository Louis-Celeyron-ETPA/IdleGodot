using Godot;
using Godot.Collections;
using System;

[GlobalClass]
public partial class Duck : Resource
{
	[Export] public int BaseLove, BaseRun = 50;
	[Export] public Texture2D Sprite;
	[Export] public float RunRate = .2f;
	[Export] public int GoldAmount;
	[Export] private Array<CardEvent> _events;

	public void RunEventOnStart(TeamManager teamManager)
	{
		foreach (var  @event in _events)
		{
			@event.OnSubscribe(teamManager);
		}
	}

	public string GetDescription()
	{
		var s = string.Empty;
		if (_events is { Count: > 0 })
		{
			foreach (var @event in _events)
			{
				if (@event != null)
				{
					s += @event.GetDescription();
				}
			}
			return s;
		}
		
		return "Does nothing, but is silly, always c:";
	}
}
