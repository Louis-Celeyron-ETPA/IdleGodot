using Godot;
using System;

public partial class CardInUiZoomedOut : Control
{
    [Export] private Duck _currentDuck;
    [Export] private CardInUiZoomedBridge _zoomedInCard;
    [Export] private TextureRect _texRec, _bgTexRec;
    private bool _isActive=true;

    public void UpdateCard(Duck newDuck)
    {
        _bgTexRec.Modulate = Colors.Aquamarine;
        _isActive = true;
        _currentDuck = newDuck;
        _texRec.Texture = newDuck.Sprite;
        _zoomedInCard.Update(_currentDuck);
    }
    public void DisableCard()
    {
        _bgTexRec.Modulate = Colors.Black;
        _texRec.Texture = null;
        HideDuck();
        _isActive = false;
    }
    public void ShowDuck()
    {
        if (_isActive)
        {
            _zoomedInCard.Visible = true;
        }
    }

    public void HideDuck()
    {
        if (_isActive)
        {
            _zoomedInCard.Visible = false;
        }
    }

}
