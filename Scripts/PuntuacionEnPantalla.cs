using Godot;
using System;
using System.IO;

public partial class PuntuacionEnPantalla : Node2D
{
	// Called when the node enters the scene tree for the first time.
	public override void _Ready()
	{
		Label label = GetNode<Label>("PuntuacionPantalla");

		StreamWriter miFichero = new StreamWriter("Archivos/puntuacionTemporal.txt");
		miFichero.WriteLine("");
		miFichero.Close();
		label.Text="";
	}

	// Called every frame. 'delta' is the elapsed time since the previous frame.
	public override void _Process(double delta)
	{
		Label label = GetNode<Label>("PuntuacionPantalla");
		label.Text = LeerInfoFichero();
	}

	public string LeerInfoFichero()
	{
		string ficheroEntero = "";

		try
		{
			String[] fichero = File.ReadAllLines("Archivos/puntuacionTemporal.txt");

			for (int i = 0; i < fichero.Length; i++)
			{
				ficheroEntero += (fichero[i] + "\n");
			}
		}
		catch (Exception e)
		{
			GD.PrintErr("Error reading file: " + e.Message);
		}

		return ficheroEntero;
	}
}
