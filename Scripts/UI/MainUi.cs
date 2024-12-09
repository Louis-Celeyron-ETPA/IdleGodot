using Godot;
using System;

public partial class MainUi : Control
{
    
    [Export] private Label _scoreLabel;
    [Export] private Label _gemLabel;

    private ScoreManager _scoreManager;
    private CardsManager _cardsManager;
    public override void _Ready()
    {
        _scoreManager = ManagerManager.GetManager<ScoreManager>();
        _cardsManager = ManagerManager.GetManager<CardsManager>();
        _scoreManager.OnScoreChange += UpdateScoreLabel;
        _cardsManager.OnGemChange += UpdateGemLabel;
    }

    private void UpdateScoreLabel(int score)
    {
        _scoreLabel.Text = "Score : " + score.ToString("00");
    }
    
    
    private void UpdateGemLabel(int score)
    {
        _scoreLabel.Text = "Gems : " + score.ToString("00");
    }
}
