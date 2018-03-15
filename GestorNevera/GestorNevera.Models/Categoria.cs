using System;
using System.Collections.Generic;
using System.Text;

namespace GestorNevera.Models
{
    public class Categoria
    {
		public int CategoriaId { get; set; }
		public string NombreCategoria { get; set; }
		public IList<Capacidad> Capacidad { get; set; }
		public IList<Precio> Precio { get; set; }

    }
}
