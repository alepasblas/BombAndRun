using Godot;
using System;

public partial class llave : Area2D
{
	[Export]
	bool conseguido= false;
	// Called when the node enters the scene tree for the first time.
	public override void _Ready()
	{
	}

	// Called every frame. 'delta' is the elapsed time since the previous frame.
	public override void _Process(double delta)
	{

		if(conseguido)
		{
			GD.Print("Abriendo...");
			puerta puerta = GetNode<puerta>("../Puerta");
			puerta.AbrirPuerta();
			GD.Print("Puerta abierta");
			QueueFree();

		}
	}

	private void _on_body_entered(Node2D body)
	{
		GD.Print("Llave conseguida");
		conseguido = true;
		GD.Print(conseguido);
		
		
		
	}
}
