using Godot;
using System;

public partial class jugador_1 : CharacterBody2D
{
	public const float movementSpeed = 300.0f;
	int vidas = 5;
	bomba bombaInstance;

	

	public override void _PhysicsProcess(double delta)
	{
		Movimiento();
	}

	private void Movimiento()
	{
		float xMov = Input.GetActionStrength("MoverDer") - Input.GetActionStrength("MoverIzq");
		float yMov = Input.GetActionStrength("MoverAbajo") - Input.GetActionStrength("MoverArriba");
		Vector2 mov = new Vector2(xMov, yMov);

		Velocity = mov.Normalized() * movementSpeed;
		MoveAndSlide();
	}

	public override void _Process(double delta)
	{
		ColocarBomba();
	}

	private void ColocarBomba()
	{
		if (Input.IsActionPressed("ColocarBomba"))
		{
			if (bombaInstance == null)
			{
				bombaInstance = new bomba(); 
				AddChild(bombaInstance); 
			}

			bombaInstance.Activar(); 
		}
	}


}


