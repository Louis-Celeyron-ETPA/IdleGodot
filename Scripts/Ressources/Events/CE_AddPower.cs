using Godot;
using System;

[GlobalClass]
public partial class CE_AddPower : CardEvent
{
    [Export]
    private int _amount;
    public override void OnSubscribe(CardsManager cardsManager)
    {
        cardsManager.ClickManagerRef.RiseTempPower(_amount);
    }

    public override void OnUnsubscribe(CardsManager cardsManager)
    {
        cardsManager.ClickManagerRef.RiseTempPower(-_amount);
    }
}
