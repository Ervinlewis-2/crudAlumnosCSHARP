using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Matriculas.UI
{
    internal class MainUI : UI
    {
        public override void MonstrarMenu()
        {
            int opcion = 0;

            while (opcion != 5)
            {
                Console.Clear();
                this.mensaje.MonstrarTitulo("MANTENIMIENTO DE PROFESORES");
                Console.WriteLine(@"
                [1] ADMINISTRACION DE PROFESORES
                [2] ADMINISTRACION DE ALUMNOS
                [3] PROCESO DE MATRICULAS
                [4] REPORTES
                [5] SALIR
                ");
                this.mensaje.MonstrarTitulo("INGRESE UNA OPCIÓN DEL MENU :");
                opcion = int.Parse(Console.ReadLine());
                Console.Clear();

                switch (opcion)
                {
                    case 1:
                        ProfesorUI profesorUI = new ProfesorUI();
                        profesorUI.MonstrarMenu();
                        break;
                    case 2:
                        AlumnoUI alumnoUI = new AlumnoUI();
                        alumnoUI.MonstrarMenu();
                        break;
                    case 3:

                        break;
                    case 4:

                        break;
                    case 5:
                        Console.WriteLine("Saliendo del sistema");
                        break;
                    default:
                        this.mensaje.MostrarMensaje("OPCION INVALIDA!!!");

                        break;

                }
            }
        }

    }
}
