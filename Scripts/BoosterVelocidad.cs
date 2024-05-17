using BombermanV1.Scripts;
using Godot;
using System;

public partial class BoosterVelocidad : Boost
{

	private void _on_body_entered(Node body)
	{
		boosterVelocidad(body);
		if (body is jugador_1 jugador)
		{
			QueueFree();
		}
	}

}



