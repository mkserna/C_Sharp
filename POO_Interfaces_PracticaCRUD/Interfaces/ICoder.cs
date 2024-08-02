using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace POO_Interfaces_PracticaCRUD.Interfaces
{
    public interface ICoder
    {
        public void Crear();
        public void Editar();
        public void Eliminar();  
        public void ObtenerTodos();
    }
}