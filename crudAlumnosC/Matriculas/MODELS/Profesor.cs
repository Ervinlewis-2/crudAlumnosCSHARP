using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Matriculas.MODELS
{
    internal class Profesor : Persona
    {
        // Atributos
        private string especialidad;
        // Constructores
        public Profesor(int id, string nom, string mail, string esp) : base(id, nom, mail)
        {
            this.especialidad = esp;
        }

        public string Especialidad { get => especialidad; set => especialidad = value; }

        // Métodos
        public override void Mostrar()
        {
            Console.WriteLine("DATOS DEL PROFESOR: ");
            base.Mostrar();
            Console.WriteLine($"ESPECIALIDAD: {especialidad}");
            Console.WriteLine(new string('-', 50));
        }
    }
}
