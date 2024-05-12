using Godot;
using System;
using System.Collections.Generic;
using System.IO;

public partial class Registro : Control
{
	List<String> usuarios = new List<String>();
	List<String> contrasenas = new List<String>();
	string usuario="";
	string contrasena="";
	
	bool creado= false;


	
	
	private void _on_button_pressed()
	{

		TextEdit Usuario = GetNode<TextEdit>("Usuario");
		TextEdit Contrasena = GetNode<TextEdit>("Contrasena");

		usuario = Usuario.Text;
		usuarios.Add(usuario);

		contrasena = Contrasena.Text;
		contrasenas.Add(contrasena);



		try
		{

		   
			using (StreamWriter users = new StreamWriter("Archivos/usuarios.txt", true))
			using (StreamWriter pass = new StreamWriter("Archivos/contrasenas.txt", true))
			{
				users.WriteLine(usuario);
				pass.WriteLine(contrasena);
			}
		}
		catch(Exception ex)
		{
			Console.WriteLine(ex.ToString());
		}

		GetTree().ChangeSceneToFile("res://Escenas/iniciar_sesion.tscn");
	}

}


