using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata;
using System.Threading.Tasks;
using POO_Interfaces.Interfaces;

namespace POO_Interfaces.Models
{
    //Clase con interfaz, heredamos de la interfaz IAnimal. Es OBLIGAARORIO traernos los metodos de la interfaz.
    //Primero heredamos de Animal (Clase padre), luego de IAnimal (Interfaz )
    public class Leon : Animal, IAnimal
    {
        public bool Melena { get; set; }

        //Constructor con parametros de la clase padre
        public Leon(bool melena, string nombre, double peso) : base(nombre, peso)
        {
            Melena = melena;
        }
        public void Comer()
        {
            Console.WriteLine($"Esta comendo");
        }
        public void Dormir()
        {
            Console.WriteLine($"Esta dormido");
        }
        public void Desplazar()
        {
            Console.WriteLine($"Esta desplazando");
        }

        //Como tenermos el metodo en la clase padre y en la clase hija, tenemos que sobreescribir el metodo abstracto en la clase hija.
        public override void Respirar()
        {
            throw new NotImplementedException();
        }
    }
}


/* using System;
 using System.Collections.Generic;
 using System.Linq;
 using System.Threading.Tasks
 namespace POO_Interfaces.Models
 {
     public class Leon : Animal
     {
         public bool Melena { get; set; }
         // Son los datos que se le van a dar al constructor padre   ": base(nombre, peso)"
         public Leon(string nombre, double peso, bool melena) : base(nombre, peso)
         {
             Melena = melena;
         }
         //Como en la clase padre tenemos un metodo abstracto, tenemos que sobreescribirlo en la clase hija.
         //Con la palabra override, indicamos que el metodo abstracto se va a sobreescribir.
         //En la clase padre creamos el metodo abstracto Respirar, en la clase hija sobreescribimos el mismo, es decir, se crea el codigo de la clase hija. {Aquí adentro}
         public override void Respirar(){
             Console.WriteLine($"{this.Nombre} esta respirando");
         
     }
 }*/