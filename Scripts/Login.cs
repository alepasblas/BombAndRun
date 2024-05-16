using Godot;
using System;

public partial class Login : Control
{	
	private void _on_button_pressed()
	{
		GetTree().ChangeSceneToFile("res://Escenas/menu.tscn");
	}

}


