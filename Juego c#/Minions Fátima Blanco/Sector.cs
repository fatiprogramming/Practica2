using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Minions_Fátima_Blanco
{
    public class Sector
    {
        protected int _dificultad;
        protected string _size;
        protected int _staminaRequerida;
        public Sector(string size, int staminaRequerida, int dificultad = 10) {

             size.ToLower().Trim();
            _size = size;
            _dificultad = dificultad;
            _staminaRequerida = staminaRequerida;
        }
        public int Dificultad { 
            get { return _dificultad; }
        }
        public string Size
        {
            get { return _size; }
        }
        public int StaminaRequerida
        {
            get { return _staminaRequerida;}
        }
    }
}
