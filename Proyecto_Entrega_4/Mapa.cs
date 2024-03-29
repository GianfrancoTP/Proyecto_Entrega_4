﻿using System;
using System.Collections.Generic;
using System.Linq;
namespace Proyecto_Entrega_4
{
    public class Mapa
    {
        public bool sobrepoblacion = false;
        public List<Bitmon> Bitmons; // Lista de Bitmons
        public List<Bitmon> Bitmons_muertos; // lista de bitmons muertos
        public List<Bitmon> Bitmons_creados;
        public int Alto;
        public int Ancho;
        public List<int[]> Espacios_vacios;
        public List<int[]> Espacios_1;
        public List<int[]> Espacios_2;
        public Terreno[,] Terrenos; // Matriz con Terrenos
        public List<Bitmon> bitmons_creado_mes;
        public List<Bitmon> bitmons_muertos_mes;
        public Mapa()
        {
            this.Bitmons_muertos = new List<Bitmon>();
            this.Bitmons_creados = new List<Bitmon>();
            this.Espacios_vacios = new List<int[]>();
            this.Bitmons = new List<Bitmon>();
            this.Espacios_1 = new List<int[]>();
            this.Espacios_2 = new List<int[]>();
            this.bitmons_creado_mes = new List<Bitmon>();
            this.bitmons_muertos_mes = new List<Bitmon>();
        }
        public void Actualizar_espacios()
        {
            List<int[]> Espacios_v = new List<int[]>();
            List<int[]> Espacios1 = new List<int[]>();
            List<int[]> Espacios2 = new List<int[]>();
            List<int[]> Espacios_b = new List<int[]>();
            for (int i = 0; i < Bitmons.Count; i++)
            {
                int[] pos = Bitmons[i].Posicion;
                Espacios_b.Add(pos);
                for (int j = i + 1; j < Bitmons.Count; j++)
                {
                    if ((Bitmons[i].Posicion[0] == Bitmons[j].Posicion[0]) && (Bitmons[i].Posicion[1] == Bitmons[j].Posicion[1]))
                    {
                        Espacios2.Add(pos);
                    }
                }
            }
            for (int i = 0; i < Alto; i++)
            {
                for (int j = 0; j < Ancho; j++)
                {
                    int[] pos = { i, j };
                    bool hay_1_bitmon = false;
                    bool hay_2_bitmon = false;
                    foreach (var bitmon in Bitmons)
                    {
                        if (bitmon.Posicion[0] == i && bitmon.Posicion[1] == j)
                        {
                            hay_1_bitmon = true;
                        }
                    }
                    foreach (var espacio in Espacios2)
                    {
                        if (espacio[0] == i && espacio[1] == j)
                        {
                            hay_2_bitmon = true;
                        }
                    }
                    if (hay_1_bitmon && !hay_2_bitmon)
                    {
                        Espacios1.Add(pos);
                    }
                    else if (!hay_1_bitmon)
                    {
                        Espacios_v.Add(pos);
                    }
                }
            }
            Espacios_vacios = Espacios_v;
            Espacios_1 = Espacios1;
            Espacios_2 = Espacios2;
        }

        public void CrearBitmon(Bitmon papa, Bitmon mama)
        {
            List<int[]> espacios_disponibles = new List<int[]>();
            float probabilidad;
            try
            {
                probabilidad = (papa.CantidadDereproducciones * 100) / (papa.CantidadDereproducciones + mama.CantidadDereproducciones);
            }
            catch (Exception)
            {
                probabilidad = 50f;
            }
            Random random = new Random();
            int numeroRan = random.Next(1, 101);
            string padre_ganador;
            if (numeroRan <= probabilidad)
            {
                padre_ganador = papa.Tipo;
            }
            else
            {
                padre_ganador = mama.Tipo;
            }
            Bitmon bitmon;
            if (padre_ganador == "Wetar")
            {
                for (int i = 0; i < Alto; i++)
                {
                    for (int j = 0; j < Ancho; j++)
                    {
                        int[] pos = { i, j };
                        string tipo = Terrenos[i, j].tipo;
                        if (tipo == "Acuatico")
                        {
                            bool hay_dos = false;
                            foreach (var espacio in Espacios_2)
                            {
                                if (espacio[0] == pos[0] && espacio[1] == pos[1])
                                {
                                    hay_dos = true;
                                }
                            }
                            if (!hay_dos)
                            {
                                espacios_disponibles.Add(pos);
                            }
                        }
                    }
                }
                if (espacios_disponibles.Count > 0)
                {
                    numeroRan = random.Next(0, espacios_disponibles.Count);
                    bitmon = new Wetar(espacios_disponibles[numeroRan]);
                    Bitmons_creados.Add(bitmon);
                    bitmons_creado_mes.Add(bitmon);
                    Bitmons.Add(bitmon);
                }
                else
                {
                    sobrepoblacion = true;
                }
            }
            else if (padre_ganador == "Ent")
            {
                for (int i = 0; i < Alto; i++)
                {
                    for (int j = 0; j < Ancho; j++)
                    {
                        int[] pos = { i, j };
                        string tipo = Terrenos[i, j].tipo;
                        if (tipo != "Acuatico" && tipo != "Volcanic")
                        {
                            bool hay_dos = false;
                            foreach (var espacio in Espacios_2)
                            {
                                if (espacio[0] == pos[0] && espacio[1] == pos[1])
                                {
                                    hay_dos = true;
                                }
                            }
                            if (!hay_dos)
                            {
                                espacios_disponibles.Add(pos);
                            }
                        }
                    }
                }
                if (espacios_disponibles.Count > 0)
                {
                    numeroRan = random.Next(0, espacios_disponibles.Count);
                    bitmon = new Ent(espacios_disponibles[numeroRan]);
                    Bitmons_creados.Add(bitmon);
                    bitmons_creado_mes.Add(bitmon);
                    Bitmons.Add(bitmon);
                }
                else
                {
                    sobrepoblacion = true;
                }
            }
            else
            {
                for (int i = 0; i < Alto; i++)
                {
                    for (int j = 0; j < Ancho; j++)
                    {
                        int[] pos = { i, j };
                        string tipo = Terrenos[i, j].tipo;
                        if (tipo != "Acuatico")
                        {
                            bool hay_dos = false;
                            foreach (var espacio in Espacios_2)
                            {
                                if (espacio[0] == pos[0] && espacio[1] == pos[1])
                                {
                                    hay_dos = true;
                                }
                            }
                            if (!hay_dos)
                            {
                                espacios_disponibles.Add(pos);
                            }
                        }
                    }
                }
                if (espacios_disponibles.Count > 0)
                {
                    numeroRan = random.Next(0, espacios_disponibles.Count);
                    if (padre_ganador == "Dorvalo")
                    {
                        bitmon = new Dorvalo(espacios_disponibles[numeroRan]);
                        Bitmons.Add(bitmon);
                        Bitmons_creados.Add(bitmon);
                        bitmons_creado_mes.Add(bitmon);
                    }
                    else if (padre_ganador == "Doti")
                    {
                        bitmon = new Doti(espacios_disponibles[numeroRan]);
                        Bitmons_creados.Add(bitmon);
                        Bitmons.Add(bitmon);
                        bitmons_creado_mes.Add(bitmon);
                    }
                    else if (padre_ganador == "Gofue")
                    {
                        bitmon = new Gofue(espacios_disponibles[numeroRan]);
                        Bitmons_creados.Add(bitmon);
                        Bitmons.Add(bitmon);
                        bitmons_creado_mes.Add(bitmon);
                    }
                    else if (padre_ganador == "Taplan")
                    {
                        bitmon = new Taplan(espacios_disponibles[numeroRan]);
                        Bitmons_creados.Add(bitmon);
                        Bitmons.Add(bitmon);
                        bitmons_creado_mes.Add(bitmon);
                    }
                }
                else
                {
                    sobrepoblacion = true;
                }
            }
            papa.CantidadDereproducciones++;
            mama.CantidadDereproducciones++;
            this.Actualizar_espacios();
            Console.WriteLine($"{papa.Tipo} en [{papa.Posicion[0]},{papa.Posicion[1]}] con {mama.Tipo} en [{mama.Posicion[0]},{mama.Posicion[1]}]");
        }

        public void Relaciones()
        {
            bitmons_muertos_mes.Clear();

            if (Espacios_2.Count >= 0)
            {
                foreach (var pos in Espacios_2)
                {
                    //Apareamiento
                    var bitmons2 = Bitmons.Where(emp => (emp.Posicion[0] == pos[0]) && (emp.Posicion[1] == pos[1])).ToList();
                    if ((bitmons2[0].Tipo == "Doti" && bitmons2[1].Tipo == "Doti") || (bitmons2[0].Tipo == "Doti" && bitmons2[1].Tipo == "Ent") || (bitmons2[0].Tipo == "Ent" && bitmons2[1].Tipo == "Doti") || (bitmons2[0].Tipo == "Doti" && bitmons2[1].Tipo == "Dorvalo") || (bitmons2[0].Tipo == "Dorvalo" && bitmons2[1].Tipo == "Doti") || (bitmons2[0].Tipo == "Doti" && bitmons2[1].Tipo == "Gofue") || (bitmons2[0].Tipo == "Gofue" && bitmons2[1].Tipo == "Doti") || (bitmons2[0].Tipo == "Doti" && bitmons2[1].Tipo == "Taplan") || (bitmons2[0].Tipo == "Taplan" && bitmons2[1].Tipo == "Doti") || (bitmons2[0].Tipo == "Ent" && bitmons2[1].Tipo == "Ent") || (bitmons2[0].Tipo == "Dorvalo" && bitmons2[1].Tipo == "Dorvalo") || (bitmons2[0].Tipo == "Dorvalo" && bitmons2[1].Tipo == "Gofue") || (bitmons2[0].Tipo == "Gofue" && bitmons2[1].Tipo == "Dorvalo") || (bitmons2[0].Tipo == "Gofue" && bitmons2[1].Tipo == "Gofue") || (bitmons2[0].Tipo == "Wetar" && bitmons2[1].Tipo == "Wetar") || (bitmons2[0].Tipo == "Taplan" && bitmons2[1].Tipo == "Taplan"))
                    {
                        CrearBitmon(bitmons2[0], bitmons2[1]);
                    }
                    //Pelea

                    else if ((bitmons2[0].Tipo == "Ent" && bitmons2[1].Tipo == "Dorvalo") || (bitmons2[0].Tipo == "Dorvalo" && bitmons2[1].Tipo == "Ent") || (bitmons2[0].Tipo == "Ent" && bitmons2[1].Tipo == "Gofue") || (bitmons2[0].Tipo == "Gofue" && bitmons2[1].Tipo == "Ent") || (bitmons2[0].Tipo == "Ent" && bitmons2[1].Tipo == "Wetar") || (bitmons2[0].Tipo == "Wetar" && bitmons2[1].Tipo == "Ent") || (bitmons2[0].Tipo == "Ent" && bitmons2[1].Tipo == "Taplan") || (bitmons2[0].Tipo == "Taplan" && bitmons2[1].Tipo == "Ent") || (bitmons2[0].Tipo == "Gofue" && bitmons2[1].Tipo == "Wetar") || (bitmons2[0].Tipo == "Wetar" && bitmons2[1].Tipo == "Gofue") || (bitmons2[0].Tipo == "Gofue" && bitmons2[1].Tipo == "Taplan") || (bitmons2[0].Tipo == "Taplan" && bitmons2[1].Tipo == "Gofue") || (bitmons2[0].Tipo == "Dorvalo" && bitmons2[1].Tipo == "Wetar") || (bitmons2[0].Tipo == "Wetar" && bitmons2[1].Tipo == "Dorvalo") || (bitmons2[0].Tipo == "Dorvalo" && bitmons2[1].Tipo == "Taplan") || (bitmons2[0].Tipo == "Taplan" && bitmons2[1].Tipo == "Dorvalo"))//los que pelean
                    {
                        float a = bitmons2[0].Multiplicador * bitmons2[1].PuntosdeAtaque;
                        float b = bitmons2[1].Multiplicador * bitmons2[0].PuntosdeAtaque;
                        bitmons2[0].PuntosdeVida -= a;
                        bitmons2[1].PuntosdeVida -= b;

                        if ((bitmons2[0].PuntosdeVida <= 0) && (bitmons2[1].PuntosdeVida > 0))
                        {
                            bitmons2[1].PuntosdeVida += b;//SEGUN ENUNCIADO SI UN BITMON MATA A OTRO RECUPERA LOS PUNTOS DE VIDA
                            bitmons2[0].Morir();
                            Bitmons.Remove(bitmons2[0]);
                            Bitmons_muertos.Add(bitmons2[0]);
                            bitmons_muertos_mes.Add(bitmons2[0]);
                        }

                        else if ((bitmons2[1].PuntosdeVida <= 0) && (bitmons2[0].PuntosdeVida > 0))
                        {
                            bitmons2[0].PuntosdeVida += a;//SEGUN ENUNCIADO SI UN BITMON MATA A OTRO RECUPERA LOS PUNTOS DE VIDA
                            bitmons2[1].Morir();
                            Bitmons.Remove(bitmons2[1]);
                            Bitmons_muertos.Add(bitmons2[1]);
                            bitmons_muertos_mes.Add(bitmons2[1]);
                        }
                        else if ((bitmons2[1].PuntosdeVida <= 0) && (bitmons2[0].PuntosdeVida <= 0))
                        {
                            bitmons2[0].Morir();
                            bitmons2[1].Morir();
                            Bitmons.Remove(bitmons2[0]);
                            Bitmons_muertos.Add(bitmons2[0]);
                            Bitmons.Remove(bitmons2[1]);
                            Bitmons_muertos.Add(bitmons2[1]);
                            bitmons_muertos_mes.Add(bitmons2[0]);
                            bitmons_muertos_mes.Add(bitmons2[1]);
                        }
                    }
                }
            }
        }
    }
}
