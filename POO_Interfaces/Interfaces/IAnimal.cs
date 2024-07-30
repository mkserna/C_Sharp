using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace POO_Interfaces.Interfaces
{
    //Siempre al archivo de la interfaz se pone la letra I al inicio.
    public interface IAnimal
    {
        //Todos los metodos de una inteface deben ser public.
        //No se pueden poner private, protected o internal. Por defecto son public.
        //public void Comer(); es igual a void Comer();
        public void Comer();
        public void Dormir();
        public void Respirar();
        public void Desplazar();

    }
}