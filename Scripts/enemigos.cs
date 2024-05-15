using Godot;
using System;

public partial class enemigos : Area2D
{
	
	
	[Export]
	protected int velocidad;

	protected mundo_1 juego;

	public enemigos()
	{
	}

	public enemigos(int velocidad, mundo_1 juego)
	{
		this.velocidad = velocidad;
		this.juego = juego;
	}
	

}




