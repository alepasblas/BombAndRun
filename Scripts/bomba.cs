using Godot;
using System;

public partial class bomba : RigidBody2D
{

	[Export]
	public bool destruido = false;

	Timer deletionTimer; 

	TileMap tilemap;
	public bomba()
	{

	}

	public override void _Ready()
	{

		tilemap = GetNode<TileMap>("TileMap");
		deletionTimer = GetNode<Timer>("DeletionTimer");
		Activar();

	}

	public void Activar()
	{
		Sprite2D sprite = GetNode<Sprite2D>("Sprite2D");
		AnimationPlayer animPlayer = sprite.GetNode<AnimationPlayer>("AnimationPlayer");
		if (!animPlayer.IsPlaying())
			animPlayer.Play("BombaAnim");
	}

	public override void _Process(double delta)
	{
		if (!destruido) 
		{
			
			destruido = true;
		}
	}

	public override void _PhysicsProcess(double delta)
	{
		base._PhysicsProcess(delta);

		//verificarTile();
	}

	public bomba(Vector2 playerPosition)
	{

		Position = playerPosition;
		GetTree().Root.AddChild(this);
	}
	/*
	public bool verificarTile()
	{
		var posicionTile = tilemap.LocalToMap(GlobalPosition);
		var tileData = tilemap.GetCellTileData(1, posicionTile);

		if (tileData != null)
		{
			var data = tileData.GetCustomData("romper");

			if ((bool)data)
			{
				
				tilemap.SetCell(1, posicionTile, -1);
				deletionTimer.Start(0.5f);


			}
		}
		return false;
	}*/

	public void _on_DeletionTimer_timeout() 
	{

		QueueFree();
	}

	private void _on_body_entered(Node body)
	{
		if (body is enemigos enemigo)
		{

			enemigos enemigo1 = GetNode<enemigos>($"../Enemigos");
			enemigo1.QueueFree();
			enemigos enemigo2 = GetNode<enemigos>($"../Enemigos2");
			enemigo2.QueueFree();
			QueueFree();
		}
	}



}
