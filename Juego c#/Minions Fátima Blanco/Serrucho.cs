using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Minions_Fátima_Blanco
{
    public class Serrucho :IHerramientas
    {

        public override bool Equals(object obj)
        {

            return obj is Serrucho;
        }

        public override int GetHashCode()
        {

            return typeof(Serrucho).GetHashCode();
        }
        public void RepararMaquina()
        {
            Console.WriteLine("Serruchando cosas que obstruyen a la máquina");
        }
    }
}
