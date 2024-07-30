using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace POO_Interfaces.Models
{
    public class Oso : Animal
    {
        public bool Ivernar { get; set; }
        public Oso(string nombre, double peso, bool ivernar) : base(nombre, peso)
        {
            Ivernar = ivernar;
        }
        public override void Respirar(){
            Console.WriteLine($"{this.Nombre} esta respirando");
        }
    }
}