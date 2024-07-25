using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TallerClases.models
{
    public class Empleado
    {
        private Guid Id { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public string Correo { get; set; }
        private double SueldoBase { get; set; }
        public double PorcentajePension { get; set; }
        public double PorcentajeSalud { get; set; }
        public double PorcentajeAhorroCooperativa { get; set; }

        public Empleado(string nombre, string apellido, string correo, double sueldoBase, double porcentajePension, double porcentajeSalud, double porcentajeAhorroCooperativa)
        {
            this.Id = new Guid();
            this.Nombre = nombre;
            this.Apellido = apellido;
            this.Correo = correo;
            this.SueldoBase = sueldoBase;
            this.PorcentajePension = porcentajePension;
            this.PorcentajeSalud = porcentajeSalud;
            this.PorcentajeAhorroCooperativa = porcentajeAhorroCooperativa;
        }

        public double CalcularSueldoEmpleado(double SueldoBase, double PorcentajeSalud, double PorcentajePension, double PorcentajeAhorroCooperativa)
        {
            double deducciones = PorcentajePension + PorcentajeSalud;
            double salarioTotal = SueldoBase - deducciones;
            return salarioTotal;
        }

        private double CalcularDeducciones(double SalarioBase, double PorcentajePension, double porcentajeSalud)
        {
            double deduccionSalud = SalarioBase * PorcentajeSalud / 100; 
            double deduccionPension = SalarioBase * PorcentajePension / 100;            
            double deduccionesTotales = deduccionPension + deduccionSalud;
            return deduccionesTotales;
        }

        private double CalcularAhorro(double SalarioBase, double PorcentajeAhorroCooperativa)
        {
            double ahorro = SalarioBase * PorcentajeAhorroCooperativa / 100; 
            return ahorro;
        }
    }
}
