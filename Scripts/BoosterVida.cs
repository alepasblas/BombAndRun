using Godot;
using System;

public partial class BoosterVida : Area2D
{
	// Called when the node enters the scene tree for the first time.
	public override void _Ready()
	{
	}

	// Called every frame. 'delta' is the elapsed time since the previous frame.
	public override void _Process(double delta)
	{
	}
	private void _on_body_entered(Node2D body)
	{
		if (body is jugador_1 jugador)
			{
				jugador.salud += 50;
				GD.Print("+50 vida");
				QueueFree();
			}
	}
}



