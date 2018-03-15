using System;
using System.Collections.Generic;
using System.Text;

namespace GestorNevera.Models
{
    public class Precio
    {
		public int PrecioId { get; set; }
		public IList<Materiales> Materiales { get; set; }


    }
}
