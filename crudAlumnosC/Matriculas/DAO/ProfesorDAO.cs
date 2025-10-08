using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using Matriculas.MODELS;
using Matriculas.UTILS;


namespace Matriculas.DAO
{
    internal class ProfesorDAO : DAO
    {
        private List<Profesor> ListaProfesores = new List<Profesor>();

        //Metodos
        private Profesor FindValue()
        {
            Console.WriteLine("INGRESE EL EMAIL DEL PROFESOR :");
            string email= Console.ReadLine();

            Profesor profesor = ListaProfesores.Find(a => a.Email.Equals(email, StringComparison.OrdinalIgnoreCase));
            return profesor;
        }

        public override void Create()
        {
            base.mensaje.MonstrarTitulo( "REGISTRO DE NUEVO PROFESOR");
            Console.Write("ID : ");
            int id = int.Parse(Console.ReadLine());
            Console.Write("NOMBRE : ");
            string nombre = Console.ReadLine();
            Console.Write("EMAIL : ");
            string email = Console.ReadLine();
            Console.Write("ESPECIALIDAD : ");
            string especialidad = Console.ReadLine();
            Profesor nuevoProfesor = new Profesor(id, nombre, email, especialidad);
            ListaProfesores.Add(nuevoProfesor);
            base.mensaje.MostrarMensaje("Profesor registrado con éxito.");

        }
        public override void Read()
        {
            base.mensaje.MonstrarTitulo("LISTA DE PROFESORES");
            if (ListaProfesores.Count > 0)
            {
                foreach (var profesor in ListaProfesores)
                {
                    profesor.Mostrar();
                }
            }
            else
            {
                Console.WriteLine("No hay profesores registrados.");
            }
        }
        public override void Update()
        {
            base.mensaje.MonstrarTitulo("ACTULIZAR PROFESOR");
            Profesor profesor = this.FindValue();
            if (profesor != null)
            {
                Console.WriteLine("NUEVO NOMBRE:");
                string nuevoNombre = Console.ReadLine();
                Console.WriteLine("NUEVO EMAIL:");
                string nuevoEmail = Console.ReadLine();
                Console.WriteLine("NUEVA ESPECIALIDAD:");
                string nuevaEspecialidad = Console.ReadLine();

                profesor.Nombre = nuevoNombre;
                profesor.Email = nuevoEmail;
                profesor.Especialidad = nuevaEspecialidad;

                this.mensaje.MostrarMensaje("PROFESOR ACTUALIZADO CON ÉXITO ...");
            } 
            else 
                {
                this.mensaje.MostrarMensaje("PROFESOR NO ENCONTRADO ...");
                }
        }
        public override void Delete()
        {
            base.mensaje.MonstrarTitulo("ELIMINAR PROFESOR");
            Profesor profesor = this.FindValue();
            if (profesor != null)
            {
                ListaProfesores.Remove(profesor);

                this.mensaje.MostrarMensaje("PROFESOR ELIMINADO CON ÉXITO ...");
            }
            else
            {
                this.mensaje.MostrarMensaje("PROFESOR NO ENCONTRADO ...");
            }
            ;
        }


    }
}
