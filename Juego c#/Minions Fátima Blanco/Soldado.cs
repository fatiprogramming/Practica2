using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Personajes;

namespace Minions_Fátima_Blanco
{
    public class Soldado : Personaje, IDisposable, ISoldado
    {
        
        protected int _practica;
        protected int _damageExtra;
        protected string _tipo;
    
        public int Practica
        {
            get { return _practica; }
        }
        public int DamageExtra
        {
            get { return _damageExtra; }
        }
        public Soldado(string tipo, string nombre, int stamina) : base(tipo, nombre, stamina)
        {
            tipo = tipo.ToLower().Trim();
            _tipo = tipo;
        }
        public List<IArma> Arsenal{ get; set; } = new List<IArma>();
        public bool Atacar(int indice, Amenaza amenaza, int dificultad)
        {
            if (_tipo == "ciclope" || _tipo == "cíclope")
            {
                if (_fuerza >= amenaza.NivelAmenaza * 2)

                {
                    Arsenal[indice].Atacar();
                    Random random = new Random();
                    double numeroAleatorio = random.NextDouble() * Acierto;
                    Console.WriteLine(numeroAleatorio);
                    if (numeroAleatorio > 0.25f)
                    {
                        amenaza.RecibirDamage(_fuerza);
                        _practica = _practica + 1;
                        _damageExtra = _practica * 2;
                        _fuerza += _damageExtra;
                        Console.WriteLine($"Ataque realizado. Su práctica es ahora {Practica} y su fuerza ahora es de {Fuerza}");
                        Experiencia += dificultad + 1;
                        return true;
                    }
                    else
                    {
                        
                        Console.WriteLine("El ataque ha fallado, no se obtuvo práctica");
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
                    Arsenal[indice].Atacar();
                  
                    
                        amenaza.RecibirDamage(_fuerza);
                        _practica = _practica + 1;
                        _damageExtra = _practica * 2;
                        _fuerza += _damageExtra;
                        Console.WriteLine($"Ataque realizado. Su práctica es ahora {Practica} y su fuerza ahora es de {Fuerza}");
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

            public void AgregarArma(IArma arma)
        {
            Arsenal.Add(arma);
        }

        public void QuitarHerramienta(IArma arma)
        {
            Arsenal.Remove(arma);
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
        
        public void Reparar()
        {
            Console.WriteLine("No tiene las herramientas necesarias");
        }

        //El método Dispose() nos permite eliminar un objeto, se asume que en el juego tendríamos
        //al científico como capaz de eliminar personajes
        public void DespedirSoldado()
        {
            Console.WriteLine($"El soldado {Nombre} ha sido despedido.");
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

        ~Soldado()
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

