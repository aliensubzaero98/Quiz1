using System;
using System.Collections.Generic;
using System.Text;

namespace GestorNevera.Models
{
    public class Materiales
    {
		public int MaterialesId { get; set; }
		public int PrecioId { get; set; }
		public Precio Precio { get; set; }


    }
}
