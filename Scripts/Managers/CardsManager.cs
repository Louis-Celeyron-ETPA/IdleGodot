using Godot;
using System;
using Godot.Collections;

[GlobalClass]
public partial class CardsManager : Manager
{
    [Export]
    private Array<Card> _cards;
    public ClickManager ClickManagerRef;

    public override void ManagerInit()
    {
        ClickManagerRef = ManagerManager.GetManager<ClickManager>();
    }

    public void Draw()
    {
        _cards[0].Draw(this);
    }
}
