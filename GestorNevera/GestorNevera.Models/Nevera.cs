using System;
using System.Collections.Generic;
using System.Text;

namespace GestorNevera.Models
{
    public class Nevera
    {
		public string NeveraId { get; set; }
		public string Marca { get; set; }
		public int Serie { get; set; }

		public IList<Precio> Precio { get; set; }


    }
}
