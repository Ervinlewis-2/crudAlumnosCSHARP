using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Herencia.Dao
{
    internal class AlumnoCrud : Crud
    {
        public override void Create()
        {
            Console.WriteLine("Crear Alumno");
        }
        public override void Delete()
        {
            Console.WriteLine("Eliminar Alumno");
        }
        public override void Read()
        {
            Console.WriteLine("Leer Alumno");
        }
        public override void Update()
        {
            Console.WriteLine("Actualizar Alumno");
        }
    }
}
