using Godot;
using System;

public partial class menu : Control
{
	// Called when the node enters the scene tree for the first time.
	public override void _Ready()
	{

	}

	// Called every frame. 'delta' is the elapsed time since the previous frame.
	public override void _Process(double delta)
	{

	}
	
	private void _on_jugar_pressed()
	{
		GetTree().ChangeSceneToFile("res://Escenas/mundo_1.tscn");
	}

	private void _on_créditos_pressed()
	{
		GetTree().ChangeSceneToFile("res://Escenas/creditos.tscn");
	}

	private void _on_puntuación_pressed()
	{
		GetTree().ChangeSceneToFile("res://Escenas/puntuacion.tscn");
	}
	
	private void _on_salir_pressed()
	{
		GetTree().Quit();
	}
	private void _on_como_jugar_pressed()
	{
		GetTree().ChangeSceneToFile("res://Escenas/ComoJugar.tscn");
	}
		
	//Romer menu al estilo geometry dash
	
}












