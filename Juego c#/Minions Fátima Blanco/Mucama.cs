using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Personajes;

namespace Minions_Fátima_Blanco
{
    public class Mucama : Personaje
    {
        public Mucama(string tipo, string nombre, int stamina) : base(tipo, nombre, stamina)
        {
            
        }
        public bool Atacar()
        {
            Console.WriteLine("La mucama no puede atacar");
            return false;
        }
        public bool Limpiar(int dificultad)
        {
            Console.WriteLine("Dora la limpiaDORA está limpiando el sector");
            Experiencia += dificultad + 1;
            return true;
        }
        public void Reparar()
        {
            Console.WriteLine("No tiene las herramientas necesarias");
        }
    }
}
