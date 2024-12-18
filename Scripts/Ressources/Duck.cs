using Godot;
using System;

[GlobalClass]
public partial class Duck : Resource
{
    [Export] public int BaseLove;
    [Export] public Texture2D Sprite;
    [Export] public int GoldAmount;
}
