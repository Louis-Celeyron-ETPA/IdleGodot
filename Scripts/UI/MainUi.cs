using Godot;
using System;

public partial class MainUi : Control
{
    
    [Export] private Label _grapeLabel;
    [Export] private Label _peasLabel;
    [Export] private Label _cornLabel;

    private GoldAndInventoryManager _goldAndInventoryManager;
    private TeamManager _teamManager;
    public override void _Ready()
    {
        _goldAndInventoryManager = ManagerManager.GetManager<GoldAndInventoryManager>();
        _teamManager = ManagerManager.GetManager<TeamManager>();
        _goldAndInventoryManager.OnGoldChange += UpdateCornLabel;
        _teamManager.OnGemChange += UpdateGrapeLabel;
    }

    private void UpdateGrapeLabel(int gold)
    {
        _grapeLabel.Text = gold.ToString("0000");
    }
    
    
    private void UpdateCornLabel(int score)
    {
        _cornLabel.Text = score.ToString("0000");
    }
}
