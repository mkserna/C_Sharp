using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Practica_POO.Models
{
    public class Estudiante
    {
        public string Nombre { get; set; }
        public int Edad { get; set; }
        public int Matricula { get; set; }

        public Estudiante(string nombre, int edad, int matricula)
        {
            this.Nombre = nombre;
            this.Edad = edad;
            this.Matricula = matricula;
        }
    }

}