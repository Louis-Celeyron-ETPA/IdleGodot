using Godot;
using System;

public partial class ButtonBridge : Button
{

	private GoldAndInventoryManager _goldAndInventoryManager;
	private CardsManager _cardsManager;
	private ClickManager _clickManager;
	// Called when the node enters the scene tree for the first time.
	public override void _Ready()
	{
		_clickManager = ManagerManager.GetManager<ClickManager>();
		_goldAndInventoryManager = ManagerManager.GetManager<GoldAndInventoryManager>();
		_cardsManager = ManagerManager.GetManager<CardsManager>();
	}

	// Called every frame. 'delta' is the elapsed time since the previous frame.
	public override void _Process(double delta)
	{
	}

	public void Temp_Draw()
	{
		_cardsManager.Draw();
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
