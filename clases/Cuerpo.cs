using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace futbol
{
    public class CuerpoTecnico : Persona
    {
        public string? Cargo { get; set; }
        public CuerpoTecnico() { }
        public CuerpoTecnico(int id, string? nombre, string? apellido, int edad, string? nacionalidad, string? cargo)

        {
            Id = id;
            Nombre = nombre;
            Apellido = apellido;
            Edad = edad;
            Nacionalidad = nacionalidad;
            Cargo = cargo;
        }
        public override string ToString()
        {
            return $"{Cargo}: Id: {Id}, Nombre Completo: {Nombre} {Apellido}, Nacionalidad: {Nacionalidad}, Edad: {Edad}";
        }
        public CuerpoTecnico Addtecnico()
        {
            while (true)
            {
                Console.WriteLine("Ingrese el Id de la persona");
                string? dataIn = Console.ReadLine();
                if (int.TryParse(dataIn, out int id))
                {
                    Id = id;
                }
                if (SubmenuEquipo.tecnicos.Any(t => t.Id == id))
                {
                    Console.WriteLine("❗ Este Id ya existe, ingrese uno nuevo.");
                    continue;
                }
                else
                {
                    break;
                }
            }
            Console.WriteLine("Ingrese el nombre de la persona");
            Nombre = Console.ReadLine();
            Console.WriteLine("Ingrese el apellido de la persona");
            Apellido = Console.ReadLine();
            Console.WriteLine("Ingrese la edad de la persona");
            string? dataEn = Console.ReadLine();
            if (int.TryParse(dataEn, out int edad))
            {
                Edad = edad;
            }
            Console.WriteLine("Ingrese la nacionalidad de la persona");
            Nacionalidad = Console.ReadLine();
            Console.WriteLine("Ingrese el cargo de la persona");
            Cargo = Console.ReadLine();

            return new CuerpoTecnico(Id, Nombre, Apellido, Edad, Nacionalidad, Cargo);
        }
    }
    public class CuerpoMedico : Persona
    {
        public string? Cargo { get; set; }
        public CuerpoMedico() { }
        public CuerpoMedico(int id, string? nombre, string? apellido, int edad, string? nacionalidad, string? cargo)

        {
            Id = id;
            Nombre = nombre;
            Apellido = apellido;
            Edad = edad;
            Nacionalidad = nacionalidad;
            Cargo = cargo;
        }
        public override string ToString()
        {
            return $"{Cargo}: {Nombre} {Apellido}, Nacionalidad: {Nacionalidad}, Edad: {Edad}";
        }
        public CuerpoMedico Addmedico()
        {
            while (true)
            {
                Console.WriteLine("Ingrese el Id de la persona");
                string? dataIn = Console.ReadLine();
                if (int.TryParse(dataIn, out int id))
                {
                    Id = id;
                }
                if (SubmenuEquipo.tecnicos.Any(t => t.Id == id))
                {
                    Console.WriteLine("❗ Este Id ya existe, ingrese uno nuevo.");
                    continue;
                }
                else
                {
                    break;
                }
            }
            Console.WriteLine("Ingrese el nombre de la persona");
            Nombre = Console.ReadLine();
            Console.WriteLine("Ingrese el apellido de la persona");
            Apellido = Console.ReadLine();
            Console.WriteLine("Ingrese la edad de la persona");
            string? dataEn = Console.ReadLine();
            if (int.TryParse(dataEn, out int edad))
            {
                Edad = edad;
            }
            Console.WriteLine("Ingrese la nacionalidad de la persona");
            Nacionalidad = Console.ReadLine();
            Console.WriteLine("Ingrese el cargo de la persona");
            Cargo = Console.ReadLine();
            
            return new CuerpoMedico(Id, Nombre, Apellido, Edad, Nacionalidad, Cargo);
        }
    }
}