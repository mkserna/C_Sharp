using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Workshop_POO.Models
{
    public class Estudiante(
        string nombre,
        string apellido,
        string tipoDeDocumento,
        string numeroDocumento,
        string email,
        string telefono,
        string nombreAcudiente,
        string cursoActual,
        DateOnly fechaNacimiento,
        List<double> calificaciones) 
        : Persona(nombre,
        apellido,
        tipoDeDocumento,
        numeroDocumento,
        email,
        telefono)
    {
        //Propiedades Estudiante
        public string NombreAcudiente { get; set; } = nombreAcudiente;
        public string CursoActual { get; set; } = cursoActual;
        public DateOnly FechaNacimiento { get; set; } = fechaNacimiento;
        public List<double> Calificaciones { get; set; } = new List<double>();

        //Metodo AgregarCalificacion de Estudiante
        public void AgregarCalificacion(double calificacion)
        {
            this.Calificaciones.Add(calificacion);
        }

        //Metodo MostrarInformacion
        public void MostrarInformacionEstudiante()
        {
            Console.WriteLine("");
            base.MostrarInformacion();
            Console.WriteLine($"Nombre del acudidente: {NombreAcudiente}");
            Console.WriteLine($"Curso actual: {CursoActual}");
            Console.WriteLine($"Fecha de nacimiento: {FechaNacimiento}");
            Console.WriteLine($"Calificaciones: {string.Join(", ", Calificaciones)}");
            Console.WriteLine("--------------------------------------------------------------------------------");


        }

        //Metodo CalcularEdad de Estudiante
        public int CalcularEdad()
        {
            return (DateTime.Now.Year - this.FechaNacimiento.Year);
        }

        //Metodo CalcularCalificaciones de Estudiante
        public double CalcularCalificaciones(List<double> calificaciones)
        {
            double calificacionesTotal = 0;
            foreach (double calificacion in calificaciones)
            {
                calificacionesTotal += calificacion;
            }
            return calificacionesTotal;
        }
    }

}