using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Workshop_POO.Models
{
    //Propiedades Persona
    public class Persona
    {
        public Persona(string nombre, string apellido, string tipoDeDocumento, string numeroDocumento, string email, string telefono)
        {
            Nombre = nombre;
            Apellido = apellido;
            TipoDeDocumento = tipoDeDocumento;
            NumeroDocumento = numeroDocumento;
            Email = email;
            Telefono = telefono;
        }

        protected Guid Id { get; set; }
        protected string Nombre { get; set; }
        protected string Apellido { get; set; }
        protected string TipoDeDocumento { get; set; }
        protected string NumeroDocumento { get; set; }
        protected string Email { get; set; }
        protected string Telefono { get; set; }

        public string GetNombre() => Nombre;
        public string GetApellido() => Apellido;
        public string GetTipoDeDocumento() => TipoDeDocumento;
        public string GetNumeroDocumento() => NumeroDocumento;
        public string GetEmail() => Email;
        public string GetTelefono() => Telefono;

        public string SetNombre(string nombre) => Nombre = nombre;
        public string SetApellido(string apellido) => Apellido = apellido;
        public string SetTipoDeDocumento(string tipoDeDocumento) => TipoDeDocumento = tipoDeDocumento;
        public string SetNumeroDocumento(string numeroDocumento) => NumeroDocumento = numeroDocumento;
        public string SetEmail(string email) => Email = email;
        public string SetTelefono(string telefono) => Telefono = telefono;

        //Metodo MostrarInformacion de Persona
        public void MostrarInformacion()
        {
            Console.WriteLine("--------------------------------------------------------------------------------");
            Console.WriteLine($"Nombre: {Nombre}");
            Console.WriteLine($"Apellido: {Apellido}");
            Console.WriteLine($"Tipo de documento: {TipoDeDocumento}");
            Console.WriteLine($"Numero de documento: {NumeroDocumento}");
            Console.WriteLine($"Email: {Email}");
            Console.WriteLine($"Telefono: {Telefono}");
        }
    }
}