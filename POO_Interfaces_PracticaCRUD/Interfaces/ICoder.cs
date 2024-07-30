using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace POO_Interfaces_PracticaCRUD.Interfaces
{
    public interface ICoder
    {
        public void Crear(Coder coder);
        public void Editar(Coder coder);
        public void Eliminar(Coder coder);  
        public List<Coder> ObtenerTodos();
    }
}