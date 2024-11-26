using Godot;
using System;

[GlobalClass]
public partial class GameMaster : Node
{
	
	[Signal]
	public delegate void OnScoreChangeEventHandler(int score);
	
	private int _score; 
	
	// Called when the node enters the scene tree for the first time.
	public override void _Ready()
	{
	}

	// Called every frame. 'delta' is the elapsed time since the previous frame.
	public override void _Process(double delta)
	{
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
	public int GetScore()
	{
		return _score;
	}
}
