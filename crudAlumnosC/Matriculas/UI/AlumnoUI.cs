using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Matriculas.DAO;

namespace Matriculas.UI
{
    internal class AlumnoUI : UI
    {
        //Atributos
        private AlumnoDAO DAO = new AlumnoDAO();
        //constructor
        public AlumnoUI()
        {
            DAO = new AlumnoDAO();
        }
        //metodos
        public override void MonstrarMenu()
        {
            int opcion = 0;
            while (opcion != 5)
            {
                Console.Clear();
                base.mensaje.MonstrarTitulo("MANTENIMIENTO DE ALUMNOS");
                Console.WriteLine(@"
                [1] REGISTRAR ALUMNO
                [2] MOSTRAR ALUMNO
                [3] ACTUALIZAR ALUMNO
                [4] ELIMINAR ALUMNO
                [5] SALIR
                ");
                base.mensaje.MonstrarTitulo("INGRESE UNA OPCIÓN DEL MENU :");
                opcion = int.Parse(Console.ReadLine());
                Console.Clear();
                switch (opcion)
                {
                    case 1:
                        DAO.Create();
                        break;
                    case 2:
                        DAO.Read();
                        Console.WriteLine("PRESIONE ENTER PARA CONTINUAR...");
                        Console.ReadKey();
                        break;
                    case 3:
                        DAO.Update();
                        break;
                    case 4:
                        DAO.Delete();
                        break;
                    case 5:
                        Console.WriteLine("Saliendo del sistema");
                        break;
                    default:
                        base.mensaje.MostrarMensaje("OPCION INVALIDA!!!");
                        break;
                }
            }
        }

    }
}
