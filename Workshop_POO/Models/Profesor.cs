using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Workshop_POO.Models
{
    public class Profesor(string nombre, string apellido, string tipoDeDocumento, string numeroDocumento, string email, string telefono, DateOnly fechaNacimiento, string asignatura, double salario, DateOnly fechaContratacion, List<string> nuevoCursos) : Persona(nombre, apellido, tipoDeDocumento, numeroDocumento, email, telefono)
    {
        public string Asignatura { get; set; } = asignatura;
        protected double Salario { get; set; } = salario;
        public DateOnly FechaContratacion { get; set; } = fechaContratacion;
        public List<string> Cursos { get; set; } = new List<string>();

        public double GetSalario() => Salario;

        //Metodo CalcularAntiguedad
        public int CalcularAntiguedad()
        {
            int antiguedad = (DateTime.Now.Year - this.FechaContratacion.Year);
            return antiguedad;
        }

        //Metodo ObtenerSalario
        public void ObtenerSalario(double salario){
            this.Salario = salario;
        }

        //Metodo mostrarInformacion
        public void MostrarInformacionProfesor()
        {
            Console.WriteLine("");
            base.MostrarInformacion();
            Console.WriteLine($"Asigantura: {Asignatura}");
            Console.WriteLine($"Salario: ${Salario}");
            Console.WriteLine($"Fecha de contratacion: {FechaContratacion}");
            Console.WriteLine("--------------------------------------------------------------------------------");
        }

        //Metodo Cursos
        public void MateriasPermitidas()
        {
            this.Cursos.Add("Matemáticas");
            this.Cursos.Add("Física");
            this.Cursos.Add("Química");
            this.Cursos.Add("Historia");
            this.Cursos.Add("Lengua");
            this.Cursos.Add("Biología");
            this.Cursos.Add("Infirmática");
            this.Cursos.Add("Educación Física");
        }
    }
}