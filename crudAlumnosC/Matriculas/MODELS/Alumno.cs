using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Matriculas.MODELS
{
    internal class Alumno : Persona
    {
        // Atributos
        private string carrera;
        private int nota; 
        // Constructores
        public Alumno(int id, string nom, string mail, string car, int nota) : base(id, nom, mail)
        {
            this.carrera = car;
            this.nota = nota;
        }

        public string Carrera { get => carrera; set => carrera = value; }
        public int Nota { get => nota; set => nota = value; }

        // Métodos
        public override void Mostrar()
        {
            Console.WriteLine("DATOS DEL ALUMNO: ");
            base.Mostrar();
            Console.WriteLine($"CARRERA: {carrera}");
            Console.WriteLine($"NOTA: {nota}");
            Console.WriteLine(new string('-', 50));
        }
    }
}
