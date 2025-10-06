using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Herencia.Models
{
    internal class Alumno : Persona
    {
        // Atributos
        public int Nota { get; set; }

        // Métodos

        public override void Mostrar()
        {
            Console.WriteLine("DATOS DEL ALUMNO: ");
            base.Mostrar();
            Console.WriteLine($"Nota: {Nota}");
            Console.WriteLine(new string('-', 50));
        }
    }
}
