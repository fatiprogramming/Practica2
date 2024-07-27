
namespace Personajes;
using System;
public class Personaje
{
    protected int _stamina;
    protected float _acierto;
    protected int _ojos;
    protected string _nombre;
    protected int _fuerza;
    protected int _experiencia;

    public Personaje(string tipo, string nombre, int stamina)
    {
        ConfigurarPersonaje(tipo, nombre, ref stamina);
        _stamina = stamina;
        
    }

    protected virtual void ConfigurarPersonaje(string tipo, string nombre, ref int stamina)
    {
        tipo = tipo.ToLower().Trim();

        if (tipo == "biclope" || tipo == "bíclope")
        {
           
            if (stamina > 10)
            {
                Console.WriteLine($"Se ha cambiado el valor de la stamina de '{nombre}' a su valor máximo posible (10)");
                stamina = 10;
            }
            _acierto = 1;
            _ojos = 2;
            _fuerza = stamina / 2 + 2;
        }
        else if (tipo == "ciclope" || tipo == "cíclope")
        {
            _acierto = 0.5f;
            _ojos = 1;
            _fuerza = (stamina / 2) / 2 + 2;
        }
        else
        {
            throw new ArgumentException($"Tipo de personaje '{tipo}' no válido. Debe ser 'Biclope' o 'Ciclope'.");
        }
        _nombre = nombre;
    }

    public int Stamina
    {
        get { return _stamina; }
    }
    public int Fuerza
    {
        get { return _fuerza; }
    }
    public float Acierto
    {
        get { return _acierto; }
    }

    public int Ojos
    {
        get { return _ojos; }
    }
    public string Nombre
    { 
        get { return _nombre; } 
    }
    public int Experiencia { get; set; }
}


