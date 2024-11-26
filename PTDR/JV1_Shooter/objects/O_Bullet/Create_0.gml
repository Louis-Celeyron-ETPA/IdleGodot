/// @DnDAction : YoYo Games.Instances.Sprite_Rotate
/// @DnDVersion : 1
/// @DnDHash : 5B122B1B
/// @DnDArgument : "angle" "point_direction(x,y,mouse_x,mouse_y)"
image_angle = point_direction(x,y,mouse_x,mouse_y);

/// @DnDAction : YoYo Games.Movement.Set_Direction_Free
/// @DnDVersion : 1
/// @DnDHash : 245C13F8
/// @DnDArgument : "direction" "point_direction(x,y,mouse_x,mouse_y)"
direction = point_direction(x,y,mouse_x,mouse_y);

/// @DnDAction : YoYo Games.Movement.Set_Speed
/// @DnDVersion : 1
/// @DnDHash : 10ED12EE
/// @DnDArgument : "speed" "5"
speed = 5;

/// @DnDAction : YoYo Games.Instances.Set_Alarm
/// @DnDVersion : 1
/// @DnDHash : 47DF0194
alarm_set(0, 30);