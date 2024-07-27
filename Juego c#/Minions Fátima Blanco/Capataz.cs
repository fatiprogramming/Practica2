using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Minions_Fátima_Blanco
{
    public class Capataz
    {
        protected string _nombre;
        public string Nombre { get { return _nombre; } }
        public Capataz(string nombre) {
            _nombre = nombre;
            Console.WriteLine($"{Nombre} es el nuevo capataz");
        }
        public void HacerTarea()
        {
            Console.WriteLine($"La tarea ha sido delegada a {Nombre}a falta de personal");
        }
        public void AtaqueSoldado(Soldado soldado, int indice, Amenaza amenaza, int dificultad)
        {
            Console.WriteLine($"Se ha delegado la tarea de ataque a {soldado.Nombre}");
            if (soldado.Atacar(indice, amenaza, dificultad))
            {
                Console.WriteLine("Tarea delegada con éxito");

            }
            else
            {
                HacerTarea();

            }
        }
        public void AtaqueObrero(Obrero obrero, Amenaza amenaza, int dificultad)
        {
            Console.WriteLine($"Se ha delegado la tarea de ataque a {obrero.Nombre}");
            if (obrero.Atacar(amenaza, dificultad))
            {
                Console.WriteLine("Tarea delegada con éxito");
            }
            else
            {
                HacerTarea();

            }
        }
        public void AtaqueMucama(Mucama mucama)
        {
            HacerTarea();

        }

        public void LimpiezaObrero(Obrero obrero, Sector sector, int dificultad)
        {
            if (obrero.Limpiar(sector, dificultad))
            {
                Console.WriteLine("Tarea delegada con éxito");
            }
            else
            {
                HacerTarea();
            }
        }
        public void LimpiezaSoldado(Soldado soldado, Sector sector  , int dificultad)
        {
            if (soldado.Limpiar(sector, dificultad))
            {
                Console.WriteLine("Tarea delegada con éxito");
            }
            else
            {
                HacerTarea();
            }
        }
        public void LimpiezaMucama(Mucama mucama, int dificultad)
        {
            mucama.Limpiar(dificultad);
            Console.WriteLine("Tarea delegada con éxito");
        }
        public void RepararObrero(Obrero obrero, int indice, Maquina maquina, List<IHerramientas> herramientasValidas, int dificultad)
        {
            if (obrero.UsarHerramienta(indice, maquina, herramientasValidas, dificultad))
            {
                Console.WriteLine("Tarea delegada con éxito");
            }
            else
            {
                HacerTarea();
            }
        }
        public void RepararSoldado(Soldado soldado)
        {
            HacerTarea();
        }
        public void RepararMucama(Mucama mucama)
        {
            HacerTarea();
        }
    }
}
