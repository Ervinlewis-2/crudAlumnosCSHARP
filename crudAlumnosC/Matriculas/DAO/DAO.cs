using Matriculas.MODELS;
using Matriculas.UTILS;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Matriculas.DAO
{
    internal abstract class DAO
    {
        //atributos
        //private List<Persona> ListaDAO =new List<Persona>();
        protected Mensaje mensaje = new Mensaje(50);
        //constructor
        public DAO()
        {

        }
        //metodos abstractos
        public abstract void Create();

        public abstract void Read();

        public abstract void Update();

        public abstract void Delete();
    }
}
