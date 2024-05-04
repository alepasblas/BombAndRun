using Godot;
using System;
using System.IO;


public partial class rayo : Area2D
{
	private int puntuacion = 0;

	// Called when the node enters the scene tree for the first time.
	public override void _Ready()
	{
	}

	// Called every frame. 'delta' is the elapsed time since the previous frame.
	public override void _Process(double delta)
	{
	}
	
	private void GuardarPuntuacion()
	{
		using (StreamWriter miFichero = new StreamWriter("Archivos/puntuacionTemporal.txt"))
		{
			miFichero.WriteLine(puntuacion);
		}
	}
//Hacer que cuando se toque, se mueva y salga de forma random en otro sitio
	private void _on_body_entered(Node body)
	{
		if (body is Node2D)
		{
			puntuacion += 100;
			GuardarPuntuacion();

		}
	}
}



