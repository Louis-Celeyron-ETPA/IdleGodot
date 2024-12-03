using Godot;
using Godot.Collections;
using System;


[GlobalClass]
public partial class Card : Resource
{
    [Export] public int Price;
    [Export] private Array<CardEvent> _events;
    
    public Card() : this(0)
    {
        
    }
    
    public Card(int price)
    {
        Price = price;
    }

    public void Draw(CardsManager cardsManager)
    {
        foreach (var cevent in _events)
        {
            cevent.OnSubscribe(cardsManager);
        }
    }

    public void Discard(CardsManager cardsManager)
    {
        foreach (var cevent in _events)
        {
            cevent.OnUnsubscribe(cardsManager);
        }
    }
}
