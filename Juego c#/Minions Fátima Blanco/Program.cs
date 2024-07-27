using System;
using System.Collections.Generic;
using Personajes;

namespace Minions_Fátima_Blanco
{

    public class Minions
    {
 
        public static void Main(string[] args)
        {

            Amenaza amenazante = new Amenaza(2, 200);
            Maquina maquinola = new Maquina("Maquinola", 1);
            maquinola.AgregarHerramienta(new Martillo());
            

            Obrero pepito = new Obrero("Biclope", "Pepito", 12);
            pepito.AgregarHerramienta(new Martillo());
            pepito.AgregarHerramienta(new Serrucho());
            pepito.AgregarHerramienta(new Destornillador());
            pepito.UsarHerramienta(0, maquinola, maquinola.HerramientasValidas, 4);
 
            maquinola.HerramientasValidas.ForEach(h => { Console.WriteLine(h); });
            pepito.Cinturon.ForEach(h => { Console.WriteLine(h); });

            Console.WriteLine($"{pepito.Fuerza}");
            pepito.Atacar(amenazante, 2);

            Console.WriteLine("------------");
            Capataz capacito = new Capataz("Capacito");
            Sector sectorcito = new Sector("chico", 1, 0);
            capacito.LimpiezaObrero(pepito, sectorcito, 2);


            

            Soldado rigoberto = new Soldado("Ciclope", "Rigoberto", 22);
            Console.WriteLine($"{rigoberto.Fuerza}");
            rigoberto.AgregarArma(new Laser());
            rigoberto.AgregarArma(new RaquetaConPinchos());
            rigoberto.Atacar(0, amenazante, 1);
            rigoberto.Atacar(0, amenazante, 1);
            rigoberto.Atacar(0, amenazante ,1);
            rigoberto.Atacar(0, amenazante, 1);

            rigoberto.Reparar();
            rigoberto.Limpiar(sectorcito, 56);

            Console.WriteLine("------------");

            Soldado rios = new Soldado("Biclope", "Rios", 2);
            Console.WriteLine($"{rios.Fuerza}");
            rios.AgregarArma(new Laser());
            rios.Atacar(0, amenazante, 1);
            rios.Atacar(0, amenazante, 1);
            rios.Atacar(0, amenazante, 1);
            rios.Atacar(0, amenazante, 1);
            rios.Reparar();
            rios.Limpiar(sectorcito, 3);

            Console.WriteLine("------------");

            Mucama mucamita = new Mucama("Bíclope", "Ralonga", 90);
            mucamita.Limpiar(3);
            mucamita.Atacar();
            mucamita.Reparar();

            Console.WriteLine($"Experiencia de Rigoberto: {rigoberto.Experiencia}");
            Console.WriteLine($"Experiencia de Pepito: {pepito.Experiencia}");
            Console.WriteLine($"Experiencia de mucamita: {mucamita.Experiencia}");

            //Si quisiéramos cambiar el rol, podríamos eliminar a Pepito el obrero y crear otro 
            //No encontré otra solución posible para el cambio de rol
            pepito.DespedirObrero();

        }
    }
}