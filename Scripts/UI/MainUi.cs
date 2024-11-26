using Godot;
using System;

public partial class MainUi : Control
{
    
    [Export] private Label _scoreLabel;

    private ScoreManager _scoreManager;
    public override void _Ready()
    {
        _scoreManager = ManagerManager.GetManager<ScoreManager>();
        _scoreManager.OnScoreChange += UpdateScoreLabel;
    }

    public void UpdateScoreLabel(int score)
    {
        _scoreLabel.Text = "Score : " + score.ToString("00");
    }
}
