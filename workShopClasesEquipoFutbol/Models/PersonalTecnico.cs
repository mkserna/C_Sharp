using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace workShopClasesEquipoFutbol.Models
{
    public class PersonalTecnico
    {
        private int Id { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public string TipoDeDocumento { get; set; }
        public string NumeroDocumento { get; set; }
        public DateOnly FechaNacimiento { get; set; }
        protected string RH { get; set; }
        public string TallaSuperior { get; set; }
        public string TallaInferior { get; set; }
        public double TallaZapatos { get; set; }

        public Byte CalcularEdad(DateOnly fechaNacimiento){
            this.FechaNacimiento = fechaNacimiento;
            
        }
    }
}