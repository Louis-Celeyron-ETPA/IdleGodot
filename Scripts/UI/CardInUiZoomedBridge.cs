using Godot;
using System;

public partial class CardInUiZoomedBridge : Control
{
    [Export] private TextureRect _texRect;
    [Export] private Label _descLabel, _nameLabel;

    public void Update(Duck duck)
    {
        _texRect.Texture = duck.Sprite;
        _nameLabel.Text = duck.ResourceName;
        _descLabel.Text = duck.GetDescription();
    }
    
}
