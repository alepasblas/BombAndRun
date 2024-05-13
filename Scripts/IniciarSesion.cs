using Godot;
using System;
using System.Collections.Generic;
using System.IO;

public partial class IniciarSesion : Control
{

	private void _on_registrarse_button_pressed()
	{
		GetTree().ChangeSceneToFile("res://Escenas/Registro.tscn");
	}

	private void _on_entrar_pressed()
	{
		string usuario = "";
		string contrasena = "";
		List<String> usuarios = new List<String>();
		List<String> contrasenas = new List<String>();

		usuarios.AddRange(File.ReadAllLines("Archivos/usuarios.txt"));
		contrasenas.AddRange(File.ReadAllLines("Archivos/contrasenas.txt"));

		TextEdit Usuario = GetNode<TextEdit>("Usuario");
		TextEdit Contrasena = GetNode<TextEdit>("Contrasena");
		usuario = Usuario.Text;
		contrasena = Contrasena.Text.Sha256Text();


		bool credencialesCorrectas = false;
		for (int i = 0; i < usuarios.Count; i++)
		{
			if (usuarios[i] == usuario && contrasenas[i] == contrasena)
			{
				credencialesCorrectas = true;
			}
		}

		if (credencialesCorrectas)
		{
			GetTree().ChangeSceneToFile("res://Escenas/menu.tscn");
		}
		else
		{
			
			GD.Print("Usuario o contraseña incorrecto");
		}
	}
}




