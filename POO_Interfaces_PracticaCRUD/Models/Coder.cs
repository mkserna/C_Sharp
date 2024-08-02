using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using POO_Interfaces_PracticaCRUD.Interfaces;

namespace POO_Interfaces_PracticaCRUD.Models
{
    public class Coder : ICoder
    {
        public Guid Id { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public string Email { get; set; }
        public string Telefono { get; set; }
        public List<Coder> Coders { get; set; }
        public Coder(string nombre, string apellido, string email, string telefono)
        {
            this.Nombre = nombre;
            this.Apellido = apellido;
            this.Email = email;
            this.Telefono = telefono;
        }

        //Crear nuevo coder
        public void Crear()
        {
            Console.WriteLine("Ingresa el nombre del coder: "); string Nombre = Console.ReadLine();
            Console.WriteLine("Ingresa el apellido del coder: "); string Apellido = Console.ReadLine();
            Console.WriteLine("Ingresa el email del coder: "); string Email = Console.ReadLine();
            Console.WriteLine("Ingresa el telefono del coder: "); string Telefono = Console.ReadLine();
            Coder nuevoCoder = new Coder(Nombre, Apellido, Email, Telefono);
            Coders.Add(nuevoCoder);
        }

        public void Editar()
        {
            ObtenerTodos();
            Console.WriteLine("Ingresa el telefono del coder que desea editar: "); string TelefonoEditar = Console.ReadLine();
            Coder coders = Coders.Find(x => x.Telefono == TelefonoEditar);

            if (coders != null)
            {
                Console.WriteLine("Ingresa el nombre del coder: "); string? nombreEditar = Console.ReadLine();
                Console.WriteLine("Ingresa el apellido del coder: "); string? apellidoEditar = Console.ReadLine();
                Console.WriteLine("Ingresa el email del coder: "); string? emailEditar = Console.ReadLine();
                Console.WriteLine("Ingresa el telefono del coder: "); string? telefonoEditar = Console.ReadLine();
                
                coders.Nombre = string.IsNullOrEmpty(nombreEditar) ? coders.Nombre : nombreEditar;
                coders.Apellido = string.IsNullOrEmpty(apellidoEditar) ? coders.Apellido : apellidoEditar;
                coders.Email = string.IsNullOrEmpty(emailEditar) ? coders.Email : emailEditar;
                coders.Telefono = string.IsNullOrEmpty(telefonoEditar) ? coders.Telefono : telefonoEditar;

                Console.WriteLine("");
                Console.WriteLine("El coder ha sido editado con exito");
                Console.WriteLine("");
            }
            else
            {
                Console.WriteLine("");
                Console.WriteLine("El coder no existe");
                Console.WriteLine("");
            }
        }

        public void Eliminar()
        {
            Console.WriteLine("Ingresa el telefono del coder que desea eliminar: "); string TelefonoEliminar = Console.ReadLine();
            Coder coders = Coders.Find(x => x.Telefono == TelefonoEliminar);

            if (coders != null)
            {
                Coders.Remove(coders);
                Console.WriteLine("");
                Console.WriteLine("El coder ha sido eliminado con exito");
            }
            else
            {
                Console.WriteLine("");
                Console.WriteLine("El coder no existe");
            }

        }

        public void ObtenerTodos()
        {
            Console.WriteLine("Información de los coders");
            foreach (Coder coder in Coders)
            {
                Console.WriteLine($"Nombre: {coder.Nombre} \n Apellido: {coder.Apellido} \n Email: {coder.Email} \n Telefono: {coder.Telefono}");
            }
        }
    }
}