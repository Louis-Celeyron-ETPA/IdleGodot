/// @DnDAction : YoYo Games.Instances.Sprite_Rotate
/// @DnDVersion : 1
/// @DnDHash : 243C1088
/// @DnDArgument : "angle" "point_direction(x,y,mouse_x,mouse_y)"
image_angle = point_direction(x,y,mouse_x,mouse_y);

/// @DnDAction : YoYo Games.Movement.Wrap_Room
/// @DnDVersion : 1
/// @DnDHash : 55B580C5
move_wrap(1, 1, 0);

/// @DnDAction : YoYo Games.Common.Temp_Variable
/// @DnDVersion : 1
/// @DnDHash : 6CB9675B
/// @DnDArgument : "var" "isKeyPressed"
/// @DnDArgument : "value" "false"
var isKeyPressed = false;

/// @DnDAction : YoYo Games.Common.Variable
/// @DnDVersion : 1
/// @DnDHash : 1CF2B60C
/// @DnDInput : 2
/// @DnDArgument : "var" "dir_x"
/// @DnDArgument : "var_1" "dir_y"
dir_x = 0;
dir_y = 0;

/// @DnDAction : YoYo Games.Mouse & Keyboard.If_Key_Down
/// @DnDVersion : 1
/// @DnDHash : 339A7FE7
/// @DnDArgument : "key" "vk_right"
var l339A7FE7_0;l339A7FE7_0 = keyboard_check(vk_right);if (l339A7FE7_0){	/// @DnDAction : YoYo Games.Common.Variable
	/// @DnDVersion : 1
	/// @DnDHash : 1FC7A94C
	/// @DnDInput : 2
	/// @DnDParent : 339A7FE7
	/// @DnDArgument : "expr" "true"
	/// @DnDArgument : "expr_1" "1"
	/// @DnDArgument : "var" "isKeyPressed"
	/// @DnDArgument : "var_1" "dir_x"
	isKeyPressed = true;
	dir_x = 1;}

/// @DnDAction : YoYo Games.Mouse & Keyboard.If_Key_Down
/// @DnDVersion : 1
/// @DnDHash : 33001CC7
/// @DnDArgument : "key" "vk_left"
var l33001CC7_0;l33001CC7_0 = keyboard_check(vk_left);if (l33001CC7_0){	/// @DnDAction : YoYo Games.Common.Variable
	/// @DnDVersion : 1
	/// @DnDHash : 419CD276
	/// @DnDInput : 2
	/// @DnDParent : 33001CC7
	/// @DnDArgument : "expr" "true"
	/// @DnDArgument : "expr_1" "-1"
	/// @DnDArgument : "var" "isKeyPressed"
	/// @DnDArgument : "var_1" "dir_x"
	isKeyPressed = true;
	dir_x = -1;}

/// @DnDAction : YoYo Games.Mouse & Keyboard.If_Key_Down
/// @DnDVersion : 1
/// @DnDHash : 21479B08
/// @DnDArgument : "key" "vk_up"
var l21479B08_0;l21479B08_0 = keyboard_check(vk_up);if (l21479B08_0){	/// @DnDAction : YoYo Games.Common.Variable
	/// @DnDVersion : 1
	/// @DnDHash : 5A096956
	/// @DnDInput : 2
	/// @DnDParent : 21479B08
	/// @DnDArgument : "expr" "true"
	/// @DnDArgument : "expr_1" "-1"
	/// @DnDArgument : "var" "isKeyPressed"
	/// @DnDArgument : "var_1" "dir_y"
	isKeyPressed = true;
	dir_y = -1;}

/// @DnDAction : YoYo Games.Mouse & Keyboard.If_Key_Down
/// @DnDVersion : 1
/// @DnDHash : 5BC09447
/// @DnDArgument : "key" "vk_down"
var l5BC09447_0;l5BC09447_0 = keyboard_check(vk_down);if (l5BC09447_0){	/// @DnDAction : YoYo Games.Common.Variable
	/// @DnDVersion : 1
	/// @DnDHash : 4FA3A6F6
	/// @DnDInput : 2
	/// @DnDParent : 5BC09447
	/// @DnDArgument : "expr" "true"
	/// @DnDArgument : "expr_1" "1"
	/// @DnDArgument : "var" "isKeyPressed"
	/// @DnDArgument : "var_1" "dir_y"
	isKeyPressed = true;
	dir_y = 1;}

/// @DnDAction : YoYo Games.Movement.Set_Direction_Free
/// @DnDVersion : 1
/// @DnDHash : 3CE523A1
/// @DnDArgument : "direction" "point_direction(0,0,dir_x,dir_y)"
direction = point_direction(0,0,dir_x,dir_y);

/// @DnDAction : YoYo Games.Common.If_Variable
/// @DnDVersion : 1
/// @DnDHash : 05BDB703
/// @DnDArgument : "var" "isKeyPressed"
/// @DnDArgument : "value" "true"
if(isKeyPressed == true){	/// @DnDAction : YoYo Games.Movement.Set_Speed
	/// @DnDVersion : 1
	/// @DnDHash : 7F3B5160
	/// @DnDParent : 05BDB703
	/// @DnDArgument : "speed" "3"
	speed = 3;}

/// @DnDAction : YoYo Games.Common.Else
/// @DnDVersion : 1
/// @DnDHash : 728E5637
else{	/// @DnDAction : YoYo Games.Movement.Set_Speed
	/// @DnDVersion : 1
	/// @DnDHash : 17507780
	/// @DnDParent : 728E5637
	speed = 0;}