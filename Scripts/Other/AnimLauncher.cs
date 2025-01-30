using Godot;
using System;
using Godot.Collections;

public partial class AnimLauncher : Sprite2D
{
	[Export]
	private Animation _animation;
	[Export]
	private Array<Texture2D> _textureArray;
	[Export]
	private AnimationPlayer _animationPlayer;

	public void PlayAnimation()
	{
		Texture = _textureArray.PickRandom();
		_animationPlayer.Play("anim_Honk");
		Rotation = (float)GD.RandRange(315.0f,405.0f);
	}

}
