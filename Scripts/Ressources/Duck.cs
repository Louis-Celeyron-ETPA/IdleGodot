using Godot;
using System;

[GlobalClass]
public partial class Duck : Resource
{
    [Export] public int BaseHp;
    [Export] public Texture Sprite;
    [Export] public int GoldAmount;
}
