using Godot;
using System;
using System.Collections.Generic;
using System.IO;

public partial class Registro : Control
{
	List<String> usuarios = new List<String>();

	string usuario="";
	string contrasena="";
	
	bool creado= false;

	private void _on_boton_iniciar_sesion_pressed()
	{
		GetTree().ChangeSceneToFile("res://Escenas/iniciar_sesion.tscn");
	}




	private void _on_button_pressed()
	{

		TextEdit Usuario = GetNode<TextEdit>("Usuario");
		TextEdit Contrasena = GetNode<TextEdit>("Contrasena");
		Label etiqueta = GetNode<Label>("Label");

		usuario = Usuario.Text;
		contrasena = Contrasena.Text.Sha256Text();



		try
		{
			usuarios.AddRange(File.ReadAllLines("Archivos/usuarios.txt"));
			
			bool existe = false;
			
			for (int i = 0; i < usuarios.Count; i++)
			{
				if (usuarios[i] == usuario)
				{
					existe = true;
					etiqueta.Text="Usuario ya existente, inicia sesion";
				}
			}
				
			if(!existe)
			{
				using (StreamWriter users = new StreamWriter("Archivos/usuarios.txt", true))
				using (StreamWriter pass = new StreamWriter("Archivos/contrasenas.txt", true))
				{
					users.WriteLine(usuario);
					pass.WriteLine(contrasena);
					etiqueta.Text = "Usuario creado, inicia sesion";

				}
			}
		   
			
		}
		catch(Exception ex)
		{
			Console.WriteLine(ex.ToString());
		}


	}

}




