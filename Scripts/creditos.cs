using Godot;
using System;

public partial class creditos : Node2D
{
	
	private void _on_button_pressed()
	{
		GetTree().ChangeSceneToFile("res://Escenas/menu.tscn");
	}
}


