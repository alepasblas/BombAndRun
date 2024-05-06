using Godot;
using System;

public partial class Vida : Label
{
	private jugador_1 jugador; 


	public override void _Ready()
	{

		jugador = GetNode<jugador_1>("/root/Mundo1/Jugador1");
	}


	public override void _Process(double delta)
	{
		if (jugador != null)
		{

			Text = Convert.ToString(jugador.salud);
		}
	}
}
