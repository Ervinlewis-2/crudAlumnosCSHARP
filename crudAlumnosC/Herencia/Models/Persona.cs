using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Herencia.Models
{
    internal class Persona
    {
        // Propiedades
        public string Nombre { get; set; }
        public string AEmail { get; set; }

        // Constructor

        public Persona()
        {

        }
        // Métodos
        public virtual void Mostrar()
        {
            Console.WriteLine(new string('-', 50));
            Console.WriteLine($"Nombre: {Nombre}");
            Console.WriteLine($"Email: {AEmail}");

        }
    }
}
