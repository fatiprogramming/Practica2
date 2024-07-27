using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Personajes;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Minions_Fátima_Blanco
{
    public class Obrero : Personaje, IObrero, IDisposable
    {
        protected string _tipo;
        public List<IHerramientas> Cinturon { get; set; } = new List<IHerramientas>();
        public void AgregarHerramienta(IHerramientas herramienta)
        {
            Cinturon.Add(herramienta);
        }

        public void QuitarHerramienta(IHerramientas herramienta)
        {
            Cinturon.Remove(herramienta);
        }

     

        
        public Obrero(string tipo, string nombre, int stamina) : base(tipo, nombre, stamina)
        {
            tipo = tipo.ToLower().Trim();
            _tipo = tipo;
        }
        public bool Atacar( Amenaza amenaza, int dificultad)
        {
            if (_tipo == "ciclope" || _tipo == "cíclope")
            {
                if (_fuerza >= amenaza.NivelAmenaza * 2)
                {
                    Random random = new Random();
                    double numeroAleatorio = random.NextDouble() * Acierto;
                    Console.WriteLine(numeroAleatorio);
                    if (numeroAleatorio > 0.25f)
                    {
                        amenaza.RecibirDamage(_fuerza);

                        Console.WriteLine("Ataque realizado con éxito");
                        _stamina = _stamina / 2;
                        Console.WriteLine($"{Nombre} ha perdido stamina. Restante: {_stamina}");
                        Experiencia += dificultad + 1;
                        return true;
                    }
                    else
                    {
                        Console.WriteLine("El ataque ha fallado");
                        Experiencia += dificultad + 1;
                        return true;

                    }

                }
                else
                {
                    Console.WriteLine("Nivel de fuerza insuficiente, no puede atacar");
                    return false;
                }
            }


            else if (_tipo == "biclope" || _tipo == "bíclope")
            {
                if (_fuerza >= amenaza.NivelAmenaza)

                {
                    amenaza.RecibirDamage(_fuerza);
                    Console.WriteLine("Ataque realizado con éxito");
                    _stamina = _stamina / 2;
                    Console.WriteLine($"{Nombre} ha perdido stamina. Restante: {_stamina}");
                    Experiencia += dificultad + 1;
                    return true;
                }
                else
                {
                    Console.WriteLine("Nivel de fuerza insuficiente, no puede atacar");

                    return false;
                }

            }

            return true;
        }
        public bool Limpiar(Sector sector, int dificultad)
        {
            if (sector.StaminaRequerida <= _stamina)
            {
                if (sector.Size == "grande")
                {
                    _stamina -= 4;

                }
                else if (sector.Size == "chico")
                {
                    _stamina -= 1;

                }
                Console.WriteLine("Limpieza realizada exitosamente");
                Experiencia += dificultad + 1;
                return true;
            }
            else
            {
                Console.WriteLine("Nivel de stamina insuficiente");
                return false;
            }
        }
        public bool UsarHerramienta(int indice, Maquina maquina, List<IHerramientas> herramientasValidas, int dificultad)
        {
            bool cantidadHerramientas = herramientasValidas.All(herramienta => Cinturon.Contains(herramienta));

            if (cantidadHerramientas && _stamina >= maquina.Complejidad)
            {
                Cinturon[indice].RepararMaquina();
                Experiencia += dificultad + 1;
                return true;
            }
            else
            {
                Console.WriteLine("No se cumple con los requisitos");
                return false;
            }
        }
        //El método Dispose() nos permite eliminar un objeto, se asume que en el juego tendríamos
        //al científico como capaz de eliminar personajes
        public void DespedirObrero()
        {
            Console.WriteLine($"El obrero {Nombre} ha sido despedido.");
            Dispose();
        }
        private bool _disposed = false;
        public void Dispose(bool disposing)
        {
            if (_disposed)
                return;

            if (disposing)
            {

            }
            _disposed = true;
        }

        ~Obrero()
        {
            Dispose(false);
        }
        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }
    }
}


