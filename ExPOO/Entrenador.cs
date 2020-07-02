using System;
namespace ExPOO
{
    public class Entrenador : IChangePlayer
    {
        private string name;
        private int edad;
        private int sueldo;
        private int tp;
        private string nacionalidad;
        public Entrenador(string Name, int TP, string Nacionalidad, int Edad, int Sueldo)
        {
            this.edad = Edad;
            this.sueldo = Sueldo;
            this.name = Name;
            this.tp = TP;
            this.nacionalidad = Nacionalidad;
        }

        public void CambiaJugador()
        {

        }





        public string Nombre { get => name; set => name = value; }
        public int Edad { get => edad; set => edad = value; }
        public int Sueldo { get => sueldo; set => sueldo = value; }
        public int PuntosTecnico { get => tp; set => tp = value; }
    }
}
