using Godot;
using System;

public partial class ButtonTest : Button
{

	private ScoreManager _scoreManager;
	// Called when the node enters the scene tree for the first time.
	public override void _Ready()
	{
		_scoreManager = ManagerManager.GetManager<ScoreManager>();

	}

	// Called every frame. 'delta' is the elapsed time since the previous frame.
	public override void _Process(double delta)
	{
	}



	private void OnButtonDown()
	{
		_scoreManager.RiseScore(1);
	}

}
