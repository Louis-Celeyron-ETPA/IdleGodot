using Godot;
using System;

public partial class MainUi : Control
{
    
    [Export] private Label _goldLabel;
    [Export] private Label _gemLabel;

    private GoldAndInventoryManager _goldAndInventoryManager;
    private TeamManager _teamManager;
    public override void _Ready()
    {
        _goldAndInventoryManager = ManagerManager.GetManager<GoldAndInventoryManager>();
        _teamManager = ManagerManager.GetManager<TeamManager>();
        _goldAndInventoryManager.OnGoldChange += UpdateGoldAndInventoryLabel;
        _teamManager.OnGemChange += UpdateGemLabel;
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
