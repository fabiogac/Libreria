using System;
using System.ComponentModel.DataAnnotations;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Libreria
{
    public class Libro
    {


        public int idLibro { get; set; }
        public int idCategoria { get; set; }
        public String Nombre { get; set; } = String.Empty;
        public String Autor { get; set; } = String.Empty;

        
        public [DataType(DataType.Date)] FechaPublicacion { get; set; }

        
    }
}