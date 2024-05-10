using Godot;
using System;

public partial class enemigos : Area2D
{

	private int velocidad;
	private mundo_1 juego;
	
	public override void _Ready()
	{
		velocidad = 75;

		juego= GetNode<mundo_1>("/root/Mundo1");
	}
	public void Animacion()
	{
		Sprite2D spriteEnemigo = GetNode<Sprite2D>("Sprite2D");
		AnimationPlayer animacion = spriteEnemigo.GetNode<AnimationPlayer>("AnimationPlayer");
		animacion.Play("enemigo");
	}


	public override void _Process(double delta)
	{
		Animacion();

		Vector2 posPersonaje = juego.GetPosicionPersonaje();
		
		Vector2 distancia= posPersonaje - Position;
		
		Position+= distancia.Normalized() * velocidad * (float)delta;
	
	}

	private void _on_body_entered(Node body)
	{
		if (body is jugador_1 jugador)
		{
			jugador.salud -= 5;
			GD.Print("-5 de vida");
			jugador.SinVida();
			
		}
	}





}




