using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Practica_POO.Models
{
    public class Persona
    {
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public int YearNacimiento { get; set; }
        public double Altura { get; set; }
        public double Peso { get; set; }

        Persona nuevaPersona = new Persona("Juan", "Perez", 2003, 1.65, 70.5);

        public Persona(string nombre, string apellido, int yearNacimiento, double altura, double peso)
        {
            this.Nombre = nombre;
            this.Apellido = apellido;
            this.YearNacimiento = yearNacimiento;
            this.Altura = altura;
            this.Peso = peso;
        }

        public string MostrarInformacion() {
            return @$"Informacion completa de {Nombre}: 
                        Nombre completo: {Nombre} {Apellido}
                        Año de nacimiento: {YearNacimiento}
                        Altura: {Altura}
                        Peso: {Peso}";
        }


        public double CalcularIMC(double peso, double altura){
            double calculo = peso / altura * altura;
            return calculo;
        }
    }
}