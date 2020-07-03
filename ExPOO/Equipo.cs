using System;
using System.Collections.Generic;



namespace ExPOO
{
    public class Equipo
    {
        private List<Jugador> jugadores;
        private List<Jugador> jugadoresencancha;
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

        public string JugadoresLlamados()
        {
            Console.WriteLine("Dorsal  Nombre  Puntos de Ataque  Puntos de defensa");
            foreach(Jugador jugador in jugadores)
            {  
                Console.WriteLine(jugador.Dorsal+"       " +jugador.Nombre + "       " + jugador.AP + "       " + jugador.DP);
            }
            return "";
        }
    }
}
