using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Matriculas.UTILS
{
    internal class Mensaje
    {
        private int ancho;

        // Constructor
        public Mensaje(int ancho)
        {
            this.ancho = ancho;
        }

        public void MonstrarTitulo(string titulo)
        {
            Console.WriteLine(new string('=', ancho));
            Console.WriteLine(new string (' ',15)+titulo);
            Console.WriteLine(new string('=', ancho));
        }
        public void MostrarMensaje(string mensaje)
        {
            Console.Clear();
            Console.WriteLine(new string('*', ancho));
            Console.WriteLine(new string (' ',15)+mensaje);
            Console.WriteLine(new string('*', ancho));
            System.Threading.Thread.Sleep(1000);
        }
    }
}
