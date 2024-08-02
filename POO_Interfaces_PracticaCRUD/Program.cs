using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using POO_Interfaces_PracticaCRUD.Models;

namespace POO_Interfaces_PracticaCRUD.Interfaces
{
    class Program
    {
        static void Main(string[] args)
        {
            Coder coders = new Coder(string.Empty, string.Empty, string.Empty, string.Empty);
            bool continuar = true;
            while (continuar)
            {
                Console.WriteLine("Bienvenido a la práctica de interfaz CRUD");
                Console.WriteLine("1. Crear un nuevo coder");
                Console.WriteLine("2. Actualizar un coder");
                Console.WriteLine("3. Eliminar un coder");
                Console.WriteLine("4. Obtener todos los coders");
                Console.WriteLine("5. Salir");
                Console.Write("ingresa una opcion: ");
                int opcion = Convert.ToInt32(Console.ReadLine());
                switch (opcion)
                {
                    case 1:
                        coders.Crear();
                        break;
                    case 2:
                        coders.Editar();
                        break;
                    case 3:
                        coders.Eliminar();
                        break;
                    case 4:
                        coders.ObtenerTodos();
                        break;
                    case 5:
                        continuar = false;
                        break;
                }
            }
        }
    }
}