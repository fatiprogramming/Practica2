using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Minions_Fátima_Blanco
{
    internal class Destornillador :IHerramientas
    {

        public override bool Equals(object obj)
        {
            
            return obj is Destornillador;
        }

        public override int GetHashCode()
        {
    
            return typeof(Destornillador).GetHashCode();
        }
        public void RepararMaquina()
        {
            Console.WriteLine("Desatornillando tornillos mal puestos");
        }
    }
}
