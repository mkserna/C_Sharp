using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Practica_POO.Models;

namespace Practica_POO;

class Program
{

    public static void Main(String[] args)
    {
        List<Estudiante> estudiantes = [
            new Estudiante ("Pedro", 25, 1),
            new Estudiante ("Juan", 18, 2),
            new Estudiante ("María", 20, 3),
            new Estudiante ("Camilo", 29, 4),
            new Estudiante ("Sara", 17, 5),
        ];

        bool continuar = true;
        while (continuar)
        {
        Console.WriteLine("Selecciona una opción: ");
        Console.WriteLine("1. Clase Estudiante (Mostrar cada estudiante)");
        Console.WriteLine("2. Clase");
        Console.WriteLine("3. Clase");
        Console.WriteLine("4. Clase");
        Console.WriteLine("5. Clase");
        Console.WriteLine("16. Salir");

        int opcion = int.Parse(Console.ReadLine()); 
            switch (opcion)
            {
                case 1:
                    Console.WriteLine("Nombre\tEdad\tMatricula");
                    foreach (Estudiante estudiante in estudiantes)
                    {
                        Console.WriteLine($"{estudiante.Nombre}\t{estudiante.Edad}\t{estudiante.Matricula}");
                    }
                    break;
                case 16:
                    continuar = false;
                    break;

                default:
                    Console.WriteLine("Ingresa una opción valida.");
                    break;
            }
        }


    }
}