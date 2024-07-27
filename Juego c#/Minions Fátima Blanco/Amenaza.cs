using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Minions_Fátima_Blanco
{
    public class Amenaza
    {
        protected int _nivelAmenaza;
        protected int _vida;

        public int NivelAmenaza { get { return _nivelAmenaza;} }
        public Amenaza(int nivelAmenaza, int vida)
        {
            _nivelAmenaza = nivelAmenaza;
            _vida = vida;
        }
        public bool RecibirDamage(int damage)
        {
            _vida -= damage;
            Console.WriteLine($"La amenaza ahora tiene {_vida} puntos de vida");
            return true;
        }
    }
}
