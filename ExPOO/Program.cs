using System;

namespace ExPOO
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            //static void Entrenadorr_CambioRealizado()
            //{
            //    Console.WriteLine("Cambio Realizado");
            //}
            BDD bdd = new BDD();
            Console.WriteLine("Ajustes del partido:");
            Console.WriteLine("Nacional / Internacional");
            string respuesta = Console.ReadLine();
            while (true)
            {
                if (respuesta == "Nacional")
                {
                    Console.WriteLine("Equipos liga nacional:");
                    Console.WriteLine("1) Chile");
                    Console.WriteLine("2) Argentina");
                    Console.WriteLine("3) Brasil");
                    break;
                }
                if (respuesta == "Internacional")
                {
                    Console.WriteLine("Equipos ligas internacionales:");
                    Console.WriteLine("1) Barcelona");
                    Console.WriteLine("2) Colo Colo");
                    Console.WriteLine("3) Santos");
                    break;
                }
            }
            string equipo1 = Console.ReadLine();
            string equipo2 = Console.ReadLine();

            //Creacion de equipos
            Equipo Argentina = new Equipo("Argentina", "Argentina", bdd.jugadoreselegidosArg, bdd.EntrenadorArg, bdd.MedicoArg);
            Equipo Chile = new Equipo("Chile", "Chile", bdd.jugadoreselegidosCh, bdd.EntrenadorCh, bdd.MedicoCh);
            Equipo Brasil = new Equipo("Brasil", "Brasil", bdd.jugadoreselegidosB, bdd.EntrenadorB, bdd.MedicoB);

            Equipo Barcelona = new Equipo("Barcelona", "España", bdd.jugadoreselegidosBar, bdd.EntrenadorBar, bdd.MedicoBar);
            Equipo ColoColo = new Equipo("Colo Colo", "Chile", bdd.jugadoreselegidosCol, bdd.EntrenadorCol, bdd.MedicoCol);
            Equipo Santos = new Equipo("Santos", "Brasil", bdd.jugadoreselegidosSa, bdd.EntrenadorSa, bdd.MedicoSa);


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
            while (equipo1 == "Santos" || equipo1 == "ColoColo" || equipo1 == "Barcelona" && equipo2 == "Santos" || equipo2 == "ColoColo" || equipo2 == "Barcelona")
            {
                if (equipo1 == "Santos" && equipo2 == "ColoColo"
                    || equipo2 == "ColoColo" && equipo1 == "Santos")
                {
                    Partido partido = new Partido(Santos, ColoColo, duracion, "Latinoamericana");
                    Console.WriteLine(partido.Start());
                    break;
                }
                if (equipo1 == "ColoColo" && equipo2 == "Barcelona" || equipo1 == "Barcelona" && equipo2 == "ColoColo")
                {
                    Partido partido = new Partido(ColoColo, Barcelona, duracion, "Mundial de Clubes");
                    Console.WriteLine(partido.Start());
                    break;
                }
                if (equipo1 == "Barcelona" && equipo2 == "Santos" || equipo1 == "Santos" && equipo2 == "Barcelona")
                {
                    Partido partido = new Partido(Barcelona, Santos, duracion, "Mundial de Clubes");
                    Console.WriteLine(partido.Start());
                    break;
                }
            }
        }
    }
}
