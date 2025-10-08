using Matriculas.DAO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Matriculas.UI
{
    internal class ProfesorUI :UI
    {
        private ProfesorDAO DAO = new ProfesorDAO();

        //constructor
        public ProfesorUI()
        {
            DAO = new ProfesorDAO();
        }

        public override void MonstrarMenu()
        {
            int opcion= 0;

            while (opcion != 5)
            {
                Console.Clear();
                base.mensaje.MonstrarTitulo("MANTENIMIENTO DE PROFESORES");
                Console.WriteLine(@"
                [1] REGISTRAR PROFESOR
                [2] MOSTRAR PROFESOR
                [3] ACTUALIZAR PROFESOR
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
