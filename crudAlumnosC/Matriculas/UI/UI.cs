using Matriculas.UTILS;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Matriculas.UI
{
    internal abstract class UI
    {
        const int ancho = 50;
        protected Mensaje mensaje = new Mensaje(ancho);

        //metodos

        public abstract void MonstrarMenu();


    }
}
