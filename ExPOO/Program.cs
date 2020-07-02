using System;

namespace ExPOO
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            BDD bdd = new BDD();
            Console.WriteLine("Ajustes del partido:");
            Console.WriteLine("Equipos:");
            Console.WriteLine("1) Chile");
            Console.WriteLine("2) Argentina");
            Console.WriteLine("3) Brasil");
            string equipo1 = Console.ReadLine();
            string equipo2 = Console.ReadLine();

            //Creacion de equipos
            Equipo Argentina = new Equipo("Argentina", "Argentina", bdd.jugadoreselegidosArg, bdd.EntrenadorArg, bdd.MedicoArg);
            Equipo Chile = new Equipo("Chile", "Chile", bdd.jugadoreselegidosCh, bdd.EntrenadorCh, bdd.MedicoCh);
            Equipo Brasil = new Equipo("Brasil", "Brasil", bdd.jugadoreselegidosB, bdd.EntrenadorB, bdd.MedicoB);

            //Duracion
            Console.WriteLine("Duración:");
            int duracion = Convert.ToInt32(Console.ReadLine());

            while (equipo1 == "Chile" || equipo1 == "Argentina" || equipo1 == "Brasil" && equipo2 == "Chile" || equipo2 == "Argentina" || equipo2 == "Brasil")
            {
                if (equipo1 == "Chile" && equipo2 == "Argentina"
                    || equipo2 == "Chile" && equipo1 == "Argentina")
                {
                    Partido partido = new Partido(Chile, Argentina, duracion, "Nacional");
                    Console.WriteLine(partido.Start());
                    break;
                }
                if (equipo1 == "Chile" && equipo2 == "Brasil" || equipo1 == "Brasil" && equipo2 == "Chile")
                {
                    Partido partido = new Partido(Chile, Brasil, duracion, "Nacional");
                    Console.WriteLine(partido.Start());
                    break;
                }
                if (equipo1 == "Argentina" && equipo2 == "Brasil" || equipo1 == "Brasil" && equipo2 == "Argentina")
                {
                    Partido partido = new Partido(Argentina, Brasil, duracion, "Nacional");
                    Console.WriteLine(partido.Start());
                    break;
                }
            }
        }
    }
}
