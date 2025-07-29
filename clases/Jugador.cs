using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace futbol
{
    public class Jugador : Persona
    {
        public int Dorsal { get; set; }
        public string? Posicion { get; set; }
        public Jugador(int id, string? nombre, string? apellido, int edad,
        string? nacionalidad, int dorsal, string? posicion)
        {
            Id = id;
            Nombre = nombre;
            Apellido = apellido;
            Edad = edad;
            Nacionalidad = nacionalidad;
            Dorsal = dorsal;
            Posicion = posicion;
        }
        public Jugador() { }
        public override string ToString()
        {
            return $"Id: {Id}, Nombre Completo: {Nombre} {Apellido}, Edad: {Edad}, Nacionalidad: {Nacionalidad}, Dorsal: {Dorsal}, Posición: {Posicion}";
        }
        public Jugador Addjugador()
        {
            while (true)
            {
                Console.WriteLine("Ingrese el Id del jugador");
                string? dataIn = Console.ReadLine();
                if (int.TryParse(dataIn, out int id))
                {
                    Id = id;
                }
                if (SubmenuJugadores.jugadores.Any(j => j.Id == id))
                {
                    Console.WriteLine("❗Este Id ya existe, ingrese uno nuevo.");
                    continue;
                }
                else
                {
                    break;
                }
            }
            Console.WriteLine("Ingrese el nombre del jugador");
            Nombre = Console.ReadLine();
            Console.WriteLine("Ingrese el apellido del jugador");
            Apellido = Console.ReadLine();
            Console.WriteLine("Ingrese la edad del jugador");
            string? dataEn = Console.ReadLine();
            if (int.TryParse(dataEn, out int edad))
            {
                Edad = edad;
            }
            Console.WriteLine("Ingrese la nacionalidad del jugador");
            Nacionalidad = Console.ReadLine();
            Console.WriteLine("Ingrese el dorsal del jugador");
            string? datoIn = Console.ReadLine();
            if (int.TryParse(datoIn, out int dorsal))
            {
                Dorsal = dorsal;
            }
            Console.WriteLine("Ingrese la posición del jugador");
            Posicion = Console.ReadLine();
           
            return new Jugador(Id, Nombre, Apellido, Edad, Nacionalidad, Dorsal, Posicion);
        }
    }
}