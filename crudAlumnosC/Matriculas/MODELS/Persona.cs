using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Matriculas.MODELS
{
    internal class Persona
    {
        //Atributos
        private int id;
        private string nombre;
        private string email;

        // constructores
        public Persona(int id, string nom, string mail)
        {
            this.id = id;
            this.nombre = nom;
            this.email = mail;
        }

        public string Nombre { get => nombre; set => nombre = value; }
        public string Email { get => email; set => email = value; }

        // metodos
        public virtual void Mostrar()
        {
            Console.WriteLine($"ID: {id}");
            Console.WriteLine($"NOMBRE: {nombre}");
            Console.WriteLine($"EMAIL: {email}");
        }


    }
}
