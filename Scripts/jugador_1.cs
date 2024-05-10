using Godot;
using System;

public partial class jugador_1 : CharacterBody2D
{
	
	[Export]
	public int salud = 150;
	[Export]
	public int velocidad = 100;
	
	int vidas = 5;

	

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
		PonerBomba();
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
	
	
	public void PonerBomba()
	{
		if (Input.IsActionJustPressed("ColocarBomba"))
		{
			// Crear una nueva instancia de bomba
			//Node scene = ResourceLoader.Load<PackedScene>("res://Escenas/bomba.tscn").Instantiate();

			RigidBody2D bombaM = GetNode<RigidBody2D>($"../Bomba");

			//float alturaSuelo = 33; // Altura deseada del suelo
			//((RigidBody2D)scene).Position = new Vector2(Position.X, Position.Y + alturaSuelo);

			((RigidBody2D)bombaM).Position = Position;




			//GetTree().Root.AddChild(scene);

		}
	}



	public void SinVida()
	{
		if(salud<=0)
		{
			//Poner la escena de cuando mueres
			GetTree().ChangeSceneToFile("res://Escenas/Muerte.tscn");
		}
	}









}





