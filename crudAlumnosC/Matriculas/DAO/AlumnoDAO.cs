using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Matriculas.MODELS;

namespace Matriculas.DAO
{
    internal class AlumnoDAO : DAO
    {
        private List<Alumno> ListaAlumnos = new List<Alumno>();


        //Metodos
        private Alumno FindValue()
        {
            Console.WriteLine("INGRESE EL EMAIL DEL ALUMNO :");
            string email = Console.ReadLine();
            Alumno alumno = ListaAlumnos.Find(a => a.Email.Equals(email, StringComparison.OrdinalIgnoreCase));
            return alumno;
        }

        public override void Create()
        {
            base.mensaje.MonstrarTitulo("REGISTRO DE NUEVO ALUMNO");
            Console.Write("ID : ");
            int id = int.Parse(Console.ReadLine());
            Console.Write("NOMBRE : ");
            string nombre = Console.ReadLine();
            Console.Write("EMAIL : ");
            string email = Console.ReadLine();
            Console.Write("CARRERA : ");
            string carrera = Console.ReadLine();
            Console.Write("NOTA : ");
            int nota = int.Parse(Console.ReadLine());
            Alumno nuevoAlumno = new Alumno(id, nombre, email, carrera, nota);
            ListaAlumnos.Add(nuevoAlumno);
            base.mensaje.MostrarMensaje("Alumno registrado con éxito.");
        }
        public override void Read()
        {
            base.mensaje.MonstrarTitulo("LISTA DE ALUMNOS");
            if (ListaAlumnos.Count > 0)
            {
                foreach (var alumno in ListaAlumnos)
                {
                    alumno.Mostrar();
                }
            }
            else
            {
                Console.WriteLine("No hay alumnos registrados.");
            }
        }
        public override void Update()
        {
            base.mensaje.MonstrarTitulo("ACTUALIZAR ALUMNO");
            Alumno alumnos = FindValue();
            if (alumnos != null)
            {
                base.mensaje.MonstrarTitulo("ACTUALIZAR ALUMNO");
                Console.Write("NUEVO NOMBRE : ");
                string nombre = Console.ReadLine();
                Console.Write("NUEVO EMAIL : ");
                string email = Console.ReadLine();
                Console.Write("NUEVA CARRERA : ");
                string carrera = Console.ReadLine();
                Console.Write("NUEVA NOTA : ");
                int nota = int.Parse(Console.ReadLine());
                alumnos.Nombre = nombre;
                alumnos.Email = email;
                // Asumiendo que la clase Alumno tiene una propiedad Carrera
                // Si no la tiene, deberías agregarla.
                alumnos.Carrera = carrera; 
                alumnos.Nota = nota;
                base.mensaje.MostrarMensaje("Alumno actualizado con éxito.");
            }
            else
            {
                base.mensaje.MostrarMensaje("Alumno no encontrado.");
            }

        }
        public override void Delete()
        {
            Alumno alumno = FindValue();
            if (alumno != null)
            {
                ListaAlumnos.Remove(alumno);
                base.mensaje.MostrarMensaje("Alumno eliminado con éxito.");
            }
            else
            {
                base.mensaje.MostrarMensaje("Alumno no encontrado.");
            }
        }
    }
}
