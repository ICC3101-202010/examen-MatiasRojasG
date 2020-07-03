using System;
using System.Collections.Generic;



namespace ExPOO
{
    public class Equipo
    {
        private List<Jugador> jugadores;
        private string nombre;
        private string pais;
        private Entrenador trainer;
        private Medico medic;


        public Equipo(string Nombre, string Pais, List<Jugador> Jugadores, Entrenador Trainer, Medico Medic)
        {
            this.nombre = Nombre;
            this.pais = Pais;
            this.trainer = Trainer;
            this.medic = Medic;
            this.jugadores = Jugadores;
        }
        public string Name { get => nombre; set => nombre = value; }
        public string Pais { get => pais; set => pais = value; }
        public string Entrenador { get => trainer.Nombre; set => trainer.Nombre = value; }
        public string Medico { get => medic.Nombre; set => medic.Nombre = value; }
        public Entrenador Entrenadorr { get => trainer; set => trainer = value; }
        public Jugador Delantero1 { get => jugadores[10]; set => jugadores[10] = value; }
        public Jugador Delantero2 { get => jugadores[14]; set => jugadores[14] = value; }

        public string JugadoresLlamados()
        {
            Console.WriteLine("Dorsal  Nombre  Puntos de Ataque  Puntos de defensa");
            foreach(Jugador jugador in jugadores)
            {  
                Console.WriteLine(jugador.Dorsal+"       " +jugador.Nombre + "       " + jugador.AP + "       " + jugador.DP);
            }
            return "";
        }
        public void CorroborarNacionalidad(string Nacinoalidad)
        {
            foreach(Jugador jugador in jugadores)
            {
                if(jugador.Nacionalidad!=Nacinoalidad)
                {
                    Console.WriteLine(jugador.Nombre + " no puede ingresar a la nómina del país ya que no tiene su nacionalidad ahí");
                }
            }
        }
        public int PuntosdeAtaque()
        {
            int PuntosdeAtaque = 0;
            foreach(Jugador jugador in jugadores)
            {
                PuntosdeAtaque += jugador.AP;
            }
            return PuntosdeAtaque;
        }
        public int PuntosdeDefensa()
        {
            int PuntosdeDefensa = 0;
            foreach (Jugador jugador in jugadores)
            {
                PuntosdeDefensa += jugador.DP;
            }
            return PuntosdeDefensa;
        }
    }
}
