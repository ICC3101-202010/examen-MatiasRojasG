using System;
using System.Threading;
namespace ExPOO
{
    public class Partido
    {
        Random rnd = new Random();
        private int minutos;
        private string liganacional;
        private Equipo team1;
        private Equipo team2;
        public Partido(Equipo Team1, Equipo Team2, int Minutos, string LigaNacional)
        {
            this.minutos = Minutos;
            this.liganacional = LigaNacional;
            this.team1 = Team1;
            this.team2 = Team2;
        }
        public string Team1 { get => team1.Name; set => team1.Name = value; }
        public string Team2 { get => team2.Name; set => team2.Name = value; }

        public int Duracion { get => minutos; set => minutos = value; }


        public string Start()
        {
            Thread.Sleep(1000);
            Console.WriteLine("Hoy será " + Team1 + " vs " + Team2);
            Console.WriteLine(Duracion + " minutos de mojar la camiseta");

            Console.WriteLine("Para " + Team1+ "la formación será");
            team1.JugadoresLlamados();
            Thread.Sleep(1000);
            Console.WriteLine("DT "+team1.Entrenador);
            Thread.Sleep(1000);
            Console.WriteLine("Medico " + team1.Medico);

            Console.WriteLine("Para " + Team2 + "la formación será");
            team2.JugadoresLlamados();
            Thread.Sleep(1000);
            Console.WriteLine("DT " + team2.Entrenador);
            Thread.Sleep(1000);
            Console.WriteLine("Medico " + team1.Medico);

            if (liganacional == "Nacional")
            {
                Console.WriteLine("Por un partido entre naciones");
            }
            else
            {
                Console.WriteLine("Un partido de la liga" + liganacional);
            }
            Console.WriteLine("Comienza el partido");
            int golesteam1 = 0;
            int golesteam2 = 0;
            Thread.Sleep(2000);


            //Primera jugada
            int primerajugada = rnd.Next(0, 2);
            int equipoprimerajugada = rnd.Next(0, 2);
            if (primerajugada == 1 && equipoprimerajugada==0)
            {
                Console.WriteLine("Golazo de " + Team1+ " al minuto "+ Duracion / 4);
                golesteam1+=1;
                Console.WriteLine("Tenemos " + golesteam1 + ":" + golesteam2);
            }
            if(primerajugada == 1 && equipoprimerajugada == 1)
            {
                Console.WriteLine("Golazo de "+Team2 + " al minuto " + Duracion / 4);
                golesteam2 += 1;
            }
            if (primerajugada == 0 && equipoprimerajugada == 0)
            {
                Console.WriteLine("Muy cerquita, palo de " + Team2);
            }
            if (primerajugada == 0 && equipoprimerajugada == 1)
            {
                Console.WriteLine("Muy cerquita, palo de " + Team2);
            }
            Console.WriteLine("");
            Thread.Sleep(2000);
            Console.WriteLine("");
            //Segunda jugada
            int segundajugada = rnd.Next(0, 2);
            int equiposegundajugada = rnd.Next(0, 2);
            if (segundajugada == 1 && equiposegundajugada == 0)
            {

                Console.WriteLine("Tenemos GOOOOOL de " + Team1+ " al minuto "+ Duracion/3);
                golesteam1 += 1;
                Console.WriteLine("El marcador queda " + golesteam1 + ":" + golesteam2);
            }
            if (segundajugada == 1 && equiposegundajugada == 1)
            {
                Console.WriteLine("Tenemos GOOOOOL de " + Team2+ " al minuto "+ Duracion / 3);
                golesteam2 += 1;
                Console.WriteLine("El marcador queda " + golesteam1 + ":" + golesteam2);
            }
            if (segundajugada == 0 && equiposegundajugada == 0)
            {
                Console.WriteLine("Yyyy se fue el balón, mala jugada de " + Team2);
            }
            if (segundajugada == 0 && equiposegundajugada == 1)
            {
                Console.WriteLine("Yyyy se fue el balón, mala jugada de " + Team2);
            }
            Thread.Sleep(2000);
            Console.WriteLine("");
            Console.WriteLine("Fin del primer tiempo");




            Thread.Sleep(2000);
            Console.WriteLine("Comenzamos con el segundo tiempo");
            Thread.Sleep(1000);
            int tercerajugada = rnd.Next(0, 2);
            int equipotercerajugada = rnd.Next(0, 2);
            if (tercerajugada == 1 && equipotercerajugada == 0)
            {

                Console.WriteLine("Que clase de " + Team1 + " un magnifico gol al minuto "+ Duracion / 2);
                golesteam1 += 1;
                Console.WriteLine("El marcador queda " + golesteam1 + ":" + golesteam2);
            }
            if (tercerajugada == 1 && equipotercerajugada == 1)
            {
                Console.WriteLine("Que clase de " + Team2 + " un magnifico gol al minuto "+ Duracion / 2);
                golesteam2 += 1;
                Console.WriteLine("El marcador queda " + golesteam1 + ":" + golesteam2);
            }
            if (tercerajugada == 0 && equipotercerajugada == 0)
            {
                Console.WriteLine("Se lamenta " + team2.Entrenador+", una jugada perdida");
            }
            if (tercerajugada == 0 && equipotercerajugada == 1)
            {
                Console.WriteLine("Se lamenta " + team1.Entrenador + ", una jugada perdida");
            }
            Thread.Sleep(1000);
            int cuartajugada = rnd.Next(0, 2);
            int equipocuartajugada = rnd.Next(0, 2);
            if (cuartajugada == 1 && equipocuartajugada == 0)
            {

                Console.WriteLine("A minutos del fin del partido tenemos un GOOOOOL de "+Team1);
                golesteam1 += 1;
                Console.WriteLine("El marcador queda " + golesteam1 + ":" + golesteam2);
            }
            if (cuartajugada == 1 && equipocuartajugada == 1)
            {
                Console.WriteLine("A minutos del fin del partido tenemos un GOOOOOL de " + Team2);
                golesteam2 += 1;
                Console.WriteLine("El marcador queda " + golesteam1 + ":" + golesteam2);
            }
            if (cuartajugada == 0 && equipocuartajugada == 0)
            {
                Console.WriteLine("Se lamenta " + team2.Entrenador + ", una jugada perdida");
            }
            if (cuartajugada == 0 && equipocuartajugada == 1)
            {
                Console.WriteLine("Se lamenta " + team1.Entrenador + ", una jugada perdida");
            }


            Thread.Sleep(2000);
            Console.WriteLine("");
            if (golesteam1 < golesteam2)
            {
                return "El partido acaba " + golesteam1 + ":" + golesteam2+" para "+Team2;
            }
            if (golesteam1 > golesteam2)
            {
                return "El partido acaba " + golesteam1 + ":" + golesteam2 + " para " + Team1;
            }
            else
            {
                return "El partido acaba en empate" + golesteam1 + ":" + golesteam2;
            }
        }
    }
}
