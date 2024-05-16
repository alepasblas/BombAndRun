using Godot;
using System;

public partial class Muerte : Control
{
	private void _on_button_pressed()
	{
		GetTree().ChangeSceneToFile("res://Escenas/Menu.tscn");
	}
}



