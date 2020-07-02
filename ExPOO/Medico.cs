using System;
namespace ExPOO
{
    public class Medico : IEnC
    {
        private string name;
        private int edad;
        private int sueldo;
        private string nacionalidad;
        private string equipo;

        public Medico(string Name, int Edad, int Sueldo,string Nacionalidad, string Team)
        {
            this.name = Name;
            this.edad = Edad;
            this.sueldo = Sueldo;
            this.nacionalidad = Nacionalidad;
            this.equipo = Team;
        }


        //Metodos para evaluar y curar a un jugador
        public void Evaluar()
        {

        }
        public void Curar()
        {

        }



        public string Nombre { get => name; set => name = value; }
        public string Nacionalidad { get => nacionalidad; set => nacionalidad = value; }
    }
}
