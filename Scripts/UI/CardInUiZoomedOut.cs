using Godot;
using System;

public partial class CardInUiZoomedOut : Control
{
    [Export] private Duck _currentDuck;
    [Export] private CardInUiZoomedBridge _zoomedInCard;
    public void ShowDuck()
    {
        _zoomedInCard.Visible = true;
        _zoomedInCard.Update(_currentDuck);
    }

    public void HideDuck()
    {
        _zoomedInCard.Visible = false;
    }

}
