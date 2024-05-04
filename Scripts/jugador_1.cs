using Godot;
using System;

public partial class jugador_1 : CharacterBody2D
{

	[Export]
	public int salud = 150;
	[Export]
	public int velocidad = 100;
	
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

		Velocity = mov.Normalized() * velocidad;
		MoveAndSlide();
	}

	public override void _Process(double delta)
	{
		if(Input.IsPhysicalKeyPressed(Key.S))
		{
			MovAbajo();
		}
		else if(Input.IsPhysicalKeyPressed(Key.A))
		{
			MoverIzq();
		}
		else if(Input.IsPhysicalKeyPressed(Key.D))
		{
			MoverDer();
		}
		else if(Input.IsPhysicalKeyPressed(Key.W))
		{
			MovArriba();
		}

		//ColocarBomba();
	}

	public void MoverIzq()
	{
		Sprite2D sprite = GetNode<Sprite2D>("Sprite2D");
		AnimationPlayer animPlayer = sprite.GetNode<AnimationPlayer>("AnimationPlayer2");
		animPlayer.Play("MovIzq");
	}

	public void MoverDer()
	{
		Sprite2D sprite = GetNode<Sprite2D>("Sprite2D");
		AnimationPlayer animPlayer = sprite.GetNode<AnimationPlayer>("AnimationPlayer2");
		animPlayer.Play("MovDer");
	}
	public void MovAbajo()
	{
		Sprite2D sprite = GetNode<Sprite2D>("Sprite2D");
		AnimationPlayer animPlayer = sprite.GetNode<AnimationPlayer>("AnimationPlayer2");
		animPlayer.Play("MovAbajo");
	}

	public void MovArriba()
	{
		Sprite2D sprite = GetNode<Sprite2D>("Sprite2D");
		AnimationPlayer animPlayer = sprite.GetNode<AnimationPlayer>("AnimationPlayer2");
		animPlayer.Play("MovArriba");
	}

	/*
	private void ColocarBomba()
	{
		if (Input.IsActionPressed("ColocarBomba"))
		{
			bombaInstance= new bomba();
			bombaInstance.Activar();
		}
	}*/


}





