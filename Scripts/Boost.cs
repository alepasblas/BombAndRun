﻿using Godot;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace BombermanV1.Scripts
{
    public class Boost 
    {
        public void boosterVelocidad(Node body)
        {
            if (body is jugador_1 jugador)
            {
                jugador.velocidad += 50;
                
            }
        }

        private void boosterVida(Node2D body)
        {
            if (body is jugador_1 jugador)
            {
                jugador.salud += 50;
                GD.Print("+50 vida");
            }
        }
    }
}
