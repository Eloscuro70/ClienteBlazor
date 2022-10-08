using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Tienda_De_Instrumentos_MUsicales.ClienteBlazor.Models
{
    public class Contacto
    {
        public int Id { get; set; }
        public int IdCategoria { get; set; }
        public string Nombre { get; set; }
        public string Telefono { get; set; }
        public string Imagen { get; set; }
    }
}
