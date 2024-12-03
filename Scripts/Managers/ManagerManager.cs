using System.Collections.Generic;
using Godot;


[GlobalClass]
public partial class ManagerManager : Node
{
    private static ManagerManager _instance;

    private List<Manager> _managers; 


    public override void _Ready()
    {
        if (_instance == null)
        {
            _instance = this;
            SubscribeManagers();
        }
        else
        {
            QueueFree();
        }
    }

    private void SubscribeManagers()
    {
        var children = GetChildren();
        _managers = new List<Manager>();
        for (int i = 0; i < children.Count; i++)
        {
            var c = GetChildOrNull<Manager>(i);
            if(c!=null)
            {
                _managers.Add(c);
            }
        }
        InitializeManager();
    }

    private void InitializeManager()
    {
        foreach (var manager in _managers)
        {
            manager.ManagerInit();
        }
    }

    private T GetManagerPrivate<T>() where T : Manager
    {
        foreach (var manager in _managers)
        {
            if (manager.GetType() == typeof(T))
            {
                return manager as T;
            }
        }
        return null;
    }

    public static T GetManager<T>() where T : Manager //#Karen
    {
        return _instance.GetManagerPrivate<T>();
    }
    
}