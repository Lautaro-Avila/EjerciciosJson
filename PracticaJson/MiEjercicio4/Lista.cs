using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticaJson.MiEjercicio4
{
    internal class Lista
    {
        public List<Productos> productos { get; set; }

     public Lista()
        {
            productos = new List<Productos>();
        }
    }
}
