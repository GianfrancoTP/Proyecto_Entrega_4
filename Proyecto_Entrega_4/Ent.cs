﻿using System;
namespace Proyecto_Entrega_4
{
    class Ent : Bitmon
    {
        public Ent(int[] posicion) : base(posicion)
        {
            Random random = new Random();
            int vida = random.Next(18, 22);
            this.Tipo = "Ent";
            this.Posicion = posicion;
            this.TiempoVida = vida;
            this.Multiplicador = 0.7f;
            this.PuntosdeAtaque = 9;
            this.PuntosdeVida = 42;
        }
        public override void Mover(Mapa mapa)
        {
        }
    }
}
