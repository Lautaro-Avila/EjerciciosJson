using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticaJson.MiEjercicio4
{
    internal class Productos
    {
        public string nombre { get; set; }
        public double precio {  get; set; }
        public int existensias { get; set; }
        public bool descuento_disponible { get; set; }
        public List<string> etiquetas { get; set; } 
        public detalles detalles { get; set; }
     }
}
