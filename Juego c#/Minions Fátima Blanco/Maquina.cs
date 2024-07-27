using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Minions_Fátima_Blanco
{
    public class Maquina
    {
        private int _complejidad;
        private string _nombre;

        public int Complejidad
        {
            get { return _complejidad; }
        }
        public string Nombre
        {
            get { return _nombre; }
        }
        public Maquina(string nombre, int complejidad)
        {
            _complejidad = complejidad;
            _nombre = nombre;
            Console.WriteLine($"La máquina {_nombre} ha aparecido");
        }
        public List<IHerramientas> HerramientasValidas { get; set; } = new List<IHerramientas> { };

        public void AgregarHerramienta(IHerramientas herramienta)
        {
            HerramientasValidas.Add(herramienta);
        }

        
    }
}
