using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace POO_Interfaces.Models
{
    //Clase abstracta: Ya que tien un solo metodo abstracto, la convierte en abstracta.
    //En el diseño UML se ven las letras ladeadas
    public abstract class Animal
    {
        public string Nombre { get; set; }
        public double PesoKG { get; set; }

        public Animal(string nombre, double peso)
        {
            this.Nombre = nombre;
            this.PesoKG = peso;
        }

        public void Comer()
        {
            Console.WriteLine($"{this.Nombre} esta comiendo");
        }

        public void Dormir()
        {
            Console.WriteLine($"{this.Nombre} esta dormiendo");
        }
        //Metodo normal:
        public void Caminar()
        {
            Console.WriteLine($"{this.Nombre} esta caminando");
        }
        //Metodo abstracto:
        public abstract void Respirar();
        
    }
}