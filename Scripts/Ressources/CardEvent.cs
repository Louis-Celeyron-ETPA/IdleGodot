using Godot;
using System;

[GlobalClass]
public partial class CardEvent : Resource
{
    
    public virtual void OnSubscribe(TeamManager teamManager)
    {
        
    }

    public virtual void OnUnsubscribe(TeamManager teamManager)
    {
        
    }

    public virtual string  GetDescription()
    {
        return "That's one silly duck";
    }
}


