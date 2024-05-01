using Godot;
using System;

public partial class bomba : RigidBody2D
{
	// Called when the node enters the scene tree for the first time.
	public override void _Ready()
	{
		
	}
	public void Activar()
	{
		Sprite2D sprite = GetNode<Sprite2D>("Sprite2D");
		AnimationPlayer animPlayer = sprite.GetNode<AnimationPlayer>("AnimationPlayer");
		animPlayer.Play("BombaAnim");
	}

	// Called every frame. 'delta' is the elapsed time since the previous frame.
	public override void _Process(double delta)
	{

	}



	//Mirar Error de colocar Bomba
}
