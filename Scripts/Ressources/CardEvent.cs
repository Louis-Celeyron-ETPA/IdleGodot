using Godot;
using System;

[GlobalClass]
public partial class CardEvent : Resource
{
	[Export] private int _cost;
	
	public virtual void OnSubscribe(TeamManager teamManager)
	{
		
	}

	public virtual void OnUnsubscribe(TeamManager teamManager)
	{
		
	}

	
	public virtual string  GetDescription()
	{
		return "That's one silly duck";
	}
}
