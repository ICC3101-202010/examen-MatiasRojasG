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

        
        private List<Jugador> jugadoresBar = new List<Jugador>();
        private List<Jugador> jugadoresCol = new List<Jugador>();
        private List<Jugador> jugadoresSa = new List<Jugador>();

        private List<string> ligas = new List<string>();
        public BDD()
        {
            //Entrenadores
            Entrenador trainerB = new Entrenador("Tite", 90, "Brasileña", 59, 3900000, "Brasil");
            entrenadorB.Add(trainerB);

            Entrenador trainerCh = new Entrenador("Rueda", 90, "Hondureña", 63, 3500000, "Chile");
            entrenadorCh.Add(trainerCh);

            Entrenador trainerArg = new Entrenador("Scaloni", 90, "Argentina", 42, 500000, "Argentina");
            entrenadorArg.Add(trainerArg);

            Entrenador trainerSant = new Entrenador("Ferreira", 90, "Portuguez", 74, 6000000, "Santos de Brasil");
            entrenadorSa.Add(trainerSant);
            Entrenador trainerColo = new Entrenador("Espina", 90, "Argentina", 53, 6000000, "Colo Colo");
            entrenadorBar.Add(trainerColo);
            Entrenador trainerBarc = new Entrenador("Setien", 90, "Española", 61, 7000000, "Barcelona");
            entrenadorCol.Add(trainerBarc);

            //Medicos
            Medico medicB = new Medico("Oliveria", 53, 2000000, "Brasileña", "Brasil");
            medicoB.Add(medicB);
            Medico medicSant = new Medico("Silva", 47, 2000000, "Brasileña", "Santos de Brasil");
            medicoSa.Add(medicSant);

            Medico medicCh = new Medico("Alvarez", 52, 1900000, "Chilena", "Chile");
            medicoCh.Add(medicCh);
            Medico medicColo = new Medico("Silva", 57, 1800000, "Chilena", "Colo Colo");
            medicoCol.Add(medicColo);

            Medico medicArg = new Medico("Mendoza", 45, 2000000, "Argentina", "Argentina");
            medicoArg.Add(medicArg);
            Medico medicBarc = new Medico("Gutierrez", 61, 2500000, "Española", "Barcelona");
            medicoBar.Add(medicBarc);

            //Jugadores Brasil
            Jugador jugadorb1 = new Jugador("A", 30, 38000000, 20, 90, "1", "Portero", "Brasileña", "Brasil");
            jugadoresB.Add(jugadorb1);
            Jugador jugadorb2 = new Jugador("B", 31, 36000000, 48, 68, "6", "Defensa", "Brasileña", "Brasil");
            jugadoresB.Add(jugadorb2);
            Jugador jugadorb3 = new Jugador("C", 32, 35000000, 57, 69, "12", "Defensa", "Brasileña", "Brasil");
            jugadoresB.Add(jugadorb3);
            Jugador jugadorb4 = new Jugador("D", 33, 40000000, 55, 78, "13", "Defensa", "Brasileña", "Brasil");
            jugadoresB.Add(jugadorb4);
            Jugador jugadorb5 = new Jugador("E", 31, 42000000, 70, 60, "7", "Defensa", "Brasileña", "Brasil");
            jugadoresB.Add(jugadorb5);
            Jugador jugadorb6 = new Jugador("F", 32, 42000000, 77, 69, "8", "CentroCampista", "Brasileña", "Brasil");
            jugadoresB.Add(jugadorb6);
            Jugador jugadorb7 = new Jugador("G", 33, 42000000, 82, 65, "1", "CentroCampista", "Brasileña", "Brasil");
            jugadoresB.Add(jugadorb7);
            Jugador jugadorb8 = new Jugador("H", 30, 50000000, 87, 70, "18", "CentroCampista", "Brasileña", "Brasil");
            jugadoresB.Add(jugadorb8);
            Jugador jugadorb9 = new Jugador("I", 31, 50000000, 85, 68, "6", "CentroCampista", "Brasileña", "Brasil");
            jugadoresB.Add(jugadorb9);
            Jugador jugadorb10 = new Jugador("J", 32, 50000000, 98, 69, "10", "Delantero", "Brasileña", "Brasil");
            jugadoresB.Add(jugadorb10);
            Jugador jugadorb11 = new Jugador("K", 33, 50000000, 96, 74, "9", "Delantero", "Brasileña", "Brasil");
            jugadoresB.Add(jugadorb11);
            Jugador jugadorb12 = new Jugador("L", 31, 50000000, 82, 60, "19", "Delantero", "Brasileña", "Brasil");
            jugadoresB.Add(jugadorb12);
            Jugador jugadorb13 = new Jugador("M", 32, 50000000, 97, 74, "20", "Delantero", "Brasileña", "Brasil");
            jugadoresB.Add(jugadorb13);
            Jugador jugadorb14 = new Jugador("N", 33, 50000000, 82, 65, "15", "Delantero", "Brasileña", "Brasil");
            jugadoresB.Add(jugadorb14);
            Jugador jugadorb15 = new Jugador("O", 32, 50000000, 76, 65, "24", "CentroCampista", "Brasileña", "Brasil");
            jugadoresB.Add(jugadorb15);


            //Jugadores Chile
            Jugador jugadorCh1 = new Jugador("A", 30, 38000000, 20, 90, "1", "Portero", "Chilena", "Chile");
            jugadoresCh.Add(jugadorCh1);
            Jugador jugadorCh2 = new Jugador("B", 31, 36000000, 48, 68, "7", "Defensa", "Chilena", "Chile");
            jugadoresCh.Add(jugadorCh2);
            Jugador jugadorCh3 = new Jugador("C", 32, 35000000, 57, 69, "13", "Defensa", "Chilena", "Chile");
            jugadoresCh.Add(jugadorCh3);
            Jugador jugadorCh4 = new Jugador("D", 33, 40000000, 55, 78, "14", "Defensa", "Chilena", "Chile");
            jugadoresCh.Add(jugadorCh4);
            Jugador jugadorCh5 = new Jugador("E", 31, 42000000, 70, 60, "8", "Defensa", "Chilena", "Chile");
            jugadoresCh.Add(jugadorCh5);
            Jugador jugadorCh6 = new Jugador("F", 32, 42000000, 77, 69, "9", "CentroCampista", "Chilena", "Chile");
            jugadoresCh.Add(jugadorCh6);
            Jugador jugadorCh7 = new Jugador("G", 33, 42000000, 82, 65, "3", "CentroCampista", "Chilena", "Chile");
            jugadoresCh.Add(jugadorCh7);
            Jugador jugadorCh8 = new Jugador("H", 30, 50000000, 87, 70, "4", "CentroCampista", "Chilena", "Chile");
            jugadoresCh.Add(jugadorCh8);
            Jugador jugadorCh9 = new Jugador("I", 31, 50000000, 85, 68, "6", "CentroCampista", "Chilena", "Chile");
            jugadoresCh.Add(jugadorCh9);
            Jugador jugadorCh10 = new Jugador("J", 32, 50000000, 98, 69, "10", "Delantero", "Chilena", "Chile");
            jugadoresCh.Add(jugadorCh10);
            Jugador jugadorCh11 = new Jugador("K", 33, 50000000, 96, 74, "9", "Delantero", "Chilena", "Chile");
            jugadoresCh.Add(jugadorCh11);
            Jugador jugadorCh12 = new Jugador("L", 31, 50000000, 82, 60, "19", "Delantero", "Chilena", "Chile");
            jugadoresCh.Add(jugadorCh12);
            Jugador jugadorCh13 = new Jugador("M", 32, 50000000, 97, 74, "20", "Delantero", "Chilenaa", "Chile");
            jugadoresCh.Add(jugadorCh13);
            Jugador jugadorCh14 = new Jugador("N", 33, 50000000, 82, 65, "15", "Delantero", "Chilena", "Chile");
            jugadoresCh.Add(jugadorCh14);
            Jugador jugadorCh15 = new Jugador("O", 32, 50000000, 76, 65, "24", "CentroCampista", "Chilena", "Chile");
            jugadoresCh.Add(jugadorCh15);


            //Jugadores Argentina
            Jugador jugadorArg1 = new Jugador("A", 30, 38000000, 20, 90, "1", "Portero", "Argentina", "Argentina");
            jugadoresArg.Add(jugadorArg1);
            Jugador jugadorArg2 = new Jugador("B", 31, 36000000, 48, 68, "6", "Defensa", "Argentina", "Argentina");
            jugadoresArg.Add(jugadorArg2);
            Jugador jugadorArg3 = new Jugador("C", 32, 35000000, 57, 69, "12", "Defensa", "Argentina", "Argentina");
            jugadoresArg.Add(jugadorArg3);
            Jugador jugadorArg4 = new Jugador("D", 33, 40000000, 55, 79, "13", "Defensa", "Argentina", "Argentina");
            jugadoresArg.Add(jugadorArg4);
            Jugador jugadorArg5 = new Jugador("E", 31, 42000000, 77, 60, "7", "Defensa", "Argentina", "Argentina");
            jugadoresArg.Add(jugadorArg5);
            Jugador jugadorArg6 = new Jugador("F", 32, 42000000, 72, 69, "8", "CentroCampista", "Argentina", "Argentina");
            jugadoresArg.Add(jugadorArg6);
            Jugador jugadorArg7 = new Jugador("G", 33, 42000000, 81, 65, "1", "CentroCampista", "Argentina", "Argentina");
            jugadoresArg.Add(jugadorArg7);
            Jugador jugadorArg8 = new Jugador("H", 30, 50000000, 85, 70, "1", "CentroCampista", "Argentina", "Argentina");
            jugadoresArg.Add(jugadorArg8);
            Jugador jugadorArg9 = new Jugador("I", 31, 50000000, 85, 67, "6", "CentroCampista", "Argentina", "Argentina");
            jugadoresArg.Add(jugadorArg9);
            Jugador jugadorArg10 = new Jugador("J", 32, 50000000, 98, 69, "10", "Delantero", "Argentina", "Argentina");
            jugadoresArg.Add(jugadorArg10);
            Jugador jugadorArg11 = new Jugador("K", 33, 50000000, 96, 64, "9", "Delantero", "Argentina", "Argentina");
            jugadoresArg.Add(jugadorArg11);
            Jugador jugadorArg12 = new Jugador("L", 31, 50000000, 82, 60, "19", "Delantero", "Argentina", "Argentina");
            jugadoresArg.Add(jugadorArg12);
            Jugador jugadorArg13 = new Jugador("M", 32, 50000000, 97, 74, "20", "Delantero", "Argentina", "Argentina");
            jugadoresArg.Add(jugadorArg13);
            Jugador jugadorArg14 = new Jugador("N", 33, 50000000, 82, 65, "15", "Delantero", "Argentina", "Argentina");
            jugadoresArg.Add(jugadorArg14);
            Jugador jugadorArg15 = new Jugador("O", 32, 50000000, 76, 65, "24", "CentroCampista", "Argentina", "Argentina");
            jugadoresArg.Add(jugadorArg15);


            //Jugadores Barcelona
            Jugador jugadorBar1 = new Jugador("A", 30, 38000000, 20, 90, "1", "Portero", "Española", "Barcelona");
            jugadoresBar.Add(jugadorBar1);
            Jugador jugadorBar2 = new Jugador("B", 31, 36000000, 48, 68, "6", "Defensa", "Brasileña", "Barcelona");
            jugadoresBar.Add(jugadorBar2);
            Jugador jugadorBar3 = new Jugador("C", 32, 35000000, 57, 69, "12", "Defensa", "Española", "Barcelona");
            jugadoresBar.Add(jugadorBar3);
            Jugador jugadorBar4 = new Jugador("D", 33, 40000000, 55, 78, "13", "Defensa", "Argentina", "Barcelona");
            jugadoresBar.Add(jugadorBar4);
            Jugador jugadorBar5 = new Jugador("E", 31, 42000000, 70, 60, "7", "Defensa", "Argentina", "Barcelona");
            jugadoresBar.Add(jugadorBar5);
            Jugador jugadorBar6 = new Jugador("F", 32, 42000000, 77, 69, "8", "CentroCampista", "Chilena", "Barcelona");
            jugadoresBar.Add(jugadorBar6);
            Jugador jugadorBar7 = new Jugador("G", 33, 42000000, 82, 65, "1", "CentroCampista", "Alemana", "Barcelona");
            jugadoresBar.Add(jugadorBar7);
            Jugador jugadorBar8 = new Jugador("H", 30, 50000000, 84, 70, "1", "CentroCampista", "Brasileña", "Barcelona");
            jugadoresBar.Add(jugadorBar8);
            Jugador jugadorBar9 = new Jugador("I", 31, 50000000, 85, 68, "6", "CentroCampista", "Alemana", "Barcelona");
            jugadoresBar.Add(jugadorBar9);
            Jugador jugadorBar10 = new Jugador("J", 32, 50000000, 92, 69, "10", "Delantero", "Argentina", "Barcelona");
            jugadoresBar.Add(jugadorBar10);
            Jugador jugadorBar11 = new Jugador("K", 33, 50000000, 97, 74, "9", "Delantero", "Argentina", "Barcelona");
            jugadoresBar.Add(jugadorBar11);
            Jugador jugadorBar12 = new Jugador("L", 31, 50000000, 82, 60, "19", "Delantero", "Argentina", "Barcelona");
            jugadoresBar.Add(jugadorBar12);
            Jugador jugadorBar13 = new Jugador("M", 32, 50000000, 92, 74, "20", "Delantero", "Francesa", "Barcelona");
            jugadoresBar.Add(jugadorBar13);
            Jugador jugadorBar14 = new Jugador("N", 33, 50000000, 87, 65, "15", "Delantero", "Alemana", "Barcelona");
            jugadoresBar.Add(jugadorBar14);
            Jugador jugadorBar15 = new Jugador("O", 32, 50000000, 79, 65, "24", "CentroCampista", "Francesa", "Barcelona");
            jugadoresBar.Add(jugadorBar15);


            //Jugadores ColoColo
            Jugador jugadorCol1 = new Jugador("A", 30, 38000000, 20, 90, "1", "Portero", "Uruaguaya", "Barcelona");
            jugadoresCol.Add(jugadorCol1);
            Jugador jugadorCol2 = new Jugador("B", 31, 36000000, 48, 68, "6", "Defensa", "Argentina", "Barcelona");
            jugadoresCol.Add(jugadorCol2);
            Jugador jugadorCol3 = new Jugador("C", 32, 35000000, 57, 69, "12", "Defensa", "Argentina", "Barcelona");
            jugadoresCol.Add(jugadorCol3);
            Jugador jugadorCol4 = new Jugador("D", 33, 40000000, 55, 78, "13", "Defensa", "Chilena", "Barcelona");
            jugadoresCol.Add(jugadorCol4);
            Jugador jugadorCol5 = new Jugador("E", 31, 42000000, 70, 60, "7", "Defensa", "Argentina", "Barcelona");
            jugadoresCol.Add(jugadorCol5);
            Jugador jugadorCol6 = new Jugador("F", 32, 42000000, 77, 69, "8", "CentroCampista", "Uruaguaya", "Barcelona");
            jugadoresCol.Add(jugadorCol6);
            Jugador jugadorCol7 = new Jugador("G", 33, 42000000, 82, 65, "1", "CentroCampista", "Uruaguaya", "Barcelona");
            jugadoresCol.Add(jugadorCol7);
            Jugador jugadorCol8 = new Jugador("H", 30, 50000000, 84, 70, "1", "CentroCampista", "Chilena", "Barcelona");
            jugadoresCol.Add(jugadorCol8);
            Jugador jugadorCol9 = new Jugador("I", 31, 50000000, 85, 68, "6", "CentroCampista", "Chilena", "Barcelona");
            jugadoresCol.Add(jugadorCol9);
            Jugador jugadorCol10 = new Jugador("J", 32, 50000000, 92, 69, "10", "Delantero", "Argentina", "Barcelona");
            jugadoresCol.Add(jugadorBar10);
            Jugador jugadorCol11 = new Jugador("K", 33, 50000000, 97, 74, "9", "Delantero", "Chilena", "Barcelona");
            jugadoresCol.Add(jugadorCol11);
            Jugador jugadorCol12 = new Jugador("L", 31, 50000000, 82, 60, "19", "Delantero", "Argentina", "Barcelona");
            jugadoresCol.Add(jugadorCol12);
            Jugador jugadorCol13 = new Jugador("M", 32, 50000000, 92, 74, "20", "Delantero", "Chilena", "Barcelona");
            jugadoresCol.Add(jugadorCol13);
            Jugador jugadorCol14 = new Jugador("N", 33, 50000000, 87, 65, "15", "Delantero", "Argentina", "Barcelona");
            jugadoresCol.Add(jugadorCol14);
            Jugador jugadorCol15 = new Jugador("O", 32, 50000000, 79, 65, "24", "CentroCampista", "Chilena", "Barcelona");
            jugadoresCol.Add(jugadorCol15);





            //Jugadores Santos
            Jugador jugadorSa1 = new Jugador("A", 30, 38000000, 20, 90, "1", "Portero", "Brasileña", "Barcelona");
            jugadoresSa.Add(jugadorSa1);
            Jugador jugadorSa2 = new Jugador("B", 31, 36000000, 48, 68, "6", "Defensa", "Argentina", "Barcelona");
            jugadoresSa.Add(jugadorSa2);
            Jugador jugadorSa3 = new Jugador("C", 32, 35000000, 57, 69, "12", "Defensa", "Brasileña", "Barcelona");
            jugadoresSa.Add(jugadorSa3);
            Jugador jugadorSa4 = new Jugador("D", 33, 40000000, 55, 78, "13", "Defensa", "Chilena", "Barcelona");
            jugadoresSa.Add(jugadorSa4);
            Jugador jugadorSa5 = new Jugador("E", 31, 42000000, 70, 60, "7", "Defensa", "Argentina", "Barcelona");
            jugadoresSa.Add(jugadorSa5);
            Jugador jugadorSa6 = new Jugador("F", 32, 42000000, 77, 69, "8", "CentroCampista", "Brasileña", "Barcelona");
            jugadoresSa.Add(jugadorSa6);
            Jugador jugadorSa7 = new Jugador("G", 33, 42000000, 82, 65, "1", "CentroCampista", "Brasileña", "Barcelona");
            jugadoresSa.Add(jugadorSa7);
            Jugador jugadorSa8 = new Jugador("H", 30, 50000000, 84, 70, "1", "CentroCampista", "Brasileña", "Barcelona");
            jugadoresSa.Add(jugadorSa8);
            Jugador jugadorSa9 = new Jugador("I", 31, 50000000, 85, 68, "6", "CentroCampista", "Chilena", "Barcelona");
            jugadoresSa.Add(jugadorSa9);
            Jugador jugadorSa10 = new Jugador("J", 32, 50000000, 92, 69, "10", "Delantero", "Brasileña", "Barcelona");
            jugadoresSa.Add(jugadorSa10);
            Jugador jugadorSa11 = new Jugador("K", 33, 50000000, 97, 74, "9", "Delantero", "Chilena", "Barcelona");
            jugadoresSa.Add(jugadorSa11);
            Jugador jugadorSa12 = new Jugador("L", 31, 50000000, 82, 60, "19", "Delantero", "Brasileña", "Barcelona");
            jugadoresSa.Add(jugadorSa12);
            Jugador jugadorSa13 = new Jugador("M", 32, 50000000, 92, 74, "20", "Delantero", "Chilena", "Barcelona");
            jugadoresSa.Add(jugadorSa13);
            Jugador jugadorSa14 = new Jugador("N", 33, 50000000, 87, 65, "15", "Delantero", "Brasileña", "Barcelona");
            jugadoresSa.Add(jugadorSa14);
            Jugador jugadorSa15 = new Jugador("O", 32, 50000000, 79, 65, "24", "CentroCampista", "Chilena", "Barcelona");
            jugadoresSa.Add(jugadorSa15);




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



        public List<Jugador> jugadoreselegidosBar { get => jugadoresBar; set => jugadoresBar = value; }
        public List<Jugador> jugadoreselegidosCol { get => jugadoresCol; set => jugadoresCol = value; }
        public List<Jugador> jugadoreselegidosSa { get => jugadoresSa; set => jugadoresSa = value; }

        public Entrenador EntrenadorBar { get => entrenadorArg[0]; set => entrenadorArg[0] = value; }
        public Entrenador EntrenadorCol { get => entrenadorCh[0]; set => entrenadorCh[0] = value; }
        public Entrenador EntrenadorSa { get => entrenadorB[0]; set => entrenadorB[0] = value; }

        public Medico MedicoBar { get => medicoBar[0]; set => medicoBar[0] = value; }
        public Medico MedicoCol { get => medicoCol[0]; set => medicoCol[0] = value; }
        public Medico MedicoSa { get => medicoSa[0]; set => medicoSa[0] = value; }


    }
}
