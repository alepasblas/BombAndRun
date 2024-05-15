using Godot;
using System;
using System.IO;

public partial class puerta : Area2D
{
	private AnimatedSprite2D animatedSprite;

	// Called when the node enters the scene tree for the first time.
	public override void _Ready()
	{
		animatedSprite = GetNode<AnimatedSprite2D>("Puerta");

		animatedSprite.Frame = 0;

	}

	// Called every frame. 'delta' is the elapsed time since the previous frame.
	public override void _Process(double delta)
	{


	}

	private void _on_body_entered(Node2D body)
	{

		GuardarPuntuacion();
		
		GD.Print("¡Cuerpo entrado!");
		if (body is jugador_1 jugador)
		{

			if(animatedSprite.Frame == 1)
			{
				GetTree().ChangeSceneToFile("res://Escenas/menu.tscn");

			}
			else
			{
				GD.Print("Puerta cerrada");
			}

		}
	}

	public void GuardarPuntuacion()
	{
		String[] todosUsuarios = File.ReadAllLines("Archivos/usuarios.txt");

		string user = todosUsuarios[todosUsuarios.Length - 1];

		StreamReader miFichero = new StreamReader("Archivos/puntuacionTemporal.txt");
		string puntuacion = miFichero.ReadLine();
		miFichero.Close();

		string dia = Convert.ToString(DateTime.Now);

		StreamWriter mifichero = new StreamWriter("Archivos/puntuacion.txt", true);
		mifichero.Write(user + ": ");
		mifichero.Write(puntuacion + ", fecha: ");
		mifichero.WriteLine(dia);
		mifichero.Close();
	}
	public void AbrirPuerta()
	{
		animatedSprite.Frame = 1;

	}


}


