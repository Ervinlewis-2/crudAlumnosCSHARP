using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Herencia.Dao
{
    internal abstract class Crud
    {
        public abstract void Create();
        public abstract void Read();
        public abstract void Update();
        public abstract void Delete();


    }
}
