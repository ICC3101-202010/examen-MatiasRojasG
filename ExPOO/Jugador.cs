using System;
namespace ExPOO
{
    public class Jugador : ILesion
    {
        private string name;
        private int edad;
        private int sueldo;
        private int ap; //Puntos de ataque
        private int dp; //Puntos de defensa
        private string dorsal;
        private string posicion;
        private string nacionalidad;
        private string equipo;
        public Jugador(string Name, int Edad, int Sueldo, int AP, int DP, string Dorsal, string Posicion, string Nacionalidad, string Team)
        {
            this.edad = Edad;
            this.sueldo = Sueldo;
            this.ap = AP;
            this.dp = DP;
            this.dorsal = Dorsal;
            this.posicion = Posicion;
            this.nacionalidad = Nacionalidad;
            this.name = Name;
            this.equipo = Team;
        }
        public void Lesion()
        {
            Console.WriteLine(Nombre + " está lesionado");
            Console.WriteLine("No puede seguir jugando");
            var evento = CambioRealizado;
            if(evento!=null)
            {
                evento();
            }
        }
        public delegate void Cambio();
        public event Cambio CambioRealizado;
        public int Edad { get => edad; set => edad = value; }
        public int Sueldo { get => sueldo; set => sueldo = value; }
        public string Nombre { get => name; set => name = value; }
        public int AP { get => ap; set => ap = value; }
        public int DP { get => dp; set => dp = value; }
        public string Dorsal { get => dorsal; set => dorsal = value; }
        public string Posicion { get => posicion; set => posicion = value; }
        public string Nacionalidad { get => nacionalidad; set => nacionalidad = value; }
        public string Equipo { get => equipo; set => equipo = value; }

        




    }
}
