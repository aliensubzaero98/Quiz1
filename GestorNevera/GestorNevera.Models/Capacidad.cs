using System;
using System.Collections.Generic;
using System.Text;

namespace GestorNevera.Models
{
    public class Capacidad
    {
		public int CapacidadId { get; set; }
		public int Marca { get; set; }
		public Marca Tipo { get; set; }
		public int CategoriaId { get; set; }
		public Capacidad Tamaño { get; set; }

		public IList<Precio> PrecioAsociado { get; set; }
    }
}
