/// @DnDAction : YoYo Games.Common.Variable
/// @DnDVersion : 1
/// @DnDHash : 5D0FAE92
/// @DnDArgument : "expr" "x+32"
/// @DnDArgument : "var" "CannonHeadReference.x"
CannonHeadReference.x = x+32;

/// @DnDAction : YoYo Games.Mouse & Keyboard.If_Mouse_Pressed
/// @DnDVersion : 1.1
/// @DnDHash : 0B81BD49
var l0B81BD49_0;l0B81BD49_0 = mouse_check_button_pressed(mb_left);if (l0B81BD49_0){	/// @DnDAction : YoYo Games.Instances.Create_Instance
	/// @DnDVersion : 1
	/// @DnDHash : 45296323
	/// @DnDParent : 0B81BD49
	/// @DnDArgument : "xpos_relative" "1"
	/// @DnDArgument : "ypos_relative" "1"
	/// @DnDArgument : "objectid" "O_Bullet"
	/// @DnDArgument : "layer" ""PlayerCharacter""
	/// @DnDSaveInfo : "objectid" "O_Bullet"
	instance_create_layer(x + 0, y + 0, "PlayerCharacter", O_Bullet);}