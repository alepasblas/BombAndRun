using Godot;
using System;

public partial class ComoJugar : Control
{
	private void _on_button_pressed()
	{
		GetTree().ChangeSceneToFile("res://Escenas/menu.tscn");
	}

}


