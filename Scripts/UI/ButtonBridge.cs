using Godot;
using System;

public partial class ButtonBridge : Button
{

	private GoldAndInventoryManager _goldAndInventoryManager;
	private TeamManager _teamManager;
	private ClickManager _clickManager;
	// Called when the node enters the scene tree for the first time.
	public override void _Ready()
	{
		_clickManager = ManagerManager.GetManager<ClickManager>();
		_goldAndInventoryManager = ManagerManager.GetManager<GoldAndInventoryManager>();
		_teamManager = ManagerManager.GetManager<TeamManager>();
	}

	// Called every frame. 'delta' is the elapsed time since the previous frame.
	public override void _Process(double delta)
	{
	}

	
	private void RisePower()
	{
		_clickManager.RisePower();
	}

	private void RiseScoreByPower()
	{
		_goldAndInventoryManager.RiseScoreByPower();
	}

}
