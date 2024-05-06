using Godot;
using System;

public partial class mundo_1 : Node2D
{
	private jugador_1 jugador;

	public override void _Ready()
	{
		jugador= GetNode<jugador_1>("/root/Mundo1/Jugador1");
	}

	// Called every frame. 'delta' is the elapsed time since the previous frame.
	public override void _Process(double delta)
	{
	}
	
	public Vector2 GetPosicionPersonaje()
	{
		return jugador.Position;
	}
}
