using Godot;
using System;

public partial class MainUi : Control
{
    
    [Export] private Label _goldLabel;
    [Export] private Label _gemLabel;

    private GoldAndInventoryManager _goldAndInventoryManager;
    private CardsManager _cardsManager;
    public override void _Ready()
    {
        _goldAndInventoryManager = ManagerManager.GetManager<GoldAndInventoryManager>();
        _cardsManager = ManagerManager.GetManager<CardsManager>();
        _goldAndInventoryManager.OnGoldChange += UpdateGoldAndInventoryLabel;
        _cardsManager.OnGemChange += UpdateGemLabel;
    }

    private void UpdateGoldAndInventoryLabel(int gold)
    {
        _goldLabel.Text = "Gold : " + gold.ToString("00");
    }
    
    
    private void UpdateGemLabel(int score)
    {
        _goldLabel.Text = "Gems : " + score.ToString("00");
    }
}
