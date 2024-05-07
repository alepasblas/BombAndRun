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

		PruebaQuitarBloques();

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
		if (Input.IsActionJustPressed("ColocarBomba") && bombaInstance == null)
		{
			// Crear una nueva instancia de bomba
			Node scene = ResourceLoader.Load<PackedScene>("res://Escenas/bomba.tscn").Instantiate();

			float alturaSuelo = 33; // Altura deseada del suelo
			((RigidBody2D)scene).Position = new Vector2(Position.X, Position.Y + alturaSuelo);

			((RigidBody2D)scene).GravityScale = 0;



			GetTree().Root.AddChild(scene);

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

	public void PruebaQuitarBloques()
	{
		TileMap tilemap = GetNode<TileMap>("TileMap");

		int cellSizeX = 16;
		int cellSizeY = 16;

		int capa = 1;

		int cellX = (int)Position.X / cellSizeX;
		int cellY = (int)Position.Y / cellSizeY;

		if (60 == 60 && 50 == 50)
		{
			Vector2I cellCoordinates = new Vector2I(10, 105);

			tilemap.SetCell(capa, cellCoordinates, -1);
		}


	}







}





