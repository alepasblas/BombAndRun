using Godot;
using System;

public partial class enemigos : RigidBody2D
{

	private Vector2 velocidad;

	public override void _Ready()
	{
		velocidad = new Vector2(100, 0);

	}
	public void Animacion()
	{
		AnimatedSprite2D spriteEnemigo = GetNode<AnimatedSprite2D>("AnimatedSprite2D");
		AnimationPlayer animacion = spriteEnemigo.GetNode<AnimationPlayer>("AnimationPlayer");
		animacion.Play("enemigo");
	}


	public override void _Process(double delta)
	{
		Animacion();

		Position += velocidad * (float)delta;
		if (Position.X > 691)
		{
			velocidad = new Vector2(-100, 0);
		}
		if (Position.X < 40)
		{
			velocidad = new Vector2(100, 0);
		}
	}

	private void _on_body_entered(Node body)
	{
		if (body is jugador_1 jugador)
		{
			jugador.salud -= 50;
			GD.Print("-50 de vida");
			
		}
	}





}



