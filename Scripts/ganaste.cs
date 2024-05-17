using Godot;
using System;

public partial class ganaste : Control
{
	private void _on_button_pressed()
	{
		GetTree().ChangeSceneToFile("res://Escenas/menu.tscn");

	}
}



