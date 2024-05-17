using BombermanV1.Scripts;
using Godot;
using System;

public partial class BoosterVida : Boost
{
	private void _on_body_entered(Node2D body)
	{
		boosterVida(body);
		if (body is jugador_1 jugador)
		{
			QueueFree();
		}
	}
}



