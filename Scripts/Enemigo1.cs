using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Godot;

namespace BombermanV1.Scripts
{
	public partial class Enemigo1:enemigos
	{
		public override void _Ready()
		{
			velocidad = 40;

			juego = GetNode<mundo_1>("/root/Mundo1");
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

			Vector2 distancia = posPersonaje - Position;

			Position += distancia.Normalized() * velocidad * (float)delta;

		}

		private void _on_body_entered(Node body)
		{
			if (body is jugador_1 jugador)
			{
				jugador.salud -= 10;

				jugador.SinVida();

			}
		}
	}
}
