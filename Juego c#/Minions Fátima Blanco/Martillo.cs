using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Minions_Fátima_Blanco
{
    public class Martillo : IHerramientas
    {
        public override bool Equals(object obj)
        {

            return obj is Martillo;
        }

        public override int GetHashCode()
        {

            return typeof(Martillo).GetHashCode();
        }

        public void RepararMaquina()
        {
            Console.WriteLine("Martillando...");
        }
    }
}
