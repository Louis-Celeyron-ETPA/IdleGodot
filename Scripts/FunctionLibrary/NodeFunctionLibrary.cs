using Godot;
using System;

public static class NodeFunctionLibrary
{
    public static T GetChildOfClass<T>(this Node node) where T : Node
    {
        //Can be optimized by looking for every child in one loop with multiple T and a 
        for (int i = 0; i < node.GetChildCount(); i++)
        {
            var ret = node.GetChildOrNull<T>(i, true);
            if (ret != null)
            {
                return ret as T;
            }
        }
        return null;
    }
    
    
    
    

    public static void EasyPrint(this object o)
    {
        GD.Print(o);
    }
}
