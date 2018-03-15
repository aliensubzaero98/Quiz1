using System;
using System.Collections.Generic;
using System.Text;

namespace GestorNevera.Models
{
    public class Marca
    {
		public int MarcaId { get; set; }
		public string NombreMarca { get; set; }
		public IList<Capacidad> Capacidad { get; set; }
		public IList<Precio> Precio { get; set; }

    }
}
