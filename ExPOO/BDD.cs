using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Resources;


namespace ExPOO
{
    public class BDD
    {
        private List<Equipo> equipos = new List<Equipo>();
        private List<Entrenador> entrenadorArg = new List<Entrenador>();
        private List<Medico> medicoArg = new List<Medico>();

        private List<Entrenador> entrenadorCh = new List<Entrenador>();
        private List<Medico> medicoCh = new List<Medico>();

        private List<Entrenador> entrenadorB = new List<Entrenador>();
        private List<Medico> medicoB = new List<Medico>();

        private List<Entrenador> entrenadorSa = new List<Entrenador>();
        private List<Medico> medicoSa = new List<Medico>();

        private List<Entrenador> entrenadorBar = new List<Entrenador>();
        private List<Medico> medicoBar = new List<Medico>();

        private List<Entrenador> entrenadorCol = new List<Entrenador>();
        private List<Medico> medicoCol = new List<Medico>();





        private List<Jugador> jugadoresB = new List<Jugador>();
        private List<Jugador> jugadoresCh = new List<Jugador>();
        private List<Jugador> jugadoresArg = new List<Jugador>();

        
        private List<Jugador> jugadoresBarcelona = new List<Jugador>();
        private List<Jugador> jugadoresColoColo = new List<Jugador>();
        private List<Jugador> jugadoresSantos = new List<Jugador>();

        private List<string> paises = new List<string>();
        private List<string> ligas = new List<string>();
        public BDD()
        {
            //Paises
            paises.Add("Italia");
            paises.Add("España");
            paises.Add("Alemania");
            paises.Add("Chile");
            paises.Add("Argentina");
            paises.Add("Brasil");
            //Entrenadores
            Entrenador trainerB = new Entrenador("Tite", 90, "Brasileña", 59, 3900000);
            entrenadorB.Add(trainerB);

            Entrenador trainerCh = new Entrenador("Rueda", 90, "Hondureña", 63, 3500000);
            entrenadorCh.Add(trainerCh);

            Entrenador trainerArg = new Entrenador("Scaloni", 90, "Argentina", 42, 500000);
            entrenadorArg.Add(trainerArg);

            Entrenador trainerSant = new Entrenador("Ferreira", 90, "Portuguez", 74, 6000000);
            entrenadorSa.Add(trainerSant);
            Entrenador trainerColo = new Entrenador("Espina", 90, "Argentina", 53, 6000000);
            entrenadorBar.Add(trainerColo);
            Entrenador trainerBarc = new Entrenador("Setien", 90, "Española", 61, 7000000);
            entrenadorCol.Add(trainerBarc);

            //Medicos
            Medico medicB = new Medico("Oliveria", 53, 2000000, "Brasileña", "Brasil");
            medicoB.Add(medicB);
            Medico medicSant = new Medico("Silva", 47, 2000000, "Brasileña", "Santos de Brasil");
            medicoSa.Add(medicSant);

            Medico medicCh = new Medico("Alvarez", 52, 1900000, "Chilena", "Chile");
            medicoCh.Add(medicB);
            Medico medicColo = new Medico("Silva", 57, 1800000, "Chilena", "Colo Colo");
            medicoCol.Add(medicColo);

            Medico medicArg = new Medico("Mendoza", 45, 2000000, "Argentina", "Argentina");
            medicoArg.Add(medicB);
            Medico medicBarc = new Medico("Gutierrez", 61, 2500000, "Española", "Barcelona");
            medicoBar.Add(medicSant);







            //Equipos
            //Equipo Brasil = new Equipo("Brasil", "Brasil", jugadoresB, trainerB)
            //Jugadores Brasil
            //Jugador jugador1B = new Jugador("Alisson", 0, 90, "1", "Portero", "Brasileña", )
            //Jugadores Chile
            //Jugadores Argentina
        }




        //Para paises
        public List<Jugador> jugadoreselegidosArg { get => jugadoresArg; set => jugadoresArg = value; }
        public List<Jugador> jugadoreselegidosCh { get => jugadoresCh; set => jugadoresCh = value; }
        public List<Jugador> jugadoreselegidosB { get => jugadoresB; set => jugadoresB = value; }

        public Entrenador EntrenadorArg { get => entrenadorArg[0]; set => entrenadorArg[0] = value; }
        public Entrenador EntrenadorCh { get => entrenadorCh[0]; set => entrenadorCh[0] = value; }
        public Entrenador EntrenadorB { get => entrenadorB[0]; set => entrenadorB[0] = value; }

        public Medico MedicoArg { get => medicoArg[0]; set => medicoArg[0] = value; }
        public Medico MedicoCh { get => medicoCh[0]; set => medicoCh[0] = value; }
        public Medico MedicoB { get => medicoB[0]; set => medicoB[0] = value; }



    }
}
