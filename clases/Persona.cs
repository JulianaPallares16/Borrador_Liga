using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace futbol
{
    public class Persona
    {
        public int Id { get; set; }
        public string? Nombre { get; set; }
        public string? Apellido { get; set; }
        public int Edad { get; set; }
        public string? Nacionalidad { get; set; }
        public Persona(int id, string? nombre, string? apellido, int edad,
        string? nacionalidad)
        {
            Id = id;
            Nombre = nombre;
            Apellido = apellido;
            Edad = edad;
            Nacionalidad = nacionalidad;

        }
        public Persona() { }
    }
}