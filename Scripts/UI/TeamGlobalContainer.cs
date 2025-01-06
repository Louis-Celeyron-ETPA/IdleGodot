using Godot;
using System;
using Godot.Collections;

public partial class TeamGlobalContainer : Control
{
    [Export] private Array<CardInUiZoomedOut> _teamCards;

    private TeamManager _teamManager;
    public override void _Ready()
    {
        _teamManager = ManagerManager.GetManager<TeamManager>();
        _teamManager.AddActionToTeamUpdate( UpdateTeam);
    }

    public void UpdateTeam(Array<Duck> team)
    {
        for (int i = 0; i < _teamCards.Count; i++)
        {
            if (i >= team.Count)
            {
                _teamCards[i].DisableCard();
            }
            else
            {
                _teamCards[i].UpdateCard(team[i]);
            }
        }        
    }
}
